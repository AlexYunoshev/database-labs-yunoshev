
namespace lab6_yunoshev.StorehouseFields
{
    partial class UpdateStorehouseFields
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
            this.CheckBoxRId = new MaterialSkin.Controls.MaterialCheckbox();
            this.TextBoxShelfLife = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxManufactureDate = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxCriticalQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.ButtonAcceptRId = new MaterialSkin.Controls.MaterialButton();
            this.NumericRId = new System.Windows.Forms.NumericUpDown();
            this.TextBoxStatusRId = new System.Windows.Forms.TextBox();
            this.LabelStatusRId = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.NumericId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRId)).BeginInit();
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
            this.ButtonUpdate.Location = new System.Drawing.Point(143, 77);
            this.ButtonUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(211, 96);
            this.ButtonUpdate.TabIndex = 48;
            this.ButtonUpdate.Text = "Изменить";
            this.ButtonUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonUpdate.UseAccentColor = false;
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // TextBoxStatusId
            // 
            this.TextBoxStatusId.ForeColor = System.Drawing.Color.Red;
            this.TextBoxStatusId.Location = new System.Drawing.Point(15, 150);
            this.TextBoxStatusId.Name = "TextBoxStatusId";
            this.TextBoxStatusId.Size = new System.Drawing.Size(120, 23);
            this.TextBoxStatusId.TabIndex = 47;
            this.TextBoxStatusId.Text = "Не выбрано";
            this.TextBoxStatusId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelStatusId
            // 
            this.LabelStatusId.Depth = 0;
            this.LabelStatusId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelStatusId.Location = new System.Drawing.Point(15, 128);
            this.LabelStatusId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelStatusId.Name = "LabelStatusId";
            this.LabelStatusId.Size = new System.Drawing.Size(120, 20);
            this.LabelStatusId.TabIndex = 46;
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
            this.ButtonAcceptId.Location = new System.Drawing.Point(83, 99);
            this.ButtonAcceptId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAcceptId.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAcceptId.Name = "ButtonAcceptId";
            this.ButtonAcceptId.Size = new System.Drawing.Size(52, 23);
            this.ButtonAcceptId.TabIndex = 45;
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
            this.LabelId.Location = new System.Drawing.Point(15, 77);
            this.LabelId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(120, 20);
            this.LabelId.TabIndex = 44;
            this.LabelId.Text = "ID записи";
            this.LabelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericId
            // 
            this.NumericId.Location = new System.Drawing.Point(15, 99);
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
            this.NumericId.TabIndex = 43;
            this.NumericId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CheckBoxRId
            // 
            this.CheckBoxRId.AutoSize = true;
            this.CheckBoxRId.Depth = 0;
            this.CheckBoxRId.Enabled = false;
            this.CheckBoxRId.Location = new System.Drawing.Point(20, 352);
            this.CheckBoxRId.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxRId.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxRId.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxRId.Name = "CheckBoxRId";
            this.CheckBoxRId.Ripple = true;
            this.CheckBoxRId.Size = new System.Drawing.Size(184, 37);
            this.CheckBoxRId.TabIndex = 41;
            this.CheckBoxRId.Text = "id запроса на склад";
            this.CheckBoxRId.UseVisualStyleBackColor = true;
            this.CheckBoxRId.CheckedChanged += new System.EventHandler(this.CheckBoxRId_CheckedChanged);
            // 
            // TextBoxShelfLife
            // 
            this.TextBoxShelfLife.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxShelfLife.Depth = 0;
            this.TextBoxShelfLife.Enabled = false;
            this.TextBoxShelfLife.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxShelfLife.Hint = "Употребить до ГГГГ-ММ-ДД";
            this.TextBoxShelfLife.Location = new System.Drawing.Point(15, 299);
            this.TextBoxShelfLife.MaxLength = 8;
            this.TextBoxShelfLife.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxShelfLife.Multiline = false;
            this.TextBoxShelfLife.Name = "TextBoxShelfLife";
            this.TextBoxShelfLife.Size = new System.Drawing.Size(339, 50);
            this.TextBoxShelfLife.TabIndex = 40;
            this.TextBoxShelfLife.Text = "";
            // 
            // TextBoxManufactureDate
            // 
            this.TextBoxManufactureDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxManufactureDate.Depth = 0;
            this.TextBoxManufactureDate.Enabled = false;
            this.TextBoxManufactureDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxManufactureDate.Hint = "Дата изготовления ГГГГ-ММ-ДД";
            this.TextBoxManufactureDate.Location = new System.Drawing.Point(15, 243);
            this.TextBoxManufactureDate.MaxLength = 10;
            this.TextBoxManufactureDate.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxManufactureDate.Multiline = false;
            this.TextBoxManufactureDate.Name = "TextBoxManufactureDate";
            this.TextBoxManufactureDate.Size = new System.Drawing.Size(339, 50);
            this.TextBoxManufactureDate.TabIndex = 34;
            this.TextBoxManufactureDate.Text = "";
            // 
            // TextBoxCriticalQuantity
            // 
            this.TextBoxCriticalQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxCriticalQuantity.Depth = 0;
            this.TextBoxCriticalQuantity.Enabled = false;
            this.TextBoxCriticalQuantity.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxCriticalQuantity.Hint = "Критическое количество";
            this.TextBoxCriticalQuantity.Location = new System.Drawing.Point(141, 187);
            this.TextBoxCriticalQuantity.MaxLength = 10;
            this.TextBoxCriticalQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxCriticalQuantity.Multiline = false;
            this.TextBoxCriticalQuantity.Name = "TextBoxCriticalQuantity";
            this.TextBoxCriticalQuantity.Size = new System.Drawing.Size(213, 50);
            this.TextBoxCriticalQuantity.TabIndex = 33;
            this.TextBoxCriticalQuantity.Text = "";
            // 
            // TextBoxQuantity
            // 
            this.TextBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxQuantity.Depth = 0;
            this.TextBoxQuantity.Enabled = false;
            this.TextBoxQuantity.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxQuantity.Hint = "Количество";
            this.TextBoxQuantity.Location = new System.Drawing.Point(15, 187);
            this.TextBoxQuantity.MaxLength = 10;
            this.TextBoxQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxQuantity.Multiline = false;
            this.TextBoxQuantity.Name = "TextBoxQuantity";
            this.TextBoxQuantity.Size = new System.Drawing.Size(120, 50);
            this.TextBoxQuantity.TabIndex = 32;
            this.TextBoxQuantity.Text = "";
            // 
            // ButtonAcceptRId
            // 
            this.ButtonAcceptRId.AutoSize = false;
            this.ButtonAcceptRId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAcceptRId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAcceptRId.Depth = 0;
            this.ButtonAcceptRId.DrawShadows = true;
            this.ButtonAcceptRId.Enabled = false;
            this.ButtonAcceptRId.HighEmphasis = true;
            this.ButtonAcceptRId.Icon = null;
            this.ButtonAcceptRId.Location = new System.Drawing.Point(95, 395);
            this.ButtonAcceptRId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAcceptRId.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAcceptRId.Name = "ButtonAcceptRId";
            this.ButtonAcceptRId.Size = new System.Drawing.Size(109, 23);
            this.ButtonAcceptRId.TabIndex = 50;
            this.ButtonAcceptRId.Text = "ОК";
            this.ButtonAcceptRId.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAcceptRId.UseAccentColor = false;
            this.ButtonAcceptRId.UseVisualStyleBackColor = true;
            // 
            // NumericRId
            // 
            this.NumericRId.Enabled = false;
            this.NumericRId.Location = new System.Drawing.Point(27, 395);
            this.NumericRId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumericRId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericRId.Name = "NumericRId";
            this.NumericRId.Size = new System.Drawing.Size(61, 23);
            this.NumericRId.TabIndex = 49;
            this.NumericRId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TextBoxStatusRId
            // 
            this.TextBoxStatusRId.ForeColor = System.Drawing.Color.Red;
            this.TextBoxStatusRId.Location = new System.Drawing.Point(222, 394);
            this.TextBoxStatusRId.Name = "TextBoxStatusRId";
            this.TextBoxStatusRId.Size = new System.Drawing.Size(132, 23);
            this.TextBoxStatusRId.TabIndex = 52;
            this.TextBoxStatusRId.Text = "Не выбрано";
            this.TextBoxStatusRId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelStatusRId
            // 
            this.LabelStatusRId.Depth = 0;
            this.LabelStatusRId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelStatusRId.Location = new System.Drawing.Point(222, 359);
            this.LabelStatusRId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelStatusRId.Name = "LabelStatusRId";
            this.LabelStatusRId.Size = new System.Drawing.Size(132, 20);
            this.LabelStatusRId.TabIndex = 51;
            this.LabelStatusRId.Text = "Статус ID";
            this.LabelStatusRId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateStorehouseFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 431);
            this.Controls.Add(this.TextBoxStatusRId);
            this.Controls.Add(this.LabelStatusRId);
            this.Controls.Add(this.ButtonAcceptRId);
            this.Controls.Add(this.NumericRId);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.TextBoxStatusId);
            this.Controls.Add(this.LabelStatusId);
            this.Controls.Add(this.ButtonAcceptId);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.NumericId);
            this.Controls.Add(this.CheckBoxRId);
            this.Controls.Add(this.TextBoxShelfLife);
            this.Controls.Add(this.TextBoxManufactureDate);
            this.Controls.Add(this.TextBoxCriticalQuantity);
            this.Controls.Add(this.TextBoxQuantity);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateStorehouseFields";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.Text = "Изменение записи";
            ((System.ComponentModel.ISupportInitialize)(this.NumericId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRId)).EndInit();
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
        private MaterialSkin.Controls.MaterialCheckbox CheckBoxRId;
        private MaterialSkin.Controls.MaterialTextBox TextBoxShelfLife;
        private MaterialSkin.Controls.MaterialTextBox TextBoxManufactureDate;
        private MaterialSkin.Controls.MaterialTextBox TextBoxCriticalQuantity;
        private MaterialSkin.Controls.MaterialTextBox TextBoxQuantity;
        private MaterialSkin.Controls.MaterialButton ButtonAcceptRId;
        private System.Windows.Forms.NumericUpDown NumericRId;
        private System.Windows.Forms.TextBox TextBoxStatusRId;
        private MaterialSkin.Controls.MaterialLabel LabelStatusRId;
    }
}