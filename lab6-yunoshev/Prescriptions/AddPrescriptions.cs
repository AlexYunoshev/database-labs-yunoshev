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


namespace lab6_yunoshev.Prescriptions
{
    public partial class AddPrescriptions : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public AddPrescriptions()
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
    }
}
