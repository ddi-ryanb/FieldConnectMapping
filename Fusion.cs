using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusion
{
    public static class FusionDevice
    {
        public static List<CornerConnectorGroup> AllCornerConnectorGroups = new List<CornerConnectorGroup>();


        public class CornerConnectorGroup
        {
            public string Designation;
            public byte StartPin;
            public byte EndPin;

            public CornerConnectorGroup(string Name, byte Start, byte End)
            {
                Designation = Name;
                StartPin = Start;
                EndPin = End;
            }
        }

        public static void InitCornerConnectorGroups()
        {
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS1A", 1, 18));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS1B", 19, 36));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS1C", 37, 54));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS1D", 55, 72));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS1E", 73, 90));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS1F", 91, 108));

            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS2A", 1, 18));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS2B", 19, 36));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS2C", 37, 54));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS2D", 55, 72));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS2E", 73, 90));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS2F", 91, 108));

            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS3A", 1, 18));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS3B", 19, 36));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS3C", 37, 54));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS3D", 55, 72));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS3E", 73, 90));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS3F", 91, 108));

            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS4A", 1, 18));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS4B", 19, 36));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS4C", 37, 54));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS4D", 55, 72));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS4E", 73, 90));
            AllCornerConnectorGroups.Add(new CornerConnectorGroup("JS4F", 91, 108));
        }
    }
}