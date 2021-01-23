namespace PsgMuhendislik.Modul_Musteriler
{
    partial class frmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriler));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.Borc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Müşteriler = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnTumMusterileriSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnMusteriDetayi = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeAl = new DevExpress.XtraEditors.SimpleButton();
            this.btnBorcEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnMusteriSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnMusteriDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnMusteriEkle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.grdMusteriler = new DevExpress.XtraGrid.GridControl();
            this.gridViewMusteriler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BinaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OdemeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OdemeSekli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Not = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblBorc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnExcele_Aktar = new DevExpress.XtraEditors.SimpleButton();
            this.btnPDFe_Aktar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).BeginInit();
            this.Müşteriler.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Borc
            // 
            this.Borc.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Borc.AppearanceCell.Options.UseFont = true;
            this.Borc.Caption = "Bakiye";
            this.Borc.DisplayFormat.FormatString = "C2";
            this.Borc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Borc.FieldName = "Borc";
            this.Borc.Name = "Borc";
            this.Borc.OptionsColumn.AllowEdit = false;
            this.Borc.Visible = true;
            this.Borc.VisibleIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Müşteriler);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControl3);
            this.splitContainer1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1114, 548);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 0;
            // 
            // Müşteriler
            // 
            this.Müşteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Müşteriler.Location = new System.Drawing.Point(0, 0);
            this.Müşteriler.Name = "Müşteriler";
            this.Müşteriler.SelectedTabPage = this.xtraTabPage1;
            this.Müşteriler.Size = new System.Drawing.Size(221, 548);
            this.Müşteriler.TabIndex = 0;
            this.Müşteriler.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnTumMusterileriSil);
            this.xtraTabPage1.Controls.Add(this.btnMusteriDetayi);
            this.xtraTabPage1.Controls.Add(this.btnOdemeAl);
            this.xtraTabPage1.Controls.Add(this.btnBorcEkle);
            this.xtraTabPage1.Controls.Add(this.btnMusteriSil);
            this.xtraTabPage1.Controls.Add(this.btnMusteriDuzenle);
            this.xtraTabPage1.Controls.Add(this.btnMusteriEkle);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(219, 534);
            // 
            // btnTumMusterileriSil
            // 
            this.btnTumMusterileriSil.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnTumMusterileriSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnTumMusterileriSil.Appearance.Options.UseBackColor = true;
            this.btnTumMusterileriSil.Appearance.Options.UseFont = true;
            this.btnTumMusterileriSil.Enabled = false;
            this.btnTumMusterileriSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTumMusterileriSil.ImageOptions.Image")));
            this.btnTumMusterileriSil.Location = new System.Drawing.Point(13, 359);
            this.btnTumMusterileriSil.Name = "btnTumMusterileriSil";
            this.btnTumMusterileriSil.Size = new System.Drawing.Size(198, 51);
            this.btnTumMusterileriSil.TabIndex = 6;
            this.btnTumMusterileriSil.Text = "SEÇİLİ MÜŞTERİLERİ SİL";
            this.btnTumMusterileriSil.Click += new System.EventHandler(this.btnTumMusterileriSil_Click);
            // 
            // btnMusteriDetayi
            // 
            this.btnMusteriDetayi.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnMusteriDetayi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnMusteriDetayi.Appearance.Options.UseBackColor = true;
            this.btnMusteriDetayi.Appearance.Options.UseFont = true;
            this.btnMusteriDetayi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriDetayi.ImageOptions.Image")));
            this.btnMusteriDetayi.Location = new System.Drawing.Point(13, 302);
            this.btnMusteriDetayi.Name = "btnMusteriDetayi";
            this.btnMusteriDetayi.Size = new System.Drawing.Size(198, 51);
            this.btnMusteriDetayi.TabIndex = 5;
            this.btnMusteriDetayi.Text = "MÜŞTERİ DETAYI";
            this.btnMusteriDetayi.Click += new System.EventHandler(this.btnMusteriDetayi_Click);
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnOdemeAl.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnOdemeAl.Appearance.Options.UseBackColor = true;
            this.btnOdemeAl.Appearance.Options.UseFont = true;
            this.btnOdemeAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeAl.ImageOptions.Image")));
            this.btnOdemeAl.Location = new System.Drawing.Point(13, 245);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(198, 51);
            this.btnOdemeAl.TabIndex = 4;
            this.btnOdemeAl.Text = "ÖDEME AL";
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // btnBorcEkle
            // 
            this.btnBorcEkle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnBorcEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnBorcEkle.Appearance.Options.UseBackColor = true;
            this.btnBorcEkle.Appearance.Options.UseFont = true;
            this.btnBorcEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBorcEkle.ImageOptions.Image")));
            this.btnBorcEkle.Location = new System.Drawing.Point(13, 188);
            this.btnBorcEkle.Name = "btnBorcEkle";
            this.btnBorcEkle.Size = new System.Drawing.Size(198, 51);
            this.btnBorcEkle.TabIndex = 3;
            this.btnBorcEkle.Text = "BORÇ EKLE";
            this.btnBorcEkle.Click += new System.EventHandler(this.btnBorcEkle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnMusteriSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnMusteriSil.Appearance.Options.UseBackColor = true;
            this.btnMusteriSil.Appearance.Options.UseFont = true;
            this.btnMusteriSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriSil.ImageOptions.Image")));
            this.btnMusteriSil.Location = new System.Drawing.Point(13, 131);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(198, 51);
            this.btnMusteriSil.TabIndex = 2;
            this.btnMusteriSil.Text = "MÜŞTERİ SİL";
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriDuzenle
            // 
            this.btnMusteriDuzenle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnMusteriDuzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnMusteriDuzenle.Appearance.Options.UseBackColor = true;
            this.btnMusteriDuzenle.Appearance.Options.UseFont = true;
            this.btnMusteriDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriDuzenle.ImageOptions.Image")));
            this.btnMusteriDuzenle.Location = new System.Drawing.Point(13, 74);
            this.btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            this.btnMusteriDuzenle.Size = new System.Drawing.Size(198, 51);
            this.btnMusteriDuzenle.TabIndex = 1;
            this.btnMusteriDuzenle.Text = "MÜŞTERİ DÜZENLE";
            this.btnMusteriDuzenle.Click += new System.EventHandler(this.btnMusteriDuzenle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnMusteriEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnMusteriEkle.Appearance.Options.UseBackColor = true;
            this.btnMusteriEkle.Appearance.Options.UseFont = true;
            this.btnMusteriEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriEkle.ImageOptions.Image")));
            this.btnMusteriEkle.Location = new System.Drawing.Point(13, 17);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(198, 51);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "MÜŞTERİ EKLE";
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.grdMusteriler);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 38);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(889, 471);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "groupControl3";
            // 
            // grdMusteriler
            // 
            this.grdMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMusteriler.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.grdMusteriler.Location = new System.Drawing.Point(2, 2);
            this.grdMusteriler.MainView = this.gridViewMusteriler;
            this.grdMusteriler.Name = "grdMusteriler";
            this.grdMusteriler.Size = new System.Drawing.Size(885, 467);
            this.grdMusteriler.TabIndex = 12;
            this.grdMusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMusteriler});
            // 
            // gridViewMusteriler
            // 
            this.gridViewMusteriler.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridViewMusteriler.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewMusteriler.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewMusteriler.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Navy;
            this.gridViewMusteriler.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewMusteriler.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewMusteriler.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewMusteriler.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewMusteriler.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewMusteriler.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridViewMusteriler.Appearance.Row.Options.UseBackColor = true;
            this.gridViewMusteriler.Appearance.Row.Options.UseForeColor = true;
            this.gridViewMusteriler.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewMusteriler.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewMusteriler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AdSoyad,
            this.Telefon,
            this.BinaAdi,
            this.Tarih,
            this.OdemeTarihi,
            this.Borc,
            this.OdemeSekli,
            this.Not,
            this.ID});
            this.gridViewMusteriler.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            gridFormatRule1.Column = this.Borc;
            gridFormatRule1.ColumnApplyTo = this.Borc;
            gridFormatRule1.Name = "Format1";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.Red;
            formatConditionRuleExpression1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Black;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseFont = true;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "[Borc] > 0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule1.StopIfTrue = true;
            gridFormatRule2.Column = this.Borc;
            gridFormatRule2.ColumnApplyTo = this.Borc;
            gridFormatRule2.Name = "Format0";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Expression = "[Borc] < 1";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.gridViewMusteriler.FormatRules.Add(gridFormatRule1);
            this.gridViewMusteriler.FormatRules.Add(gridFormatRule2);
            this.gridViewMusteriler.GridControl = this.grdMusteriler;
            this.gridViewMusteriler.Name = "gridViewMusteriler";
            this.gridViewMusteriler.OptionsDetail.ShowDetailTabs = false;
            this.gridViewMusteriler.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewMusteriler.OptionsSelection.MultiSelect = true;
            this.gridViewMusteriler.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewMusteriler.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMusteriler.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewMusteriler.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewMusteriler_RowStyle);
            this.gridViewMusteriler.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewMusteriler_SelectionChanged);
            this.gridViewMusteriler.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewMusteriler_CellValueChanged);
            this.gridViewMusteriler.ColumnFilterChanged += new System.EventHandler(this.gridViewMusteriler_ColumnFilterChanged_1);
            this.gridViewMusteriler.DoubleClick += new System.EventHandler(this.gridViewMusteriler_DoubleClick_1);
            // 
            // AdSoyad
            // 
            this.AdSoyad.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.AdSoyad.AppearanceCell.Options.UseFont = true;
            this.AdSoyad.Caption = "Müşteri Adı";
            this.AdSoyad.FieldName = "AdSoyad";
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.OptionsColumn.AllowEdit = false;
            this.AdSoyad.Visible = true;
            this.AdSoyad.VisibleIndex = 1;
            // 
            // Telefon
            // 
            this.Telefon.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Telefon.AppearanceCell.Options.UseFont = true;
            this.Telefon.Caption = "Telefon";
            this.Telefon.FieldName = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.OptionsColumn.AllowEdit = false;
            this.Telefon.Visible = true;
            this.Telefon.VisibleIndex = 2;
            // 
            // BinaAdi
            // 
            this.BinaAdi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BinaAdi.AppearanceCell.Options.UseFont = true;
            this.BinaAdi.Caption = "Bina Adı";
            this.BinaAdi.FieldName = "BinaAdi";
            this.BinaAdi.Name = "BinaAdi";
            this.BinaAdi.OptionsColumn.AllowEdit = false;
            this.BinaAdi.Visible = true;
            this.BinaAdi.VisibleIndex = 3;
            // 
            // Tarih
            // 
            this.Tarih.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Tarih.AppearanceCell.Options.UseFont = true;
            this.Tarih.Caption = "Kayıt Tarihi";
            this.Tarih.FieldName = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.OptionsColumn.AllowEdit = false;
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 4;
            // 
            // OdemeTarihi
            // 
            this.OdemeTarihi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.OdemeTarihi.AppearanceCell.Options.UseFont = true;
            this.OdemeTarihi.Caption = "Ödeme Tarihi";
            this.OdemeTarihi.FieldName = "OdemeTarihi";
            this.OdemeTarihi.Name = "OdemeTarihi";
            this.OdemeTarihi.Visible = true;
            this.OdemeTarihi.VisibleIndex = 5;
            // 
            // OdemeSekli
            // 
            this.OdemeSekli.Caption = "Ödeme Şekli";
            this.OdemeSekli.FieldName = "OdemeSekli";
            this.OdemeSekli.Name = "OdemeSekli";
            this.OdemeSekli.Visible = true;
            this.OdemeSekli.VisibleIndex = 8;
            // 
            // Not
            // 
            this.Not.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Not.AppearanceCell.Options.UseFont = true;
            this.Not.Caption = "Not";
            this.Not.FieldName = "Not";
            this.Not.Name = "Not";
            this.Not.OptionsColumn.AllowEdit = false;
            this.Not.Visible = true;
            this.Not.VisibleIndex = 7;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblBorc);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 509);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(889, 39);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "groupControl2";
            // 
            // lblBorc
            // 
            this.lblBorc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBorc.AutoSize = true;
            this.lblBorc.BackColor = System.Drawing.Color.Aqua;
            this.lblBorc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblBorc.Location = new System.Drawing.Point(762, 13);
            this.lblBorc.Name = "lblBorc";
            this.lblBorc.Size = new System.Drawing.Size(0, 17);
            this.lblBorc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(649, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Borç Toplamı";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.splitContainer2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(889, 38);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(2, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnTemizle);
            this.splitContainer2.Panel1.Controls.Add(this.dtBitis);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.dtBaslangic);
            this.splitContainer2.Panel1.Controls.Add(this.btnAra);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnExcele_Aktar);
            this.splitContainer2.Panel2.Controls.Add(this.btnPDFe_Aktar);
            this.splitContainer2.Size = new System.Drawing.Size(885, 34);
            this.splitContainer2.SplitterDistance = 688;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(597, 6);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dtBitis
            // 
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitis.Location = new System.Drawing.Point(365, 7);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(117, 21);
            this.dtBitis.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kayıt Bitiş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kayıt Başlangıç Tarihi";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslangic.Location = new System.Drawing.Point(126, 7);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(117, 21);
            this.dtBaslangic.TabIndex = 7;
            this.dtBaslangic.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(511, 6);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnExcele_Aktar
            // 
            this.btnExcele_Aktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcele_Aktar.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnExcele_Aktar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExcele_Aktar.Appearance.Options.UseBackColor = true;
            this.btnExcele_Aktar.Appearance.Options.UseFont = true;
            this.btnExcele_Aktar.Location = new System.Drawing.Point(4, 5);
            this.btnExcele_Aktar.Name = "btnExcele_Aktar";
            this.btnExcele_Aktar.Size = new System.Drawing.Size(89, 24);
            this.btnExcele_Aktar.TabIndex = 10;
            this.btnExcele_Aktar.Text = "Exel\'e Aktar";
            this.btnExcele_Aktar.Click += new System.EventHandler(this.btnExcele_Aktar_Click);
            // 
            // btnPDFe_Aktar
            // 
            this.btnPDFe_Aktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDFe_Aktar.Appearance.BackColor = System.Drawing.Color.Firebrick;
            this.btnPDFe_Aktar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPDFe_Aktar.Appearance.Options.UseBackColor = true;
            this.btnPDFe_Aktar.Appearance.Options.UseFont = true;
            this.btnPDFe_Aktar.Location = new System.Drawing.Point(99, 5);
            this.btnPDFe_Aktar.Name = "btnPDFe_Aktar";
            this.btnPDFe_Aktar.Size = new System.Drawing.Size(89, 24);
            this.btnPDFe_Aktar.TabIndex = 11;
            this.btnPDFe_Aktar.Text = "PDF\'e Aktar";
            this.btnPDFe_Aktar.Click += new System.EventHandler(this.btnPDFe_Aktar_Click);
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 548);
            this.Controls.Add(this.splitContainer1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmMusteriler.IconOptions.SvgImage")));
            this.Name = "frmMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMusteriler_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).EndInit();
            this.Müşteriler.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTab.XtraTabControl Müşteriler;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnMusteriDetayi;
        private DevExpress.XtraEditors.SimpleButton btnOdemeAl;
        private DevExpress.XtraEditors.SimpleButton btnBorcEkle;
        private DevExpress.XtraEditors.SimpleButton btnMusteriSil;
        private DevExpress.XtraEditors.SimpleButton btnMusteriDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnMusteriEkle;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBorc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
        public DevExpress.XtraEditors.SimpleButton btnTumMusterileriSil;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraEditors.SimpleButton btnExcele_Aktar;
        private DevExpress.XtraEditors.SimpleButton btnPDFe_Aktar;
        private DevExpress.XtraGrid.Columns.GridColumn AdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn Telefon;
        private DevExpress.XtraGrid.Columns.GridColumn BinaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn OdemeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn Borc;
        private DevExpress.XtraGrid.Columns.GridColumn Not;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        public DevExpress.XtraGrid.GridControl grdMusteriler;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewMusteriler;
        private DevExpress.XtraGrid.Columns.GridColumn OdemeSekli;
        public System.Windows.Forms.DateTimePicker dtBaslangic;
    }
}