using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Notes
//- Each JS connector has (6) groups of 18 pins
//- JS group designation (e.g. JS1A, JS2B, etc.) will be assigned by user based on what is in the FC schematic
//- Netlist contains assignments of signal names to JS connector using pins 1-108
//- Each JS group has 18 pins
//- JS group (A-F) can be determined by performing a modulo 18 calculation on the pin number read from the netlist
//- 

//Contains functionality to define slot card selection for a Fusion/RIM device
namespace DeviceSlotCards
{
    public static class AvailableSlotCards
    {
        public static List<SlotCard> AllSlotCards = new List<SlotCard>();

        public static void InitCardSelection()
        {
            //DIN cards
            AllSlotCards.Add(new SlotCard(SlotCardType.CDI_10, "CDI-10", 16, 1));
            AllSlotCards.Add(new SlotCard(SlotCardType.CDI_11, "CDI-11", 16, 1));
            AllSlotCards.Add(new SlotCard(SlotCardType.CDI_12, "CDI-12", 16, 1));
            AllSlotCards.Add(new SlotCard(SlotCardType.COI_10, "COI-10", 8, 2));
            AllSlotCards.Add(new SlotCard(SlotCardType.COI_11, "COI-11", 16, 1));

            //DOUT cards
            AllSlotCards.Add(new SlotCard(SlotCardType.CDO_10, "CDO-10", 16, 1));
            AllSlotCards.Add(new SlotCard(SlotCardType.CDO_11, "CDO-11", 16, 1));
            AllSlotCards.Add(new SlotCard(SlotCardType.CRS_10, "CRS-10", 8, 2));
            AllSlotCards.Add(new SlotCard(SlotCardType.CRS_13, "CRS-13", 4, 2));
            //            AllSlotCards.Add(new SlotCard(SlotCardType.CRS_14, "CRS-14", 8, 2));
            AllSlotCards.Add(new SlotCard(SlotCardType.COO_10, "COO-10", 8, 2));
            AllSlotCards.Add(new SlotCard(SlotCardType.COO_11, "COO-11", 16, 1));

            //AIN cards
            AllSlotCards.Add(new SlotCard(SlotCardType.CAI_10, "CAI-10", 8, 2));
            AllSlotCards.Add(new SlotCard(SlotCardType.CAI_11, "CAI-11", 8, 2));
            AllSlotCards.Add(new SlotCard(SlotCardType.CAI_14, "CAI-14", 16, 1));
            AllSlotCards.Add(new SlotCard(SlotCardType.CAI_15, "CAI-15", 16, 1));

            //AOUT cards
            AllSlotCards.Add(new SlotCard(SlotCardType.CAO_10, "CAO-10", 8, 2));
            AllSlotCards.Add(new SlotCard(SlotCardType.CAO_15 , "CAI-15", 8, 2));
            AllSlotCards.Add(new SlotCard(SlotCardType.CAO_16, "CAI-16", 16, 1));
            AllSlotCards.Add(new SlotCard(SlotCardType.CAO_17, "CAI-17", 16, 1));
            AllSlotCards.Add(new SlotCard(SlotCardType.CAO_20, "CAI-20", 8, 2));
            AllSlotCards.Add(new SlotCard(SlotCardType.CAO_21, "CAI-21", 16, 1));

            //Temperature & Specialty Cards
            AllSlotCards.Add(new SlotCard(SlotCardType.CTP_11, "CTP_11", 16, 1));
            AllSlotCards.Add(new SlotCard(SlotCardType.CTP_11, "CTP_12", 4, 1));
            AllSlotCards.Add(new SlotCard(SlotCardType.CPM_10, "CPM_10", 16, 1));
            AllSlotCards.Add(new SlotCard(SlotCardType.CUR_12, "CUR_12", 4, 4));
        }

    }

    static class Constants
    {
        //IO types for slot cards
        public const ushort IOTYPE_DIN = 0;
        public const ushort IOTYPE_DOUT = 1;
        public const ushort IOTYPE_AIN = 2;
        public const ushort IOTYPE_AOUT = 3;
        public const ushort IOTYPE_AINOUT = 4;
        public const ushort IOTYPE_UART = 5;

        public static string [] CornerConnectorGroups = new string[]{
            "JS1A",
            "JS1B",
            "JS1C",
            "JS1D",
            "JS1E",
            "JS1F",
            "JS2A",
            "JS2B",
            "JS2C",
            "JS2D",
            "JS2E",
            "JS2F",
            "JS3A",
            "JS3B",
            "JS3C",
            "JS3D",
            "JS3E",
            "JS3F",
            "JS4A",
            "JS4B",
            "JS4C",
            "JS4D",
            "JS4E",
            "JS4F"
        };

    }

    
    //Used to define a slot card which is installed in a Fusion or RIM
    public class SlotCard
    {
        public String CardDescription;
        public String CodeName;
        public byte NumChannels;
        public byte PinsPerChannel;
        public Int16 HexCode;
        public byte IOChannelType;
        public String[] PartNumbers;

        public SlotCard(String CardDesc, String Code, byte NumCh, byte Pstep)
        {
            CardDescription = CardDesc;
            CodeName = Code;
            NumChannels = NumCh;
            PinsPerChannel = Pstep;
        }

        public SlotCard(String CardDesc, String Code, byte NumCh, byte ChannelPins, Int16 CodeVal, byte IOType, String[] Pns)
        {
            CardDescription = CardDesc;
            CodeName = Code;
            NumChannels = NumCh;
            PinsPerChannel = ChannelPins;
            HexCode = CodeVal;
            IOChannelType = IOType;
            PartNumbers = Pns;
        }


    }

    public static class SlotCardType
    {
        //DIN Cards
        public const string CDI_10 = "16xDIN 12v threshold";
        public const string CDI_11 = "16xDIN 2.5v threshold";
        public const string CDI_12 = "16xDIN 24V inverted";
        public const string COI_10 = "8xOpto In";
        public const string COI_11 = "16xOpto In";

        //DOUT Cards
        public const string CDO_10 = "16xDOUT Source";
        public const string CDO_11 = "16xDOUT Sink";
        public const string CRS_10 = "8xRelay SPST";
        public const string CRS_13 = "4-ch FG relay SOUT card";
        public const string COO_10 = "8xOpto Out";
        public const string COO_11 = "16xOpto Out";

        //AIN Cards
        public const string CAI_10 = "8xAIN 16 bit open reads 10";
        public const string CAI_11 = "8xAIN 16 bit open reads 0";
        public const string CAI_14 = "16xAIN 16 bit open reads 10";
        public const string CAI_15 = "16xAIN 16 bit open reads 0";

        //AOUT Cards
        public const string CAO_10 = "8xAOUT 16 bit 0 to 10";
        public const string CAO_15 = "8xAOUT 16 bit -10 to 10";
        public const string CAO_16 = "16xAOUT 16 bit 0 to 10";
        public const string CAO_17 = "16xAOUT 16 bit -10 to 10";
        public const string CAO_20 = "8xAOUT 16 bit 0 to 0 to 10";
        public const string CAO_21 = "16xAOUT 16 bit 0 to 0 to 10";

        //Temperature & Specialty Cards
        public const string CTP_11 = "8xThermocouple k-type";
        public const string CTP_12 = "4xRTD _10 to 10";
        public const string CPM_10 = "16xAIN/OUT PPM _10 to 10";
        public const string CUR_12 = "4xUART RS232/RS485";

    }




}
