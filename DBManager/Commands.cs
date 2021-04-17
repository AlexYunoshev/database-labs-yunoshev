using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager
{
    public static class Commands
    {
        public static string InsertIntoMedications(string Name, double Price, string Quantity, string Volume, int MedicationType, int UsesType, int ManufactureType, 
            string MixableList = "", string PreparationTime = "", string FiltrationTime = "")
        {
   
            //if (MixableList != "") list.Add("mixable_list");
            //if (PreparationTime != DateTime.MinValue) list.Add("prepation_time");
            //if (FiltrationTime != DateTime.MinValue) list.Add("filtration_time");
        

            string cmd = @"insert into 
            dbo.medications(medications_name, price, quantity, volume, medications_types_id, uses_types_id, manufacture_types_id, 
            mixable_list, prepation_time, filtration_time)
            values(N'" + Name + "', " + Price + ", N'" + Quantity + "', N'" + Volume + "', " + MedicationType + ", " + UsesType + ", " + ManufactureType
            + "N'" + MixableList + "', " + PreparationTime + ", " + FiltrationTime + ");";
            return cmd;
        }
    }
}
