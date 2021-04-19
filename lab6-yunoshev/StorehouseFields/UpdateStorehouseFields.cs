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
            string[] data = new string[7];
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
                NumericRId.Enabled = true;
                ButtonAcceptRId.Enabled = true;

                ConnectedData.SetCommand(query);
                data = ConnectedData.GetRowFromTable();

                TextBoxQuantity.Text = data[4];
                TextBoxCriticalQuantity.Text = data[2];
                TextBoxManufactureDate.Text = data[5];
                TextBoxShelfLife.Text = data[6];
                if (data[3] != "-")
                {
                    NumericRId.Value = Convert.ToInt32(data[3]);
                    CheckBoxRId.Checked = true;
                }
                else
                {
                    CheckBoxRId.Checked = false;
                }
                    



                this.Refresh();

            }
            else
            {
                TextBoxStatusId.Text = "Не выбрано";
                TextBoxStatusId.ForeColor = Color.Red;
                //TextBoxName.ResetText();
                //TextBoxPrice.ResetText();
                //TextBoxQuantity.ResetText();
                //TextBoxVolume.ResetText();
                //ComboBoxMedType.SelectedIndex = -1;
                //ComboBoxUsesType.SelectedIndex = -1;
                //ComboBoxManufType.SelectedIndex = -1;
                //CheckBoxFilterTime.Checked = false;
                //CheckBoxPrepTime.Checked = false;
                //TextBoxPrepTime.ResetText();
                //TextBoxFiltrationTime.ResetText();
                //TextBoxMixableList.ResetText();
                //ButtonUpdate.Enabled = false;
                //TextBoxName.Enabled = false;
                //TextBoxPrice.Enabled = false;
                //TextBoxQuantity.Enabled = false;
                //TextBoxVolume.Enabled = false;
                //ComboBoxMedType.Enabled = false;
                //ComboBoxUsesType.Enabled = false;
                //ComboBoxManufType.Enabled = false;
                //CheckBoxPrepTime.Enabled = false;
                //CheckBoxFilterTime.Enabled = false;
                //TextBoxPrepTime.Enabled = false;
                //TextBoxFiltrationTime.Enabled = false;
                //TextBoxMixableList.Enabled = false;
                this.Refresh();
                MessageBox.Show("Записи с таким id не существует!");
            }
        }

        private void CheckBoxRId_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxRId.Checked == true)
            {
                NumericRId.Enabled = true;
            }
            else
            {
                NumericRId.Value = 1;
                NumericRId.Enabled = false;
            }
        }
    }
}
