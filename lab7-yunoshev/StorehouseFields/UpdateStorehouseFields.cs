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

namespace lab6_yunoshev.StorehouseFields
{
    public partial class UpdateStorehouseFields : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private string[] data = new string[7];
        private string[] data2 = new string[4];
        public UpdateStorehouseFields()
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
            TextBoxStatusRId.ForeColor = Color.Red;
        }

        private void ButtonAcceptId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(NumericId.Value);
            string query = Commands.SelectStorehouseFWhereId(id);
            
            ConnectedData.SetCommand(query);
            bool status = ConnectedData.CheckExist();
            if (status == true)
            {
                TextBoxStatusId.Text = "Выбрано";
                TextBoxStatusId.ForeColor = Color.Green;
                ButtonUpdate.Enabled = true;
                TextBoxQuantity.Enabled = true;
                TextBoxCriticalQuantity.Enabled = true;
                TextBoxManufactureDate.Enabled = true;
                TextBoxShelfLife.Enabled = true;
                CheckBoxRId.Enabled = true;
               
                ConnectedData.SetCommand(query);
                data = ConnectedData.GetRowFromTable();

                TextBoxQuantity.Text = data[4];
                TextBoxCriticalQuantity.Text = data[2];

                DateTime manufactureDate = Convert.ToDateTime(data[5]);
                DateTime shelfLife = Convert.ToDateTime(data[6]);
                TextBoxManufactureDate.Text = manufactureDate.ToShortDateString();
                TextBoxShelfLife.Text = shelfLife.ToShortDateString();

                if (data[3] != "-")
                {
                    NumericRId.Value = Convert.ToInt32(data[3]);
                    CheckBoxRId.Checked = true;
                    NumericRId.Enabled = true;
                    ButtonAcceptRId.Enabled = true;
                    TextBoxStatusRId.ForeColor = Color.Green;
                    TextBoxStatusRId.Text = "Выбрано";
                }
                else
                {
                    CheckBoxRId.Checked = false;
                    TextBoxStatusRId.ForeColor = Color.Red;
                    TextBoxStatusRId.Text = "Не выбрано";
                }

                this.Refresh();

            }
            else
            {
                TextBoxStatusId.Text = "Не выбрано";
                TextBoxStatusId.ForeColor = Color.Red;
                ButtonUpdate.Enabled = false;
                TextBoxQuantity.Enabled = false;
                TextBoxCriticalQuantity.Enabled = false;
                TextBoxManufactureDate.Enabled = false;
                TextBoxShelfLife.Enabled = false;
                CheckBoxRId.Checked = false;
                CheckBoxRId.Enabled = false;
                TextBoxStatusRId.ForeColor = Color.Red;
                TextBoxStatusRId.Text = "Не выбрано";

                this.Refresh();
                MessageBox.Show("Записи с таким id не существует!");
            }
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

        private void ButtonAcceptRId_Click(object sender, EventArgs e)
        {
            int RId = Convert.ToInt32(NumericRId.Value);
            string query = Commands.SelectStorehouseRWhereId(RId);
      
            ConnectedData.SetCommand(query);
            bool status = ConnectedData.CheckExist();
            if (status == true)
            {
                data2 = ConnectedData.GetRowFromTable();
                if (Convert.ToInt32(data2[2]) == Convert.ToInt32(data[1]))
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

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (TextBoxQuantity.Text.Length == 0 || TextBoxCriticalQuantity.Text.Length == 0 ||
                TextBoxManufactureDate.Text.Length == 0 || TextBoxShelfLife.Text.Length == 0 ||
                (CheckBoxRId.Checked == true && TextBoxStatusRId.Text == "Не выбрано"))
            {
                MessageBox.Show("Проверьте корректность введенных данных!");
            }

            else
            {
                Models.StorehouseField.id1 = Convert.ToInt32(NumericId.Value);
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
