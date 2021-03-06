using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBManager;
using lab6_yunoshev.Medications;
using lab6_yunoshev.StorehouseFields;
using lab6_yunoshev.Prescriptions;
using Models;

namespace lab6_yunoshev
{
    public partial class MainForm : MaterialForm
    {
        ConnectionTypes connectionType;
        string query = "";
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        DataSet dataSet;

        public MainForm(ConnectionTypes connectionType)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE);
            this.connectionType = connectionType;
        }
      

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = MainTabControl.TabPages[0].Text;
            MedicationsPrint(SortTypes.IdAsc);
            StorehouseFPrint(SortTypes.IdAsc);
            PrescriptionsPrint(SortTypes.IdAsc);
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = MainTabControl.SelectedIndex;
            this.Text = MainTabControl.TabPages[index].Text;     
        }

        public void MedicationsPrint(SortTypes sort, string name = "")
        {
            double sum = 0;
            int countPills = 0;
            int countSolutes = 0;
            MedicationsListView.Items.Clear();
            if (name != "") query = Commands.SelectMedications(sort, name);
            else query = Commands.SelectMedications(sort);
            ListViewItem item;

            if (connectionType == ConnectionTypes.Connected)
            {
                
                ConnectedData.SetCommand(query);
                int[] size = new int[2];
                size = ConnectedData.GetRowAndColumnCount();
                int row = size[0];
                int column = size[1];
                
                string[,] data = new string[row, column];
                data = ConnectedData.GetTableData();

                for (int i = 0; i < row; i++)
                {
                    item = new ListViewItem(data[i, 0]);
                    for (int j = 1; j < column; j++)
                    {
                        if (j == 2)
                        {
                            double value = Convert.ToDouble(data[i, j]);
                            item.SubItems.Add(Math.Round(value, 2).ToString() + " грн");
                            sum += value;
                        }

                        else
                            item.SubItems.Add(data[i, j]);
                        if (j == 5 && data[i, j] == "Таблетки") countPills++;
                        else if (j == 5 && data[i, j] == "Раствор") countSolutes++;
                    }
                    MedicationsListView.Items.Add(item);
                }
            }

            else
            {
                dataSet = DisconnectedData.GetTableData(query);
                DataTable dataTable = dataSet.Tables[0];
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow dataRow = dataTable.Rows[i];
                    item = new ListViewItem(dataRow[0].ToString());
                    for (int j = 1; j < dataTable.Columns.Count; j++)
                    {
                        if (j == 2)
                        {
                            double value = Convert.ToDouble(dataRow[j]);
                            item.SubItems.Add(Math.Round(value, 2).ToString() + " грн");
                            sum += value;
                        }

                        else
                            item.SubItems.Add(dataRow[j].ToString());
                        if (j == 5 && dataRow[j].ToString() == "Таблетки") countPills++;
                        else if (j == 5 && dataRow[j].ToString() == "Раствор") countSolutes++;
                    }
                    MedicationsListView.Items.Add(item);
                }
            }


            LabelMedicationsSumPriceValue.Text = Math.Round(sum, 2).ToString() + " грн";
            LabelMedicationsSumPillsValue.Text = countPills.ToString();
            LabelMedicationsSumSolutesValue.Text = countSolutes.ToString();
        }

        private void MedicationButtonAdd_Click(object sender, EventArgs e)
        {
            AddMedications addMedications = new AddMedications();
            DialogResult status = addMedications.ShowDialog();
            if (status == DialogResult.OK)
            {
                query = Commands.InsertMedications(Models.Medications.Name, Models.Medications.Price, Models.Medications.Quantity,
                        Models.Medications.Volume, Models.Medications.MedicationType, Models.Medications.UsesType, Models.Medications.ManufactureType,
                        Models.Medications.MixableList, Models.Medications.PreparationTime, Models.Medications.FiltrationTime);
                MessageBox.Show(query);
                int count;
                if (connectionType == ConnectionTypes.Connected)
                {
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                
                }
                else
                {
                    count = DisconnectedData.InsertData(query);
                }
                MessageBox.Show("Добавлено: " + count.ToString());
                MedicationsPrint(SortTypes.IdAsc);
            }       
        }

        private void MedicationButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteMedications deleteMedications = new DeleteMedications();
            DialogResult status = deleteMedications.ShowDialog();

            if (status == DialogResult.OK)
            {
                query = Commands.DeleteMedications(Models.Medications.id1, Models.Medications.id2, Models.Medications.Name);
                MessageBox.Show(query);
                int count;
                if (connectionType == ConnectionTypes.Connected)
                {
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                }
                else
                {
                    count = DisconnectedData.DeleteData(query);
                }
                MessageBox.Show("Удалено: " + count.ToString());
                MedicationsPrint(SortTypes.IdAsc);    
            }
            

               
        }

        private void MedicationButtonEdit_Click(object sender, EventArgs e)
        {
            UpdateMedications updateMedications = new UpdateMedications(connectionType);
            DialogResult status = updateMedications.ShowDialog();
            if (status == DialogResult.OK)
            {
                query = Commands.UpdateMedications(Models.Medications.id1, Models.Medications.Name, Models.Medications.Price, Models.Medications.Quantity,
                       Models.Medications.Volume, Models.Medications.MedicationType, Models.Medications.UsesType, Models.Medications.ManufactureType,
                       Models.Medications.MixableList, Models.Medications.PreparationTime, Models.Medications.FiltrationTime);
                MessageBox.Show(query);
                int count;

                if (connectionType == ConnectionTypes.Connected)
                {
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                }
                else
                {
                    count = DisconnectedData.UpdateData(query);
                }
               
                MessageBox.Show("Обновлено: " + count.ToString());
                MedicationsPrint(SortTypes.IdAsc);
            }

            

                
        }

        private void MedicationsComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MedicationsComboBoxSort.SelectedIndex == 0) MedicationsPrint(SortTypes.IdAsc);
            else if (MedicationsComboBoxSort.SelectedIndex == 1) MedicationsPrint(SortTypes.IdDesc);
            else if (MedicationsComboBoxSort.SelectedIndex == 2) MedicationsPrint(SortTypes.NameAsc);
            else if (MedicationsComboBoxSort.SelectedIndex == 3) MedicationsPrint(SortTypes.NameDesc);
        }

        private void MedicationsTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (MedicationsTextBoxSearch.Text != "")
            {
                MedicationsPrint(SortTypes.IdAsc, MedicationsTextBoxSearch.Text);
            }
            else
            {
                MedicationsPrint(SortTypes.IdAsc);
            }
        }

        public void StorehouseFPrint(SortTypes sort, string name = "")
        {
            StorehouseFListView.Items.Clear();
            if (name != "") query = Commands.SelectStorehouseF(sort, name);
            else query = Commands.SelectStorehouseF(sort);
            ListViewItem item;
            if (connectionType == ConnectionTypes.Connected)
            {
                
                ConnectedData.SetCommand(query);
                int[] size = new int[2];
                size = ConnectedData.GetRowAndColumnCount();
                int row = size[0];
                int column = size[1];
                string[,] data = new string[row, column];
                data = ConnectedData.GetTableData();

                for (int i = 0; i < row; i++)
                {
                    item = new ListViewItem(data[i, 0]);

                    for (int j = 1; j < column; j++)
                    {
                        if (j == 5 || j == 6)
                        {
                            DateTime value = Convert.ToDateTime(data[i, j]);
                            item.SubItems.Add(value.ToShortDateString());
                        }

                        else
                            item.SubItems.Add(data[i, j]);
                    }
                    StorehouseFListView.Items.Add(item);
                }
            }
            else
            {
                dataSet = DisconnectedData.GetTableData(query);
                DataTable dataTable = dataSet.Tables[0];
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow dataRow = dataTable.Rows[i];
                    item = new ListViewItem(dataRow[0].ToString());
                    for (int j = 1; j < dataTable.Columns.Count; j++)
                    {
                        if (j == 5 || j == 6)
                        {
                            DateTime value = Convert.ToDateTime(dataRow[j]);
                            item.SubItems.Add(value.ToShortDateString());
                        }

                        else
                            item.SubItems.Add(dataRow[j].ToString());
                    }
                    StorehouseFListView.Items.Add(item);
                }
            }

              
        }

        private void StorehouseFComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StorehouseFComboBoxSort.SelectedIndex == 0) StorehouseFPrint(SortTypes.IdAsc);
            else if (StorehouseFComboBoxSort.SelectedIndex == 1) StorehouseFPrint(SortTypes.IdDesc);
            else if (StorehouseFComboBoxSort.SelectedIndex == 2) StorehouseFPrint(SortTypes.NameAsc);
            else if (StorehouseFComboBoxSort.SelectedIndex == 3) StorehouseFPrint(SortTypes.NameDesc);
        }

        private void StorehouseFTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (StorehouseFTextBoxSearch.Text != "")
            {
                StorehouseFPrint(SortTypes.IdAsc, StorehouseFTextBoxSearch.Text);
            }
            else
            {
                StorehouseFPrint(SortTypes.IdAsc);
            }
        }

        private void StorehouseFButtonAdd_Click(object sender, EventArgs e)
        {
            AddStorehouseFields addStorehouseFields = new AddStorehouseFields(connectionType);
            DialogResult status = addStorehouseFields.ShowDialog();
            if (status == DialogResult.OK)
            {
                query = Commands.InsertStorehouseF(Models.StorehouseField.Medications_id,
                    Models.StorehouseField.Quantity, Models.StorehouseField.Critical_quantity,
                    Models.StorehouseField.StorehouseRequestsId, Models.StorehouseField.ManufactureDate,
                    Models.StorehouseField.ShelfLife);
                MessageBox.Show(query);
                int count;
                if (connectionType == ConnectionTypes.Connected)
                {
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                }
                else
                {
                    count = DisconnectedData.InsertData(query);
                }
                
                MessageBox.Show("Добавлено: " + count.ToString());
                StorehouseFPrint(SortTypes.IdAsc);
            }


        }

        private void StorehouseFButtonDelete_Click(object sender, EventArgs e)
        {   
            DeleteStorehouseFields deleteStorehouseFields = new DeleteStorehouseFields();
            DialogResult status = deleteStorehouseFields.ShowDialog();

            if (status == DialogResult.OK)
            {
                query = Commands.DeleteStorehouseF(Models.StorehouseField.id1, Models.StorehouseField.id2, Models.StorehouseField.MedicationsName);
                MessageBox.Show(query);
                int count;
                if (connectionType == ConnectionTypes.Connected)
                {
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                }
                else
                {
                    count = DisconnectedData.DeleteData(query);
                }
                
                MessageBox.Show("Удалено: " + count.ToString());
                StorehouseFPrint(SortTypes.IdAsc);
            }

        }

        private void StorehouseFButtonEdit_Click(object sender, EventArgs e)
        {
            UpdateStorehouseFields updateStorehouseFields = new UpdateStorehouseFields(connectionType);
            DialogResult status = updateStorehouseFields.ShowDialog();
            if (status == DialogResult.OK)
            {
                query = Commands.UpdateStorehouseF(Models.StorehouseField.id1, Models.StorehouseField.Quantity,
                        Models.StorehouseField.Critical_quantity, Models.StorehouseField.StorehouseRequestsId,
                        Models.StorehouseField.ManufactureDate, Models.StorehouseField.ShelfLife);
                MessageBox.Show(query);
                int count;
                if (connectionType == ConnectionTypes.Connected)
                {
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                }
                else
                {
                    count = DisconnectedData.UpdateData(query);
                }
                MessageBox.Show("Обновлено: " + count.ToString());
                StorehouseFPrint(SortTypes.IdAsc);
            }

        }

        public void PrescriptionsPrint(SortTypes sort, string name = "")
        {
            PrescriptionsListView.Items.Clear();
            if (name != "") query = Commands.SelectPrescriptions(sort, name);
            else query = Commands.SelectPrescriptions(sort);
            ListViewItem item;
            
            if (connectionType == ConnectionTypes.Connected)
            {

                ConnectedData.SetCommand(query);
                int[] size = new int[2];
                size = ConnectedData.GetRowAndColumnCount();
                int row = size[0];
                int column = size[1];
                string[,] data = new string[row, column];
                data = ConnectedData.GetTableData();
                Dictionary<int, string> list = GetPrescriptionsDiagnoses();
                Dictionary<int, string> list2 = GetPrescriptionsMedications();
                for (int i = 0; i < row; i++)
                {
                    item = new ListViewItem(data[i, 0]);
                    for (int j = 1; j < column; j++)
                    {
                        if (j == 4 || j == 5)
                        {
                            bool value = Convert.ToBoolean(data[i, j]);
                            if (value == true)
                                item.SubItems.Add("+");
                            else
                                item.SubItems.Add("-");
                        }

                        else
                            item.SubItems.Add(data[i, j]);
                    }

                    if (list.ContainsKey(Convert.ToInt32(data[i, 0])))
                        item.SubItems.Add(list[Convert.ToInt32(data[i, 0])]);
                    else
                        item.SubItems.Add("-");

                    if (list2.ContainsKey(Convert.ToInt32(data[i, 0])))
                        item.SubItems.Add(list2[Convert.ToInt32(data[i, 0])]);
                    else
                        item.SubItems.Add("-");

                    PrescriptionsListView.Items.Add(item);
                }
            }
            else
            {
                dataSet = DisconnectedData.GetTableData(query);
                DataTable dataTable = dataSet.Tables[0];
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow dataRow = dataTable.Rows[i];
                    item = new ListViewItem(dataRow[0].ToString());
                    for (int j = 1; j < dataTable.Columns.Count; j++)
                    {
                        if (j == 4 || j == 5)
                        {
                            bool value = Convert.ToBoolean(dataRow[j]);
                            if (value == true)
                                item.SubItems.Add("+");
                            else
                                item.SubItems.Add("-");
                        }

                        else
                            item.SubItems.Add(dataRow[j].ToString());
                    }
                    Dictionary<int, string> list = GetPrescriptionsDiagnoses();
                    Dictionary<int, string> list2 = GetPrescriptionsMedications();
                    if (list.ContainsKey(Convert.ToInt32(dataRow[0])))
                        item.SubItems.Add(list[Convert.ToInt32(dataRow[0])]);
                    else
                        item.SubItems.Add("-");

                    if (list2.ContainsKey(Convert.ToInt32(dataRow[0])))
                        item.SubItems.Add(list2[Convert.ToInt32(dataRow[0])]);
                    else
                        item.SubItems.Add("-");
                    PrescriptionsListView.Items.Add(item);
                }
            }
               
        }

        public Dictionary<int, string> GetPrescriptionsDiagnoses()
        {
            query = Commands.SelectPrescriptionsDiagnoses();
            ConnectedData.SetCommand(query);
            Dictionary<int, string> list = new Dictionary<int, string>();
            if (connectionType == ConnectionTypes.Connected)
            {
               
                int[] size = new int[2];
                size = ConnectedData.GetRowAndColumnCount();
                int row = size[0];
                int column = size[1];
               

                string[,] data = new string[row, column];
                data = ConnectedData.GetTableData();

                int key = Convert.ToInt32(data[0, 0]);
                string str = "";



                for (int i = 0; i < row; i++)
                {
                    if (Convert.ToInt32(data[i, 0]) == key)
                    {
                        str += data[i, 1] + ", ";
                    }
                    else
                    {
                        str = str.Remove(str.Length - 2);
                        list.Add(key, str);
                        str = "";
                        key = Convert.ToInt32(data[i, 0]);
                        str += data[i, 1] + ", ";
                    }
                }
                str = str.Remove(str.Length - 2);
                list.Add(key, str);  
            }

            else
            {
                dataSet = DisconnectedData.GetTableData(query);
                DataTable dataTable = dataSet.Tables[0];
                DataRow dataRow = dataTable.Rows[0];
                int key = Convert.ToInt32(dataRow[0]);
                string str = "";

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataRow = dataTable.Rows[i];
                    if (Convert.ToInt32(dataRow[0]) == key)
                    {
                        str += dataRow[1] + ", ";
                    }
                    else
                    {
                        str = str.Remove(str.Length - 2);
                        list.Add(key, str);
                        str = "";
                        key = Convert.ToInt32(dataRow[0]);
                        str += dataRow[1] + ", ";
                    }
                    
                }         
                str = str.Remove(str.Length - 2);
                list.Add(key, str);

            }

            return list;
        }

        public Dictionary<int, string> GetPrescriptionsMedications()
        {
            query = Commands.SelectPrescriptionsMedications();
            ConnectedData.SetCommand(query);
            Dictionary<int, string> list = new Dictionary<int, string>();
            if (connectionType == ConnectionTypes.Connected)
            {
                int[] size = new int[2];
                size = ConnectedData.GetRowAndColumnCount();
                int row = size[0];
                int column = size[1];
     
                string[,] data = new string[row, column];
                data = ConnectedData.GetTableData();

                int key = Convert.ToInt32(data[0, 0]);
                string str = "";

                for (int i = 0; i < row; i++)
                {
                    if (Convert.ToInt32(data[i, 0]) == key)
                    {
                        str += data[i, 1] + " " + data[i, 2] + "шт, ";
                    }
                    else
                    {
                        str = str.Remove(str.Length - 2);
                        list.Add(key, str);
                        str = "";
                        key = Convert.ToInt32(data[i, 0]);
                        str += data[i, 1] + " " + data[i, 2] + "шт, ";
                    }
                }
                str = str.Remove(str.Length - 2);
                list.Add(key, str);
                
            }

            else
            {
                dataSet = DisconnectedData.GetTableData(query);
                DataTable dataTable = dataSet.Tables[0];
                DataRow dataRow = dataTable.Rows[0];
                int key = Convert.ToInt32(dataRow[0]);
                string str = "";
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataRow = dataTable.Rows[i];
                    if (Convert.ToInt32(dataRow[0]) == key)
                    {
                        str += dataRow[1] + " " + dataRow[2] + "шт, ";
                    }
                    else
                    {
                        str = str.Remove(str.Length - 2);
                        list.Add(key, str);
                        str = "";
                        key = Convert.ToInt32(dataRow[0]);
                        str += dataRow[1] + " " + dataRow[2] + "шт, ";
                    }

                }
                str = str.Remove(str.Length - 2);
                list.Add(key, str);
            }
            return list;

        }

        private void PrescriptionsComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PrescriptionsComboBoxSort.SelectedIndex == 0) PrescriptionsPrint(SortTypes.IdAsc);
            else if (PrescriptionsComboBoxSort.SelectedIndex == 1) PrescriptionsPrint(SortTypes.IdDesc);
            else if (PrescriptionsComboBoxSort.SelectedIndex == 2) PrescriptionsPrint(SortTypes.NameAsc);
            else if (PrescriptionsComboBoxSort.SelectedIndex == 3) PrescriptionsPrint(SortTypes.NameDesc);
            else if (PrescriptionsComboBoxSort.SelectedIndex == 4) PrescriptionsPrint(SortTypes.Name2Asc);
            else if (PrescriptionsComboBoxSort.SelectedIndex == 5) PrescriptionsPrint(SortTypes.Name2Desc);
        }

        private void PrescriptionsTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (PrescriptionsTextBoxSearch.Text != "")
            {
                PrescriptionsPrint(SortTypes.IdAsc, PrescriptionsTextBoxSearch.Text);
            }
            else
            {
                PrescriptionsPrint(SortTypes.IdAsc);
            }
        }

        private void PrescriptionsButtonAdd_Click(object sender, EventArgs e)
        {
            AddPrescriptions addPrescriptions = new AddPrescriptions(connectionType);
            DialogResult status = addPrescriptions.ShowDialog();
            if (status == DialogResult.OK)
            {
                query = Commands.InsertPrescriptions(Models.Prescriptions.doctorName,
                    Models.Prescriptions.doctorSignature, Models.Prescriptions.doctorStamp,
                    Models.Prescriptions.patientId);

                int count;

                if (connectionType == ConnectionTypes.Connected)
                {
                    MessageBox.Show("1\n" + query);
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                    MessageBox.Show("Добавлено: " + count.ToString());

                    string[] data = new string[1];
                    query = Commands.SelectLastId("dbo.prescriptions");
                    MessageBox.Show("2\n" + query);
                    ConnectedData.SetCommand(query);
                    data = ConnectedData.GetRowFromTable();
                    int id = Convert.ToInt32(data[0]);

                    query = Commands.InsertDiagnosesPrescriptions(Models.Prescriptions.diagnosesId, id);
                    MessageBox.Show("3\n" + query);
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                    MessageBox.Show("Добавлено: " + count.ToString());

                    query = Commands.InsertPrescriptionsMedications(Models.Prescriptions.medicationsId, id);
                    MessageBox.Show("4\n" + query);
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                    MessageBox.Show("Добавлено: " + count.ToString());
                }

                else
                {
                    count = DisconnectedData.InsertData(query);
                    MessageBox.Show("Добавлено: " + count.ToString());

                    query = Commands.SelectLastId("dbo.prescriptions");
                    MessageBox.Show("2\n" + query);

                    dataSet = DisconnectedData.GetTableData(query);
                    DataTable dataTable = dataSet.Tables[0];
                    DataRow dataRow = dataTable.Rows[0];
                    int id = Convert.ToInt32(dataRow[0]);

                    query = Commands.InsertDiagnosesPrescriptions(Models.Prescriptions.diagnosesId, id);
                    MessageBox.Show("3\n" + query);
                    count = DisconnectedData.InsertData(query);
                    MessageBox.Show("Добавлено: " + count.ToString());

                    query = Commands.InsertPrescriptionsMedications(Models.Prescriptions.medicationsId, id);
                    MessageBox.Show("4\n" + query);
                    count = DisconnectedData.InsertData(query);
                    MessageBox.Show("Добавлено: " + count.ToString());
                }

                PrescriptionsPrint(SortTypes.IdAsc);
            }
        }

        private void PrescriptionsButtonDelete_Click(object sender, EventArgs e)
        {
            DeletePrescriptions deletePrescriptions = new DeletePrescriptions();
            DialogResult status = deletePrescriptions.ShowDialog();

            if (status == DialogResult.OK)
            {
                query = Commands.DeletePrescriptions(Models.Prescriptions.id1, Models.Prescriptions.id2, Models.Prescriptions.patientName);
                MessageBox.Show(query);
                int count;

                if (connectionType == ConnectionTypes.Connected)
                {
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                }
                else
                {
                    count = DisconnectedData.DeleteData(query);
                }
                
                MessageBox.Show("Удалено: " + count.ToString());
                PrescriptionsPrint(SortTypes.IdAsc);
            }

        }

        private void PrescriptionsButtonEdit_Click(object sender, EventArgs e)
        {
            UpdatePrescriptions updatePrescriptions = new UpdatePrescriptions(connectionType);
            DialogResult status = updatePrescriptions.ShowDialog();
            if (status == DialogResult.OK)
            {
                query = Commands.UpdatePrescriptions(Models.Prescriptions.id1, Models.Prescriptions.doctorName,
                    Models.Prescriptions.doctorSignature, Models.Prescriptions.doctorStamp,
                    Models.Prescriptions.patientId);
                int count;
                MessageBox.Show(query);

                if (connectionType == ConnectionTypes.Connected)
                {
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                    MessageBox.Show("Обновлено основ: " + count.ToString());
                    PrescriptionsPrint(SortTypes.IdAsc);

                    query = Commands.DeleteDiagnosesPrescriptions(Models.Prescriptions.id1);
                    MessageBox.Show(query);
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                    MessageBox.Show("Удалено диагнозов: " + count.ToString());
                    PrescriptionsPrint(SortTypes.IdAsc);

                    query = Commands.DeletePrescriptionsMedications(Models.Prescriptions.id1);
                    MessageBox.Show(query);
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                    MessageBox.Show("Удалено лекарств: " + count.ToString());
                    PrescriptionsPrint(SortTypes.IdAsc);

                    query = Commands.InsertDiagnosesPrescriptions(Models.Prescriptions.diagnosesId, Models.Prescriptions.id1);
                    MessageBox.Show("3\n" + query);
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                    MessageBox.Show("Добавлено диагнозов: " + count.ToString());

                    query = Commands.InsertPrescriptionsMedications(Models.Prescriptions.medicationsId, Models.Prescriptions.id1);
                    MessageBox.Show("4\n" + query);
                    ConnectedData.SetCommand(query);
                    count = ConnectedData.UpdateData();
                    MessageBox.Show("Добавлено лекарств: " + count.ToString());
                }

                else
                {
                    count = DisconnectedData.UpdateData(query);
                    MessageBox.Show("Обновлено основ: " + count.ToString());
                    PrescriptionsPrint(SortTypes.IdAsc);

                    query = Commands.DeleteDiagnosesPrescriptions(Models.Prescriptions.id1);
                    MessageBox.Show(query);
                   
                    count = DisconnectedData.DeleteData(query);
                    MessageBox.Show("Удалено диагнозов: " + count.ToString());
                    PrescriptionsPrint(SortTypes.IdAsc);

                    query = Commands.DeletePrescriptionsMedications(Models.Prescriptions.id1);
                    MessageBox.Show(query);
                    
                    count = DisconnectedData.DeleteData(query);
                    MessageBox.Show("Удалено лекарств: " + count.ToString());
                    PrescriptionsPrint(SortTypes.IdAsc);

                    query = Commands.InsertDiagnosesPrescriptions(Models.Prescriptions.diagnosesId, Models.Prescriptions.id1);
                    MessageBox.Show("3\n" + query);
                   
                    count = DisconnectedData.InsertData(query);
                    MessageBox.Show("Добавлено диагнозов: " + count.ToString());

                    query = Commands.InsertPrescriptionsMedications(Models.Prescriptions.medicationsId, Models.Prescriptions.id1);
                    MessageBox.Show("4\n" + query);
                    count = DisconnectedData.InsertData(query);
                    MessageBox.Show("Добавлено лекарств: " + count.ToString());

                }
                

                PrescriptionsPrint(SortTypes.IdAsc);
            }

        }
    }
}
