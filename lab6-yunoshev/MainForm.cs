using MaterialSkin.Controls;
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

namespace lab6_yunoshev
{
    public partial class MainForm : MaterialForm
    {

        ConnectedData connection = new ConnectedData(@"Data Source = (LocalDB)\MSSQLLocalDB;Initial Catalog = yunoshevdb; Integrated Security = True;");


        string query = @"select med.id, med.medications_name, med.price,
        med.quantity, med.volume,
        medt.type_name,
        uset.type_name,
        mant.type_name,
        med.mixable_list, med.prepatation_time, med.filtration_time
        from dbo.medications med, dbo.medications_types medt, dbo.manufacture_types mant, dbo.uses_types uset
        where med.medications_types_id = medt.id and
        med.uses_types_id = uset.id and
        med.manufacture_types_id = mant.id";

        //string query = "select med.id, med.medications_name, med.price, medt.type_name, uset.type_name, mant.type_name, med.mixable_list, med.prepatation_time, med.filtration_time from dbo.medications med, dbo.medications_types medt, dbo.manufacture_types mant, dbo.uses_types uset where med.medications_types_id = medt.id and med.uses_types_id = uset.id and med.manufacture_types_id = mant.id";

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public MainForm()
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            connection.SetCommand(query);
            int[] size = new int[2];
            size = connection.GetRowAndColumnCount();
            int row = size[0];
            int column = size[1];
            ListViewItem item;
            string[,] data = new string[row, column];
            data = connection.GetTableData();

            for (int i = 0; i < row; i++)
            {
                item = new ListViewItem(data[i, 0]);
                for (int j = 1; j < column; j++)
                {
                    if (j == 2)
                    {
                        double value = Convert.ToDouble(data[i, j]);
                        item.SubItems.Add(Math.Round(value, 2).ToString() + " грн");
                    }
                        
                    else
                        item.SubItems.Add(data[i, j]);
                }
                ListViewMedications.Items.Add(item);

            }
        }

        private void ButtonAddMedication_Click(object sender, EventArgs e)
        {
            AddMedications addMedications = new AddMedications();
            addMedications.ShowDialog();
        }
    }
}
