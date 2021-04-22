
namespace lab6_yunoshev.Prescriptions
{
    partial class UpdatePrescriptions
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
            this.ButtonUpdate = new MaterialSkin.Controls.MaterialButton();
            this.TextBoxStatusId = new System.Windows.Forms.TextBox();
            this.LabelStatusId = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonAcceptId = new MaterialSkin.Controls.MaterialButton();
            this.LabelId = new MaterialSkin.Controls.MaterialLabel();
            this.NumericId = new System.Windows.Forms.NumericUpDown();
            this.DGVMedications = new System.Windows.Forms.DataGridView();
            this.ColumnMedicationsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMedicationsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVDiagnoses = new System.Windows.Forms.DataGridView();
            this.ColumnDiagnosisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckBoxDStamp = new MaterialSkin.Controls.MaterialCheckbox();
            this.LabelPId = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxStatusPId = new System.Windows.Forms.TextBox();
            this.LabelStatusPId = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonAcceptPId = new MaterialSkin.Controls.MaterialButton();
            this.NumericPId = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxDSignature = new MaterialSkin.Controls.MaterialCheckbox();
            this.TextBoxDName = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxPName = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiagnoses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPId)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.AutoSize = false;
            this.ButtonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdate.Depth = 0;
            this.ButtonUpdate.DrawShadows = true;
            this.ButtonUpdate.Enabled = false;
            this.ButtonUpdate.HighEmphasis = true;
            this.ButtonUpdate.Icon = null;
            this.ButtonUpdate.Location = new System.Drawing.Point(140, 73);
            this.ButtonUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(263, 96);
            this.ButtonUpdate.TabIndex = 63;
            this.ButtonUpdate.Text = "Изменить";
            this.ButtonUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonUpdate.UseAccentColor = false;
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // TextBoxStatusId
            // 
            this.TextBoxStatusId.ForeColor = System.Drawing.Color.Red;
            this.TextBoxStatusId.Location = new System.Drawing.Point(12, 146);
            this.TextBoxStatusId.Name = "TextBoxStatusId";
            this.TextBoxStatusId.ReadOnly = true;
            this.TextBoxStatusId.Size = new System.Drawing.Size(120, 23);
            this.TextBoxStatusId.TabIndex = 62;
            this.TextBoxStatusId.Text = "Не выбрано";
            this.TextBoxStatusId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelStatusId
            // 
            this.LabelStatusId.Depth = 0;
            this.LabelStatusId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelStatusId.Location = new System.Drawing.Point(12, 124);
            this.LabelStatusId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelStatusId.Name = "LabelStatusId";
            this.LabelStatusId.Size = new System.Drawing.Size(120, 20);
            this.LabelStatusId.TabIndex = 61;
            this.LabelStatusId.Text = "Статус ID";
            this.LabelStatusId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAcceptId
            // 
            this.ButtonAcceptId.AutoSize = false;
            this.ButtonAcceptId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAcceptId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAcceptId.Depth = 0;
            this.ButtonAcceptId.DrawShadows = true;
            this.ButtonAcceptId.HighEmphasis = true;
            this.ButtonAcceptId.Icon = null;
            this.ButtonAcceptId.Location = new System.Drawing.Point(80, 95);
            this.ButtonAcceptId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAcceptId.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAcceptId.Name = "ButtonAcceptId";
            this.ButtonAcceptId.Size = new System.Drawing.Size(52, 23);
            this.ButtonAcceptId.TabIndex = 60;
            this.ButtonAcceptId.Text = "ОК";
            this.ButtonAcceptId.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAcceptId.UseAccentColor = false;
            this.ButtonAcceptId.UseVisualStyleBackColor = true;
            this.ButtonAcceptId.Click += new System.EventHandler(this.ButtonAcceptId_Click);
            // 
            // LabelId
            // 
            this.LabelId.Depth = 0;
            this.LabelId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelId.Location = new System.Drawing.Point(12, 73);
            this.LabelId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(120, 20);
            this.LabelId.TabIndex = 59;
            this.LabelId.Text = "ID записи";
            this.LabelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericId
            // 
            this.NumericId.Location = new System.Drawing.Point(12, 95);
            this.NumericId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumericId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericId.Name = "NumericId";
            this.NumericId.Size = new System.Drawing.Size(61, 23);
            this.NumericId.TabIndex = 58;
            this.NumericId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DGVMedications
            // 
            this.DGVMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMedications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMedicationsId,
            this.ColumnMedicationsCount});
            this.DGVMedications.Enabled = false;
            this.DGVMedications.Location = new System.Drawing.Point(169, 387);
            this.DGVMedications.Name = "DGVMedications";
            this.DGVMedications.RowTemplate.Height = 25;
            this.DGVMedications.Size = new System.Drawing.Size(234, 120);
            this.DGVMedications.TabIndex = 101;
            this.DGVMedications.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMedications_CellEndEdit);
            // 
            // ColumnMedicationsId
            // 
            this.ColumnMedicationsId.HeaderText = "id лекарства";
            this.ColumnMedicationsId.Name = "ColumnMedicationsId";
            // 
            // ColumnMedicationsCount
            // 
            this.ColumnMedicationsCount.HeaderText = "Количество";
            this.ColumnMedicationsCount.Name = "ColumnMedicationsCount";
            this.ColumnMedicationsCount.Width = 90;
            // 
            // DGVDiagnoses
            // 
            this.DGVDiagnoses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDiagnoses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDiagnosisId});
            this.DGVDiagnoses.Enabled = false;
            this.DGVDiagnoses.Location = new System.Drawing.Point(12, 387);
            this.DGVDiagnoses.Name = "DGVDiagnoses";
            this.DGVDiagnoses.RowTemplate.Height = 25;
            this.DGVDiagnoses.Size = new System.Drawing.Size(143, 120);
            this.DGVDiagnoses.TabIndex = 100;
            this.DGVDiagnoses.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDiagnoses_CellEndEdit);
            // 
            // ColumnDiagnosisId
            // 
            this.ColumnDiagnosisId.HeaderText = "id диагноза";
            this.ColumnDiagnosisId.Name = "ColumnDiagnosisId";
            // 
            // CheckBoxDStamp
            // 
            this.CheckBoxDStamp.AutoSize = true;
            this.CheckBoxDStamp.Depth = 0;
            this.CheckBoxDStamp.Enabled = false;
            this.CheckBoxDStamp.Location = new System.Drawing.Point(183, 347);
            this.CheckBoxDStamp.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxDStamp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxDStamp.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxDStamp.Name = "CheckBoxDStamp";
            this.CheckBoxDStamp.Ripple = true;
            this.CheckBoxDStamp.Size = new System.Drawing.Size(156, 37);
            this.CheckBoxDStamp.TabIndex = 99;
            this.CheckBoxDStamp.Text = "Печать доктора";
            this.CheckBoxDStamp.UseVisualStyleBackColor = true;
            // 
            // LabelPId
            // 
            this.LabelPId.Depth = 0;
            this.LabelPId.Enabled = false;
            this.LabelPId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelPId.Location = new System.Drawing.Point(12, 183);
            this.LabelPId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelPId.Name = "LabelPId";
            this.LabelPId.Size = new System.Drawing.Size(177, 20);
            this.LabelPId.TabIndex = 98;
            this.LabelPId.Text = "id пациента";
            this.LabelPId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxStatusPId
            // 
            this.TextBoxStatusPId.Enabled = false;
            this.TextBoxStatusPId.ForeColor = System.Drawing.Color.Red;
            this.TextBoxStatusPId.Location = new System.Drawing.Point(207, 207);
            this.TextBoxStatusPId.Name = "TextBoxStatusPId";
            this.TextBoxStatusPId.ReadOnly = true;
            this.TextBoxStatusPId.Size = new System.Drawing.Size(132, 23);
            this.TextBoxStatusPId.TabIndex = 97;
            this.TextBoxStatusPId.Text = "Не выбрано";
            this.TextBoxStatusPId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelStatusPId
            // 
            this.LabelStatusPId.Depth = 0;
            this.LabelStatusPId.Enabled = false;
            this.LabelStatusPId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelStatusPId.Location = new System.Drawing.Point(207, 183);
            this.LabelStatusPId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelStatusPId.Name = "LabelStatusPId";
            this.LabelStatusPId.Size = new System.Drawing.Size(132, 20);
            this.LabelStatusPId.TabIndex = 96;
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
            this.ButtonAcceptPId.Enabled = false;
            this.ButtonAcceptPId.HighEmphasis = true;
            this.ButtonAcceptPId.Icon = null;
            this.ButtonAcceptPId.Location = new System.Drawing.Point(80, 206);
            this.ButtonAcceptPId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAcceptPId.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAcceptPId.Name = "ButtonAcceptPId";
            this.ButtonAcceptPId.Size = new System.Drawing.Size(109, 23);
            this.ButtonAcceptPId.TabIndex = 95;
            this.ButtonAcceptPId.Text = "ОК";
            this.ButtonAcceptPId.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAcceptPId.UseAccentColor = false;
            this.ButtonAcceptPId.UseVisualStyleBackColor = true;
            this.ButtonAcceptPId.Click += new System.EventHandler(this.ButtonAcceptPId_Click);
            // 
            // NumericPId
            // 
            this.NumericPId.Enabled = false;
            this.NumericPId.Location = new System.Drawing.Point(12, 206);
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
            this.NumericPId.TabIndex = 94;
            this.NumericPId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CheckBoxDSignature
            // 
            this.CheckBoxDSignature.AutoSize = true;
            this.CheckBoxDSignature.Depth = 0;
            this.CheckBoxDSignature.Enabled = false;
            this.CheckBoxDSignature.Location = new System.Drawing.Point(7, 347);
            this.CheckBoxDSignature.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxDSignature.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxDSignature.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxDSignature.Name = "CheckBoxDSignature";
            this.CheckBoxDSignature.Ripple = true;
            this.CheckBoxDSignature.Size = new System.Drawing.Size(167, 37);
            this.CheckBoxDSignature.TabIndex = 91;
            this.CheckBoxDSignature.Text = "Подпись доктора";
            this.CheckBoxDSignature.UseVisualStyleBackColor = true;
            // 
            // TextBoxDName
            // 
            this.TextBoxDName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxDName.Depth = 0;
            this.TextBoxDName.Enabled = false;
            this.TextBoxDName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxDName.Hint = "Имя доктора";
            this.TextBoxDName.Location = new System.Drawing.Point(12, 294);
            this.TextBoxDName.MaxLength = 254;
            this.TextBoxDName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxDName.Multiline = false;
            this.TextBoxDName.Name = "TextBoxDName";
            this.TextBoxDName.Size = new System.Drawing.Size(391, 50);
            this.TextBoxDName.TabIndex = 90;
            this.TextBoxDName.Text = "";
            // 
            // TextBoxPName
            // 
            this.TextBoxPName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPName.Depth = 0;
            this.TextBoxPName.Enabled = false;
            this.TextBoxPName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPName.Hint = "Имя пациента";
            this.TextBoxPName.Location = new System.Drawing.Point(12, 238);
            this.TextBoxPName.MaxLength = 254;
            this.TextBoxPName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxPName.Multiline = false;
            this.TextBoxPName.Name = "TextBoxPName";
            this.TextBoxPName.ReadOnly = true;
            this.TextBoxPName.Size = new System.Drawing.Size(391, 50);
            this.TextBoxPName.TabIndex = 89;
            this.TextBoxPName.Text = "";
            // 
            // UpdatePrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 522);
            this.Controls.Add(this.DGVMedications);
            this.Controls.Add(this.DGVDiagnoses);
            this.Controls.Add(this.CheckBoxDStamp);
            this.Controls.Add(this.LabelPId);
            this.Controls.Add(this.TextBoxStatusPId);
            this.Controls.Add(this.LabelStatusPId);
            this.Controls.Add(this.ButtonAcceptPId);
            this.Controls.Add(this.NumericPId);
            this.Controls.Add(this.CheckBoxDSignature);
            this.Controls.Add(this.TextBoxDName);
            this.Controls.Add(this.TextBoxPName);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.TextBoxStatusId);
            this.Controls.Add(this.LabelStatusId);
            this.Controls.Add(this.ButtonAcceptId);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.NumericId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdatePrescriptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение рецепта";
            ((System.ComponentModel.ISupportInitialize)(this.NumericId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiagnoses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton ButtonUpdate;
        private System.Windows.Forms.TextBox TextBoxStatusId;
        private MaterialSkin.Controls.MaterialLabel LabelStatusId;
        private MaterialSkin.Controls.MaterialButton ButtonAcceptId;
        private MaterialSkin.Controls.MaterialLabel LabelId;
        private System.Windows.Forms.NumericUpDown NumericId;
        private System.Windows.Forms.DataGridView DGVMedications;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMedicationsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMedicationsCount;
        private System.Windows.Forms.DataGridView DGVDiagnoses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiagnosisId;
        private MaterialSkin.Controls.MaterialCheckbox CheckBoxDStamp;
        private MaterialSkin.Controls.MaterialLabel LabelPId;
        private System.Windows.Forms.TextBox TextBoxStatusPId;
        private MaterialSkin.Controls.MaterialLabel LabelStatusPId;
        private MaterialSkin.Controls.MaterialButton ButtonAcceptPId;
        private System.Windows.Forms.NumericUpDown NumericPId;
        private MaterialSkin.Controls.MaterialCheckbox CheckBoxDSignature;
        private MaterialSkin.Controls.MaterialTextBox TextBoxDName;
        private MaterialSkin.Controls.MaterialTextBox TextBoxPName;
    }
}