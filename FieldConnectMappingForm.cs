using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DeviceSlotCards;
using Fusion;
using System.Text.RegularExpressions;

namespace FieldConnectMapping
{
    public partial class FieldConnectMappingForm : Form
    {
        private const string Version = "0.2";
        private const string SignalHeader = "*SIGNAL*";
        private const byte CornerConnectorGroupSize = 18;

        private const byte NumSlots = 24; //temporary, for testing Fusion
        private const byte MaxRowsToRandomize = 24; //temporary, for testing form

        private string[] CornerConnectorPrefixes = { "JS1", "JS2", "JS3", "JS4" };

        //For representing field connect info as a table
        //These data tables will store the slot card arrangement and netlist and merge them
        DataTable dtSlotCardConnections;
        DataTable dtNetList;
        DataTable dtFieldConnectMapping;
        DataTable dtFieldConnectors;

        //Dictionaries for Field Connect Signals and Slot Card Connections
        private Dictionary<string, SlotCardConnection> dictSlotCardConnection;
        private Dictionary<string, FieldConnectSignal> dictFieldConnectSignal;
        private Dictionary<string, FieldConnectorInfo> dictFieldConnectors;



        private struct SlotCardConnection
        {
            public string CardDescription;
            public byte SlotNumber;
            public byte SlotCardPinNumber;
            public string CornerConnectorDesignation;
        };

        private struct FieldConnectSignal
        {
            public string SignalName;
            public string ConnectorDesignation;
            public string CornerConnectorDesignation;
        };

        private struct FieldConnectorInfo
        {
            public string ConnectorName;
            public string ConnectorDescription;
            public string ConnectorType;
        };


        public FieldConnectMappingForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewRow SlotCardRow;
            DataGridViewCell cellSlotNum;

            AvailableSlotCards.InitCardSelection();
            FusionDevice.InitCornerConnectorGroups();


            for (int row = 0; row < NumSlots; row++)
            {
                dgvSlotCardArrangement.Rows.Add();
                dgvSlotCardArrangement["colSlotNum", row].Value = row + 1;
            }

            //            for(int row = 0; row < NumSlots; row++)
            //           {
            //                dgvSlotCardArrangement[0, row].Value = 123;
            //            }

            foreach (SlotCard currCard in AvailableSlotCards.AllSlotCards)
            {
                this.colCardDesc.Items.Add(currCard.CardDescription);
            }

            foreach (string connGroup in DeviceSlotCards.Constants.CornerConnectorGroups)
            {
                this.colCornerConnectorGroup.Items.Add(connGroup);
            }
        }


        private void btnOpenFcNetlist_Click(object sender, EventArgs e)
        {
            string NetlistFilePath;

            OpenFileDialog openNetlistFileDialog = new OpenFileDialog();

            openNetlistFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openNetlistFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openNetlistFileDialog.FilterIndex = 2;
            openNetlistFileDialog.RestoreDirectory = true;

            if (openNetlistFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                NetlistFilePath = openNetlistFileDialog.FileName;


                //Read the contents of the file into a stream
                GetFieldConnectDesignations(NetlistFilePath);

                //Update Netlist DataGridView with parsed netlist
                // .DataSource = dtSlotCardPins;
                dgvNetlistContents.DataSource = dtNetList;
            }

        }

        private Boolean GetFieldConnectDesignations(string NetlistFile)
        {
            StreamReader reader;
            string line = string.Empty;
            string SignalName = string.Empty;
            string[] splitsignalline = new string[2];
            string ConnectorAssignments = string.Empty;
            string SignalCornerConnectorDesignation = string.Empty;
            string SignalFcConnectorDesignations = string.Empty;

            Boolean InSignalSection = false;

            int i;      //for testing

            FieldConnectSignal myFieldConnectSignal = new FieldConnectSignal();
            dictFieldConnectSignal = new Dictionary<string, FieldConnectSignal>();



            dtNetList = new DataTable("FieldConnectNetlist");
            dtNetList.Columns.Add("Signal Name", typeof(string));
            dtNetList.Columns.Add("Field Connector Designations", typeof(string));
            dtNetList.Columns.Add("Corner Connector Designation", typeof(string));


            reader = File.OpenText(NetlistFile);

            do
            {
                if (!InSignalSection)
                {
                    //Not in signal section
                    //Read next line and check if it is a signal line
                    if ((line = reader.ReadLine()) == null)
                    {
                        break;
                    }
                }

                //Process line if it is for a signal
                //Otherwise, skip
                if (line.Contains(SignalHeader))
                {
                    InSignalSection = true;
                    ConnectorAssignments = string.Empty;

                    //Parse signal name from line and add to Netlist data table
                    splitsignalline = line.Split("* ");
                    SignalName = splitsignalline[1];


                    //Process lines from netlist file until next signal header is found
                    do
                    {
                        line = reader.ReadLine();
                        if (line == null)
                            break;
                        if (!line.Contains(SignalHeader))
                        {
                            if(ConnectorAssignments == string.Empty)
                                ConnectorAssignments += line;
                            else
                                ConnectorAssignments += " " + line;
                        }
                    }
                    while (!(line.Contains(SignalHeader)));



                    //Signals which are connected to field connector pins will be added to netlist data table 
                    //Field connectors may or may not have a connection to a corner connector
                    //If corner connector information is available, this will be included in netlist datatable



                    //Check if 
                    //Parse corner connector designation & pin# from all connector designations for this signal
                    string[] splitConnectorAssignments = ConnectorAssignments.Split(' ');
                    foreach(string ConnectorDesignation in splitConnectorAssignments)
                    {
                        //check current connector designation against possible choices of corner connector names
                        foreach (string CornerConnector in CornerConnectorPrefixes)
                        {
                            //If there is a corner connector name found
                            //Add contents of this signal to Netlist datatable
                            if (ConnectorDesignation.Contains(CornerConnector))
                            {
                                //                                dtNetList.Rows.Add(SignalName, SignalCornerConnectorDesignation);
                                //                                dtNetList.Rows.Add(SignalName, ConnectorDesignation);
                                
                                //Store the corner connector designation for later use
                                SignalCornerConnectorDesignation = ConnectorDesignation;

                                //Get string with all connector designations except for the corner connector
                                //Remove corner connector designation from the full list of connector designations 
                                SignalFcConnectorDesignations = ConnectorAssignments.Replace(SignalCornerConnectorDesignation + " ", "");

                                //Split string of all FC Connectors into individual FC connectors
                                string[] splitFcConnectorDesignations = SignalFcConnectorDesignations.Split(' ');

                                //Add each FC Connector assignment to netlist data table and netlist dictionary
                                foreach(string FcConnectorDesignation in splitFcConnectorDesignations)
                                {
                                    if (SignalName.Equals("BUSY_1"))
                                        i = 0;

                                    //Add this FC connector assignment to the netlist data table
                                    dtNetList.Rows.Add(SignalName, FcConnectorDesignation, SignalCornerConnectorDesignation);
                                    
                                    //Populate a Field Connect Signal structure and add to Field Connect Signal dictionary
                                    myFieldConnectSignal.ConnectorDesignation = FcConnectorDesignation;
                                    myFieldConnectSignal.SignalName = SignalName;
                                    myFieldConnectSignal.CornerConnectorDesignation = SignalCornerConnectorDesignation;

//                                    dictFieldConnectSignal.Add(FcConnectorDesignation, myFieldConnectSignal);
                                }
                            }
                        }
                    }


                    i = 0;
                }

            } while (line != null);

            return true;
        }

        private void dgvSlotCardArrangement_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Int32 i;
            string formCardDescription = string.Empty;
            string formCcGroupDesignation = string.Empty;

            //Handle event when editing is done in Card Description column
            if (e.ColumnIndex == dgvSlotCardArrangement.Columns["colCardDesc"].Index)
            {
                if (dgvSlotCardArrangement[e.ColumnIndex, e.RowIndex].Value != null)
                {
                    formCardDescription = dgvSlotCardArrangement[e.ColumnIndex, e.RowIndex].Value.ToString();
                    //Look up the slotcard object with this description
                    foreach (SlotCard currCard in DeviceSlotCards.AvailableSlotCards.AllSlotCards)
                    {
                        if (currCard.CardDescription.Equals(formCardDescription))
                        {
                            dgvSlotCardArrangement["colNumChannels", e.RowIndex].Value = currCard.NumChannels;
                            dgvSlotCardArrangement["colCodeName", e.RowIndex].Value = currCard.CodeName;
                            dgvSlotCardArrangement["colPinStep", e.RowIndex].Value = currCard.PinsPerChannel;

                            i = 1;
                        }
                    }
                }
            }
            //Handle event when editing is done in Card Description column
            else if (e.ColumnIndex == dgvSlotCardArrangement.Columns["colCornerConnectorGroup"].Index)
            {
                if (dgvSlotCardArrangement[e.ColumnIndex, e.RowIndex].Value != null)
                {
                    formCcGroupDesignation = dgvSlotCardArrangement[e.ColumnIndex, e.RowIndex].Value.ToString();
                    //Look up the slotcard object with this description
                    foreach (FusionDevice.CornerConnectorGroup currCcGroup in FusionDevice.AllCornerConnectorGroups)
                    {
                        if (currCcGroup.Designation.Equals(formCcGroupDesignation))
                        {
                            dgvSlotCardArrangement["colCcStartPin", e.RowIndex].Value = currCcGroup.StartPin;
                            dgvSlotCardArrangement["colCcENdPin", e.RowIndex].Value = currCcGroup.EndPin;

                            i = 1;
                        }
                    }
                }
            }
            else
            {
                i = 0;
            }

        }

        private void btnCreateSlotCardConfig_Click(object sender, EventArgs e)
        {
            string sCardDescription = string.Empty;
            string sCcGroup = string.Empty;
            string sCcPinDesignation = string.Empty;
            Int32 SlotNum = 0;
            Int32 CcStartPin = 0;
            Int32 CcEndPin = 0;
            Int32 CcLastPin = 0;                     //from corner connector group (unused?)
            Int32 CcPin = 0;
            Int32 SlotPin = 0;
            Int32 ChannelPins = 0;
            Int32 NumChannels = 0;

            dtSlotCardConnections = new DataTable("SlotCardPinConfig");
            dtSlotCardConnections.Columns.Add("Card Description", typeof(string));
            dtSlotCardConnections.Columns.Add("Slot Number", typeof(byte));
            dtSlotCardConnections.Columns.Add("Corner Connector Group", typeof(string));
            dtSlotCardConnections.Columns.Add("Corner Connector Pin", typeof(byte));
            dtSlotCardConnections.Columns.Add("Slot Card Pin #", typeof(byte));
            dtSlotCardConnections.Columns.Add("Corner Connector Designation", typeof(string));



            SlotCardConnection mySlotCardConnection = new SlotCardConnection();
            dictSlotCardConnection = new Dictionary<string, SlotCardConnection>(); 

            foreach (DataGridViewRow row in dgvSlotCardArrangement.Rows)
            {
                if (dgvSlotCardArrangement["colCardDesc", row.Index].Value != null)
                {
                    sCardDescription = dgvSlotCardArrangement["colCardDesc", row.Index].Value.ToString();
                }
                else
                    continue;

                if (dgvSlotCardArrangement["colSlotNum", row.Index].Value != null)
                {
                    SlotNum = Convert.ToByte(dgvSlotCardArrangement["colSlotNum", row.Index].Value);
                }
                else
                    continue;

                if (dgvSlotCardArrangement["colCornerConnectorGroup", row.Index].Value != null)
                {
                    sCcGroup = dgvSlotCardArrangement["colCornerConnectorGroup", row.Index].Value.ToString();
                }
                else
                    continue;

                if (dgvSlotCardArrangement["colCcStartPin", row.Index].Value != null)
                {
                    CcStartPin = Convert.ToByte(dgvSlotCardArrangement["colCcStartPin", row.Index].Value);
                }
                else
                    continue;

                if (dgvSlotCardArrangement["colCcEndPin", row.Index].Value != null)
                {
                    CcEndPin = Convert.ToByte(dgvSlotCardArrangement["colCcEndPin", row.Index].Value);
                }
                else
                    continue;


//                dtSlotCards.Rows.Add(sCardDescription, SlotNum, sCcGroup);

                //Look up the slotcard object with this description
                foreach (SlotCard currCard in DeviceSlotCards.AvailableSlotCards.AllSlotCards)
                {
                    if (currCard.CardDescription.Equals(sCardDescription))
                    {
                        NumChannels = (byte)currCard.NumChannels;
                        ChannelPins = currCard.PinsPerChannel;
                    }
                }

                CcEndPin = CcStartPin + NumChannels * ChannelPins;

                //                for (CcPin = CcStartPin; CcPin < CcEndPin + 1; CcPin++)
                for (CcPin = CcStartPin; CcPin < CcEndPin; CcPin++)
                {
                    SlotPin = (byte)(CcPin % CornerConnectorGroupSize);
                    if (SlotPin == 0)
                        SlotPin = 18;

                    sCcPinDesignation = sCcGroup.Substring(0, 3) + "." + CcPin.ToString();

                    //Add this slot card connection to the data table
                    dtSlotCardConnections.Rows.Add(sCardDescription, SlotNum, sCcGroup, CcPin, SlotPin, sCcPinDesignation);

                    //Populate slot card connection structure then add to dictionary
                    mySlotCardConnection.CardDescription = sCardDescription;
                    mySlotCardConnection.CornerConnectorDesignation = sCcPinDesignation;
                    mySlotCardConnection.SlotCardPinNumber = (byte)SlotPin;
                    mySlotCardConnection.SlotNumber = (byte)SlotNum;

                    dictSlotCardConnection.Add(sCcPinDesignation, mySlotCardConnection);
                }

            }

            dgvSlotCardPins.DataSource = dtSlotCardConnections;
        }

        private void btnPopulateRandomly_Click(object sender, EventArgs e)
        {
            int NumSlotCards;
            int NumCornerConnectorGroups;
            int tmpSlotCard;
            int tmpGroup;
            Random rndSlotCard = new Random();
            Random rndGroup = new Random();

            NumSlotCards = AvailableSlotCards.AllSlotCards.Count();
            NumCornerConnectorGroups = FusionDevice.AllCornerConnectorGroups.Count();

            foreach (DataGridViewRow row in dgvSlotCardArrangement.Rows)
            {
                if (row.Index >= MaxRowsToRandomize)
                    break;

                tmpSlotCard = rndSlotCard.Next(NumSlotCards);
                //                tmpGroup = rndGroup.Next(NumCornerConnectorGroups);
                tmpGroup = row.Index;

                dgvSlotCardArrangement["colCardDesc", row.Index].Value = AvailableSlotCards.AllSlotCards[tmpSlotCard].CardDescription;
                dgvSlotCardArrangement["colNumChannels", row.Index].Value = AvailableSlotCards.AllSlotCards[tmpSlotCard].NumChannels;
                dgvSlotCardArrangement["colCodeName", row.Index].Value = AvailableSlotCards.AllSlotCards[tmpSlotCard].CodeName;
                dgvSlotCardArrangement["colPinStep", row.Index].Value = AvailableSlotCards.AllSlotCards[tmpSlotCard].PinsPerChannel;

                dgvSlotCardArrangement["colCornerConnectorGroup", row.Index].Value = FusionDevice.AllCornerConnectorGroups[tmpGroup].Designation;
                dgvSlotCardArrangement["colCcStartPin", row.Index].Value = FusionDevice.AllCornerConnectorGroups[tmpGroup].StartPin;
                dgvSlotCardArrangement["colCcENdPin", row.Index].Value = FusionDevice.AllCornerConnectorGroups[tmpGroup].EndPin;


            }
        }


        private void btnCreateFcMap_Click(object sender, EventArgs e)
        {
            int i;
            string SignalName = string.Empty;
            string FieldConnectorDesignation = string.Empty;
            string CardDescription = string.Empty;
            string CornerConnectorDesignation = string.Empty;
            byte SlotNumber = 0;
            byte SlotCardPin = 0;

            bool IsFieldConnector = false;

            SlotCardConnection currSlotCardConnection = new SlotCardConnection();


            //Create new mapping which contains field connector and slot card mapping details
            dtFieldConnectMapping = new DataTable("FieldConnectMapping");
            dtFieldConnectMapping.Columns.Add("Signal Name", typeof(string));
            dtFieldConnectMapping.Columns.Add("Field Connector Designation", typeof(string));
            dtFieldConnectMapping.Columns.Add("Card Description", typeof(string));
            dtFieldConnectMapping.Columns.Add("Slot Number", typeof(byte));
            dtFieldConnectMapping.Columns.Add("Slot Card Pin #", typeof(byte));
            dtFieldConnectMapping.Columns.Add("Corner Connector Designation", typeof(string));


            //Netlist structure
            //dtNetList.Columns.Add("Signal Name", typeof(string));
            //dtNetList.Columns.Add("Field Connector Designations", typeof(string));
            //dtNetList.Columns.Add("Corner Connector Designation", typeof(string));

            //private struct SlotCardConnection
            //{
            //    public string CardDescription;
            //    public byte SlotNumber;
            //    public byte SlotCardPinNumber;
            //    public string CornerConnectorDesignation;
            //};


            foreach (DataRow row in dtNetList.Rows)
            {
                //Check if this row in the netlist data table contains information about a field connector name
                //This is done by checking to see if a known field connector name appears in the field connector designation from the netlist
                IsFieldConnector = false;

                FieldConnectorDesignation = row.ItemArray[1].ToString();
                foreach(String FieldConnectorName in dictFieldConnectors.Keys)
                {
                    if (FieldConnectorDesignation.Contains(FieldConnectorName))
                        IsFieldConnector = true;
                }

                //If this row does not include field connector information, continue to the next netlist data table row
                if (!IsFieldConnector)
                    continue;

                CornerConnectorDesignation = row.ItemArray[2].ToString();


                //Test
                SignalName = row.ItemArray[0].ToString();
                FieldConnectorDesignation = row.ItemArray[1].ToString();
                if (dictSlotCardConnection.TryGetValue(CornerConnectorDesignation, out currSlotCardConnection))
                {
                    CardDescription = currSlotCardConnection.CardDescription;
                    SlotNumber = currSlotCardConnection.SlotNumber;
                    SlotCardPin = currSlotCardConnection.SlotCardPinNumber;
                }

                dtFieldConnectMapping.Rows.Add(SignalName, FieldConnectorDesignation, CardDescription, SlotNumber, SlotCardPin, CornerConnectorDesignation);


                //If the Corner Connector Designation is found in the slot card mapping (data table)
                //Then a matching slot card mapping has been found
                //Combine information from this slot card mapping with the field connect mapping in a new map (data table)
                //if (dictSlotCardConnection.TryGetValue(CornerConnectorDesignation, out currSlotCardConnection))
                //{
                //    SignalName = row.ItemArray[0].ToString();
                //    FieldConnectorDesignation = row.ItemArray[1].ToString();
                //    CardDescription = currSlotCardConnection.CardDescription;
                //    SlotNumber = currSlotCardConnection.SlotNumber;
                //    SlotCardPin = currSlotCardConnection.SlotCardPinNumber;

                //    dtFieldConnectMapping.Rows.Add(SignalName, FieldConnectorDesignation, CardDescription, SlotNumber, SlotCardPin, CornerConnectorDesignation);
                //    i = 1;
                //}

                //else;
                //    i= 0;
            }

            dgvFcMap.DataSource = dtFieldConnectMapping;
        }

        private void btnOpenConnectorList_Click(object sender, EventArgs e)
        {
            //string ConnectorName = string.Empty;
            //string ConnectorDescription = string.Empty;
            //string ConnectorType = string.Empty;

            string ConnectorListFilePath = string.Empty;
            
            FieldConnectorInfo currFieldConnectorInfo = new FieldConnectorInfo();
            DataTable dtFieldConnectors = new DataTable();
            dictFieldConnectors = new Dictionary<string, FieldConnectorInfo>();


            OpenFileDialog openConnectorListFileDialog = new OpenFileDialog();
            openConnectorListFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openConnectorListFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openConnectorListFileDialog.FilterIndex = 2;
            openConnectorListFileDialog.RestoreDirectory = true;

            if (openConnectorListFileDialog.ShowDialog() == DialogResult.OK)
            {


                //Get the path of specified file
                ConnectorListFilePath = openConnectorListFileDialog.FileName;

                //Read CSV contents into data table
                dtFieldConnectors = ConvertCSVtoDataTable(ConnectorListFilePath);


                //Populate Field Connector dictionary with contents of data table
                foreach(DataRow row in dtFieldConnectors.Rows)
                {
                    //private struct ConnectorInfo
                    //{
                    //    public string ConnectorName;
                    //    public string ConnectorDescription;
                    //    public string ConnectorType;
                    //};

                    currFieldConnectorInfo.ConnectorName = row.ItemArray[0].ToString();
                    currFieldConnectorInfo.ConnectorDescription = row.ItemArray[1].ToString();
                    currFieldConnectorInfo.ConnectorType = row.ItemArray[2].ToString();

                    dictFieldConnectors.Add(currFieldConnectorInfo.ConnectorName, currFieldConnectorInfo);
                }

                //Update Connector List DataGridView with parsed connector list
                dgvConnectorTable.DataSource = dtFieldConnectors;
            }

        }


        public static DataTable ConvertCSVtoDataTable(string sCsvFilePath)
        {
            DataTable dtTable = new DataTable();
            Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

            using (StreamReader sr = new StreamReader(sCsvFilePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dtTable.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = CSVParser.Split(sr.ReadLine());
                    DataRow dr = dtTable.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i].Replace("\"", string.Empty);
                    }
                    dtTable.Rows.Add(dr);
                }
            }

            return dtTable;
        }

    }
}
