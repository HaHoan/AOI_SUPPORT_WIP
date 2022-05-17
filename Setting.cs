using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_SUPPORT_WIP
{
    public class Setting
    {
        public class SpiName
        {
            public static string[] GetSpiName()
            {
                return new string[] { "Y44570", "Y46596" };
            }
        }
        public static string Source { get; set; }
        public static string Target { get; set; }
        public static string Backup { get; set; }
        public static string CurrentStation { get; set; }
        public static string Process { get; set; }
        public static int? TimeSleep { get; set; }
        public static int? Location { get; set; }
        public static int? PCPSheet { get; set; }
        public static string Model { get; set; }
        public static int? LengthBarcode { get; set; }
        public static int? Index { get; set; }
        public static int? To { get; set; }
        public static string CollectType { get; set; }
        public static int? StationIndex { get; set; }
        public static int? StationTo { get; set; }
        public static bool EnableCOM { get; set; }
        public static string DataMode { get; set; }
        public static string DataModelStop { get; set; }
        public static string COMPort { get; set; }
        // public static string OldStation { get; set; }
        public static string MachineName { get; set; }
    }
}
