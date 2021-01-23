namespace PsgMuhendislik.Moduller.Calisanlar
{
    partial class frmCalisanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalisanlar));
            this.Müşteriler = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnCalisanEDevlet = new DevExpress.XtraEditors.SimpleButton();
            this.btnTumCalisanlariSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnCalisanCizelgesi = new DevExpress.XtraEditors.SimpleButton();
            this.btnCalisanDetayi = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeYap = new DevExpress.XtraEditors.SimpleButton();
            this.btnMaasEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnCalisanSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnCalisanDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnCalisanEkle = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdCalisanlar = new DevExpress.XtraGrid.GridControl();
            this.gridViewCalisanlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AlacakTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsBaslangicTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CalismaSekli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).BeginInit();
            this.Müşteriler.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCalisanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCalisanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Müşteriler
            // 
            this.Müşteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Müşteriler.Location = new System.Drawing.Point(0, 0);
            this.Müşteriler.Name = "Müşteriler";
            this.Müşteriler.SelectedTabPage = this.xtraTabPage1;
            this.Müşteriler.Size = new System.Drawing.Size(221, 517);
            this.Müşteriler.TabIndex = 0;
            this.Müşteriler.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnCalisanEDevlet);
            this.xtraTabPage1.Controls.Add(this.btnTumCalisanlariSil);
            this.xtraTabPage1.Controls.Add(this.btnCalisanCizelgesi);
            this.xtraTabPage1.Controls.Add(this.btnCalisanDetayi);
            this.xtraTabPage1.Controls.Add(this.btnOdemeYap);
            this.xtraTabPage1.Controls.Add(this.btnMaasEkle);
            this.xtraTabPage1.Controls.Add(this.btnCalisanSil);
            this.xtraTabPage1.Controls.Add(this.btnCalisanDuzenle);
            this.xtraTabPage1.Controls.Add(this.btnCalisanEkle);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(219, 503);
            // 
            // btnCalisanEDevlet
            // 
            this.btnCalisanEDevlet.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnCalisanEDevlet.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalisanEDevlet.Appearance.Options.UseBackColor = true;
            this.btnCalisanEDevlet.Appearance.Options.UseFont = true;
            this.btnCalisanEDevlet.Appearance.Options.UseTextOptions = true;
            this.btnCalisanEDevlet.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnCalisanEDevlet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCalisanEDevlet.ImageOptions.SvgImage")));
            this.btnCalisanEDevlet.Location = new System.Drawing.Point(13, 394);
            this.btnCalisanEDevlet.Name = "btnCalisanEDevlet";
            this.btnCalisanEDevlet.Size = new System.Drawing.Size(198, 47);
            this.btnCalisanEDevlet.TabIndex = 9;
            this.btnCalisanEDevlet.Text = "ÇALIŞAN E DEVLET";
            this.btnCalisanEDevlet.Click += new System.EventHandler(this.btnCalisanEDevlet_Click);
            // 
            // btnTumCalisanlariSil
            // 
            this.btnTumCalisanlariSil.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnTumCalisanlariSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnTumCalisanlariSil.Appearance.Options.UseBackColor = true;
            this.btnTumCalisanlariSil.Appearance.Options.UseFont = true;
            this.btnTumCalisanlariSil.Appearance.Options.UseTextOptions = true;
            this.btnTumCalisanlariSil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnTumCalisanlariSil.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnTumCalisanlariSil.Enabled = false;
            this.btnTumCalisanlariSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTumCalisanlariSil.ImageOptions.Image")));
            this.btnTumCalisanlariSil.Location = new System.Drawing.Point(13, 448);
            this.btnTumCalisanlariSil.Name = "btnTumCalisanlariSil";
            this.btnTumCalisanlariSil.Size = new System.Drawing.Size(198, 48);
            this.btnTumCalisanlariSil.TabIndex = 8;
            this.btnTumCalisanlariSil.Text = "SEÇİLİ ÇALIŞANLARI SİL";
            this.btnTumCalisanlariSil.Click += new System.EventHandler(this.btnTumCalisanlariSil_Click);
            // 
            // btnCalisanCizelgesi
            // 
            this.btnCalisanCizelgesi.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnCalisanCizelgesi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalisanCizelgesi.Appearance.Options.UseBackColor = true;
            this.btnCalisanCizelgesi.Appearance.Options.UseFont = true;
            this.btnCalisanCizelgesi.Appearance.Options.UseTextOptions = true;
            this.btnCalisanCizelgesi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnCalisanCizelgesi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCalisanCizelgesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCalisanCizelgesi.ImageOptions.Image")));
            this.btnCalisanCizelgesi.Location = new System.Drawing.Point(13, 338);
            this.btnCalisanCizelgesi.Name = "btnCalisanCizelgesi";
            this.btnCalisanCizelgesi.Size = new System.Drawing.Size(198, 48);
            this.btnCalisanCizelgesi.TabIndex = 6;
            this.btnCalisanCizelgesi.Text = "ÇALIŞAN ÇİZELGESİ";
            this.btnCalisanCizelgesi.Click += new System.EventHandler(this.btnCalisanCizelgesi_Click);
            // 
            // btnCalisanDetayi
            // 
            this.btnCalisanDetayi.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnCalisanDetayi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalisanDetayi.Appearance.Options.UseBackColor = true;
            this.btnCalisanDetayi.Appearance.Options.UseFont = true;
            this.btnCalisanDetayi.Appearance.Options.UseTextOptions = true;
            this.btnCalisanDetayi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnCalisanDetayi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCalisanDetayi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCalisanDetayi.ImageOptions.Image")));
            this.btnCalisanDetayi.Location = new System.Drawing.Point(13, 282);
            this.btnCalisanDetayi.Name = "btnCalisanDetayi";
            this.btnCalisanDetayi.Size = new System.Drawing.Size(198, 48);
            this.btnCalisanDetayi.TabIndex = 5;
            this.btnCalisanDetayi.Text = "ÇALIŞAN DETAYI";
            this.btnCalisanDetayi.Click += new System.EventHandler(this.btnCalisanDetayi_Click);
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnOdemeYap.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnOdemeYap.Appearance.Options.UseBackColor = true;
            this.btnOdemeYap.Appearance.Options.UseFont = true;
            this.btnOdemeYap.Appearance.Options.UseTextOptions = true;
            this.btnOdemeYap.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnOdemeYap.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnOdemeYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeYap.ImageOptions.Image")));
            this.btnOdemeYap.Location = new System.Drawing.Point(13, 227);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(198, 48);
            this.btnOdemeYap.TabIndex = 4;
            this.btnOdemeYap.Text = "ÖDEME YAP";
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // btnMaasEkle
            // 
            this.btnMaasEkle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnMaasEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaasEkle.Appearance.Options.UseBackColor = true;
            this.btnMaasEkle.Appearance.Options.UseFont = true;
            this.btnMaasEkle.Appearance.Options.UseTextOptions = true;
            this.btnMaasEkle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnMaasEkle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnMaasEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMaasEkle.ImageOptions.Image")));
            this.btnMaasEkle.Location = new System.Drawing.Point(13, 172);
            this.btnMaasEkle.Name = "btnMaasEkle";
            this.btnMaasEkle.Size = new System.Drawing.Size(198, 48);
            this.btnMaasEkle.TabIndex = 3;
            this.btnMaasEkle.Text = "MAAŞ EKLE";
            this.btnMaasEkle.Click += new System.EventHandler(this.btnMaasEkle_Click);
            // 
            // btnCalisanSil
            // 
            this.btnCalisanSil.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnCalisanSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalisanSil.Appearance.Options.UseBackColor = true;
            this.btnCalisanSil.Appearance.Options.UseFont = true;
            this.btnCalisanSil.Appearance.Options.UseTextOptions = true;
            this.btnCalisanSil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnCalisanSil.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCalisanSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCalisanSil.ImageOptions.Image")));
            this.btnCalisanSil.Location = new System.Drawing.Point(13, 117);
            this.btnCalisanSil.Name = "btnCalisanSil";
            this.btnCalisanSil.Size = new System.Drawing.Size(198, 48);
            this.btnCalisanSil.TabIndex = 2;
            this.btnCalisanSil.Text = "ÇALIŞAN SİL";
            this.btnCalisanSil.Click += new System.EventHandler(this.btnCalisanSil_Click);
            // 
            // btnCalisanDuzenle
            // 
            this.btnCalisanDuzenle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnCalisanDuzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalisanDuzenle.Appearance.Options.UseBackColor = true;
            this.btnCalisanDuzenle.Appearance.Options.UseFont = true;
            this.btnCalisanDuzenle.Appearance.Options.UseTextOptions = true;
            this.btnCalisanDuzenle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnCalisanDuzenle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCalisanDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCalisanDuzenle.ImageOptions.Image")));
            this.btnCalisanDuzenle.Location = new System.Drawing.Point(13, 62);
            this.btnCalisanDuzenle.Name = "btnCalisanDuzenle";
            this.btnCalisanDuzenle.Size = new System.Drawing.Size(198, 48);
            this.btnCalisanDuzenle.TabIndex = 1;
            this.btnCalisanDuzenle.Text = "ÇALIŞAN DÜZENLE";
            this.btnCalisanDuzenle.Click += new System.EventHandler(this.btnCalisanDuzenle_Click);
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnCalisanEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalisanEkle.Appearance.Options.UseBackColor = true;
            this.btnCalisanEkle.Appearance.Options.UseFont = true;
            this.btnCalisanEkle.Appearance.Options.UseTextOptions = true;
            this.btnCalisanEkle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnCalisanEkle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCalisanEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCalisanEkle.ImageOptions.Image")));
            this.btnCalisanEkle.Location = new System.Drawing.Point(13, 8);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(198, 48);
            this.btnCalisanEkle.TabIndex = 0;
            this.btnCalisanEkle.Text = "ÇALIŞAN EKLE";
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
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
            this.splitContainer1.Panel2.Controls.Add(this.grdCalisanlar);
            this.splitContainer1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer1.Size = new System.Drawing.Size(926, 517);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 2;
            // 
            // grdCalisanlar
            // 
            this.grdCalisanlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCalisanlar.Location = new System.Drawing.Point(0, 0);
            this.grdCalisanlar.MainView = this.gridViewCalisanlar;
            this.grdCalisanlar.Name = "grdCalisanlar";
            this.grdCalisanlar.Size = new System.Drawing.Size(701, 466);
            this.grdCalisanlar.TabIndex = 6;
            this.grdCalisanlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCalisanlar});
            // 
            // gridViewCalisanlar
            // 
            this.gridViewCalisanlar.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCalisanlar.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCalisanlar.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewCalisanlar.Appearance.Row.Options.UseBackColor = true;
            this.gridViewCalisanlar.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridViewCalisanlar.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewCalisanlar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AdSoyad,
            this.Telefon,
            this.AlacakTutar,
            this.IsBaslangicTarihi,
            this.CalismaSekli,
            this.ID});
            this.gridViewCalisanlar.GridControl = this.grdCalisanlar;
            this.gridViewCalisanlar.Name = "gridViewCalisanlar";
            this.gridViewCalisanlar.OptionsSelection.MultiSelect = true;
            this.gridViewCalisanlar.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewCalisanlar.OptionsView.ShowDetailButtons = false;
            this.gridViewCalisanlar.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewCalisanlar_RowStyle);
            this.gridViewCalisanlar.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewCalisanlar_SelectionChanged_1);
            this.gridViewCalisanlar.ColumnFilterChanged += new System.EventHandler(this.gridViewCalisanlar_ColumnFilterChanged);
            this.gridViewCalisanlar.DoubleClick += new System.EventHandler(this.gridViewCalisanlar_DoubleClick_1);
            // 
            // AdSoyad
            // 
            this.AdSoyad.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.AdSoyad.AppearanceCell.Options.UseFont = true;
            this.AdSoyad.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.AdSoyad.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.AdSoyad.AppearanceHeader.Options.UseFont = true;
            this.AdSoyad.AppearanceHeader.Options.UseForeColor = true;
            this.AdSoyad.Caption = "Çalışan Adı";
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
            this.Telefon.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Telefon.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.Telefon.AppearanceHeader.Options.UseFont = true;
            this.Telefon.AppearanceHeader.Options.UseForeColor = true;
            this.Telefon.Caption = "Telefon";
            this.Telefon.FieldName = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.OptionsColumn.AllowEdit = false;
            this.Telefon.Visible = true;
            this.Telefon.VisibleIndex = 2;
            // 
            // AlacakTutar
            // 
            this.AlacakTutar.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.AlacakTutar.AppearanceCell.Options.UseFont = true;
            this.AlacakTutar.AppearanceCell.Options.UseTextOptions = true;
            this.AlacakTutar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AlacakTutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.AlacakTutar.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.AlacakTutar.AppearanceHeader.Options.UseFont = true;
            this.AlacakTutar.AppearanceHeader.Options.UseForeColor = true;
            this.AlacakTutar.Caption = "Bakiye";
            this.AlacakTutar.DisplayFormat.FormatString = "C";
            this.AlacakTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.AlacakTutar.FieldName = "AlacakTutar";
            this.AlacakTutar.Name = "AlacakTutar";
            this.AlacakTutar.OptionsColumn.AllowEdit = false;
            this.AlacakTutar.Visible = true;
            this.AlacakTutar.VisibleIndex = 3;
            // 
            // IsBaslangicTarihi
            // 
            this.IsBaslangicTarihi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.IsBaslangicTarihi.AppearanceCell.Options.UseFont = true;
            this.IsBaslangicTarihi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.IsBaslangicTarihi.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.IsBaslangicTarihi.AppearanceHeader.Options.UseFont = true;
            this.IsBaslangicTarihi.AppearanceHeader.Options.UseForeColor = true;
            this.IsBaslangicTarihi.Caption = "İş Başlangıç Tarihi";
            this.IsBaslangicTarihi.FieldName = "IsBaslangicTarihi";
            this.IsBaslangicTarihi.Name = "IsBaslangicTarihi";
            this.IsBaslangicTarihi.OptionsColumn.AllowEdit = false;
            this.IsBaslangicTarihi.Visible = true;
            this.IsBaslangicTarihi.VisibleIndex = 4;
            // 
            // CalismaSekli
            // 
            this.CalismaSekli.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.CalismaSekli.AppearanceCell.Options.UseFont = true;
            this.CalismaSekli.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.CalismaSekli.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.CalismaSekli.AppearanceHeader.Options.UseFont = true;
            this.CalismaSekli.AppearanceHeader.Options.UseForeColor = true;
            this.CalismaSekli.Caption = "Çalışma Şekli";
            this.CalismaSekli.FieldName = "CalismaSekli";
            this.CalismaSekli.Name = "CalismaSekli";
            this.CalismaSekli.OptionsColumn.AllowEdit = false;
            this.CalismaSekli.Visible = true;
            this.CalismaSekli.VisibleIndex = 5;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblToplam);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 466);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(701, 51);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "groupControl2";
            // 
            // lblToplam
            // 
            this.lblToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Aqua;
            this.lblToplam.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplam.Location = new System.Drawing.Point(564, 25);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(0, 17);
            this.lblToplam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(478, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam";
            // 
            // frmCalisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 517);
            this.Controls.Add(this.splitContainer1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmCalisanlar.IconOptions.LargeImage")));
            this.Name = "frmCalisanlar";
            this.Text = "Çalışanlar Listesi";
            this.Load += new System.EventHandler(this.frmCalisanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).EndInit();
            this.Müşteriler.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCalisanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCalisanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl Müşteriler;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnCalisanDetayi;
        private DevExpress.XtraEditors.SimpleButton btnOdemeYap;
        private DevExpress.XtraEditors.SimpleButton btnMaasEkle;
        private DevExpress.XtraEditors.SimpleButton btnCalisanSil;
        private DevExpress.XtraEditors.SimpleButton btnCalisanDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnCalisanEkle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraGrid.GridControl grdCalisanlar;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewCalisanlar;
        private DevExpress.XtraGrid.Columns.GridColumn AdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn Telefon;
        private DevExpress.XtraGrid.Columns.GridColumn AlacakTutar;
        private DevExpress.XtraGrid.Columns.GridColumn IsBaslangicTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn CalismaSekli;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        public DevExpress.XtraEditors.SimpleButton btnTumCalisanlariSil;
        private DevExpress.XtraEditors.SimpleButton btnCalisanCizelgesi;
        private DevExpress.XtraEditors.SimpleButton btnCalisanEDevlet;
    }
}