
namespace lab7_yunoshev
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
                DBManager.ConnectedData.ConnectionClose();
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
            this.MainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageMedications = new System.Windows.Forms.TabPage();
            this.MedicationsButtonEdit = new MaterialSkin.Controls.MaterialButton();
            this.MedicationsButtonDelete = new MaterialSkin.Controls.MaterialButton();
            this.MedicationsButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.MedicationsLabelSearch = new MaterialSkin.Controls.MaterialLabel();
            this.MedicationsTextBoxSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.MedicationsComboBoxSort = new MaterialSkin.Controls.MaterialComboBox();
            this.MedicationsListView = new MaterialSkin.Controls.MaterialListView();
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
            this.StorehouseFButtonEdit = new MaterialSkin.Controls.MaterialButton();
            this.StorehouseFButtonDelete = new MaterialSkin.Controls.MaterialButton();
            this.StorehouseFButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.StorehouseFLabelSearch = new MaterialSkin.Controls.MaterialLabel();
            this.StorehouseFTextBoxSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.StorehouseFComboBoxSort = new MaterialSkin.Controls.MaterialComboBox();
            this.StorehouseFListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeaderId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMedicationsId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMedicationsName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderQuantity = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCriticalQuantity = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderManufactureDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderShelfDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderStorehouseRId = new System.Windows.Forms.ColumnHeader();
            this.tabPagePrescriptons = new System.Windows.Forms.TabPage();
            this.PrescriptionsButtonEdit = new MaterialSkin.Controls.MaterialButton();
            this.PrescriptionsButtonDelete = new MaterialSkin.Controls.MaterialButton();
            this.PrescriptionsButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.PrescriptionsLabelSearch = new MaterialSkin.Controls.MaterialLabel();
            this.PrescriptionsTextBoxSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.PrescriptionsComboBoxSort = new MaterialSkin.Controls.MaterialComboBox();
            this.PrescriptionsListView = new MaterialSkin.Controls.MaterialListView();
            this.headerPrescriptionsId = new System.Windows.Forms.ColumnHeader();
            this.headerPrescriptionsPatientId = new System.Windows.Forms.ColumnHeader();
            this.headerPrescriptionsPatientName = new System.Windows.Forms.ColumnHeader();
            this.headerPrescriptionsDoctorName = new System.Windows.Forms.ColumnHeader();
            this.headerPrescriptionsDoctorSignature = new System.Windows.Forms.ColumnHeader();
            this.headerPrescriptionsDoctorStamp = new System.Windows.Forms.ColumnHeader();
            this.headerPrescriptionsDiagnoses = new System.Windows.Forms.ColumnHeader();
            this.headerPrescriptionsMedications = new System.Windows.Forms.ColumnHeader();
            this.tabPageDiagnoses = new System.Windows.Forms.TabPage();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.tabPagePatients = new System.Windows.Forms.TabPage();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabPageInformation = new System.Windows.Forms.TabPage();
            this.imageListIconsMenu = new System.Windows.Forms.ImageList(this.components);
            this.MainTabControl.SuspendLayout();
            this.tabPageMedications.SuspendLayout();
            this.tabPageStorehouse.SuspendLayout();
            this.tabPagePrescriptons.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabPageMedications);
            this.MainTabControl.Controls.Add(this.tabPageStorehouse);
            this.MainTabControl.Controls.Add(this.tabPagePrescriptons);
            this.MainTabControl.Controls.Add(this.tabPageDiagnoses);
            this.MainTabControl.Controls.Add(this.tabPageInventory);
            this.MainTabControl.Controls.Add(this.tabPagePatients);
            this.MainTabControl.Controls.Add(this.tabPageOrders);
            this.MainTabControl.Controls.Add(this.tabPageSettings);
            this.MainTabControl.Controls.Add(this.tabPageInformation);
            this.MainTabControl.Depth = 0;
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.ImageList = this.imageListIconsMenu;
            this.MainTabControl.Location = new System.Drawing.Point(3, 3);
            this.MainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1274, 714);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // tabPageMedications
            // 
            this.tabPageMedications.BackColor = System.Drawing.Color.White;
            this.tabPageMedications.Controls.Add(this.MedicationsButtonEdit);
            this.tabPageMedications.Controls.Add(this.MedicationsButtonDelete);
            this.tabPageMedications.Controls.Add(this.MedicationsButtonAdd);
            this.tabPageMedications.Controls.Add(this.MedicationsLabelSearch);
            this.tabPageMedications.Controls.Add(this.MedicationsTextBoxSearch);
            this.tabPageMedications.Controls.Add(this.MedicationsComboBoxSort);
            this.tabPageMedications.Controls.Add(this.MedicationsListView);
            this.tabPageMedications.ImageKey = "medications.png";
            this.tabPageMedications.Location = new System.Drawing.Point(4, 39);
            this.tabPageMedications.Name = "tabPageMedications";
            this.tabPageMedications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedications.Size = new System.Drawing.Size(1266, 671);
            this.tabPageMedications.TabIndex = 0;
            this.tabPageMedications.Text = "Лекарства";
            // 
            // MedicationsButtonEdit
            // 
            this.MedicationsButtonEdit.AutoSize = false;
            this.MedicationsButtonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MedicationsButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MedicationsButtonEdit.Depth = 0;
            this.MedicationsButtonEdit.DrawShadows = true;
            this.MedicationsButtonEdit.HighEmphasis = true;
            this.MedicationsButtonEdit.Icon = null;
            this.MedicationsButtonEdit.Location = new System.Drawing.Point(1030, 5);
            this.MedicationsButtonEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MedicationsButtonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.MedicationsButtonEdit.Name = "MedicationsButtonEdit";
            this.MedicationsButtonEdit.Size = new System.Drawing.Size(175, 35);
            this.MedicationsButtonEdit.TabIndex = 7;
            this.MedicationsButtonEdit.Text = "Изменить лекарство";
            this.MedicationsButtonEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MedicationsButtonEdit.UseAccentColor = false;
            this.MedicationsButtonEdit.UseVisualStyleBackColor = true;
            this.MedicationsButtonEdit.Click += new System.EventHandler(this.MedicationButtonEdit_Click);
            // 
            // MedicationsButtonDelete
            // 
            this.MedicationsButtonDelete.AutoSize = false;
            this.MedicationsButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MedicationsButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MedicationsButtonDelete.Depth = 0;
            this.MedicationsButtonDelete.DrawShadows = true;
            this.MedicationsButtonDelete.HighEmphasis = true;
            this.MedicationsButtonDelete.Icon = null;
            this.MedicationsButtonDelete.Location = new System.Drawing.Point(840, 5);
            this.MedicationsButtonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MedicationsButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.MedicationsButtonDelete.Name = "MedicationsButtonDelete";
            this.MedicationsButtonDelete.Size = new System.Drawing.Size(175, 35);
            this.MedicationsButtonDelete.TabIndex = 6;
            this.MedicationsButtonDelete.Text = "Удалить лекарство";
            this.MedicationsButtonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MedicationsButtonDelete.UseAccentColor = false;
            this.MedicationsButtonDelete.UseVisualStyleBackColor = true;
            this.MedicationsButtonDelete.Click += new System.EventHandler(this.MedicationButtonDelete_Click);
            // 
            // MedicationsButtonAdd
            // 
            this.MedicationsButtonAdd.AutoSize = false;
            this.MedicationsButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MedicationsButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MedicationsButtonAdd.Depth = 0;
            this.MedicationsButtonAdd.DrawShadows = true;
            this.MedicationsButtonAdd.HighEmphasis = true;
            this.MedicationsButtonAdd.Icon = null;
            this.MedicationsButtonAdd.Location = new System.Drawing.Point(650, 5);
            this.MedicationsButtonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MedicationsButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.MedicationsButtonAdd.Name = "MedicationsButtonAdd";
            this.MedicationsButtonAdd.Size = new System.Drawing.Size(175, 35);
            this.MedicationsButtonAdd.TabIndex = 5;
            this.MedicationsButtonAdd.Text = "Добавить лекарство";
            this.MedicationsButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MedicationsButtonAdd.UseAccentColor = false;
            this.MedicationsButtonAdd.UseVisualStyleBackColor = true;
            this.MedicationsButtonAdd.Click += new System.EventHandler(this.MedicationButtonAdd_Click);
            // 
            // MedicationsLabelSearch
            // 
            this.MedicationsLabelSearch.Depth = 0;
            this.MedicationsLabelSearch.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MedicationsLabelSearch.Location = new System.Drawing.Point(200, 6);
            this.MedicationsLabelSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.MedicationsLabelSearch.Name = "MedicationsLabelSearch";
            this.MedicationsLabelSearch.Size = new System.Drawing.Size(50, 36);
            this.MedicationsLabelSearch.TabIndex = 3;
            this.MedicationsLabelSearch.Text = "Найти:";
            this.MedicationsLabelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedicationsTextBoxSearch
            // 
            this.MedicationsTextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedicationsTextBoxSearch.Depth = 0;
            this.MedicationsTextBoxSearch.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MedicationsTextBoxSearch.Hint = "Введите название лекарства";
            this.MedicationsTextBoxSearch.Location = new System.Drawing.Point(255, 6);
            this.MedicationsTextBoxSearch.MaxLength = 50;
            this.MedicationsTextBoxSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.MedicationsTextBoxSearch.Multiline = false;
            this.MedicationsTextBoxSearch.Name = "MedicationsTextBoxSearch";
            this.MedicationsTextBoxSearch.Size = new System.Drawing.Size(388, 36);
            this.MedicationsTextBoxSearch.TabIndex = 2;
            this.MedicationsTextBoxSearch.Text = "";
            this.MedicationsTextBoxSearch.UseTallSize = false;
            this.MedicationsTextBoxSearch.TextChanged += new System.EventHandler(this.MedicationsTextBoxSearch_TextChanged);
            // 
            // MedicationsComboBoxSort
            // 
            this.MedicationsComboBoxSort.AutoResize = false;
            this.MedicationsComboBoxSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MedicationsComboBoxSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MedicationsComboBoxSort.Depth = 0;
            this.MedicationsComboBoxSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MedicationsComboBoxSort.DropDownHeight = 118;
            this.MedicationsComboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MedicationsComboBoxSort.DropDownWidth = 121;
            this.MedicationsComboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.MedicationsComboBoxSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MedicationsComboBoxSort.FormattingEnabled = true;
            this.MedicationsComboBoxSort.IntegralHeight = false;
            this.MedicationsComboBoxSort.ItemHeight = 29;
            this.MedicationsComboBoxSort.Items.AddRange(new object[] {
            "Без сортировки",
            "id ↓",
            "Название ↑",
            "Название ↓"});
            this.MedicationsComboBoxSort.Location = new System.Drawing.Point(3, 6);
            this.MedicationsComboBoxSort.MaxDropDownItems = 4;
            this.MedicationsComboBoxSort.MouseState = MaterialSkin.MouseState.OUT;
            this.MedicationsComboBoxSort.Name = "MedicationsComboBoxSort";
            this.MedicationsComboBoxSort.Size = new System.Drawing.Size(182, 35);
            this.MedicationsComboBoxSort.StartIndex = 0;
            this.MedicationsComboBoxSort.TabIndex = 1;
            this.MedicationsComboBoxSort.UseTallSize = false;
            this.MedicationsComboBoxSort.SelectedIndexChanged += new System.EventHandler(this.MedicationsComboBoxSort_SelectedIndexChanged);
            // 
            // MedicationsListView
            // 
            this.MedicationsListView.AutoSizeTable = false;
            this.MedicationsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MedicationsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedicationsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.MedicationsListView.Depth = 0;
            this.MedicationsListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MedicationsListView.FullRowSelect = true;
            this.MedicationsListView.HideSelection = false;
            this.MedicationsListView.Location = new System.Drawing.Point(3, 49);
            this.MedicationsListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.MedicationsListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MedicationsListView.MouseState = MaterialSkin.MouseState.OUT;
            this.MedicationsListView.Name = "MedicationsListView";
            this.MedicationsListView.OwnerDraw = true;
            this.MedicationsListView.Size = new System.Drawing.Size(1260, 601);
            this.MedicationsListView.TabIndex = 0;
            this.MedicationsListView.UseCompatibleStateImageBehavior = false;
            this.MedicationsListView.View = System.Windows.Forms.View.Details;
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
            this.tabPageStorehouse.Controls.Add(this.StorehouseFButtonEdit);
            this.tabPageStorehouse.Controls.Add(this.StorehouseFButtonDelete);
            this.tabPageStorehouse.Controls.Add(this.StorehouseFButtonAdd);
            this.tabPageStorehouse.Controls.Add(this.StorehouseFLabelSearch);
            this.tabPageStorehouse.Controls.Add(this.StorehouseFTextBoxSearch);
            this.tabPageStorehouse.Controls.Add(this.StorehouseFComboBoxSort);
            this.tabPageStorehouse.Controls.Add(this.StorehouseFListView);
            this.tabPageStorehouse.ImageKey = "storehouse.png";
            this.tabPageStorehouse.Location = new System.Drawing.Point(4, 39);
            this.tabPageStorehouse.Name = "tabPageStorehouse";
            this.tabPageStorehouse.Size = new System.Drawing.Size(1266, 671);
            this.tabPageStorehouse.TabIndex = 4;
            this.tabPageStorehouse.Text = "Склад";
            // 
            // StorehouseFButtonEdit
            // 
            this.StorehouseFButtonEdit.AutoSize = false;
            this.StorehouseFButtonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StorehouseFButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StorehouseFButtonEdit.Depth = 0;
            this.StorehouseFButtonEdit.DrawShadows = true;
            this.StorehouseFButtonEdit.HighEmphasis = true;
            this.StorehouseFButtonEdit.Icon = null;
            this.StorehouseFButtonEdit.Location = new System.Drawing.Point(1030, 5);
            this.StorehouseFButtonEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StorehouseFButtonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.StorehouseFButtonEdit.Name = "StorehouseFButtonEdit";
            this.StorehouseFButtonEdit.Size = new System.Drawing.Size(175, 35);
            this.StorehouseFButtonEdit.TabIndex = 14;
            this.StorehouseFButtonEdit.Text = "Изменить запись";
            this.StorehouseFButtonEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StorehouseFButtonEdit.UseAccentColor = false;
            this.StorehouseFButtonEdit.UseVisualStyleBackColor = true;
            this.StorehouseFButtonEdit.Click += new System.EventHandler(this.StorehouseFButtonEdit_Click);
            // 
            // StorehouseFButtonDelete
            // 
            this.StorehouseFButtonDelete.AutoSize = false;
            this.StorehouseFButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StorehouseFButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StorehouseFButtonDelete.Depth = 0;
            this.StorehouseFButtonDelete.DrawShadows = true;
            this.StorehouseFButtonDelete.HighEmphasis = true;
            this.StorehouseFButtonDelete.Icon = null;
            this.StorehouseFButtonDelete.Location = new System.Drawing.Point(840, 5);
            this.StorehouseFButtonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StorehouseFButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.StorehouseFButtonDelete.Name = "StorehouseFButtonDelete";
            this.StorehouseFButtonDelete.Size = new System.Drawing.Size(175, 35);
            this.StorehouseFButtonDelete.TabIndex = 13;
            this.StorehouseFButtonDelete.Text = "Удалить запись";
            this.StorehouseFButtonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StorehouseFButtonDelete.UseAccentColor = false;
            this.StorehouseFButtonDelete.UseVisualStyleBackColor = true;
            this.StorehouseFButtonDelete.Click += new System.EventHandler(this.StorehouseFButtonDelete_Click);
            // 
            // StorehouseFButtonAdd
            // 
            this.StorehouseFButtonAdd.AutoSize = false;
            this.StorehouseFButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StorehouseFButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StorehouseFButtonAdd.Depth = 0;
            this.StorehouseFButtonAdd.DrawShadows = true;
            this.StorehouseFButtonAdd.HighEmphasis = true;
            this.StorehouseFButtonAdd.Icon = null;
            this.StorehouseFButtonAdd.Location = new System.Drawing.Point(650, 5);
            this.StorehouseFButtonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StorehouseFButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.StorehouseFButtonAdd.Name = "StorehouseFButtonAdd";
            this.StorehouseFButtonAdd.Size = new System.Drawing.Size(175, 35);
            this.StorehouseFButtonAdd.TabIndex = 12;
            this.StorehouseFButtonAdd.Text = "Добавить запись";
            this.StorehouseFButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StorehouseFButtonAdd.UseAccentColor = false;
            this.StorehouseFButtonAdd.UseVisualStyleBackColor = true;
            this.StorehouseFButtonAdd.Click += new System.EventHandler(this.StorehouseFButtonAdd_Click);
            // 
            // StorehouseFLabelSearch
            // 
            this.StorehouseFLabelSearch.Depth = 0;
            this.StorehouseFLabelSearch.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StorehouseFLabelSearch.Location = new System.Drawing.Point(200, 6);
            this.StorehouseFLabelSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.StorehouseFLabelSearch.Name = "StorehouseFLabelSearch";
            this.StorehouseFLabelSearch.Size = new System.Drawing.Size(50, 36);
            this.StorehouseFLabelSearch.TabIndex = 11;
            this.StorehouseFLabelSearch.Text = "Найти:";
            this.StorehouseFLabelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StorehouseFTextBoxSearch
            // 
            this.StorehouseFTextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StorehouseFTextBoxSearch.Depth = 0;
            this.StorehouseFTextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StorehouseFTextBoxSearch.Hint = "Введите название лекарства";
            this.StorehouseFTextBoxSearch.Location = new System.Drawing.Point(255, 6);
            this.StorehouseFTextBoxSearch.MaxLength = 50;
            this.StorehouseFTextBoxSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.StorehouseFTextBoxSearch.Multiline = false;
            this.StorehouseFTextBoxSearch.Name = "StorehouseFTextBoxSearch";
            this.StorehouseFTextBoxSearch.Size = new System.Drawing.Size(388, 36);
            this.StorehouseFTextBoxSearch.TabIndex = 10;
            this.StorehouseFTextBoxSearch.Text = "";
            this.StorehouseFTextBoxSearch.UseTallSize = false;
            this.StorehouseFTextBoxSearch.TextChanged += new System.EventHandler(this.StorehouseFTextBoxSearch_TextChanged);
            // 
            // StorehouseFComboBoxSort
            // 
            this.StorehouseFComboBoxSort.AutoResize = false;
            this.StorehouseFComboBoxSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StorehouseFComboBoxSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StorehouseFComboBoxSort.Depth = 0;
            this.StorehouseFComboBoxSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.StorehouseFComboBoxSort.DropDownHeight = 118;
            this.StorehouseFComboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StorehouseFComboBoxSort.DropDownWidth = 121;
            this.StorehouseFComboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.StorehouseFComboBoxSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StorehouseFComboBoxSort.FormattingEnabled = true;
            this.StorehouseFComboBoxSort.IntegralHeight = false;
            this.StorehouseFComboBoxSort.ItemHeight = 29;
            this.StorehouseFComboBoxSort.Items.AddRange(new object[] {
            "Без сортировки",
            "id ↓",
            "Название ↑",
            "Название ↓"});
            this.StorehouseFComboBoxSort.Location = new System.Drawing.Point(3, 6);
            this.StorehouseFComboBoxSort.MaxDropDownItems = 4;
            this.StorehouseFComboBoxSort.MouseState = MaterialSkin.MouseState.OUT;
            this.StorehouseFComboBoxSort.Name = "StorehouseFComboBoxSort";
            this.StorehouseFComboBoxSort.Size = new System.Drawing.Size(182, 35);
            this.StorehouseFComboBoxSort.StartIndex = 0;
            this.StorehouseFComboBoxSort.TabIndex = 9;
            this.StorehouseFComboBoxSort.UseTallSize = false;
            this.StorehouseFComboBoxSort.SelectedIndexChanged += new System.EventHandler(this.StorehouseFComboBoxSort_SelectedIndexChanged);
            // 
            // StorehouseFListView
            // 
            this.StorehouseFListView.AutoSizeTable = false;
            this.StorehouseFListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StorehouseFListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StorehouseFListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderMedicationsId,
            this.columnHeaderMedicationsName,
            this.columnHeaderQuantity,
            this.columnHeaderCriticalQuantity,
            this.columnHeaderManufactureDate,
            this.columnHeaderShelfDate,
            this.columnHeaderStorehouseRId});
            this.StorehouseFListView.Depth = 0;
            this.StorehouseFListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StorehouseFListView.FullRowSelect = true;
            this.StorehouseFListView.HideSelection = false;
            this.StorehouseFListView.Location = new System.Drawing.Point(3, 49);
            this.StorehouseFListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.StorehouseFListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.StorehouseFListView.MouseState = MaterialSkin.MouseState.OUT;
            this.StorehouseFListView.Name = "StorehouseFListView";
            this.StorehouseFListView.OwnerDraw = true;
            this.StorehouseFListView.Size = new System.Drawing.Size(1260, 601);
            this.StorehouseFListView.TabIndex = 8;
            this.StorehouseFListView.UseCompatibleStateImageBehavior = false;
            this.StorehouseFListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "id";
            // 
            // columnHeaderMedicationsId
            // 
            this.columnHeaderMedicationsId.Text = "id лекарства";
            this.columnHeaderMedicationsId.Width = 120;
            // 
            // columnHeaderMedicationsName
            // 
            this.columnHeaderMedicationsName.Text = "Название лекарства";
            this.columnHeaderMedicationsName.Width = 170;
            // 
            // columnHeaderQuantity
            // 
            this.columnHeaderQuantity.Text = "Кол-во";
            this.columnHeaderQuantity.Width = 80;
            // 
            // columnHeaderCriticalQuantity
            // 
            this.columnHeaderCriticalQuantity.Text = "Критическое кол-во";
            this.columnHeaderCriticalQuantity.Width = 170;
            // 
            // columnHeaderManufactureDate
            // 
            this.columnHeaderManufactureDate.Text = "Дата изготовления";
            this.columnHeaderManufactureDate.Width = 160;
            // 
            // columnHeaderShelfDate
            // 
            this.columnHeaderShelfDate.Text = "Употребить до";
            this.columnHeaderShelfDate.Width = 160;
            // 
            // columnHeaderStorehouseRId
            // 
            this.columnHeaderStorehouseRId.Text = "id запроса на склад";
            this.columnHeaderStorehouseRId.Width = 165;
            // 
            // tabPagePrescriptons
            // 
            this.tabPagePrescriptons.BackColor = System.Drawing.Color.White;
            this.tabPagePrescriptons.Controls.Add(this.PrescriptionsButtonEdit);
            this.tabPagePrescriptons.Controls.Add(this.PrescriptionsButtonDelete);
            this.tabPagePrescriptons.Controls.Add(this.PrescriptionsButtonAdd);
            this.tabPagePrescriptons.Controls.Add(this.PrescriptionsLabelSearch);
            this.tabPagePrescriptons.Controls.Add(this.PrescriptionsTextBoxSearch);
            this.tabPagePrescriptons.Controls.Add(this.PrescriptionsComboBoxSort);
            this.tabPagePrescriptons.Controls.Add(this.PrescriptionsListView);
            this.tabPagePrescriptons.ImageKey = "prescription.png";
            this.tabPagePrescriptons.Location = new System.Drawing.Point(4, 39);
            this.tabPagePrescriptons.Name = "tabPagePrescriptons";
            this.tabPagePrescriptons.Size = new System.Drawing.Size(1266, 671);
            this.tabPagePrescriptons.TabIndex = 2;
            this.tabPagePrescriptons.Text = "Рецепты";
            // 
            // PrescriptionsButtonEdit
            // 
            this.PrescriptionsButtonEdit.AutoSize = false;
            this.PrescriptionsButtonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrescriptionsButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrescriptionsButtonEdit.Depth = 0;
            this.PrescriptionsButtonEdit.DrawShadows = true;
            this.PrescriptionsButtonEdit.HighEmphasis = true;
            this.PrescriptionsButtonEdit.Icon = null;
            this.PrescriptionsButtonEdit.Location = new System.Drawing.Point(1030, 5);
            this.PrescriptionsButtonEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PrescriptionsButtonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrescriptionsButtonEdit.Name = "PrescriptionsButtonEdit";
            this.PrescriptionsButtonEdit.Size = new System.Drawing.Size(175, 35);
            this.PrescriptionsButtonEdit.TabIndex = 21;
            this.PrescriptionsButtonEdit.Text = "Изменить рецепт";
            this.PrescriptionsButtonEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PrescriptionsButtonEdit.UseAccentColor = false;
            this.PrescriptionsButtonEdit.UseVisualStyleBackColor = true;
            this.PrescriptionsButtonEdit.Click += new System.EventHandler(this.PrescriptionsButtonEdit_Click);
            // 
            // PrescriptionsButtonDelete
            // 
            this.PrescriptionsButtonDelete.AutoSize = false;
            this.PrescriptionsButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrescriptionsButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrescriptionsButtonDelete.Depth = 0;
            this.PrescriptionsButtonDelete.DrawShadows = true;
            this.PrescriptionsButtonDelete.HighEmphasis = true;
            this.PrescriptionsButtonDelete.Icon = null;
            this.PrescriptionsButtonDelete.Location = new System.Drawing.Point(840, 5);
            this.PrescriptionsButtonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PrescriptionsButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrescriptionsButtonDelete.Name = "PrescriptionsButtonDelete";
            this.PrescriptionsButtonDelete.Size = new System.Drawing.Size(175, 35);
            this.PrescriptionsButtonDelete.TabIndex = 20;
            this.PrescriptionsButtonDelete.Text = "Удалить рецепт";
            this.PrescriptionsButtonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PrescriptionsButtonDelete.UseAccentColor = false;
            this.PrescriptionsButtonDelete.UseVisualStyleBackColor = true;
            this.PrescriptionsButtonDelete.Click += new System.EventHandler(this.PrescriptionsButtonDelete_Click);
            // 
            // PrescriptionsButtonAdd
            // 
            this.PrescriptionsButtonAdd.AutoSize = false;
            this.PrescriptionsButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrescriptionsButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrescriptionsButtonAdd.Depth = 0;
            this.PrescriptionsButtonAdd.DrawShadows = true;
            this.PrescriptionsButtonAdd.HighEmphasis = true;
            this.PrescriptionsButtonAdd.Icon = null;
            this.PrescriptionsButtonAdd.Location = new System.Drawing.Point(650, 5);
            this.PrescriptionsButtonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PrescriptionsButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrescriptionsButtonAdd.Name = "PrescriptionsButtonAdd";
            this.PrescriptionsButtonAdd.Size = new System.Drawing.Size(175, 35);
            this.PrescriptionsButtonAdd.TabIndex = 19;
            this.PrescriptionsButtonAdd.Text = "Добавить рецепт";
            this.PrescriptionsButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PrescriptionsButtonAdd.UseAccentColor = false;
            this.PrescriptionsButtonAdd.UseVisualStyleBackColor = true;
            this.PrescriptionsButtonAdd.Click += new System.EventHandler(this.PrescriptionsButtonAdd_Click);
            // 
            // PrescriptionsLabelSearch
            // 
            this.PrescriptionsLabelSearch.Depth = 0;
            this.PrescriptionsLabelSearch.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PrescriptionsLabelSearch.Location = new System.Drawing.Point(200, 6);
            this.PrescriptionsLabelSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrescriptionsLabelSearch.Name = "PrescriptionsLabelSearch";
            this.PrescriptionsLabelSearch.Size = new System.Drawing.Size(50, 36);
            this.PrescriptionsLabelSearch.TabIndex = 18;
            this.PrescriptionsLabelSearch.Text = "Найти:";
            this.PrescriptionsLabelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrescriptionsTextBoxSearch
            // 
            this.PrescriptionsTextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrescriptionsTextBoxSearch.Depth = 0;
            this.PrescriptionsTextBoxSearch.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrescriptionsTextBoxSearch.Hint = "Введите имя доктора или пациента";
            this.PrescriptionsTextBoxSearch.Location = new System.Drawing.Point(255, 6);
            this.PrescriptionsTextBoxSearch.MaxLength = 50;
            this.PrescriptionsTextBoxSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.PrescriptionsTextBoxSearch.Multiline = false;
            this.PrescriptionsTextBoxSearch.Name = "PrescriptionsTextBoxSearch";
            this.PrescriptionsTextBoxSearch.Size = new System.Drawing.Size(388, 36);
            this.PrescriptionsTextBoxSearch.TabIndex = 17;
            this.PrescriptionsTextBoxSearch.Text = "";
            this.PrescriptionsTextBoxSearch.UseTallSize = false;
            this.PrescriptionsTextBoxSearch.TextChanged += new System.EventHandler(this.PrescriptionsTextBoxSearch_TextChanged);
            // 
            // PrescriptionsComboBoxSort
            // 
            this.PrescriptionsComboBoxSort.AutoResize = false;
            this.PrescriptionsComboBoxSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PrescriptionsComboBoxSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrescriptionsComboBoxSort.Depth = 0;
            this.PrescriptionsComboBoxSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.PrescriptionsComboBoxSort.DropDownHeight = 118;
            this.PrescriptionsComboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrescriptionsComboBoxSort.DropDownWidth = 121;
            this.PrescriptionsComboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.PrescriptionsComboBoxSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PrescriptionsComboBoxSort.FormattingEnabled = true;
            this.PrescriptionsComboBoxSort.IntegralHeight = false;
            this.PrescriptionsComboBoxSort.ItemHeight = 29;
            this.PrescriptionsComboBoxSort.Items.AddRange(new object[] {
            "Без сортировки",
            "id ↓",
            "Имя доктора ↑",
            "Имя доктора ↓",
            "Имя пациента ↑",
            "Имя пациента ↓"});
            this.PrescriptionsComboBoxSort.Location = new System.Drawing.Point(3, 6);
            this.PrescriptionsComboBoxSort.MaxDropDownItems = 4;
            this.PrescriptionsComboBoxSort.MouseState = MaterialSkin.MouseState.OUT;
            this.PrescriptionsComboBoxSort.Name = "PrescriptionsComboBoxSort";
            this.PrescriptionsComboBoxSort.Size = new System.Drawing.Size(182, 35);
            this.PrescriptionsComboBoxSort.StartIndex = 0;
            this.PrescriptionsComboBoxSort.TabIndex = 16;
            this.PrescriptionsComboBoxSort.UseTallSize = false;
            this.PrescriptionsComboBoxSort.SelectedIndexChanged += new System.EventHandler(this.PrescriptionsComboBoxSort_SelectedIndexChanged);
            // 
            // PrescriptionsListView
            // 
            this.PrescriptionsListView.AutoSizeTable = false;
            this.PrescriptionsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PrescriptionsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrescriptionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerPrescriptionsId,
            this.headerPrescriptionsPatientId,
            this.headerPrescriptionsPatientName,
            this.headerPrescriptionsDoctorName,
            this.headerPrescriptionsDoctorSignature,
            this.headerPrescriptionsDoctorStamp,
            this.headerPrescriptionsDiagnoses,
            this.headerPrescriptionsMedications});
            this.PrescriptionsListView.Depth = 0;
            this.PrescriptionsListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrescriptionsListView.FullRowSelect = true;
            this.PrescriptionsListView.HideSelection = false;
            this.PrescriptionsListView.Location = new System.Drawing.Point(3, 49);
            this.PrescriptionsListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.PrescriptionsListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PrescriptionsListView.MouseState = MaterialSkin.MouseState.OUT;
            this.PrescriptionsListView.Name = "PrescriptionsListView";
            this.PrescriptionsListView.OwnerDraw = true;
            this.PrescriptionsListView.Size = new System.Drawing.Size(1260, 601);
            this.PrescriptionsListView.TabIndex = 15;
            this.PrescriptionsListView.UseCompatibleStateImageBehavior = false;
            this.PrescriptionsListView.View = System.Windows.Forms.View.Details;
            // 
            // headerPrescriptionsId
            // 
            this.headerPrescriptionsId.Text = "id";
            // 
            // headerPrescriptionsPatientId
            // 
            this.headerPrescriptionsPatientId.Text = "id пациента";
            this.headerPrescriptionsPatientId.Width = 115;
            // 
            // headerPrescriptionsPatientName
            // 
            this.headerPrescriptionsPatientName.Text = "Имя пациента";
            this.headerPrescriptionsPatientName.Width = 260;
            // 
            // headerPrescriptionsDoctorName
            // 
            this.headerPrescriptionsDoctorName.Text = "Имя доктора";
            this.headerPrescriptionsDoctorName.Width = 260;
            // 
            // headerPrescriptionsDoctorSignature
            // 
            this.headerPrescriptionsDoctorSignature.Text = "Подпись доктора";
            this.headerPrescriptionsDoctorSignature.Width = 160;
            // 
            // headerPrescriptionsDoctorStamp
            // 
            this.headerPrescriptionsDoctorStamp.Text = "Печать доктора";
            this.headerPrescriptionsDoctorStamp.Width = 160;
            // 
            // headerPrescriptionsDiagnoses
            // 
            this.headerPrescriptionsDiagnoses.Text = "Список диагнозов";
            this.headerPrescriptionsDiagnoses.Width = 210;
            // 
            // headerPrescriptionsMedications
            // 
            this.headerPrescriptionsMedications.Text = "Список лекарств";
            this.headerPrescriptionsMedications.Width = 600;
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
            this.Controls.Add(this.MainTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.MainTabControl;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аптека";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.tabPageMedications.ResumeLayout(false);
            this.tabPageStorehouse.ResumeLayout(false);
            this.tabPagePrescriptons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl MainTabControl;
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
        private MaterialSkin.Controls.MaterialListView MedicationsListView;
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
        private MaterialSkin.Controls.MaterialComboBox MedicationsComboBoxSort;
        private MaterialSkin.Controls.MaterialTextBox MedicationsTextBoxSearch;
        private MaterialSkin.Controls.MaterialLabel MedicationsLabelSearch;
        private MaterialSkin.Controls.MaterialButton MedicationsButtonAdd;
        private MaterialSkin.Controls.MaterialButton MedicationsButtonDelete;
        private MaterialSkin.Controls.MaterialButton MedicationsButtonEdit;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.ColumnHeader columnVolume;
        private MaterialSkin.Controls.MaterialButton StorehouseFButtonEdit;
        private MaterialSkin.Controls.MaterialButton StorehouseFButtonDelete;
        private MaterialSkin.Controls.MaterialButton StorehouseFButtonAdd;
        private MaterialSkin.Controls.MaterialLabel StorehouseFLabelSearch;
        private MaterialSkin.Controls.MaterialTextBox StorehouseFTextBoxSearch;
        private MaterialSkin.Controls.MaterialComboBox StorehouseFComboBoxSort;
        private MaterialSkin.Controls.MaterialListView StorehouseFListView;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderMedicationsId;
        private System.Windows.Forms.ColumnHeader columnHeaderMedicationsName;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderCriticalQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderManufactureDate;
        private System.Windows.Forms.ColumnHeader columnHeaderShelfDate;
        private System.Windows.Forms.ColumnHeader columnHeaderStorehouseRId;
        private MaterialSkin.Controls.MaterialButton PrescriptionsButtonEdit;
        private MaterialSkin.Controls.MaterialButton PrescriptionsButtonDelete;
        private MaterialSkin.Controls.MaterialButton PrescriptionsButtonAdd;
        private MaterialSkin.Controls.MaterialLabel PrescriptionsLabelSearch;
        private MaterialSkin.Controls.MaterialTextBox PrescriptionsTextBoxSearch;
        private MaterialSkin.Controls.MaterialComboBox PrescriptionsComboBoxSort;
        private MaterialSkin.Controls.MaterialListView PrescriptionsListView;
        private System.Windows.Forms.ColumnHeader columnHeaderPrescriptionsId;
        private System.Windows.Forms.ColumnHeader headerPrescriptionsId;
        private System.Windows.Forms.ColumnHeader headerPrescriptionsPatientId;
        private System.Windows.Forms.ColumnHeader headerPrescriptionsPatientName;
        private System.Windows.Forms.ColumnHeader headerPrescriptionsDoctorName;
        private System.Windows.Forms.ColumnHeader headerPrescriptionsDoctorSignature;
        private System.Windows.Forms.ColumnHeader headerPrescriptionsDoctorStamp;
        private System.Windows.Forms.ColumnHeader headerPrescriptionsDiagnoses;
        private System.Windows.Forms.ColumnHeader headerPrescriptionsMedications;
    }
}