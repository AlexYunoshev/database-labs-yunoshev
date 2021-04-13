
namespace lab6_yunoshev
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageMedications = new System.Windows.Forms.TabPage();
            this.ButtonEditMedication = new MaterialSkin.Controls.MaterialButton();
            this.ButtonDeleteMedication = new MaterialSkin.Controls.MaterialButton();
            this.ButtonAddMedication = new MaterialSkin.Controls.MaterialButton();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.LabelSearch = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.ComboBoxSort = new MaterialSkin.Controls.MaterialComboBox();
            this.ListViewMedications = new MaterialSkin.Controls.MaterialListView();
            this.columnId = new System.Windows.Forms.ColumnHeader();
            this.columnMedicationsName = new System.Windows.Forms.ColumnHeader();
            this.columnPrice = new System.Windows.Forms.ColumnHeader();
            this.columnQuantity = new System.Windows.Forms.ColumnHeader();
            this.columnVolume = new System.Windows.Forms.ColumnHeader();
            this.columnMedicationsType = new System.Windows.Forms.ColumnHeader();
            this.columnUsesType = new System.Windows.Forms.ColumnHeader();
            this.columnManufactureType = new System.Windows.Forms.ColumnHeader();
            this.columnPreparationTime = new System.Windows.Forms.ColumnHeader();
            this.columnFiltrationTime = new System.Windows.Forms.ColumnHeader();
            this.columnMixableList = new System.Windows.Forms.ColumnHeader();
            this.tabPageStorehouse = new System.Windows.Forms.TabPage();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.tabPagePatients = new System.Windows.Forms.TabPage();
            this.tabPageDiagnoses = new System.Windows.Forms.TabPage();
            this.tabPagePrescriptons = new System.Windows.Forms.TabPage();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabPageInformation = new System.Windows.Forms.TabPage();
            this.imageListIconsMenu = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPageMedications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageMedications);
            this.materialTabControl1.Controls.Add(this.tabPageStorehouse);
            this.materialTabControl1.Controls.Add(this.tabPageInventory);
            this.materialTabControl1.Controls.Add(this.tabPagePatients);
            this.materialTabControl1.Controls.Add(this.tabPageDiagnoses);
            this.materialTabControl1.Controls.Add(this.tabPagePrescriptons);
            this.materialTabControl1.Controls.Add(this.tabPageOrders);
            this.materialTabControl1.Controls.Add(this.tabPageSettings);
            this.materialTabControl1.Controls.Add(this.tabPageInformation);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageListIconsMenu;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 3);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1274, 714);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPageMedications
            // 
            this.tabPageMedications.BackColor = System.Drawing.Color.DimGray;
            this.tabPageMedications.Controls.Add(this.ButtonEditMedication);
            this.tabPageMedications.Controls.Add(this.ButtonDeleteMedication);
            this.tabPageMedications.Controls.Add(this.ButtonAddMedication);
            this.tabPageMedications.Controls.Add(this.pictureBoxSearch);
            this.tabPageMedications.Controls.Add(this.LabelSearch);
            this.tabPageMedications.Controls.Add(this.TextBoxSearch);
            this.tabPageMedications.Controls.Add(this.ComboBoxSort);
            this.tabPageMedications.Controls.Add(this.ListViewMedications);
            this.tabPageMedications.ImageKey = "medications.png";
            this.tabPageMedications.Location = new System.Drawing.Point(4, 39);
            this.tabPageMedications.Name = "tabPageMedications";
            this.tabPageMedications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedications.Size = new System.Drawing.Size(1266, 671);
            this.tabPageMedications.TabIndex = 0;
            this.tabPageMedications.Text = "Лекарства";
            // 
            // ButtonEditMedication
            // 
            this.ButtonEditMedication.AutoSize = false;
            this.ButtonEditMedication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonEditMedication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEditMedication.Depth = 0;
            this.ButtonEditMedication.DrawShadows = true;
            this.ButtonEditMedication.HighEmphasis = true;
            this.ButtonEditMedication.Icon = null;
            this.ButtonEditMedication.Location = new System.Drawing.Point(1030, 5);
            this.ButtonEditMedication.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonEditMedication.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonEditMedication.Name = "ButtonEditMedication";
            this.ButtonEditMedication.Size = new System.Drawing.Size(175, 35);
            this.ButtonEditMedication.TabIndex = 7;
            this.ButtonEditMedication.Text = "Изменить лекарство";
            this.ButtonEditMedication.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonEditMedication.UseAccentColor = false;
            this.ButtonEditMedication.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteMedication
            // 
            this.ButtonDeleteMedication.AutoSize = false;
            this.ButtonDeleteMedication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDeleteMedication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDeleteMedication.Depth = 0;
            this.ButtonDeleteMedication.DrawShadows = true;
            this.ButtonDeleteMedication.HighEmphasis = true;
            this.ButtonDeleteMedication.Icon = null;
            this.ButtonDeleteMedication.Location = new System.Drawing.Point(840, 5);
            this.ButtonDeleteMedication.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonDeleteMedication.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonDeleteMedication.Name = "ButtonDeleteMedication";
            this.ButtonDeleteMedication.Size = new System.Drawing.Size(175, 35);
            this.ButtonDeleteMedication.TabIndex = 6;
            this.ButtonDeleteMedication.Text = "Удалить лекарство";
            this.ButtonDeleteMedication.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonDeleteMedication.UseAccentColor = false;
            this.ButtonDeleteMedication.UseVisualStyleBackColor = true;
            // 
            // ButtonAddMedication
            // 
            this.ButtonAddMedication.AutoSize = false;
            this.ButtonAddMedication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAddMedication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddMedication.Depth = 0;
            this.ButtonAddMedication.DrawShadows = true;
            this.ButtonAddMedication.HighEmphasis = true;
            this.ButtonAddMedication.Icon = null;
            this.ButtonAddMedication.Location = new System.Drawing.Point(650, 5);
            this.ButtonAddMedication.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAddMedication.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAddMedication.Name = "ButtonAddMedication";
            this.ButtonAddMedication.Size = new System.Drawing.Size(175, 35);
            this.ButtonAddMedication.TabIndex = 5;
            this.ButtonAddMedication.Text = "Добавить лекарство";
            this.ButtonAddMedication.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAddMedication.UseAccentColor = false;
            this.ButtonAddMedication.UseVisualStyleBackColor = true;
            this.ButtonAddMedication.Click += new System.EventHandler(this.ButtonAddMedication_Click);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSearch.Image = global::lab6_yunoshev.Properties.Resources.search;
            this.pictureBoxSearch.Location = new System.Drawing.Point(600, 6);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 4;
            this.pictureBoxSearch.TabStop = false;
            // 
            // LabelSearch
            // 
            this.LabelSearch.Depth = 0;
            this.LabelSearch.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelSearch.Location = new System.Drawing.Point(200, 6);
            this.LabelSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(50, 36);
            this.LabelSearch.TabIndex = 3;
            this.LabelSearch.Text = "Найти:";
            this.LabelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.Depth = 0;
            this.TextBoxSearch.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxSearch.Location = new System.Drawing.Point(255, 6);
            this.TextBoxSearch.MaxLength = 50;
            this.TextBoxSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxSearch.Multiline = false;
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(339, 36);
            this.TextBoxSearch.TabIndex = 2;
            this.TextBoxSearch.Text = "";
            this.TextBoxSearch.UseTallSize = false;
            // 
            // ComboBoxSort
            // 
            this.ComboBoxSort.AutoResize = false;
            this.ComboBoxSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxSort.Depth = 0;
            this.ComboBoxSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxSort.DropDownHeight = 118;
            this.ComboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSort.DropDownWidth = 121;
            this.ComboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxSort.FormattingEnabled = true;
            this.ComboBoxSort.IntegralHeight = false;
            this.ComboBoxSort.ItemHeight = 29;
            this.ComboBoxSort.Items.AddRange(new object[] {
            "Без сортировки",
            "id ↑",
            "id ↓",
            "Название ↑",
            "Название ↓"});
            this.ComboBoxSort.Location = new System.Drawing.Point(3, 6);
            this.ComboBoxSort.MaxDropDownItems = 4;
            this.ComboBoxSort.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxSort.Name = "ComboBoxSort";
            this.ComboBoxSort.Size = new System.Drawing.Size(182, 35);
            this.ComboBoxSort.StartIndex = 0;
            this.ComboBoxSort.TabIndex = 1;
            this.ComboBoxSort.UseTallSize = false;
            // 
            // ListViewMedications
            // 
            this.ListViewMedications.AutoSizeTable = false;
            this.ListViewMedications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListViewMedications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewMedications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnMedicationsName,
            this.columnPrice,
            this.columnQuantity,
            this.columnVolume,
            this.columnMedicationsType,
            this.columnUsesType,
            this.columnManufactureType,
            this.columnPreparationTime,
            this.columnFiltrationTime,
            this.columnMixableList});
            this.ListViewMedications.Depth = 0;
            this.ListViewMedications.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListViewMedications.FullRowSelect = true;
            this.ListViewMedications.HideSelection = false;
            this.ListViewMedications.Location = new System.Drawing.Point(3, 49);
            this.ListViewMedications.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListViewMedications.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewMedications.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewMedications.Name = "ListViewMedications";
            this.ListViewMedications.OwnerDraw = true;
            this.ListViewMedications.Size = new System.Drawing.Size(1260, 601);
            this.ListViewMedications.TabIndex = 0;
            this.ListViewMedications.UseCompatibleStateImageBehavior = false;
            this.ListViewMedications.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "id";
            // 
            // columnMedicationsName
            // 
            this.columnMedicationsName.Text = "Название лекарства";
            this.columnMedicationsName.Width = 180;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Цена";
            this.columnPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnPrice.Width = 100;
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Кол-во";
            this.columnQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnQuantity.Width = 80;
            // 
            // columnVolume
            // 
            this.columnVolume.Text = "Объем";
            this.columnVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnVolume.Width = 105;
            // 
            // columnMedicationsType
            // 
            this.columnMedicationsType.Text = "Тип лекарства";
            this.columnMedicationsType.Width = 150;
            // 
            // columnUsesType
            // 
            this.columnUsesType.Text = "Тип применения";
            this.columnUsesType.Width = 190;
            // 
            // columnManufactureType
            // 
            this.columnManufactureType.Text = "Тип изготовления";
            this.columnManufactureType.Width = 180;
            // 
            // columnPreparationTime
            // 
            this.columnPreparationTime.Text = "Время приготовления";
            this.columnPreparationTime.Width = 180;
            // 
            // columnFiltrationTime
            // 
            this.columnFiltrationTime.Text = "Время фильтрации";
            this.columnFiltrationTime.Width = 180;
            // 
            // columnMixableList
            // 
            this.columnMixableList.Text = "Список смешиваемых компонентов";
            this.columnMixableList.Width = 400;
            // 
            // tabPageStorehouse
            // 
            this.tabPageStorehouse.BackColor = System.Drawing.Color.White;
            this.tabPageStorehouse.ImageKey = "storehouse.png";
            this.tabPageStorehouse.Location = new System.Drawing.Point(4, 39);
            this.tabPageStorehouse.Name = "tabPageStorehouse";
            this.tabPageStorehouse.Size = new System.Drawing.Size(1266, 671);
            this.tabPageStorehouse.TabIndex = 4;
            this.tabPageStorehouse.Text = "Склад";
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.BackColor = System.Drawing.Color.White;
            this.tabPageInventory.ImageKey = "inventory.png";
            this.tabPageInventory.Location = new System.Drawing.Point(4, 39);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Size = new System.Drawing.Size(1266, 671);
            this.tabPageInventory.TabIndex = 6;
            this.tabPageInventory.Text = "Инвентаризация";
            // 
            // tabPagePatients
            // 
            this.tabPagePatients.BackColor = System.Drawing.Color.White;
            this.tabPagePatients.ImageKey = "patient.png";
            this.tabPagePatients.Location = new System.Drawing.Point(4, 39);
            this.tabPagePatients.Name = "tabPagePatients";
            this.tabPagePatients.Size = new System.Drawing.Size(1266, 671);
            this.tabPagePatients.TabIndex = 1;
            this.tabPagePatients.Text = "Пациенты";
            // 
            // tabPageDiagnoses
            // 
            this.tabPageDiagnoses.BackColor = System.Drawing.Color.White;
            this.tabPageDiagnoses.ImageKey = "diagnoses.png";
            this.tabPageDiagnoses.Location = new System.Drawing.Point(4, 39);
            this.tabPageDiagnoses.Name = "tabPageDiagnoses";
            this.tabPageDiagnoses.Size = new System.Drawing.Size(1266, 671);
            this.tabPageDiagnoses.TabIndex = 5;
            this.tabPageDiagnoses.Text = "Диагнозы";
            // 
            // tabPagePrescriptons
            // 
            this.tabPagePrescriptons.BackColor = System.Drawing.Color.White;
            this.tabPagePrescriptons.ImageKey = "prescription.png";
            this.tabPagePrescriptons.Location = new System.Drawing.Point(4, 39);
            this.tabPagePrescriptons.Name = "tabPagePrescriptons";
            this.tabPagePrescriptons.Size = new System.Drawing.Size(1266, 671);
            this.tabPagePrescriptons.TabIndex = 2;
            this.tabPagePrescriptons.Text = "Рецепты";
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.BackColor = System.Drawing.Color.White;
            this.tabPageOrders.ImageKey = "orders.png";
            this.tabPageOrders.Location = new System.Drawing.Point(4, 39);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Size = new System.Drawing.Size(1266, 671);
            this.tabPageOrders.TabIndex = 3;
            this.tabPageOrders.Text = "Заказы";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.White;
            this.tabPageSettings.ImageKey = "settings.png";
            this.tabPageSettings.Location = new System.Drawing.Point(4, 39);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(1266, 671);
            this.tabPageSettings.TabIndex = 7;
            this.tabPageSettings.Text = "Настройки";
            // 
            // tabPageInformation
            // 
            this.tabPageInformation.BackColor = System.Drawing.Color.White;
            this.tabPageInformation.ImageKey = "information.png";
            this.tabPageInformation.Location = new System.Drawing.Point(4, 39);
            this.tabPageInformation.Name = "tabPageInformation";
            this.tabPageInformation.Size = new System.Drawing.Size(1266, 671);
            this.tabPageInformation.TabIndex = 8;
            this.tabPageInformation.Text = "Информация";
            // 
            // imageListIconsMenu
            // 
            this.imageListIconsMenu.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListIconsMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIconsMenu.ImageStream")));
            this.imageListIconsMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIconsMenu.Images.SetKeyName(0, "medications.png");
            this.imageListIconsMenu.Images.SetKeyName(1, "orders.png");
            this.imageListIconsMenu.Images.SetKeyName(2, "prescription.png");
            this.imageListIconsMenu.Images.SetKeyName(3, "patient.png");
            this.imageListIconsMenu.Images.SetKeyName(4, "storehouse.png");
            this.imageListIconsMenu.Images.SetKeyName(5, "diagnoses.png");
            this.imageListIconsMenu.Images.SetKeyName(6, "inventory.png");
            this.imageListIconsMenu.Images.SetKeyName(7, "information.png");
            this.imageListIconsMenu.Images.SetKeyName(8, "settings.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аптека";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageMedications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageMedications;
        private System.Windows.Forms.ImageList imageListIconsMenu;
        private System.Windows.Forms.TabPage tabPagePatients;
        private System.Windows.Forms.TabPage tabPagePrescriptons;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageStorehouse;
        private System.Windows.Forms.TabPage tabPageDiagnoses;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageInformation;
        private MaterialSkin.Controls.MaterialListView ListViewMedications;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnMedicationsName;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnMedicationsType;
        private System.Windows.Forms.ColumnHeader columnUsesType;
        private System.Windows.Forms.ColumnHeader columnManufactureType;
        private System.Windows.Forms.ColumnHeader columnPreparationTime;
        private System.Windows.Forms.ColumnHeader columnFiltrationTime;
        private System.Windows.Forms.ColumnHeader columnMixableList;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxSort;
        private MaterialSkin.Controls.MaterialTextBox TextBoxSearch;
        private MaterialSkin.Controls.MaterialLabel LabelSearch;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private MaterialSkin.Controls.MaterialButton ButtonAddMedication;
        private MaterialSkin.Controls.MaterialButton ButtonDeleteMedication;
        private MaterialSkin.Controls.MaterialButton ButtonEditMedication;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.ColumnHeader columnVolume;
    }
}