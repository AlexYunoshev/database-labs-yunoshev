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
            //MessageBox.Show(query);
            bool status = ConnectedData.CheckExist();
            //MessageBox.Show(status.ToString());
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
                TextBoxPrepTime.Enabled = true;
                TextBoxFiltrationTime.Enabled = true;
                TextBoxMixableList.Enabled = true;
                ConnectedData.SetCommand(query);
                data = ConnectedData.GetRowFromTable();
                TextBoxName.Text = data[1];
                TextBoxPrice.Text = data[2];
                TextBoxQuantity.Text = data[3];
                TextBoxVolume.Text = data[4];

                //ComboBoxMedType.Enabled = true;
                //ComboBoxUsesType.Enabled = true;
                //ComboBoxManufType.Enabled = true;

                TextBoxPrepTime.Text = data[8];
                TextBoxFiltrationTime.Text = data[9];
                TextBoxMixableList.Text = data[10];

            }
            else
            {
                TextBoxStatusId.Text = "Не выбрано";
                TextBoxStatusId.ForeColor = Color.Red;
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
                MessageBox.Show("Лекарства с таким id не существует!");
            }

        }
    }
}
