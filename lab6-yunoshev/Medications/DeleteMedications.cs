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
    public partial class DeleteMedications : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public DeleteMedications()
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

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            CheckBoxSpecificId.Checked = true;
            NumericSpecificId.Value = 1;
            CheckBoxRangeId.Checked = false;
            CheckBoxName.Checked = false;
        }

        private void CheckBoxSpecificId_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxSpecificId.Checked == true)
            {
                NumericSpecificId.Enabled = true;
                CheckBoxRangeId.Enabled = false;
                CheckBoxName.Enabled = false;
            }
            else
            {
                NumericSpecificId.Value = 1;
                NumericSpecificId.Enabled = false;
                CheckBoxRangeId.Enabled = true;
                CheckBoxName.Enabled = true;
            }
        }

        private void CheckBoxRangeId_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxRangeId.Checked == true) 
            {
                NumericFrom.Enabled = true;
                NumericTo.Enabled = true;
                CheckBoxSpecificId.Enabled = false;
            } 
            else
            {
                NumericFrom.Value = 1;
                NumericTo.Value = 1000;
                NumericFrom.Enabled = false;
                NumericTo.Enabled = false;
                if (CheckBoxName.Checked == false)
                    CheckBoxSpecificId.Enabled = true;
            }
        }

        private void CheckBoxName_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxName.Checked == true)
            {
                TextBoxName.Enabled = true;
                CheckBoxSpecificId.Enabled = false;
            }
            else
            {
                TextBoxName.Text = "";
                TextBoxName.Enabled = false;
                if (CheckBoxRangeId.Checked == false)
                    CheckBoxSpecificId.Enabled = true;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if ((CheckBoxSpecificId.Checked == false && CheckBoxRangeId.Checked == false && CheckBoxName.Checked == false) 
                || (CheckBoxName.Checked == true && TextBoxName.Text == ""))
            {
                MessageBox.Show("Проверьте корректность введенных данных!");
            }
            else
            {
                Models.Medications.Name = TextBoxName.Text;
                if (CheckBoxSpecificId.Checked == true)
                {
                    Models.Medications.id1 = Convert.ToInt32(NumericSpecificId.Value);
                    Models.Medications.id2 = -1;
                }
                else if (CheckBoxRangeId.Checked == true)
                {
                    Models.Medications.id1 = Convert.ToInt32(NumericFrom.Value);
                    Models.Medications.id1 = Convert.ToInt32(NumericTo.Value);
                }
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
