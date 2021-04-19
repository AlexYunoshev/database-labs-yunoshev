
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
            this.CheckBoxFilterTime = new MaterialSkin.Controls.MaterialCheckbox();
            this.TextBoxFiltrationTime = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxVolume = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.NumericId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // CheckBoxFilterTime
            // 
            this.CheckBoxFilterTime.AutoSize = true;
            this.CheckBoxFilterTime.Depth = 0;
            this.CheckBoxFilterTime.Enabled = false;
            this.CheckBoxFilterTime.Location = new System.Drawing.Point(20, 352);
            this.CheckBoxFilterTime.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxFilterTime.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxFilterTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxFilterTime.Name = "CheckBoxFilterTime";
            this.CheckBoxFilterTime.Ripple = true;
            this.CheckBoxFilterTime.Size = new System.Drawing.Size(184, 37);
            this.CheckBoxFilterTime.TabIndex = 41;
            this.CheckBoxFilterTime.Text = "id запроса на склад";
            this.CheckBoxFilterTime.UseVisualStyleBackColor = true;
            // 
            // TextBoxFiltrationTime
            // 
            this.TextBoxFiltrationTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxFiltrationTime.Depth = 0;
            this.TextBoxFiltrationTime.Enabled = false;
            this.TextBoxFiltrationTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxFiltrationTime.Hint = "Употребить до ГГГГ:ММ:ДД";
            this.TextBoxFiltrationTime.Location = new System.Drawing.Point(15, 299);
            this.TextBoxFiltrationTime.MaxLength = 8;
            this.TextBoxFiltrationTime.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxFiltrationTime.Multiline = false;
            this.TextBoxFiltrationTime.Name = "TextBoxFiltrationTime";
            this.TextBoxFiltrationTime.Size = new System.Drawing.Size(339, 50);
            this.TextBoxFiltrationTime.TabIndex = 40;
            this.TextBoxFiltrationTime.Text = "";
            // 
            // TextBoxVolume
            // 
            this.TextBoxVolume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxVolume.Depth = 0;
            this.TextBoxVolume.Enabled = false;
            this.TextBoxVolume.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxVolume.Hint = "Дата изготовления ГГГГ:ММ:ДД";
            this.TextBoxVolume.Location = new System.Drawing.Point(15, 243);
            this.TextBoxVolume.MaxLength = 10;
            this.TextBoxVolume.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxVolume.Multiline = false;
            this.TextBoxVolume.Name = "TextBoxVolume";
            this.TextBoxVolume.Size = new System.Drawing.Size(339, 50);
            this.TextBoxVolume.TabIndex = 34;
            this.TextBoxVolume.Text = "";
            // 
            // TextBoxQuantity
            // 
            this.TextBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxQuantity.Depth = 0;
            this.TextBoxQuantity.Enabled = false;
            this.TextBoxQuantity.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxQuantity.Hint = "Критическое количество";
            this.TextBoxQuantity.Location = new System.Drawing.Point(141, 187);
            this.TextBoxQuantity.MaxLength = 10;
            this.TextBoxQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxQuantity.Multiline = false;
            this.TextBoxQuantity.Name = "TextBoxQuantity";
            this.TextBoxQuantity.Size = new System.Drawing.Size(213, 50);
            this.TextBoxQuantity.TabIndex = 33;
            this.TextBoxQuantity.Text = "";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPrice.Depth = 0;
            this.TextBoxPrice.Enabled = false;
            this.TextBoxPrice.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPrice.Hint = "Количество";
            this.TextBoxPrice.Location = new System.Drawing.Point(15, 187);
            this.TextBoxPrice.MaxLength = 10;
            this.TextBoxPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxPrice.Multiline = false;
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(120, 50);
            this.TextBoxPrice.TabIndex = 32;
            this.TextBoxPrice.Text = "";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(95, 395);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(109, 23);
            this.materialButton1.TabIndex = 50;
            this.materialButton1.Text = "ОК";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(27, 395);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 23);
            this.numericUpDown1.TabIndex = 49;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(222, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 23);
            this.textBox1.TabIndex = 52;
            this.textBox1.Text = "Не выбрано";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(222, 359);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(132, 20);
            this.materialLabel1.TabIndex = 51;
            this.materialLabel1.Text = "Статус ID";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateStorehouseFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 431);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.TextBoxStatusId);
            this.Controls.Add(this.LabelStatusId);
            this.Controls.Add(this.ButtonAcceptId);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.NumericId);
            this.Controls.Add(this.CheckBoxFilterTime);
            this.Controls.Add(this.TextBoxFiltrationTime);
            this.Controls.Add(this.TextBoxVolume);
            this.Controls.Add(this.TextBoxQuantity);
            this.Controls.Add(this.TextBoxPrice);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateStorehouseFields";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.Text = "Изменение записи";
            ((System.ComponentModel.ISupportInitialize)(this.NumericId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private MaterialSkin.Controls.MaterialCheckbox CheckBoxFilterTime;
        private MaterialSkin.Controls.MaterialTextBox TextBoxFiltrationTime;
        private MaterialSkin.Controls.MaterialTextBox TextBoxVolume;
        private MaterialSkin.Controls.MaterialTextBox TextBoxQuantity;
        private MaterialSkin.Controls.MaterialTextBox TextBoxPrice;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}