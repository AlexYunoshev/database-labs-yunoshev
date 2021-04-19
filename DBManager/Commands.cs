﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DBManager
{
    public static class Commands
    {
        public static string InsertMedications(string Name, double Price, string Quantity, string Volume, int MedicationType, int UsesType, int ManufactureType, 
            string MixableList, string PreparationTime , string FiltrationTime)
        {
            string mixableListOut = "";
            string prepatationTimeOut = "";
            string filtrationTimeOut = "";

            if (MixableList == "") 
                mixableListOut = "NULL";
            else
            {
                mixableListOut = "N'";
                mixableListOut += MixableList;
                mixableListOut += "'";
            }

            if (PreparationTime == "") 
                prepatationTimeOut = "NULL";
            else
            {
                prepatationTimeOut = "'";
                prepatationTimeOut += PreparationTime;
                prepatationTimeOut += "'";
            }

            if (FiltrationTime == "")
                filtrationTimeOut = "NULL";
            else
            {
                filtrationTimeOut = "'";
                filtrationTimeOut += FiltrationTime;
                filtrationTimeOut += "'";

            }
        
            string cmd = @"insert into 
            dbo.medications(medications_name, price, quantity, volume, medications_types_id, uses_types_id, manufacture_types_id, 
            preparation_time, filtration_time, mixable_list)
            values(N'" + Name + "', " + Price + ", N'" + Quantity + "', N'" + Volume + "', " + MedicationType + ", " + UsesType + ", " + ManufactureType
            + ", " + prepatationTimeOut + ", " + filtrationTimeOut + ", " + mixableListOut + ");";
            return cmd;
        }

        public static string UpdateMedications(int id, string Name, double Price, string Quantity, string Volume, int MedicationType, int UsesType, int ManufactureType,
           string MixableList, string PreparationTime, string FiltrationTime)
        {
            string mixableListOut = "";
            string prepatationTimeOut = "";
            string filtrationTimeOut = "";

            if (MixableList == "")
                mixableListOut = "NULL";
            else
            {
                mixableListOut = "N'";
                mixableListOut += MixableList;
                mixableListOut += "'";
            }

            if (PreparationTime == "")
                prepatationTimeOut = "NULL";
            else
            {
                prepatationTimeOut = "'";
                prepatationTimeOut += PreparationTime;
                prepatationTimeOut += "'";
            }

            if (FiltrationTime == "")
                filtrationTimeOut = "NULL";
            else
            {
                filtrationTimeOut = "'";
                filtrationTimeOut += FiltrationTime;
                filtrationTimeOut += "'";

            }

            string cmd = @"update dbo.medications set
            medications_name = N'" + Name + "', " +
            "price = " + Price + ", " +
            "quantity = N'" + Quantity + "', " +
            "volume = N'" + Volume + "', " +
            "medications_types_id = " + MedicationType + ", " +
            "uses_types_id = " + UsesType + ", " +
            "manufacture_types_id = " + ManufactureType + ", " +
            "preparation_time = " + prepatationTimeOut + ", " +
            "filtration_time = " + filtrationTimeOut + ", " +
            "mixable_list = " + mixableListOut +
            " where id = " + id + ";";
            
            return cmd;
        }

        public static string SelectMedications(SortTypes sort, string name = "")
        {
            string cmd = @"select med.id, med.medications_name, med.price,
                med.quantity, med.volume,
                medt.type_name,
                uset.type_name,
                mant.type_name,
                med.preparation_time, med.filtration_time, med.mixable_list
                from dbo.medications med, dbo.medications_types medt, dbo.manufacture_types mant, dbo.uses_types uset
                where med.medications_types_id = medt.id and
                med.uses_types_id = uset.id and
                med.manufacture_types_id = mant.id";

            if(name != "")
            {
                cmd += " and med.medications_name like N'%" + name + "%'";
            }
            
            if (sort == SortTypes.IdDesc)
            {
                cmd += " order by med.id desc";
            }
            else if (sort == SortTypes.NameAsc)
            {
                cmd += " order by med.medications_name asc";
            }

            else if (sort == SortTypes.NameDesc)
            {
                cmd += " order by med.medications_name desc";
            }

            return cmd;
        }

        public static string SelectMedicationsWhereId(int id)
        {
            string cmd = @"select * from dbo.medications where id = " + id;    
            return cmd;    
        }

        public static string DeleteMedications(int id1 = -1, int id2 = -1, string name = "")
        {
            string cmd = "";
            if (id1 != -1 && id2 == -1 && name == "")
            {
                cmd = @"delete from dbo.medications where id = " + id1 + ";";
            }
            else if (id1 != -1 &&id2 != -1 && name == "")
            {
                cmd = @"delete from dbo.medications where id >= " + id1 + " and id <= " + id2 +";";
            } 
            else if (name != "" && id1 == -1 && id2 == -1)
            {
                cmd = @"delete from dbo.medications where medications_name = N'" + name + "';";
            }
            else if (name != "" && id1 != -1 && id2 != -1)
            {
                cmd = @"delete from dbo.medications where id >= " + id1 + " and id <= " + id2 + " and medications_name = N'" + name + "';";
            }
            return cmd;
        }

        public static string SelectStorehouseF(SortTypes sort, string name = "")
        {
            string cmd = @"select sf.id, sf.medications_id, med.medications_name, 
            sf.quantity, sf.critical_quantity, sf.manufacture_date, 
            sf.shelf_life, sf.storehouse_requests_id 
            from dbo.storehouse_fields sf, dbo.medications med
            where sf.medications_id = med.id ";

            if (name != "")
            {
                cmd += " and med.medications_name like N'%" + name + "%'";
            }

            if (sort == SortTypes.IdDesc)
            {
                cmd += " order by sf.id desc";
            }
            else if (sort == SortTypes.NameAsc)
            {
                cmd += " order by med.medications_name asc";
            }

            else if (sort == SortTypes.NameDesc)
            {
                cmd += " order by med.medications_name desc";
            }

            return cmd;
        }

        public static string SelectStorehouseFWhereId(int id)
        {
            string cmd = @"select * from dbo.storehouse_fields where id = " + id;
            return cmd;
        }

        public static string SelectStorehouseRWhereId(int id)
        {
            string cmd = @"select * from dbo.storehouse_requests where id = " + id;
            return cmd;
        }

        public static string UpdateStorehouseF(int id, int Quantity, int CriticalQuantity, string StorehouseRequestId, string ManufactureDate, string ShelfLife)
        {
            //string storehouseRequestIdOut = "";
            //if (MixableList == "")
            //    mixableListOut = "NULL";
            //else
            //{
            //    mixableListOut = "N'";
            //    mixableListOut += MixableList;
            //    mixableListOut += "'";
            //}


            string cmd = @"update dbo.storehouse_fields set
            quantity = " + Quantity + ", " +
            "critical_quantity = " + CriticalQuantity + ", " + 
            "manufacture_date = '" + ManufactureDate + "', " + 
            "shelf_life = '" + ShelfLife + "', " + 
            "storehouse_requests_id = " + StorehouseRequestId +
            " where id = " + id + ";";

            return cmd;
        }
    }
}
