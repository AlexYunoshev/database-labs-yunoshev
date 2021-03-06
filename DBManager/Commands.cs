using System;
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
                from dbo.medications med LEFT OUTER JOIN dbo.medications_types medt on (med.medications_types_id = medt.id)
				LEFT OUTER JOIN dbo.manufacture_types mant on (med.manufacture_types_id = mant.id) LEFT OUTER JOIN dbo.uses_types uset                
                on (med.uses_types_id = uset.id)";

            if (name != "")
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
            else if (id1 != -1 && id2 != -1 && name == "")
            {
                cmd = @"delete from dbo.medications where id >= " + id1 + " and id <= " + id2 + ";";
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

        public static string InsertStorehouseF(int medicationsId, int Quantity, int CriticalQuantity, string StorehouseRequestId, string ManufactureDate, string ShelfLife)
        {
            string cmd = @"insert into 
            dbo.storehouse_fields(medications_id, critical_quantity, storehouse_requests_id, quantity, manufacture_date, shelf_life)
            values(" + medicationsId + ", " + CriticalQuantity + ", " + StorehouseRequestId + ", " + Quantity + ", '" + ManufactureDate + "', '" + ShelfLife + "')";
            return cmd;
        }

        public static string UpdateStorehouseF(int id, int Quantity, int CriticalQuantity, string StorehouseRequestId, string ManufactureDate, string ShelfLife)
        {
            string cmd = @"update dbo.storehouse_fields set
            quantity = " + Quantity + ", " +
            "critical_quantity = " + CriticalQuantity + ", " +
            "manufacture_date = '" + ManufactureDate + "', " +
            "shelf_life = '" + ShelfLife + "', " +
            "storehouse_requests_id = " + StorehouseRequestId +
            " where id = " + id + ";";
            return cmd;
        }

        public static string DeleteStorehouseF(int id1 = -1, int id2 = -1, string name = "")
        {
            string cmd = "";
            if (id1 != -1 && id2 == -1 && name == "")
            {
                cmd = @"delete from dbo.storehouse_fields where id = " + id1 + ";";
            }
            else if (id1 != -1 && id2 != -1 && name == "")
            {
                cmd = @"delete from dbo.storehouse_fields where id >= " + id1 + " and id <= " + id2 + ";";
            }
            else if (name != "" && id1 == -1 && id2 == -1)
            {
                cmd = @"delete from dbo.storehouse_fields where medications_id = (select id from dbo.medications where medications_name = N'" + name + "')";
            }
            else if (name != "" && id1 != -1 && id2 != -1)
            {
                cmd = @"delete from dbo.storehouse_fields where id >= " + id1 + " and id <= " + id2 + " and medications_id = (select id from dbo.medications where medications_name = N'" + name + "')";
            }
            return cmd;
        }

        public static string SelectPrescriptions(SortTypes sort, string name = "")
        {
            string cmd = @"select pres.id, pres.patient_id, p.full_name, pres.doctor_full_name, 
            pres.doctor_signature, pres.doctor_stamp
            from dbo.prescriptions pres, dbo.patient p
            where pres.patient_id = p.id";

            if (name != "")
            {
                cmd += " and (pres.doctor_full_name like N'%" + name + "%'" + " or p.full_name like N'%" + name + "%')";
            }

            if (sort == SortTypes.IdDesc)
            {
                cmd += " order by pres.id desc";
            }
            else if (sort == SortTypes.NameAsc)
            {
                cmd += " order by pres.doctor_full_name asc";
            }

            else if (sort == SortTypes.NameDesc)
            {
                cmd += " order by pres.doctor_full_name desc";
            }

            else if (sort == SortTypes.Name2Asc)
            {
                cmd += " order by p.full_name asc";
            }

            else if (sort == SortTypes.Name2Desc)
            {
                cmd += " order by p.full_name desc";
            }

            return cmd;
        }

        public static string SelectPrescriptionsDiagnoses()
        {
            string cmd = @"select DISTINCT p.id, d.diagnosis 
            from dbo.diagnoses_prescriptions dp, dbo.diagnoses d, dbo.prescriptions p
            where dp.prescriptions_id = p.id and dp.diagnoses_id = d.id order by p.id asc";

            return cmd;
        }

        public static string SelectPrescriptionsMedications()
        {
            string cmd = @"select DISTINCT p.id, m.medications_name, pm.quantity 
            from dbo.prescriptions_medications pm, dbo.medications m, dbo.prescriptions p
            where pm.prescriptions_id = p.id and pm.medications_id = m.id order by p.id asc";

            return cmd;
        }

        public static string SelectLastId(string tableName)
        {
            string cmd = @"SELECT MAX(id) from " + tableName;
            return cmd;
        }

        public static string InsertPrescriptions(string DoctorName, bool DoctorSignature, bool DoctorStamp, int PatientId)
        {
            string cmd = @"insert into 
            dbo.prescriptions(doctor_full_name, doctor_signature, doctor_stamp, patient_id)
            values(N'" + DoctorName + "', '" + DoctorSignature + "', '" + DoctorStamp + "', " + PatientId + ");\n";
            return cmd;
        }

        public static string InsertDiagnosesPrescriptions(List<int> DiagnosesId, int id)
        {
            string cmd = @"";
            foreach (var a in DiagnosesId)
            {
                cmd += @"insert into dbo.diagnoses_prescriptions(diagnoses_id, prescriptions_id)
                values(" + a + ", " + id + ");\n";
            }
            return cmd;
        }

        public static string InsertPrescriptionsMedications(Dictionary<int, int> MedicationsId, int id)
        {
            string cmd = @"";

            foreach (KeyValuePair<int, int> a in MedicationsId)
            {
                cmd += @"insert into dbo.prescriptions_medications(prescriptions_id, medications_id, quantity)
                values(" + id + ", " + a.Key + ", " + a.Value + ");\n";
            }
            return cmd;
        }

        public static string DeletePrescriptionsMedications(int id)
        {
            string cmd = @"delete from dbo.prescriptions_medications where prescriptions_id = " + id;
            return cmd;
        }

        public static string DeleteDiagnosesPrescriptions(int id)
        {
            string cmd = @"delete from dbo.diagnoses_prescriptions where prescriptions_id = " + id;
            return cmd;
        }

        public static string SelectPatientWhereId(int id)
        {
            string cmd = @"select * from dbo.patient where id = " + id;
            return cmd;
        }

        public static string DeletePrescriptions(int id1 = -1, int id2 = -1, string name = "")
        {
            string cmd = "";
            if (id1 != -1 && id2 == -1 && name == "")
            {
                cmd = @"delete from dbo.prescriptions where id = " + id1 + ";";
            }
            else if (id1 != -1 && id2 != -1 && name == "")
            {
                cmd = @"delete from dbo.prescriptions where id >= " + id1 + " and id <= " + id2 + ";";
            }
            else if (name != "" && id1 == -1 && id2 == -1)
            {
                cmd = @"delete from dbo.prescriptions where patient_id = (select id from dbo.patient where full_name = N'" + name + "')";
            }
            else if (name != "" && id1 != -1 && id2 != -1)
            {
                cmd = @"delete from dbo.prescriptions where id >= " + id1 + " and id <= " + id2 + " and patient_id = (select id from dbo.patient where full_name = N'" + name + "')";
            }
            return cmd;
        }

        public static string SelectPrescriptionsWhereId(int id)
        {
            string cmd = @"select * from dbo.prescriptions where id = " + id;
            return cmd;
        }

        public static string SelectPrescriptionsDiagnosesWhereId(int id)
        {
            string cmd = @"select DISTINCT p.id, d.id 
            from dbo.diagnoses_prescriptions dp, dbo.diagnoses d, dbo.prescriptions p
            where dp.prescriptions_id = p.id and dp.diagnoses_id = d.id and p.id = " + id + " order by p.id asc";

            return cmd;
        }

        public static string SelectPrescriptionsMedicationsWhereId(int id)
        {
            string cmd = @"select DISTINCT p.id, m.id, pm.quantity 
            from dbo.prescriptions_medications pm, dbo.medications m, dbo.prescriptions p
            where pm.prescriptions_id = p.id and pm.medications_id = m.id and p.id = " + id + " order by p.id asc";

            return cmd;
        }

        public static string UpdatePrescriptions(int id, string DoctorName, bool DoctorSignature, bool DoctorStamp, int PatientId)
        {
            string cmd = @"update dbo.prescriptions set
            doctor_full_name = N'" + DoctorName + "', " +
            "doctor_signature = '" + DoctorSignature + "', " +
            "doctor_stamp = '" + DoctorStamp + "', " +
            "patient_id = " + PatientId +
            " where id = " + id + ";\n";
    
            return cmd;
        }
    }
}
