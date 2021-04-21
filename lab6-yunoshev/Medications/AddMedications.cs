using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Models;

namespace lab6_yunoshev.Medications
{
    public partial class AddMedications : MaterialForm
    {
        private int medicationType;
        private int usesType;
        private int manufactureType;

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public AddMedications()
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

        private void CheckBoxPrepTime_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxPrepTime.Checked == true) TextBoxPrepTime.Enabled = true;
            else {
                TextBoxPrepTime.Text = "";
                TextBoxPrepTime.Enabled = false;
            }
        }

        private void CheckBoxFilterTime_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxFilterTime.Checked == true) TextBoxFiltrationTime.Enabled = true;
            else {
                TextBoxFiltrationTime.Text = "";
                TextBoxFiltrationTime.Enabled = false;
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
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
            this.Refresh();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            switch (ComboBoxMedType.SelectedIndex)
            {
                case 0:
                    medicationType = 1;
                    break;
                case 1:
                    medicationType = 2;
                    break;
                case 2:
                    medicationType = 3;
                    break;
                case 3:
                    medicationType = 4;
                    break;
                case 4:
                    medicationType = 5;
                    break;
                case 5:
                    medicationType = 1002;
                    break;
                case 6:
                    medicationType = 1003;
                    break;
                default:
                    medicationType = -1;
                    break;
            }

            switch (ComboBoxUsesType.SelectedIndex)
            {
                case 0:
                    usesType = 1;
                    break;
                case 1:
                    usesType = 2;
                    break;
                default:
                    usesType = -1;
                    break;
            }

            switch (ComboBoxManufType.SelectedIndex)
            {
                case 0:
                    manufactureType = 1;
                    break;
                case 1:
                    manufactureType = 2;
                    break;
                case 2:
                    manufactureType = 4;
                    break;
                default:
                    manufactureType = -1;
                    break;
            }

            if (medicationType == -1 || usesType == -1 || manufactureType == -1 ||
                TextBoxName.Text.Length == 0 || TextBoxPrice.Text.Length == 0 ||
                TextBoxQuantity.Text.Length == 0 || TextBoxVolume.Text.Length == 0 ||
                (TextBoxMixableList.Text.Length == 0 && manufactureType == 4) || 
                (TextBoxPrepTime.Text.Length == 0 && CheckBoxPrepTime.Checked == true) || 
                (TextBoxFiltrationTime.Text.Length == 0 && CheckBoxFilterTime.Checked == true))
            {
                MessageBox.Show("Проверьте корректность введенных данных!");
            }

            else
            {
                Models.Medications.Name = TextBoxName.Text;
                Models.Medications.Price = Convert.ToDouble(TextBoxPrice.Text);
                Models.Medications.Quantity = TextBoxQuantity.Text;
                Models.Medications.Volume = TextBoxVolume.Text;
                Models.Medications.MedicationType = medicationType;
                Models.Medications.UsesType = usesType;
                Models.Medications.ManufactureType = manufactureType;
                Models.Medications.PreparationTime = TextBoxPrepTime.Text;
                Models.Medications.FiltrationTime = TextBoxFiltrationTime.Text;
                Models.Medications.MixableList = TextBoxMixableList.Text;
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ComboBoxManufType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxManufType.SelectedIndex == 2) TextBoxMixableList.Enabled = true;
            else TextBoxMixableList.Enabled = false;
        }
    }
}
