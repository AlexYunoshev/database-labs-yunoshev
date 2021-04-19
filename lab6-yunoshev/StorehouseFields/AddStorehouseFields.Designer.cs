
namespace lab6_yunoshev.StorehouseFields
{
    partial class AddStorehouseFields
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
            this.TextBoxStatusRId = new System.Windows.Forms.TextBox();
            this.LabelStatusRId = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonAcceptRId = new MaterialSkin.Controls.MaterialButton();
            this.NumericRId = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxRId = new MaterialSkin.Controls.MaterialCheckbox();
            this.TextBoxShelfLife = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxManufactureDate = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxCriticalQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.ButtonReset = new MaterialSkin.Controls.MaterialButton();
            this.ButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.TextBoxStatusMId = new System.Windows.Forms.TextBox();
            this.LabelStatusMId = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonAcceptMId = new MaterialSkin.Controls.MaterialButton();
            this.NumericMId = new System.Windows.Forms.NumericUpDown();
            this.LabelMId = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMId)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxStatusRId
            // 
            this.TextBoxStatusRId.ForeColor = System.Drawing.Color.Red;
            this.TextBoxStatusRId.Location = new System.Drawing.Point(208, 199);
            this.TextBoxStatusRId.Name = "TextBoxStatusRId";
            this.TextBoxStatusRId.ReadOnly = true;
            this.TextBoxStatusRId.Size = new System.Drawing.Size(132, 23);
            this.TextBoxStatusRId.TabIndex = 61;
            this.TextBoxStatusRId.Text = "Не выбрано";
            this.TextBoxStatusRId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelStatusRId
            // 
            this.LabelStatusRId.Depth = 0;
            this.LabelStatusRId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelStatusRId.Location = new System.Drawing.Point(208, 164);
            this.LabelStatusRId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelStatusRId.Name = "LabelStatusRId";
            this.LabelStatusRId.Size = new System.Drawing.Size(132, 20);
            this.LabelStatusRId.TabIndex = 60;
            this.LabelStatusRId.Text = "Статус ID";
            this.LabelStatusRId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ButtonAcceptRId.Location = new System.Drawing.Point(81, 200);
            this.ButtonAcceptRId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAcceptRId.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAcceptRId.Name = "ButtonAcceptRId";
            this.ButtonAcceptRId.Size = new System.Drawing.Size(109, 23);
            this.ButtonAcceptRId.TabIndex = 59;
            this.ButtonAcceptRId.Text = "ОК";
            this.ButtonAcceptRId.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAcceptRId.UseAccentColor = false;
            this.ButtonAcceptRId.UseVisualStyleBackColor = true;
            this.ButtonAcceptRId.Click += new System.EventHandler(this.ButtonAcceptRId_Click);
            // 
            // NumericRId
            // 
            this.NumericRId.Enabled = false;
            this.NumericRId.Location = new System.Drawing.Point(13, 200);
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
            this.NumericRId.TabIndex = 58;
            this.NumericRId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CheckBoxRId
            // 
            this.CheckBoxRId.AutoSize = true;
            this.CheckBoxRId.Depth = 0;
            this.CheckBoxRId.Location = new System.Drawing.Point(6, 157);
            this.CheckBoxRId.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxRId.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxRId.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxRId.Name = "CheckBoxRId";
            this.CheckBoxRId.Ripple = true;
            this.CheckBoxRId.Size = new System.Drawing.Size(184, 37);
            this.CheckBoxRId.TabIndex = 57;
            this.CheckBoxRId.Text = "id запроса на склад";
            this.CheckBoxRId.UseVisualStyleBackColor = true;
            this.CheckBoxRId.CheckedChanged += new System.EventHandler(this.CheckBoxRId_CheckedChanged);
            // 
            // TextBoxShelfLife
            // 
            this.TextBoxShelfLife.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxShelfLife.Depth = 0;
            this.TextBoxShelfLife.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxShelfLife.Hint = "Употребить до ГГГГ-ММ-ДД";
            this.TextBoxShelfLife.Location = new System.Drawing.Point(6, 362);
            this.TextBoxShelfLife.MaxLength = 10;
            this.TextBoxShelfLife.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxShelfLife.Multiline = false;
            this.TextBoxShelfLife.Name = "TextBoxShelfLife";
            this.TextBoxShelfLife.Size = new System.Drawing.Size(339, 50);
            this.TextBoxShelfLife.TabIndex = 56;
            this.TextBoxShelfLife.Text = "";
            // 
            // TextBoxManufactureDate
            // 
            this.TextBoxManufactureDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxManufactureDate.Depth = 0;
            this.TextBoxManufactureDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxManufactureDate.Hint = "Дата изготовления ГГГГ-ММ-ДД";
            this.TextBoxManufactureDate.Location = new System.Drawing.Point(6, 306);
            this.TextBoxManufactureDate.MaxLength = 10;
            this.TextBoxManufactureDate.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxManufactureDate.Multiline = false;
            this.TextBoxManufactureDate.Name = "TextBoxManufactureDate";
            this.TextBoxManufactureDate.Size = new System.Drawing.Size(339, 50);
            this.TextBoxManufactureDate.TabIndex = 55;
            this.TextBoxManufactureDate.Text = "";
            // 
            // TextBoxCriticalQuantity
            // 
            this.TextBoxCriticalQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxCriticalQuantity.Depth = 0;
            this.TextBoxCriticalQuantity.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxCriticalQuantity.Hint = "Критическое количество";
            this.TextBoxCriticalQuantity.Location = new System.Drawing.Point(132, 250);
            this.TextBoxCriticalQuantity.MaxLength = 10;
            this.TextBoxCriticalQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxCriticalQuantity.Multiline = false;
            this.TextBoxCriticalQuantity.Name = "TextBoxCriticalQuantity";
            this.TextBoxCriticalQuantity.Size = new System.Drawing.Size(213, 50);
            this.TextBoxCriticalQuantity.TabIndex = 54;
            this.TextBoxCriticalQuantity.Text = "";
            // 
            // TextBoxQuantity
            // 
            this.TextBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxQuantity.Depth = 0;
            this.TextBoxQuantity.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxQuantity.Hint = "Количество";
            this.TextBoxQuantity.Location = new System.Drawing.Point(6, 250);
            this.TextBoxQuantity.MaxLength = 10;
            this.TextBoxQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxQuantity.Multiline = false;
            this.TextBoxQuantity.Name = "TextBoxQuantity";
            this.TextBoxQuantity.Size = new System.Drawing.Size(120, 50);
            this.TextBoxQuantity.TabIndex = 53;
            this.TextBoxQuantity.Text = "";
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
            this.ButtonReset.Location = new System.Drawing.Point(173, 421);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(172, 36);
            this.ButtonReset.TabIndex = 63;
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
            this.ButtonAdd.Location = new System.Drawing.Point(6, 421);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(159, 36);
            this.ButtonAdd.TabIndex = 62;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAdd.UseAccentColor = false;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TextBoxStatusMId
            // 
            this.TextBoxStatusMId.ForeColor = System.Drawing.Color.Red;
            this.TextBoxStatusMId.Location = new System.Drawing.Point(208, 117);
            this.TextBoxStatusMId.Name = "TextBoxStatusMId";
            this.TextBoxStatusMId.ReadOnly = true;
            this.TextBoxStatusMId.Size = new System.Drawing.Size(132, 23);
            this.TextBoxStatusMId.TabIndex = 68;
            this.TextBoxStatusMId.Text = "Не выбрано";
            this.TextBoxStatusMId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelStatusMId
            // 
            this.LabelStatusMId.Depth = 0;
            this.LabelStatusMId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelStatusMId.Location = new System.Drawing.Point(208, 82);
            this.LabelStatusMId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelStatusMId.Name = "LabelStatusMId";
            this.LabelStatusMId.Size = new System.Drawing.Size(132, 20);
            this.LabelStatusMId.TabIndex = 67;
            this.LabelStatusMId.Text = "Статус ID";
            this.LabelStatusMId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAcceptMId
            // 
            this.ButtonAcceptMId.AutoSize = false;
            this.ButtonAcceptMId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAcceptMId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAcceptMId.Depth = 0;
            this.ButtonAcceptMId.DrawShadows = true;
            this.ButtonAcceptMId.HighEmphasis = true;
            this.ButtonAcceptMId.Icon = null;
            this.ButtonAcceptMId.Location = new System.Drawing.Point(81, 118);
            this.ButtonAcceptMId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAcceptMId.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAcceptMId.Name = "ButtonAcceptMId";
            this.ButtonAcceptMId.Size = new System.Drawing.Size(109, 23);
            this.ButtonAcceptMId.TabIndex = 66;
            this.ButtonAcceptMId.Text = "ОК";
            this.ButtonAcceptMId.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAcceptMId.UseAccentColor = false;
            this.ButtonAcceptMId.UseVisualStyleBackColor = true;
            this.ButtonAcceptMId.Click += new System.EventHandler(this.ButtonAcceptMId_Click);
            // 
            // NumericMId
            // 
            this.NumericMId.Location = new System.Drawing.Point(13, 118);
            this.NumericMId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumericMId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericMId.Name = "NumericMId";
            this.NumericMId.Size = new System.Drawing.Size(61, 23);
            this.NumericMId.TabIndex = 65;
            this.NumericMId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LabelMId
            // 
            this.LabelMId.Depth = 0;
            this.LabelMId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelMId.Location = new System.Drawing.Point(13, 82);
            this.LabelMId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelMId.Name = "LabelMId";
            this.LabelMId.Size = new System.Drawing.Size(177, 20);
            this.LabelMId.TabIndex = 69;
            this.LabelMId.Text = "id лекарства";
            this.LabelMId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddStorehouseFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 473);
            this.Controls.Add(this.LabelMId);
            this.Controls.Add(this.TextBoxStatusMId);
            this.Controls.Add(this.LabelStatusMId);
            this.Controls.Add(this.ButtonAcceptMId);
            this.Controls.Add(this.NumericMId);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxStatusRId);
            this.Controls.Add(this.LabelStatusRId);
            this.Controls.Add(this.ButtonAcceptRId);
            this.Controls.Add(this.NumericRId);
            this.Controls.Add(this.CheckBoxRId);
            this.Controls.Add(this.TextBoxShelfLife);
            this.Controls.Add(this.TextBoxManufactureDate);
            this.Controls.Add(this.TextBoxCriticalQuantity);
            this.Controls.Add(this.TextBoxQuantity);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStorehouseFields";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление записи на складе";
            ((System.ComponentModel.ISupportInitialize)(this.NumericRId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxStatusRId;
        private MaterialSkin.Controls.MaterialLabel LabelStatusRId;
        private MaterialSkin.Controls.MaterialButton ButtonAcceptRId;
        private System.Windows.Forms.NumericUpDown NumericRId;
        private MaterialSkin.Controls.MaterialCheckbox CheckBoxRId;
        private MaterialSkin.Controls.MaterialTextBox TextBoxShelfLife;
        private MaterialSkin.Controls.MaterialTextBox TextBoxManufactureDate;
        private MaterialSkin.Controls.MaterialTextBox TextBoxCriticalQuantity;
        private MaterialSkin.Controls.MaterialTextBox TextBoxQuantity;
        private MaterialSkin.Controls.MaterialButton ButtonReset;
        private MaterialSkin.Controls.MaterialButton ButtonAdd;
        private System.Windows.Forms.TextBox TextBoxStatusMId;
        private MaterialSkin.Controls.MaterialLabel LabelStatusMId;
        private MaterialSkin.Controls.MaterialButton ButtonAcceptMId;
        private System.Windows.Forms.NumericUpDown NumericMId;
        private MaterialSkin.Controls.MaterialLabel LabelMId;
    }
}