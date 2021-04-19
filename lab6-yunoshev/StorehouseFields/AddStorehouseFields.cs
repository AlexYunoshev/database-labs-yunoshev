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

namespace lab6_yunoshev.StorehouseFields
{
    public partial class AddStorehouseFields : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        private string[] data = new string[4];


        public AddStorehouseFields()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE);
            TextBoxStatusMId.ForeColor = Color.Red;
            TextBoxStatusRId.ForeColor = Color.Red;
        }

      
       

        private void CheckBoxRId_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxRId.Checked == true)
            {
                NumericRId.Enabled = true;
                ButtonAcceptRId.Enabled = true;
            }
            else
            {
                NumericRId.Value = 1;
                NumericRId.Enabled = false;
                ButtonAcceptRId.Enabled = false;
                TextBoxStatusRId.ForeColor = Color.Red;
                TextBoxStatusRId.Text = "Не выбрано";
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            TextBoxStatusMId.ForeColor = Color.Red;
            TextBoxStatusMId.Text = "Не выбрано";
            NumericMId.Value = 1;
            CheckBoxRId.Checked = false;
            TextBoxQuantity.ResetText();
            TextBoxCriticalQuantity.ResetText();
            TextBoxManufactureDate.ResetText();
            TextBoxShelfLife.ResetText();
            this.Refresh();
        }

        private void ButtonAcceptMId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(NumericMId.Value);
            string query = Commands.SelectMedicationsWhereId(id);

            ConnectedData.SetCommand(query);
            bool status = ConnectedData.CheckExist();
            if (status == true)
            {
                TextBoxStatusMId.Text = "Выбрано";
                TextBoxStatusMId.ForeColor = Color.Green;
            }
            else
            {
                TextBoxStatusMId.Text = "Не выбрано";
                TextBoxStatusMId.ForeColor = Color.Red;
                MessageBox.Show("Лекарства с таким id не существует!");
            }
        }

        private void ButtonAcceptRId_Click(object sender, EventArgs e)
        {
            int RId = Convert.ToInt32(NumericRId.Value);
            string query = Commands.SelectStorehouseRWhereId(RId);

            ConnectedData.SetCommand(query);
            bool status = ConnectedData.CheckExist();
            if (status == true)
            {

                data = ConnectedData.GetRowFromTable();
                if (Convert.ToInt32(data[2]) == Convert.ToInt32(NumericMId.Value))
                {
                    TextBoxStatusRId.ForeColor = Color.Green;
                    TextBoxStatusRId.Text = "Выбрано";
                }
                else
                {
                    TextBoxStatusRId.ForeColor = Color.Red;
                    TextBoxStatusRId.Text = "Не выбрано";
                    MessageBox.Show("Записи с таким id для такого лекарства не существует!");
                }

            }
            else
            {
                TextBoxStatusRId.ForeColor = Color.Red;
                TextBoxStatusRId.Text = "Не выбрано";
                MessageBox.Show("Записи с таким id не существует!");
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (TextBoxQuantity.Text.Length == 0 || TextBoxCriticalQuantity.Text.Length == 0 ||
                TextBoxManufactureDate.Text.Length == 0 || TextBoxShelfLife.Text.Length == 0 ||
                (CheckBoxRId.Checked == true && TextBoxStatusRId.Text == "Не выбрано") || 
                TextBoxStatusMId.Text == "Не выбрано")
            {
                MessageBox.Show("Проверьте корректность введенных данных!");
            }

            else
            {
                Models.StorehouseField.Medications_id = Convert.ToInt32(NumericMId.Value);
                Models.StorehouseField.Quantity = Convert.ToInt32(TextBoxQuantity.Text);
                Models.StorehouseField.Critical_quantity = Convert.ToInt32(TextBoxCriticalQuantity.Text);
                Models.StorehouseField.ManufactureDate = TextBoxManufactureDate.Text;
                Models.StorehouseField.ShelfLife = TextBoxShelfLife.Text;
                if (CheckBoxRId.Checked == true)
                {
                    Models.StorehouseField.StorehouseRequestsId = NumericRId.Value.ToString();
                }
                else Models.StorehouseField.StorehouseRequestsId = "NULL";

                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
