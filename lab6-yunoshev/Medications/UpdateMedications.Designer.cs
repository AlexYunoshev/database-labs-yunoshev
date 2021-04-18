
namespace lab6_yunoshev.Medications
{
    partial class UpdateMedications
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
            this.TextBoxMixableList = new MaterialSkin.Controls.MaterialTextBox();
            this.CheckBoxFilterTime = new MaterialSkin.Controls.MaterialCheckbox();
            this.TextBoxFiltrationTime = new MaterialSkin.Controls.MaterialTextBox();
            this.CheckBoxPrepTime = new MaterialSkin.Controls.MaterialCheckbox();
            this.TextBoxPrepTime = new MaterialSkin.Controls.MaterialTextBox();
            this.ComboBoxManufType = new MaterialSkin.Controls.MaterialComboBox();
            this.ComboBoxUsesType = new MaterialSkin.Controls.MaterialComboBox();
            this.ComboBoxMedType = new MaterialSkin.Controls.MaterialComboBox();
            this.TextBoxVolume = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.NumericId = new System.Windows.Forms.NumericUpDown();
            this.LabelId = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonAcceptId = new MaterialSkin.Controls.MaterialButton();
            this.LabelStatusId = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxStatusId = new System.Windows.Forms.TextBox();
            this.ButtonUpdate = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumericId)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxMixableList
            // 
            this.TextBoxMixableList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMixableList.Depth = 0;
            this.TextBoxMixableList.Enabled = false;
            this.TextBoxMixableList.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxMixableList.Hint = "Список смешиваемых компонентов";
            this.TextBoxMixableList.Location = new System.Drawing.Point(15, 406);
            this.TextBoxMixableList.MaxLength = 254;
            this.TextBoxMixableList.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxMixableList.Multiline = false;
            this.TextBoxMixableList.Name = "TextBoxMixableList";
            this.TextBoxMixableList.Size = new System.Drawing.Size(448, 50);
            this.TextBoxMixableList.TabIndex = 24;
            this.TextBoxMixableList.Text = "";
            // 
            // CheckBoxFilterTime
            // 
            this.CheckBoxFilterTime.AutoSize = true;
            this.CheckBoxFilterTime.Depth = 0;
            this.CheckBoxFilterTime.Enabled = false;
            this.CheckBoxFilterTime.Location = new System.Drawing.Point(247, 299);
            this.CheckBoxFilterTime.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxFilterTime.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxFilterTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxFilterTime.Name = "CheckBoxFilterTime";
            this.CheckBoxFilterTime.Ripple = true;
            this.CheckBoxFilterTime.Size = new System.Drawing.Size(179, 37);
            this.CheckBoxFilterTime.TabIndex = 23;
            this.CheckBoxFilterTime.Text = "Время фильтрации";
            this.CheckBoxFilterTime.UseVisualStyleBackColor = true;
            this.CheckBoxFilterTime.CheckedChanged += new System.EventHandler(this.CheckBoxFilterTime_CheckedChanged);
            // 
            // TextBoxFiltrationTime
            // 
            this.TextBoxFiltrationTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxFiltrationTime.Depth = 0;
            this.TextBoxFiltrationTime.Enabled = false;
            this.TextBoxFiltrationTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxFiltrationTime.Hint = "ЧЧ:ММ:СС";
            this.TextBoxFiltrationTime.Location = new System.Drawing.Point(254, 339);
            this.TextBoxFiltrationTime.MaxLength = 8;
            this.TextBoxFiltrationTime.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxFiltrationTime.Multiline = false;
            this.TextBoxFiltrationTime.Name = "TextBoxFiltrationTime";
            this.TextBoxFiltrationTime.Size = new System.Drawing.Size(172, 50);
            this.TextBoxFiltrationTime.TabIndex = 22;
            this.TextBoxFiltrationTime.Text = "";
            // 
            // CheckBoxPrepTime
            // 
            this.CheckBoxPrepTime.AutoSize = true;
            this.CheckBoxPrepTime.Depth = 0;
            this.CheckBoxPrepTime.Enabled = false;
            this.CheckBoxPrepTime.Location = new System.Drawing.Point(15, 300);
            this.CheckBoxPrepTime.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxPrepTime.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxPrepTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxPrepTime.Name = "CheckBoxPrepTime";
            this.CheckBoxPrepTime.Ripple = true;
            this.CheckBoxPrepTime.Size = new System.Drawing.Size(200, 37);
            this.CheckBoxPrepTime.TabIndex = 21;
            this.CheckBoxPrepTime.Text = "Время приготовления";
            this.CheckBoxPrepTime.UseVisualStyleBackColor = true;
            this.CheckBoxPrepTime.CheckedChanged += new System.EventHandler(this.CheckBoxPrepTime_CheckedChanged);
            // 
            // TextBoxPrepTime
            // 
            this.TextBoxPrepTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPrepTime.Depth = 0;
            this.TextBoxPrepTime.Enabled = false;
            this.TextBoxPrepTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPrepTime.Hint = "ЧЧ:ММ:СС";
            this.TextBoxPrepTime.Location = new System.Drawing.Point(15, 340);
            this.TextBoxPrepTime.MaxLength = 8;
            this.TextBoxPrepTime.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxPrepTime.Multiline = false;
            this.TextBoxPrepTime.Name = "TextBoxPrepTime";
            this.TextBoxPrepTime.Size = new System.Drawing.Size(200, 50);
            this.TextBoxPrepTime.TabIndex = 20;
            this.TextBoxPrepTime.Text = "";
            // 
            // ComboBoxManufType
            // 
            this.ComboBoxManufType.AutoResize = false;
            this.ComboBoxManufType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxManufType.Depth = 0;
            this.ComboBoxManufType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxManufType.DropDownHeight = 174;
            this.ComboBoxManufType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxManufType.DropDownWidth = 121;
            this.ComboBoxManufType.Enabled = false;
            this.ComboBoxManufType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxManufType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxManufType.FormattingEnabled = true;
            this.ComboBoxManufType.Hint = "Изготовление";
            this.ComboBoxManufType.IntegralHeight = false;
            this.ComboBoxManufType.ItemHeight = 43;
            this.ComboBoxManufType.Items.AddRange(new object[] {
            "Готовое",
            "Аптечное",
            "Смешанное"});
            this.ComboBoxManufType.Location = new System.Drawing.Point(318, 244);
            this.ComboBoxManufType.MaxDropDownItems = 4;
            this.ComboBoxManufType.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxManufType.Name = "ComboBoxManufType";
            this.ComboBoxManufType.Size = new System.Drawing.Size(145, 49);
            this.ComboBoxManufType.StartIndex = -1;
            this.ComboBoxManufType.TabIndex = 19;
            this.ComboBoxManufType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxManufType_SelectedIndexChanged);
            // 
            // ComboBoxUsesType
            // 
            this.ComboBoxUsesType.AutoResize = false;
            this.ComboBoxUsesType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxUsesType.Depth = 0;
            this.ComboBoxUsesType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxUsesType.DropDownHeight = 174;
            this.ComboBoxUsesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxUsesType.DropDownWidth = 121;
            this.ComboBoxUsesType.Enabled = false;
            this.ComboBoxUsesType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxUsesType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxUsesType.FormattingEnabled = true;
            this.ComboBoxUsesType.Hint = "Применение";
            this.ComboBoxUsesType.IntegralHeight = false;
            this.ComboBoxUsesType.ItemHeight = 43;
            this.ComboBoxUsesType.Items.AddRange(new object[] {
            "Внутреннее",
            "Наружное"});
            this.ComboBoxUsesType.Location = new System.Drawing.Point(169, 244);
            this.ComboBoxUsesType.MaxDropDownItems = 4;
            this.ComboBoxUsesType.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxUsesType.Name = "ComboBoxUsesType";
            this.ComboBoxUsesType.Size = new System.Drawing.Size(143, 49);
            this.ComboBoxUsesType.StartIndex = -1;
            this.ComboBoxUsesType.TabIndex = 18;
            // 
            // ComboBoxMedType
            // 
            this.ComboBoxMedType.AutoResize = false;
            this.ComboBoxMedType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxMedType.Depth = 0;
            this.ComboBoxMedType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxMedType.DropDownHeight = 174;
            this.ComboBoxMedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMedType.DropDownWidth = 121;
            this.ComboBoxMedType.Enabled = false;
            this.ComboBoxMedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxMedType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxMedType.FormattingEnabled = true;
            this.ComboBoxMedType.Hint = "Тип лекарства";
            this.ComboBoxMedType.IntegralHeight = false;
            this.ComboBoxMedType.ItemHeight = 43;
            this.ComboBoxMedType.Items.AddRange(new object[] {
            "Таблетки",
            "Мазь",
            "Порошок",
            "Раствор",
            "Травы",
            "Свечи",
            "Капли"});
            this.ComboBoxMedType.Location = new System.Drawing.Point(15, 244);
            this.ComboBoxMedType.MaxDropDownItems = 4;
            this.ComboBoxMedType.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxMedType.Name = "ComboBoxMedType";
            this.ComboBoxMedType.Size = new System.Drawing.Size(148, 49);
            this.ComboBoxMedType.StartIndex = -1;
            this.ComboBoxMedType.TabIndex = 17;
            // 
            // TextBoxVolume
            // 
            this.TextBoxVolume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxVolume.Depth = 0;
            this.TextBoxVolume.Enabled = false;
            this.TextBoxVolume.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxVolume.Hint = "Объем";
            this.TextBoxVolume.Location = new System.Drawing.Point(318, 188);
            this.TextBoxVolume.MaxLength = 10;
            this.TextBoxVolume.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxVolume.Multiline = false;
            this.TextBoxVolume.Name = "TextBoxVolume";
            this.TextBoxVolume.Size = new System.Drawing.Size(145, 50);
            this.TextBoxVolume.TabIndex = 16;
            this.TextBoxVolume.Text = "";
            // 
            // TextBoxQuantity
            // 
            this.TextBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxQuantity.Depth = 0;
            this.TextBoxQuantity.Enabled = false;
            this.TextBoxQuantity.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxQuantity.Hint = "Количество";
            this.TextBoxQuantity.Location = new System.Drawing.Point(169, 188);
            this.TextBoxQuantity.MaxLength = 10;
            this.TextBoxQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxQuantity.Multiline = false;
            this.TextBoxQuantity.Name = "TextBoxQuantity";
            this.TextBoxQuantity.Size = new System.Drawing.Size(143, 50);
            this.TextBoxQuantity.TabIndex = 15;
            this.TextBoxQuantity.Text = "";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPrice.Depth = 0;
            this.TextBoxPrice.Enabled = false;
            this.TextBoxPrice.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPrice.Hint = "Цена";
            this.TextBoxPrice.Location = new System.Drawing.Point(15, 188);
            this.TextBoxPrice.MaxLength = 10;
            this.TextBoxPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxPrice.Multiline = false;
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(148, 50);
            this.TextBoxPrice.TabIndex = 14;
            this.TextBoxPrice.Text = "";
            // 
            // TextBoxName
            // 
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxName.Depth = 0;
            this.TextBoxName.Enabled = false;
            this.TextBoxName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxName.Hint = "Название лекарства";
            this.TextBoxName.Location = new System.Drawing.Point(15, 132);
            this.TextBoxName.MaxLength = 50;
            this.TextBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxName.Multiline = false;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(448, 50);
            this.TextBoxName.TabIndex = 13;
            this.TextBoxName.Text = "";
            // 
            // NumericId
            // 
            this.NumericId.Location = new System.Drawing.Point(15, 100);
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
            this.NumericId.TabIndex = 25;
            this.NumericId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LabelId
            // 
            this.LabelId.Depth = 0;
            this.LabelId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelId.Location = new System.Drawing.Point(15, 78);
            this.LabelId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(120, 20);
            this.LabelId.TabIndex = 26;
            this.LabelId.Text = "ID лекарства";
            this.LabelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ButtonAcceptId.Location = new System.Drawing.Point(83, 100);
            this.ButtonAcceptId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAcceptId.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAcceptId.Name = "ButtonAcceptId";
            this.ButtonAcceptId.Size = new System.Drawing.Size(52, 23);
            this.ButtonAcceptId.TabIndex = 27;
            this.ButtonAcceptId.Text = "ОК";
            this.ButtonAcceptId.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAcceptId.UseAccentColor = false;
            this.ButtonAcceptId.UseVisualStyleBackColor = true;
            this.ButtonAcceptId.Click += new System.EventHandler(this.ButtonAcceptId_Click);
            // 
            // LabelStatusId
            // 
            this.LabelStatusId.Depth = 0;
            this.LabelStatusId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelStatusId.Location = new System.Drawing.Point(157, 78);
            this.LabelStatusId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelStatusId.Name = "LabelStatusId";
            this.LabelStatusId.Size = new System.Drawing.Size(95, 20);
            this.LabelStatusId.TabIndex = 28;
            this.LabelStatusId.Text = "Статус ID";
            this.LabelStatusId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxStatusId
            // 
            this.TextBoxStatusId.ForeColor = System.Drawing.Color.Red;
            this.TextBoxStatusId.Location = new System.Drawing.Point(157, 100);
            this.TextBoxStatusId.Name = "TextBoxStatusId";
            this.TextBoxStatusId.Size = new System.Drawing.Size(95, 23);
            this.TextBoxStatusId.TabIndex = 29;
            this.TextBoxStatusId.Text = "Не выбрано";
            this.TextBoxStatusId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.ButtonUpdate.Location = new System.Drawing.Point(271, 78);
            this.ButtonUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(192, 45);
            this.ButtonUpdate.TabIndex = 30;
            this.ButtonUpdate.Text = "Изменить";
            this.ButtonUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonUpdate.UseAccentColor = false;
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // UpdateMedications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 469);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.TextBoxStatusId);
            this.Controls.Add(this.LabelStatusId);
            this.Controls.Add(this.ButtonAcceptId);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.NumericId);
            this.Controls.Add(this.TextBoxMixableList);
            this.Controls.Add(this.CheckBoxFilterTime);
            this.Controls.Add(this.TextBoxFiltrationTime);
            this.Controls.Add(this.CheckBoxPrepTime);
            this.Controls.Add(this.TextBoxPrepTime);
            this.Controls.Add(this.ComboBoxManufType);
            this.Controls.Add(this.ComboBoxUsesType);
            this.Controls.Add(this.ComboBoxMedType);
            this.Controls.Add(this.TextBoxVolume);
            this.Controls.Add(this.TextBoxQuantity);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.TextBoxName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateMedications";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение лекарства";
            ((System.ComponentModel.ISupportInitialize)(this.NumericId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TextBoxMixableList;
        private MaterialSkin.Controls.MaterialCheckbox CheckBoxFilterTime;
        private MaterialSkin.Controls.MaterialTextBox TextBoxFiltrationTime;
        private MaterialSkin.Controls.MaterialCheckbox CheckBoxPrepTime;
        private MaterialSkin.Controls.MaterialTextBox TextBoxPrepTime;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxManufType;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxUsesType;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxMedType;
        private MaterialSkin.Controls.MaterialTextBox TextBoxVolume;
        private MaterialSkin.Controls.MaterialTextBox TextBoxQuantity;
        private MaterialSkin.Controls.MaterialTextBox TextBoxPrice;
        private MaterialSkin.Controls.MaterialTextBox TextBoxName;
        private System.Windows.Forms.NumericUpDown NumericId;
        private MaterialSkin.Controls.MaterialLabel LabelId;
        private MaterialSkin.Controls.MaterialButton ButtonAcceptId;
        private MaterialSkin.Controls.MaterialLabel LabelStatusId;
        private System.Windows.Forms.TextBox TextBoxStatusId;
        private MaterialSkin.Controls.MaterialButton ButtonUpdate;
    }
}