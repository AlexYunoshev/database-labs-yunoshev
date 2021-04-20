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
            TextBoxStatusPId.Text = "Не выбрано";
            TextBoxStatusPId.ForeColor = Color.Red;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            TextBoxStatusPId.Text = "Не выбрано";
            TextBoxStatusPId.ForeColor = Color.Red;
            TextBoxPName.ResetText();
            TextBoxDName.ResetText();
            CheckBoxDSignature.Checked = false;
            CheckBoxDStamp.Checked = false;
            DGVDiagnoses.Rows.Clear();
            DGVMedications.Rows.Clear();
            NumericPId.Value = 0;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (TextBoxDName.Text.Length == 0 || TextBoxStatusPId.Text == "Не выбрано")
            {
                MessageBox.Show("Проверьте корректность введенных данных!");
            }

            else
            {
                int dRow = DGVDiagnoses.RowCount;
                int mRow = DGVMedications.RowCount;

                for (int i = 0; i < dRow; i++)
                {
                    if (DGVDiagnoses[0, i].Value != null)
                    {
                        try { Models.Prescriptions.diagnosesId.Add(Convert.ToInt32(DGVDiagnoses[0, i].Value)); }
                        catch { }
                    }
                }

                for (int i = 0; i < mRow; i++)
                {
                    if (DGVMedications[0, i].Value != null && DGVMedications[1, i].Value != null)
                    {
                        try { Models.Prescriptions.medicationsId.Add(Convert.ToInt32(DGVMedications[0, i].Value), Convert.ToInt32(DGVMedications[1, i].Value)); }
                        catch {}
                    }
                }

                Models.Prescriptions.doctorName = TextBoxDName.Text;
                Models.Prescriptions.doctorSignature = CheckBoxDSignature.Checked;
                Models.Prescriptions.doctorStamp = CheckBoxDStamp.Checked;
                Models.Prescriptions.patientId = Convert.ToInt32(NumericPId.Value);
                this.Close();
                this.DialogResult = DialogResult.OK;
            }   
        }

        private void DGVDiagnoses_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int value;
            try
            {
                value = Convert.ToInt32(DGVDiagnoses[0, row].Value);
            }
            catch
            {
                MessageBox.Show("Вы пытаетесь ввести данные в неправильном формате!!!");
                DGVDiagnoses[0, row].Value = null;
            }
        }

        private void DGVMedications_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            int value;
            try
            {
                value = Convert.ToInt32(DGVMedications[column, row].Value);
            }
            catch
            {
                MessageBox.Show("Вы пытаетесь ввести данные в неправильном формате!!!");
                DGVMedications[column, row].Value = null;
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
