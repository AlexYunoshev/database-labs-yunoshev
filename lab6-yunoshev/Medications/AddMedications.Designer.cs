
namespace lab6_yunoshev.Medications
{
    partial class AddMedications
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
            this.TextBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxVolume = new MaterialSkin.Controls.MaterialTextBox();
            this.ComboBoxMedType = new MaterialSkin.Controls.MaterialComboBox();
            this.ComboBoxUsesType = new MaterialSkin.Controls.MaterialComboBox();
            this.ComboBoxManufType = new MaterialSkin.Controls.MaterialComboBox();
            this.TextBoxPrepTime = new MaterialSkin.Controls.MaterialTextBox();
            this.CheckBoxPrepTime = new MaterialSkin.Controls.MaterialCheckbox();
            this.CheckBoxFilterTime = new MaterialSkin.Controls.MaterialCheckbox();
            this.TextBoxFiltrationTime = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxMixableList = new MaterialSkin.Controls.MaterialTextBox();
            this.ButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.ButtonReset = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxName.Depth = 0;
            this.TextBoxName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxName.Hint = "Название лекарства";
            this.TextBoxName.Location = new System.Drawing.Point(6, 78);
            this.TextBoxName.MaxLength = 50;
            this.TextBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxName.Multiline = false;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(448, 50);
            this.TextBoxName.TabIndex = 0;
            this.TextBoxName.Text = "";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPrice.Depth = 0;
            this.TextBoxPrice.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPrice.Hint = "Цена";
            this.TextBoxPrice.Location = new System.Drawing.Point(6, 134);
            this.TextBoxPrice.MaxLength = 10;
            this.TextBoxPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxPrice.Multiline = false;
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(148, 50);
            this.TextBoxPrice.TabIndex = 1;
            this.TextBoxPrice.Text = "";
            // 
            // TextBoxQuantity
            // 
            this.TextBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxQuantity.Depth = 0;
            this.TextBoxQuantity.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxQuantity.Hint = "Количество";
            this.TextBoxQuantity.Location = new System.Drawing.Point(160, 134);
            this.TextBoxQuantity.MaxLength = 10;
            this.TextBoxQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxQuantity.Multiline = false;
            this.TextBoxQuantity.Name = "TextBoxQuantity";
            this.TextBoxQuantity.Size = new System.Drawing.Size(143, 50);
            this.TextBoxQuantity.TabIndex = 2;
            this.TextBoxQuantity.Text = "";
            // 
            // TextBoxVolume
            // 
            this.TextBoxVolume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxVolume.Depth = 0;
            this.TextBoxVolume.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxVolume.Hint = "Объем";
            this.TextBoxVolume.Location = new System.Drawing.Point(309, 134);
            this.TextBoxVolume.MaxLength = 10;
            this.TextBoxVolume.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxVolume.Multiline = false;
            this.TextBoxVolume.Name = "TextBoxVolume";
            this.TextBoxVolume.Size = new System.Drawing.Size(145, 50);
            this.TextBoxVolume.TabIndex = 3;
            this.TextBoxVolume.Text = "";
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
            this.ComboBoxMedType.Location = new System.Drawing.Point(6, 190);
            this.ComboBoxMedType.MaxDropDownItems = 4;
            this.ComboBoxMedType.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxMedType.Name = "ComboBoxMedType";
            this.ComboBoxMedType.Size = new System.Drawing.Size(148, 49);
            this.ComboBoxMedType.StartIndex = -1;
            this.ComboBoxMedType.TabIndex = 4;
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
            this.ComboBoxUsesType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxUsesType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxUsesType.FormattingEnabled = true;
            this.ComboBoxUsesType.Hint = "Применение";
            this.ComboBoxUsesType.IntegralHeight = false;
            this.ComboBoxUsesType.ItemHeight = 43;
            this.ComboBoxUsesType.Items.AddRange(new object[] {
            "Внутреннее",
            "Наружное"});
            this.ComboBoxUsesType.Location = new System.Drawing.Point(160, 190);
            this.ComboBoxUsesType.MaxDropDownItems = 4;
            this.ComboBoxUsesType.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxUsesType.Name = "ComboBoxUsesType";
            this.ComboBoxUsesType.Size = new System.Drawing.Size(143, 49);
            this.ComboBoxUsesType.StartIndex = -1;
            this.ComboBoxUsesType.TabIndex = 5;
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
            this.ComboBoxManufType.Location = new System.Drawing.Point(309, 190);
            this.ComboBoxManufType.MaxDropDownItems = 4;
            this.ComboBoxManufType.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxManufType.Name = "ComboBoxManufType";
            this.ComboBoxManufType.Size = new System.Drawing.Size(145, 49);
            this.ComboBoxManufType.StartIndex = -1;
            this.ComboBoxManufType.TabIndex = 6;
            this.ComboBoxManufType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxManufType_SelectedIndexChanged);
            // 
            // TextBoxPrepTime
            // 
            this.TextBoxPrepTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPrepTime.Depth = 0;
            this.TextBoxPrepTime.Enabled = false;
            this.TextBoxPrepTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPrepTime.Hint = "ЧЧ:ММ:СС";
            this.TextBoxPrepTime.Location = new System.Drawing.Point(6, 286);
            this.TextBoxPrepTime.MaxLength = 8;
            this.TextBoxPrepTime.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxPrepTime.Multiline = false;
            this.TextBoxPrepTime.Name = "TextBoxPrepTime";
            this.TextBoxPrepTime.Size = new System.Drawing.Size(200, 50);
            this.TextBoxPrepTime.TabIndex = 8;
            this.TextBoxPrepTime.Text = "";
            // 
            // CheckBoxPrepTime
            // 
            this.CheckBoxPrepTime.AutoSize = true;
            this.CheckBoxPrepTime.Depth = 0;
            this.CheckBoxPrepTime.Location = new System.Drawing.Point(6, 246);
            this.CheckBoxPrepTime.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxPrepTime.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxPrepTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxPrepTime.Name = "CheckBoxPrepTime";
            this.CheckBoxPrepTime.Ripple = true;
            this.CheckBoxPrepTime.Size = new System.Drawing.Size(200, 37);
            this.CheckBoxPrepTime.TabIndex = 9;
            this.CheckBoxPrepTime.Text = "Время приготовления";
            this.CheckBoxPrepTime.UseVisualStyleBackColor = true;
            this.CheckBoxPrepTime.CheckedChanged += new System.EventHandler(this.CheckBoxPrepTime_CheckedChanged);
            // 
            // CheckBoxFilterTime
            // 
            this.CheckBoxFilterTime.AutoSize = true;
            this.CheckBoxFilterTime.Depth = 0;
            this.CheckBoxFilterTime.Location = new System.Drawing.Point(238, 245);
            this.CheckBoxFilterTime.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxFilterTime.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxFilterTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxFilterTime.Name = "CheckBoxFilterTime";
            this.CheckBoxFilterTime.Ripple = true;
            this.CheckBoxFilterTime.Size = new System.Drawing.Size(179, 37);
            this.CheckBoxFilterTime.TabIndex = 11;
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
            this.TextBoxFiltrationTime.Location = new System.Drawing.Point(245, 285);
            this.TextBoxFiltrationTime.MaxLength = 8;
            this.TextBoxFiltrationTime.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxFiltrationTime.Multiline = false;
            this.TextBoxFiltrationTime.Name = "TextBoxFiltrationTime";
            this.TextBoxFiltrationTime.Size = new System.Drawing.Size(172, 50);
            this.TextBoxFiltrationTime.TabIndex = 10;
            this.TextBoxFiltrationTime.Text = "";
            // 
            // TextBoxMixableList
            // 
            this.TextBoxMixableList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMixableList.Depth = 0;
            this.TextBoxMixableList.Enabled = false;
            this.TextBoxMixableList.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxMixableList.Hint = "Список смешиваемых компонентов";
            this.TextBoxMixableList.Location = new System.Drawing.Point(6, 352);
            this.TextBoxMixableList.MaxLength = 254;
            this.TextBoxMixableList.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxMixableList.Multiline = false;
            this.TextBoxMixableList.Name = "TextBoxMixableList";
            this.TextBoxMixableList.Size = new System.Drawing.Size(448, 50);
            this.TextBoxMixableList.TabIndex = 12;
            this.TextBoxMixableList.Text = "";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.AutoSize = false;
            this.ButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAdd.Depth = 0;
            this.ButtonAdd.DrawShadows = true;
            this.ButtonAdd.HighEmphasis = true;
            this.ButtonAdd.Icon = null;
            this.ButtonAdd.Location = new System.Drawing.Point(7, 411);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(221, 36);
            this.ButtonAdd.TabIndex = 13;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAdd.UseAccentColor = false;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.AutoSize = false;
            this.ButtonReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonReset.Depth = 0;
            this.ButtonReset.DrawShadows = true;
            this.ButtonReset.HighEmphasis = true;
            this.ButtonReset.Icon = null;
            this.ButtonReset.Location = new System.Drawing.Point(238, 411);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(215, 36);
            this.ButtonReset.TabIndex = 14;
            this.ButtonReset.Text = "Сбросить всё";
            this.ButtonReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonReset.UseAccentColor = false;
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // AddMedications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 459);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonAdd);
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
            this.Name = "AddMedications";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление лекарства";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TextBoxName;
        private MaterialSkin.Controls.MaterialTextBox TextBoxPrice;
        private MaterialSkin.Controls.MaterialTextBox TextBoxQuantity;
        private MaterialSkin.Controls.MaterialTextBox TextBoxVolume;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxMedType;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxUsesType;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxManufType;
        private MaterialSkin.Controls.MaterialTextBox TextBoxPrepTime;
        private MaterialSkin.Controls.MaterialCheckbox CheckBoxPrepTime;
        private MaterialSkin.Controls.MaterialCheckbox CheckBoxFilterTime;
        private MaterialSkin.Controls.MaterialTextBox TextBoxFiltrationTime;
        private MaterialSkin.Controls.MaterialTextBox TextBoxMixableList;
        private MaterialSkin.Controls.MaterialButton ButtonAdd;
        private MaterialSkin.Controls.MaterialButton ButtonReset;
    }
}