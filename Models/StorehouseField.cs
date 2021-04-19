using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class StorehouseField
    {
        public static int id1 { get; set; }
        public static int id2 { get; set; }
        public static int Medications_id { get; set; }
        public static int Critical_quantity { get; set; }
        public static int Quantity { get; set; }
        public static int StorehouseRequestsId { get; set; }
        public static string ManufactureDate { get; set; }
        public static string ShelfLife { get; set; }
    }
}
