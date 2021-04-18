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
            MessageBox.Show(MainForm.connection.DBName.ToString());
            MainForm.connection.SetCommand(query);
            MessageBox.Show(query);
            int count;
            //bool status = MainForm.connection.CheckExist(out count);
            count = MainForm.connection.UpdateData();
            MessageBox.Show(count.ToString());
            //if (status == true)
            //{
            //    Models.Medications.id1 = id;
            //}
            //else
            //{
            //    MessageBox.Show("Лекарства с таким id не существует!");
            //}
            
        }
    }
}
