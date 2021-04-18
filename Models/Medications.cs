using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Medications
    {
        //private static string name;
        //private static string quantity;
        //private static string volume;
        //private static string preparationTime;
        //private static string filterTime;
        //private static string listComponents;
        //private static double price;
        //private static int medicationType;
        //private static int usesType;
        //private static int manufactureType;
        public static int id1 { get; set; }
        public static int id2 { get; set; }
        public static string Name { get; set; }
        public static string Quantity { get; set; }
        public static string Volume { get; set; }
        public static string PreparationTime { get; set; }
        public static string FiltrationTime { get; set; }
        public static string MixableList { get; set; }
        public static double Price { get; set; }
        public static int MedicationType { get; set; }
        public static int UsesType { get; set; }
        public static int ManufactureType { get; set; }
    }
}
