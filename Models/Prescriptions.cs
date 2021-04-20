using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Prescriptions
    {
        public static int id1 { get; set; }
        public static int id2 { get; set; }
        public static int patientId { get; set; }
        public static string doctorName { get; set; }
        public static bool doctorStamp { get; set; }
        public static bool doctorSignature { get; set; }
        public static List<int> diagnosesId = new List<int>();
        public static Dictionary<int, int> medicationsId = new Dictionary<int, int>();
    }
}
