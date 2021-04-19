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
using Models;

namespace lab6_yunoshev
{
    public partial class MainForm : MaterialForm
    {
        string query = "";
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = MainTabControl.TabPages[0].Text;
            //this.Text = "Аптека                                  Connection_status: ";
            //this.Text += ConnectedData.connection.State;
            PrintMedications(MedicationsSortTypes.IdAsc);
        }

        public void PrintMedications(MedicationsSortTypes sort, string name = "")
        {
            MedicationsListView.Items.Clear();
            if (name != "") query = Commands.SelectMedications(sort, name);
            else query = Commands.SelectMedications(sort);
            ConnectedData.SetCommand(query);
            int[] size = new int[2];
            size = ConnectedData.GetRowAndColumnCount();
            int row = size[0];
            int column = size[1];
            ListViewItem item;
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
                    }

                    else
                        item.SubItems.Add(data[i, j]);
                }
                MedicationsListView.Items.Add(item);
            }
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
                ConnectedData.SetCommand(query);
                int count = ConnectedData.UpdateData();
                MessageBox.Show("Добавлено: " + count.ToString());
                PrintMedications(MedicationsSortTypes.IdAsc);
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
                ConnectedData.SetCommand(query);
                int count = ConnectedData.UpdateData();
                MessageBox.Show("Удалено: " + count.ToString());
                PrintMedications(MedicationsSortTypes.IdAsc);
            }
        }

        private void MedicationButtonEdit_Click(object sender, EventArgs e)
        {
            UpdateMedications updateMedications = new UpdateMedications();
            DialogResult status = updateMedications.ShowDialog();
            if (status == DialogResult.OK)
            {
                query = Commands.UpdateMedications(Models.Medications.id1, Models.Medications.Name, Models.Medications.Price, Models.Medications.Quantity,
                       Models.Medications.Volume, Models.Medications.MedicationType, Models.Medications.UsesType, Models.Medications.ManufactureType,
                       Models.Medications.MixableList, Models.Medications.PreparationTime, Models.Medications.FiltrationTime);
                MessageBox.Show(query);
                ConnectedData.SetCommand(query);
                int count = ConnectedData.UpdateData();
                MessageBox.Show("Обновлено: " + count.ToString());
                PrintMedications(MedicationsSortTypes.IdAsc);
            }
        }

        private void MedicationsComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MedicationsComboBoxSort.SelectedIndex == 0) PrintMedications(MedicationsSortTypes.IdAsc);
            else if (MedicationsComboBoxSort.SelectedIndex == 1) PrintMedications(MedicationsSortTypes.IdDesc);
            else if (MedicationsComboBoxSort.SelectedIndex == 2) PrintMedications(MedicationsSortTypes.NameAsc);
            else if (MedicationsComboBoxSort.SelectedIndex == 3) PrintMedications(MedicationsSortTypes.NameDesc);
        }

        private void MedicationsTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (MedicationsTextBoxSearch.Text != "")
            {
                PrintMedications(MedicationsSortTypes.IdAsc, MedicationsTextBoxSearch.Text);
            }
            else
            {
                PrintMedications(MedicationsSortTypes.IdAsc);
            }
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = MainTabControl.SelectedIndex;
            this.Text = MainTabControl.TabPages[index].Text;
        }
    }
}
