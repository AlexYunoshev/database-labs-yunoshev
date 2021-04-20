
namespace lab6_yunoshev.Prescriptions
{
    partial class AddPrescriptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelMId = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxStatusPId = new System.Windows.Forms.TextBox();
            this.LabelStatusPId = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonAcceptPId = new MaterialSkin.Controls.MaterialButton();
            this.NumericPId = new System.Windows.Forms.NumericUpDown();
            this.ButtonReset = new MaterialSkin.Controls.MaterialButton();
            this.ButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.CheckBoxDSignature = new MaterialSkin.Controls.MaterialCheckbox();
            this.TextBoxDName = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxPName = new MaterialSkin.Controls.MaterialTextBox();
            this.CheckBoxDStamp = new MaterialSkin.Controls.MaterialCheckbox();
            this.DGVDiagnoses = new System.Windows.Forms.DataGridView();
            this.ColumnDiagnosisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiagnosisName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVMedications = new System.Windows.Forms.DataGridView();
            this.ColumnMedicationsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMedicationsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMedicationsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiagnoses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedications)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelMId
            // 
            this.LabelMId.Depth = 0;
            this.LabelMId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelMId.Location = new System.Drawing.Point(10, 71);
            this.LabelMId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelMId.Name = "LabelMId";
            this.LabelMId.Size = new System.Drawing.Size(177, 20);
            this.LabelMId.TabIndex = 85;
            this.LabelMId.Text = "id пациента";
            this.LabelMId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxStatusPId
            // 
            this.TextBoxStatusPId.ForeColor = System.Drawing.Color.Red;
            this.TextBoxStatusPId.Location = new System.Drawing.Point(205, 95);
            this.TextBoxStatusPId.Name = "TextBoxStatusPId";
            this.TextBoxStatusPId.ReadOnly = true;
            this.TextBoxStatusPId.Size = new System.Drawing.Size(132, 23);
            this.TextBoxStatusPId.TabIndex = 84;
            this.TextBoxStatusPId.Text = "Не выбрано";
            this.TextBoxStatusPId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelStatusPId
            // 
            this.LabelStatusPId.Depth = 0;
            this.LabelStatusPId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelStatusPId.Location = new System.Drawing.Point(205, 71);
            this.LabelStatusPId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelStatusPId.Name = "LabelStatusPId";
            this.LabelStatusPId.Size = new System.Drawing.Size(132, 20);
            this.LabelStatusPId.TabIndex = 83;
            this.LabelStatusPId.Text = "Статус ID";
            this.LabelStatusPId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAcceptPId
            // 
            this.ButtonAcceptPId.AutoSize = false;
            this.ButtonAcceptPId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAcceptPId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAcceptPId.Depth = 0;
            this.ButtonAcceptPId.DrawShadows = true;
            this.ButtonAcceptPId.HighEmphasis = true;
            this.ButtonAcceptPId.Icon = null;
            this.ButtonAcceptPId.Location = new System.Drawing.Point(78, 94);
            this.ButtonAcceptPId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAcceptPId.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAcceptPId.Name = "ButtonAcceptPId";
            this.ButtonAcceptPId.Size = new System.Drawing.Size(109, 23);
            this.ButtonAcceptPId.TabIndex = 82;
            this.ButtonAcceptPId.Text = "ОК";
            this.ButtonAcceptPId.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAcceptPId.UseAccentColor = false;
            this.ButtonAcceptPId.UseVisualStyleBackColor = true;
            this.ButtonAcceptPId.Click += new System.EventHandler(this.ButtonAcceptPId_Click);
            // 
            // NumericPId
            // 
            this.NumericPId.Location = new System.Drawing.Point(10, 94);
            this.NumericPId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumericPId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericPId.Name = "NumericPId";
            this.NumericPId.Size = new System.Drawing.Size(61, 23);
            this.NumericPId.TabIndex = 81;
            this.NumericPId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ButtonReset
            // 
            this.ButtonReset.AutoSize = false;
            this.ButtonReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReset.Depth = 0;
            this.ButtonReset.DrawShadows = true;
            this.ButtonReset.HighEmphasis = true;
            this.ButtonReset.Icon = null;
            this.ButtonReset.Location = new System.Drawing.Point(167, 541);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(170, 36);
            this.ButtonReset.TabIndex = 80;
            this.ButtonReset.Text = "Сбросить всё";
            this.ButtonReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonReset.UseAccentColor = false;
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.AutoSize = false;
            this.ButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd.Depth = 0;
            this.ButtonAdd.DrawShadows = true;
            this.ButtonAdd.HighEmphasis = true;
            this.ButtonAdd.Icon = null;
            this.ButtonAdd.Location = new System.Drawing.Point(10, 541);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(149, 36);
            this.ButtonAdd.TabIndex = 79;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAdd.UseAccentColor = false;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // CheckBoxDSignature
            // 
            this.CheckBoxDSignature.AutoSize = true;
            this.CheckBoxDSignature.Depth = 0;
            this.CheckBoxDSignature.Location = new System.Drawing.Point(5, 235);
            this.CheckBoxDSignature.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxDSignature.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxDSignature.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxDSignature.Name = "CheckBoxDSignature";
            this.CheckBoxDSignature.Ripple = true;
            this.CheckBoxDSignature.Size = new System.Drawing.Size(167, 37);
            this.CheckBoxDSignature.TabIndex = 74;
            this.CheckBoxDSignature.Text = "Подпись доктора";
            this.CheckBoxDSignature.UseVisualStyleBackColor = true;
            // 
            // TextBoxDName
            // 
            this.TextBoxDName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxDName.Depth = 0;
            this.TextBoxDName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxDName.Hint = "Имя доктора";
            this.TextBoxDName.Location = new System.Drawing.Point(10, 182);
            this.TextBoxDName.MaxLength = 10;
            this.TextBoxDName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxDName.Multiline = false;
            this.TextBoxDName.Name = "TextBoxDName";
            this.TextBoxDName.Size = new System.Drawing.Size(327, 50);
            this.TextBoxDName.TabIndex = 71;
            this.TextBoxDName.Text = "";
            // 
            // TextBoxPName
            // 
            this.TextBoxPName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPName.Depth = 0;
            this.TextBoxPName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPName.Hint = "Имя пациента";
            this.TextBoxPName.Location = new System.Drawing.Point(10, 126);
            this.TextBoxPName.MaxLength = 10;
            this.TextBoxPName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxPName.Multiline = false;
            this.TextBoxPName.Name = "TextBoxPName";
            this.TextBoxPName.ReadOnly = true;
            this.TextBoxPName.Size = new System.Drawing.Size(327, 50);
            this.TextBoxPName.TabIndex = 70;
            this.TextBoxPName.Text = "";
            // 
            // CheckBoxDStamp
            // 
            this.CheckBoxDStamp.AutoSize = true;
            this.CheckBoxDStamp.Depth = 0;
            this.CheckBoxDStamp.Location = new System.Drawing.Point(181, 235);
            this.CheckBoxDStamp.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxDStamp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxDStamp.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxDStamp.Name = "CheckBoxDStamp";
            this.CheckBoxDStamp.Ripple = true;
            this.CheckBoxDStamp.Size = new System.Drawing.Size(156, 37);
            this.CheckBoxDStamp.TabIndex = 86;
            this.CheckBoxDStamp.Text = "Печать доктора";
            this.CheckBoxDStamp.UseVisualStyleBackColor = true;
            // 
            // DGVDiagnoses
            // 
            this.DGVDiagnoses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDiagnoses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDiagnosisId,
            this.ColumnDiagnosisName});
            this.DGVDiagnoses.Location = new System.Drawing.Point(10, 275);
            this.DGVDiagnoses.Name = "DGVDiagnoses";
            this.DGVDiagnoses.RowTemplate.Height = 25;
            this.DGVDiagnoses.Size = new System.Drawing.Size(327, 120);
            this.DGVDiagnoses.TabIndex = 87;
            this.DGVDiagnoses.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDiagnoses_CellEndEdit);
            // 
            // ColumnDiagnosisId
            // 
            this.ColumnDiagnosisId.HeaderText = "id диагноза";
            this.ColumnDiagnosisId.Name = "ColumnDiagnosisId";
            // 
            // ColumnDiagnosisName
            // 
            this.ColumnDiagnosisName.HeaderText = "Диагноз";
            this.ColumnDiagnosisName.Name = "ColumnDiagnosisName";
            this.ColumnDiagnosisName.ReadOnly = true;
            this.ColumnDiagnosisName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDiagnosisName.Width = 184;
            // 
            // DGVMedications
            // 
            this.DGVMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMedications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMedicationsId,
            this.ColumnMedicationsName,
            this.ColumnMedicationsCount});
            this.DGVMedications.Location = new System.Drawing.Point(10, 412);
            this.DGVMedications.Name = "DGVMedications";
            this.DGVMedications.RowTemplate.Height = 25;
            this.DGVMedications.Size = new System.Drawing.Size(327, 120);
            this.DGVMedications.TabIndex = 88;
            this.DGVMedications.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMedications_CellEndEdit);
            // 
            // ColumnMedicationsId
            // 
            this.ColumnMedicationsId.HeaderText = "id лекарства";
            this.ColumnMedicationsId.Name = "ColumnMedicationsId";
            // 
            // ColumnMedicationsName
            // 
            this.ColumnMedicationsName.HeaderText = "Лекарство";
            this.ColumnMedicationsName.Name = "ColumnMedicationsName";
            this.ColumnMedicationsName.ReadOnly = true;
            this.ColumnMedicationsName.Width = 94;
            // 
            // ColumnMedicationsCount
            // 
            this.ColumnMedicationsCount.HeaderText = "Количество";
            this.ColumnMedicationsCount.Name = "ColumnMedicationsCount";
            this.ColumnMedicationsCount.Width = 90;
            // 
            // AddPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 592);
            this.Controls.Add(this.DGVMedications);
            this.Controls.Add(this.DGVDiagnoses);
            this.Controls.Add(this.CheckBoxDStamp);
            this.Controls.Add(this.LabelMId);
            this.Controls.Add(this.TextBoxStatusPId);
            this.Controls.Add(this.LabelStatusPId);
            this.Controls.Add(this.ButtonAcceptPId);
            this.Controls.Add(this.NumericPId);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.CheckBoxDSignature);
            this.Controls.Add(this.TextBoxDName);
            this.Controls.Add(this.TextBoxPName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPrescriptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление рецепта";
            ((System.ComponentModel.ISupportInitialize)(this.NumericPId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiagnoses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LabelMId;
        private System.Windows.Forms.TextBox TextBoxStatusPId;
        private MaterialSkin.Controls.MaterialLabel LabelStatusPId;
        private MaterialSkin.Controls.MaterialButton ButtonAcceptPId;
        private System.Windows.Forms.NumericUpDown NumericPId;
        private MaterialSkin.Controls.MaterialButton ButtonReset;
        private MaterialSkin.Controls.MaterialButton ButtonAdd;
        private MaterialSkin.Controls.MaterialCheckbox CheckBoxDSignature;
        private MaterialSkin.Controls.MaterialTextBox TextBoxDName;
        private MaterialSkin.Controls.MaterialTextBox TextBoxPName;
        private MaterialSkin.Controls.MaterialCheckbox CheckBoxDStamp;
        private System.Windows.Forms.DataGridView DGVDiagnoses;
        private System.Windows.Forms.DataGridView DGVMedications;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiagnosisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiagnosisName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMedicationsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMedicationsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMedicationsCount;
    }
}