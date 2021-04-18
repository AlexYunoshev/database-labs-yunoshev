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
using MaterialSkin.Controls;
using Models;
using lab6_yunoshev;

namespace lab6_yunoshev.Medications
{
    public partial class UpdateMedications : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public UpdateMedications()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE);
            TextBoxStatusId.ForeColor = Color.Red;
        }

        private void ButtonAcceptId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(NumericId.Value);
            string query = Commands.SelectMedicationsWhereId(id);
            string[] data = new string[11];
            ConnectedData.SetCommand(query);
            bool status = ConnectedData.CheckExist();
            if (status == true)
            {
                Models.Medications.id1 = id;
                TextBoxStatusId.Text = "Выбрано";
                TextBoxStatusId.ForeColor = Color.Green;
                ButtonUpdate.Enabled = true;
                TextBoxName.Enabled = true;
                TextBoxPrice.Enabled = true;
                TextBoxQuantity.Enabled = true;
                TextBoxVolume.Enabled = true;
                ComboBoxMedType.Enabled = true;
                ComboBoxUsesType.Enabled = true;
                ComboBoxManufType.Enabled = true;
                CheckBoxPrepTime.Enabled = true;
                CheckBoxFilterTime.Enabled = true;
                ConnectedData.SetCommand(query);
                data = ConnectedData.GetRowFromTable();
                TextBoxName.Text = data[1];
                TextBoxPrice.Text = data[2];
                TextBoxQuantity.Text = data[3];
                TextBoxVolume.Text = data[4];

                if (data[5] == "1") ComboBoxUsesType.SelectedIndex = 0;
                else if(data[5] == "2") ComboBoxUsesType.SelectedIndex = 1;

                if (data[6] == "1") ComboBoxManufType.SelectedIndex = 0;
                else if (data[6] == "2") ComboBoxManufType.SelectedIndex = 1;
                else if (data[6] == "4") ComboBoxManufType.SelectedIndex = 2;

                if (data[7] == "1") ComboBoxMedType.SelectedIndex = 0;
                else if (data[7] == "2") ComboBoxMedType.SelectedIndex = 1;
                else if (data[7] == "3") ComboBoxMedType.SelectedIndex = 2;
                else if (data[7] == "4") ComboBoxMedType.SelectedIndex = 3;
                else if (data[7] == "5") ComboBoxMedType.SelectedIndex = 4;
                else if (data[7] == "1002") ComboBoxMedType.SelectedIndex = 5;
                else if (data[7] == "1003") ComboBoxMedType.SelectedIndex = 6;

                TextBoxMixableList.Text = data[8];
                TextBoxPrepTime.Text = data[9];
                TextBoxFiltrationTime.Text = data[10];

                if (ComboBoxManufType.SelectedIndex == 2) TextBoxMixableList.Enabled = true;
                else
                {
                    TextBoxMixableList.ResetText();
                    TextBoxMixableList.Enabled = false;
                }

                if (TextBoxPrepTime.Text == "-")
                {
                    CheckBoxPrepTime.Checked = false;
                    TextBoxPrepTime.ResetText();
                    TextBoxPrepTime.Enabled = false;
                }
                else 
                { 
                    CheckBoxPrepTime.Checked = true;
                    TextBoxPrepTime.Enabled = true;
                }

                if (TextBoxFiltrationTime.Text == "-") 
                {
                    CheckBoxFilterTime.Checked = false;
                    TextBoxFiltrationTime.ResetText();
                    TextBoxFiltrationTime.Enabled = false;
                } 
                else 
                {
                    CheckBoxFilterTime.Checked = true;
                    TextBoxFiltrationTime.Enabled = true;
                }

                this.Refresh();

            }
            else
            {
                TextBoxStatusId.Text = "Не выбрано";
                TextBoxStatusId.ForeColor = Color.Red;
                TextBoxName.ResetText();
                TextBoxPrice.ResetText();
                TextBoxQuantity.ResetText();
                TextBoxVolume.ResetText();
                ComboBoxMedType.SelectedIndex = -1;
                ComboBoxUsesType.SelectedIndex = -1;
                ComboBoxManufType.SelectedIndex = -1;
                CheckBoxFilterTime.Checked = false;
                CheckBoxPrepTime.Checked = false;
                TextBoxPrepTime.ResetText();
                TextBoxFiltrationTime.ResetText();
                TextBoxMixableList.ResetText();
                ButtonUpdate.Enabled = false;
                TextBoxName.Enabled = false;
                TextBoxPrice.Enabled = false;
                TextBoxQuantity.Enabled = false;
                TextBoxVolume.Enabled = false;
                ComboBoxMedType.Enabled = false;
                ComboBoxUsesType.Enabled = false;
                ComboBoxManufType.Enabled = false;
                CheckBoxPrepTime.Enabled = false;
                CheckBoxFilterTime.Enabled = false;
                TextBoxPrepTime.Enabled = false;
                TextBoxFiltrationTime.Enabled = false;
                TextBoxMixableList.Enabled = false;
                this.Refresh();
                MessageBox.Show("Лекарства с таким id не существует!");
            }

        }

        private void ComboBoxManufType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxManufType.SelectedIndex == 2) TextBoxMixableList.Enabled = true;
            else 
            {
                TextBoxMixableList.ResetText();
                TextBoxMixableList.Enabled = false;
            } 
        }

        private void CheckBoxPrepTime_CheckedChanged(object sender, EventArgs e) 
        {
            if (CheckBoxPrepTime.Checked == true) TextBoxPrepTime.Enabled = true;
            else
            {
                TextBoxPrepTime.ResetText();
                TextBoxPrepTime.Enabled = false;
            }
        }

        private void CheckBoxFilterTime_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxFilterTime.Checked == true) TextBoxFiltrationTime.Enabled = true;
            else
            {
                TextBoxFiltrationTime.ResetText();
                TextBoxFiltrationTime.Enabled = false;
            }
        }
    }
}
