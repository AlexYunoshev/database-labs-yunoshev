
namespace lab6_yunoshev.Medications
{
    partial class DeleteMedications
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
            this.CheckBoxSpecificId = new MaterialSkin.Controls.MaterialCheckbox();
            this.CheckBoxRangeId = new MaterialSkin.Controls.MaterialCheckbox();
            this.LabelFrom = new MaterialSkin.Controls.MaterialLabel();
            this.NumericFrom = new System.Windows.Forms.NumericUpDown();
            this.NumericSpecificId = new System.Windows.Forms.NumericUpDown();
            this.LabelTo = new MaterialSkin.Controls.MaterialLabel();
            this.NumericTo = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxName = new MaterialSkin.Controls.MaterialCheckbox();
            this.TextBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.ButtonDelete = new MaterialSkin.Controls.MaterialButton();
            this.ButtonReset = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSpecificId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTo)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBoxSpecificId
            // 
            this.CheckBoxSpecificId.AutoSize = true;
            this.CheckBoxSpecificId.Checked = true;
            this.CheckBoxSpecificId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxSpecificId.Depth = 0;
            this.CheckBoxSpecificId.Location = new System.Drawing.Point(12, 80);
            this.CheckBoxSpecificId.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxSpecificId.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxSpecificId.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxSpecificId.Name = "CheckBoxSpecificId";
            this.CheckBoxSpecificId.Ripple = true;
            this.CheckBoxSpecificId.Size = new System.Drawing.Size(144, 37);
            this.CheckBoxSpecificId.TabIndex = 0;
            this.CheckBoxSpecificId.Text = "Конкретный id";
            this.CheckBoxSpecificId.UseVisualStyleBackColor = true;
            this.CheckBoxSpecificId.CheckedChanged += new System.EventHandler(this.CheckBoxSpecificId_CheckedChanged);
            // 
            // CheckBoxRangeId
            // 
            this.CheckBoxRangeId.AutoSize = true;
            this.CheckBoxRangeId.Depth = 0;
            this.CheckBoxRangeId.Enabled = false;
            this.CheckBoxRangeId.Location = new System.Drawing.Point(12, 117);
            this.CheckBoxRangeId.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxRangeId.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxRangeId.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxRangeId.Name = "CheckBoxRangeId";
            this.CheckBoxRangeId.Ripple = true;
            this.CheckBoxRangeId.Size = new System.Drawing.Size(126, 37);
            this.CheckBoxRangeId.TabIndex = 2;
            this.CheckBoxRangeId.Text = "Диапазон id";
            this.CheckBoxRangeId.UseVisualStyleBackColor = true;
            this.CheckBoxRangeId.CheckedChanged += new System.EventHandler(this.CheckBoxRangeId_CheckedChanged);
            // 
            // LabelFrom
            // 
            this.LabelFrom.AutoSize = true;
            this.LabelFrom.Depth = 0;
            this.LabelFrom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelFrom.Location = new System.Drawing.Point(157, 126);
            this.LabelFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new System.Drawing.Size(20, 19);
            this.LabelFrom.TabIndex = 5;
            this.LabelFrom.Text = "От";
            // 
            // NumericFrom
            // 
            this.NumericFrom.Enabled = false;
            this.NumericFrom.Location = new System.Drawing.Point(185, 125);
            this.NumericFrom.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumericFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericFrom.Name = "NumericFrom";
            this.NumericFrom.Size = new System.Drawing.Size(61, 23);
            this.NumericFrom.TabIndex = 3;
            this.NumericFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericSpecificId
            // 
            this.NumericSpecificId.Location = new System.Drawing.Point(185, 88);
            this.NumericSpecificId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumericSpecificId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericSpecificId.Name = "NumericSpecificId";
            this.NumericSpecificId.Size = new System.Drawing.Size(61, 23);
            this.NumericSpecificId.TabIndex = 1;
            this.NumericSpecificId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Depth = 0;
            this.LabelTo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelTo.Location = new System.Drawing.Point(261, 126);
            this.LabelTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(22, 19);
            this.LabelTo.TabIndex = 6;
            this.LabelTo.Text = "До";
            // 
            // NumericTo
            // 
            this.NumericTo.Enabled = false;
            this.NumericTo.Location = new System.Drawing.Point(298, 125);
            this.NumericTo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumericTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericTo.Name = "NumericTo";
            this.NumericTo.Size = new System.Drawing.Size(61, 23);
            this.NumericTo.TabIndex = 4;
            this.NumericTo.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // CheckBoxName
            // 
            this.CheckBoxName.AutoSize = true;
            this.CheckBoxName.Depth = 0;
            this.CheckBoxName.Enabled = false;
            this.CheckBoxName.Location = new System.Drawing.Point(12, 154);
            this.CheckBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxName.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxName.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxName.Name = "CheckBoxName";
            this.CheckBoxName.Ripple = true;
            this.CheckBoxName.Size = new System.Drawing.Size(189, 37);
            this.CheckBoxName.TabIndex = 7;
            this.CheckBoxName.Text = "Название лекарства";
            this.CheckBoxName.UseVisualStyleBackColor = true;
            this.CheckBoxName.CheckedChanged += new System.EventHandler(this.CheckBoxName_CheckedChanged);
            // 
            // TextBoxName
            // 
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxName.Depth = 0;
            this.TextBoxName.Enabled = false;
            this.TextBoxName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxName.Location = new System.Drawing.Point(20, 194);
            this.TextBoxName.MaxLength = 50;
            this.TextBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxName.Multiline = false;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(340, 50);
            this.TextBoxName.TabIndex = 8;
            this.TextBoxName.Text = "";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AutoSize = false;
            this.ButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDelete.Depth = 0;
            this.ButtonDelete.DrawShadows = true;
            this.ButtonDelete.HighEmphasis = true;
            this.ButtonDelete.Icon = null;
            this.ButtonDelete.Location = new System.Drawing.Point(20, 253);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(170, 36);
            this.ButtonDelete.TabIndex = 9;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonDelete.UseAccentColor = false;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonReset
            // 
            this.ButtonReset.AutoSize = false;
            this.ButtonReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonReset.Depth = 0;
            this.ButtonReset.DrawShadows = true;
            this.ButtonReset.HighEmphasis = true;
            this.ButtonReset.Icon = null;
            this.ButtonReset.Location = new System.Drawing.Point(198, 253);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(162, 36);
            this.ButtonReset.TabIndex = 15;
            this.ButtonReset.Text = "Сбросить всё";
            this.ButtonReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonReset.UseAccentColor = false;
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // DeleteMedications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 305);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.CheckBoxName);
            this.Controls.Add(this.NumericTo);
            this.Controls.Add(this.LabelTo);
            this.Controls.Add(this.NumericSpecificId);
            this.Controls.Add(this.CheckBoxSpecificId);
            this.Controls.Add(this.NumericFrom);
            this.Controls.Add(this.LabelFrom);
            this.Controls.Add(this.CheckBoxRangeId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteMedications";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление лекарства";
            ((System.ComponentModel.ISupportInitialize)(this.NumericFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSpecificId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckbox CheckBoxSpecificId;
        private MaterialSkin.Controls.MaterialCheckbox CheckBoxRangeId;
        private MaterialSkin.Controls.MaterialLabel LabelFrom;
        private System.Windows.Forms.NumericUpDown NumericFrom;
        private System.Windows.Forms.NumericUpDown NumericSpecificId;
        private MaterialSkin.Controls.MaterialLabel LabelTo;
        private System.Windows.Forms.NumericUpDown NumericTo;
        private MaterialSkin.Controls.MaterialCheckbox CheckBoxName;
        private MaterialSkin.Controls.MaterialTextBox TextBoxName;
        private MaterialSkin.Controls.MaterialButton ButtonDelete;
        private MaterialSkin.Controls.MaterialButton ButtonReset;
    }
}