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

namespace FieldConnectMapping
{
    public partial class Form1 : Form
    {
        private const string SignalHeader = "*SIGNAL*";
        private const string InternalConnectorPrefix = "JS";

        private const Int32 NumSlots = 24; //temporary, for testing Fusion

        public Form1()
        {
            InitializeComponent();
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
            }

        }

        private Boolean GetFieldConnectDesignations(string NetlistFile)
        {
            StreamReader reader;
            string line = string.Empty;
            string SignalName = string.Empty;
            string[] splitsignalline = new string[2];
            string ConnectorAssignments = string.Empty;
            Boolean InSignalSection = false;

            int i;

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
                //This will proceed until the first signal line is found
                if (line.Contains(SignalHeader))
                {
                    InSignalSection = true;
                    ConnectorAssignments = string.Empty;

                    splitsignalline = line.Split("* ");
                    SignalName = splitsignalline[1];

                    do
                    {
                        line = reader.ReadLine();
                        if (line == null)
                            break;
                        if (!line.Contains(SignalHeader))
                            ConnectorAssignments += " " + line;
                    }
                    while (!(line.Contains(SignalHeader)));


                    i = 0;
                }

            } while (line != null);

            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewRow SlotCardRow;
            DataGridViewCell cellSlotNum;

            AvailableSlotCards.InitCardSelection();


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

        private void dgvSlotCardArrangement_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Int32 i;
            string formCardDescription = string.Empty;



            if (e.ColumnIndex == dgvSlotCardArrangement.Columns["colCardDesc"].Index)
            {
                if (dgvSlotCardArrangement[e.ColumnIndex, e.RowIndex].Value!=null)
                {
                    formCardDescription = dgvSlotCardArrangement[e.ColumnIndex, e.RowIndex].Value.ToString();
                    //Look up the slotcard object with this description
                    foreach (SlotCard currCard in DeviceSlotCards.AvailableSlotCards.AllSlotCards)
                    {
                        if (currCard.CardDescription.Equals(formCardDescription))
                        {
                            dgvSlotCardArrangement["colNumChannels", e.RowIndex].Value = currCard.NumChannels;
                            dgvSlotCardArrangement["colCodeName", e.RowIndex].Value = currCard.CodeName;
                            dgvSlotCardArrangement["colPinStep", e.RowIndex].Value = currCard.PinStep;

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

        private void dgvSlotCardArrangement_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Int32 i;

            i = 1;
        }

        private void dgvSlotCardArrangement_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            Int32 i;

            i = 1;
        }


    }
}
