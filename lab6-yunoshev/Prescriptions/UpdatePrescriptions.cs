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
    public partial class UpdatePrescriptions : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private string[] dataPrescription = new string[5];
        private string[] dataPatient = new string[5];
        private string[,] dataDiagnoses;
        private string[,] dataMedications;

        private static List<int> diagnosesId = new List<int>();
        private static Dictionary<int, int> medicationsId = new Dictionary<int, int>();

        private int pId;

        public UpdatePrescriptions()
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
            TextBoxStatusPId.ForeColor = Color.Red;
        }

        private void InitializeDGVs(int id)
        {
            string query = Commands.SelectPrescriptionsDiagnosesWhereId(id);
            ConnectedData.SetCommand(query);
            int[] size = new int[2];
            size = ConnectedData.GetRowAndColumnCount();
            int row = size[0];
            int column = size[1];

            dataDiagnoses = new string[row, column];
            dataDiagnoses = ConnectedData.GetTableData();

            DGVDiagnoses.RowCount = row + 1;

            for (int i = 0; i < row; i++)
            {
                diagnosesId.Add(Convert.ToInt32(dataDiagnoses[i, 1]));
                DGVDiagnoses[0, i].Value = Convert.ToInt32(dataDiagnoses[i, 1]);
            }



            query = Commands.SelectPrescriptionsMedicationsWhereId(id);
            ConnectedData.SetCommand(query);
            size = new int[2];
            size = ConnectedData.GetRowAndColumnCount();
            row = size[0];
            column = size[1];

            dataMedications = new string[row, column];
            dataMedications = ConnectedData.GetTableData();

            DGVMedications.RowCount = row + 1;

            for (int i = 0; i < row; i++)
            {
                medicationsId.Add(Convert.ToInt32(dataMedications[i, 1]), Convert.ToInt32(dataMedications[i, 2]));
                DGVMedications[0, i].Value = Convert.ToInt32(dataMedications[i, 1]);
                DGVMedications[1, i].Value = Convert.ToInt32(dataMedications[i, 2]);
            }

        }

        private void ButtonAcceptId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(NumericId.Value);
            string query = Commands.SelectPrescriptionsWhereId(id);

            ConnectedData.SetCommand(query);
            bool status = ConnectedData.CheckExist();
            if (status == true)
            {
                TextBoxStatusId.Text = "Выбрано";
                TextBoxStatusId.ForeColor = Color.Green;
                TextBoxStatusPId.Text = "Выбрано";
                TextBoxStatusPId.ForeColor = Color.Green;
                ButtonUpdate.Enabled = true;
                LabelPId.Enabled = true;
                LabelStatusPId.Enabled = true;
                NumericPId.Enabled = true;
                ButtonAcceptPId.Enabled = true;
                TextBoxStatusPId.Enabled = true;
                TextBoxDName.Enabled = true;
                TextBoxPName.Enabled = true;
                CheckBoxDSignature.Enabled = true;
                CheckBoxDStamp.Enabled = true;
                DGVDiagnoses.Enabled = true;
                DGVMedications.Enabled = true;


                ConnectedData.SetCommand(query);
                dataPrescription = ConnectedData.GetRowFromTable();

                TextBoxDName.Text = dataPrescription[1];
                CheckBoxDSignature.Checked = Convert.ToBoolean(dataPrescription[2]);
                CheckBoxDStamp.Checked = Convert.ToBoolean(dataPrescription[3]);
                pId = Convert.ToInt32(dataPrescription[4]);
                NumericPId.Value = pId;
                string query2 = Commands.SelectPatientWhereId(pId);
                ConnectedData.SetCommand(query2);
                dataPatient = ConnectedData.GetRowFromTable();
                TextBoxPName.Text = dataPatient[1];

                InitializeDGVs(id);
                this.Refresh();

            }
            else
            {
                TextBoxStatusId.Text = "Не выбрано";
                TextBoxStatusId.ForeColor = Color.Red;
                ButtonUpdate.Enabled = false;
                LabelPId.Enabled = false;
                LabelStatusPId.Enabled = false;
                NumericPId.Enabled = false;
                ButtonAcceptPId.Enabled = false;
                TextBoxStatusPId.Enabled = false;
                TextBoxDName.Enabled = false;
                TextBoxPName.Enabled = false;
                CheckBoxDSignature.Enabled = false;
                CheckBoxDStamp.Enabled = false;
                DGVDiagnoses.Enabled = false;
                DGVMedications.Enabled = false;

                this.Refresh();
                MessageBox.Show("Записи с таким id не существует!");
            }
        }

        private void ButtonAcceptPId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(NumericPId.Value);
            string query = Commands.SelectPatientWhereId(id);
            string[] data = new string[5];
            ConnectedData.SetCommand(query);
            bool status = ConnectedData.CheckExist();
            if (status == true)
            {
                TextBoxStatusPId.Text = "Выбрано";
                TextBoxStatusPId.ForeColor = Color.Green;
                data = ConnectedData.GetRowFromTable();
                TextBoxPName.Text = data[1];
            }
            else
            {
                TextBoxStatusPId.Text = "Не выбрано";
                TextBoxStatusPId.ForeColor = Color.Red;
                TextBoxPName.ResetText();
                MessageBox.Show("Пациента с таким id не существует!");
            }
        }
    }
}
