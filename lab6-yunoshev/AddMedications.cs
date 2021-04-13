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

namespace lab6_yunoshev
{
    public partial class AddMedications : MaterialForm
    {


        private string name;
        private string quantity;
        private string volume;
        private string preparationTime;
        private string filterTime;
        private string listComponents;
        private double price;
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
            else TextBoxPrepTime.Enabled = false;
        }

        private void CheckBoxFilterTime_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxFilterTime.Checked == true) TextBoxFilterTime.Enabled = true;
            else TextBoxFilterTime.Enabled = false;
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
            TextBoxFilterTime.ResetText();
            TextBoxComponents.ResetText();
            this.Refresh();
      

        }
    }
}
