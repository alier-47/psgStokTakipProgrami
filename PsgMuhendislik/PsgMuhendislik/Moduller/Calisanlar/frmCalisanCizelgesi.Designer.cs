namespace PsgMuhendislik.Moduller.Calisanlar
{
    partial class frmCalisanCizelgesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalisanCizelgesi));
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.lblCalisanAdi = new System.Windows.Forms.Label();
            this.lblCalisanID = new System.Windows.Forms.Label();
            this.lblEksikGun = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.btnAra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnExcele_Aktar = new DevExpress.XtraEditors.SimpleButton();
            this.btnPDFe_Aktar = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCalisanCizelgesi = new DevExpress.XtraGrid.GridControl();
            this.gridViewCalisanCizelgesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GunSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CalisanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSecilileriSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.Müşteriler = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCalisanCizelgesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCalisanCizelgesi)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).BeginInit();
            this.Müşteriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(552, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eksik Gün Toplamı";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.lblCalisanAdi);
            this.groupControl4.Controls.Add(this.lblCalisanID);
            this.groupControl4.Controls.Add(this.lblEksikGun);
            this.groupControl4.Controls.Add(this.label1);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl4.Location = new System.Drawing.Point(0, 384);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.ShowCaption = false;
            this.groupControl4.Size = new System.Drawing.Size(866, 50);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "groupControl4";
            // 
            // lblCalisanAdi
            // 
            this.lblCalisanAdi.AutoSize = true;
            this.lblCalisanAdi.Location = new System.Drawing.Point(26, 20);
            this.lblCalisanAdi.Name = "lblCalisanAdi";
            this.lblCalisanAdi.Size = new System.Drawing.Size(0, 13);
            this.lblCalisanAdi.TabIndex = 2;
            this.lblCalisanAdi.Visible = false;
            // 
            // lblCalisanID
            // 
            this.lblCalisanID.AutoSize = true;
            this.lblCalisanID.Location = new System.Drawing.Point(5, 20);
            this.lblCalisanID.Name = "lblCalisanID";
            this.lblCalisanID.Size = new System.Drawing.Size(15, 13);
            this.lblCalisanID.TabIndex = 1;
            this.lblCalisanID.Text = "id";
            this.lblCalisanID.Visible = false;
            // 
            // lblEksikGun
            // 
            this.lblEksikGun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEksikGun.AutoSize = true;
            this.lblEksikGun.BackColor = System.Drawing.Color.Aqua;
            this.lblEksikGun.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblEksikGun.Location = new System.Drawing.Point(697, 18);
            this.lblEksikGun.Name = "lblEksikGun";
            this.lblEksikGun.Size = new System.Drawing.Size(0, 17);
            this.lblEksikGun.TabIndex = 0;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(532, 11);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dtBitis
            // 
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitis.Location = new System.Drawing.Point(301, 12);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(117, 21);
            this.dtBitis.TabIndex = 2;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslangic.Location = new System.Drawing.Point(101, 12);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(117, 21);
            this.dtBaslangic.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(447, 11);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bitiş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Başlangıç Tarihi";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.splitContainer2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(866, 46);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "groupControl2";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(2, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.dtBaslangic);
            this.splitContainer2.Panel1.Controls.Add(this.btnAra);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.btnTemizle);
            this.splitContainer2.Panel1.Controls.Add(this.dtBitis);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnExcele_Aktar);
            this.splitContainer2.Panel2.Controls.Add(this.btnPDFe_Aktar);
            this.splitContainer2.Size = new System.Drawing.Size(862, 42);
            this.splitContainer2.SplitterDistance = 639;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnExcele_Aktar
            // 
            this.btnExcele_Aktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcele_Aktar.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnExcele_Aktar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExcele_Aktar.Appearance.Options.UseBackColor = true;
            this.btnExcele_Aktar.Appearance.Options.UseFont = true;
            this.btnExcele_Aktar.Location = new System.Drawing.Point(25, 9);
            this.btnExcele_Aktar.Name = "btnExcele_Aktar";
            this.btnExcele_Aktar.Size = new System.Drawing.Size(89, 24);
            this.btnExcele_Aktar.TabIndex = 5;
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
            this.btnPDFe_Aktar.Location = new System.Drawing.Point(120, 9);
            this.btnPDFe_Aktar.Name = "btnPDFe_Aktar";
            this.btnPDFe_Aktar.Size = new System.Drawing.Size(89, 24);
            this.btnPDFe_Aktar.TabIndex = 4;
            this.btnPDFe_Aktar.Text = "PDF\'e Aktar";
            this.btnPDFe_Aktar.Click += new System.EventHandler(this.btnPDFe_Aktar_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCalisanCizelgesi;
            this.gridView1.Name = "gridView1";
            // 
            // grdCalisanCizelgesi
            // 
            this.grdCalisanCizelgesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCalisanCizelgesi.Location = new System.Drawing.Point(0, 46);
            this.grdCalisanCizelgesi.MainView = this.gridViewCalisanCizelgesi;
            this.grdCalisanCizelgesi.Name = "grdCalisanCizelgesi";
            this.grdCalisanCizelgesi.Size = new System.Drawing.Size(866, 338);
            this.grdCalisanCizelgesi.TabIndex = 0;
            this.grdCalisanCizelgesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCalisanCizelgesi,
            this.gridView1});
            // 
            // gridViewCalisanCizelgesi
            // 
            this.gridViewCalisanCizelgesi.ActiveFilterEnabled = false;
            this.gridViewCalisanCizelgesi.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCalisanCizelgesi.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCalisanCizelgesi.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewCalisanCizelgesi.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridViewCalisanCizelgesi.Appearance.Row.Options.UseBackColor = true;
            this.gridViewCalisanCizelgesi.Appearance.Row.Options.UseFont = true;
            this.gridViewCalisanCizelgesi.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewCalisanCizelgesi.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCalisanCizelgesi.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridViewCalisanCizelgesi.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewCalisanCizelgesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Tarih,
            this.GunSayisi,
            this.Aciklama,
            this.ID,
            this.CalisanID});
            this.gridViewCalisanCizelgesi.GridControl = this.grdCalisanCizelgesi;
            this.gridViewCalisanCizelgesi.Name = "gridViewCalisanCizelgesi";
            this.gridViewCalisanCizelgesi.OptionsSelection.MultiSelect = true;
            this.gridViewCalisanCizelgesi.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewCalisanCizelgesi.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewCalisanCizelgesi_RowStyle);
            this.gridViewCalisanCizelgesi.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewCalisanCizelgesi_SelectionChanged);
            // 
            // Tarih
            // 
            this.Tarih.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Tarih.AppearanceCell.Options.UseFont = true;
            this.Tarih.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Tarih.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.Tarih.AppearanceHeader.Options.UseFont = true;
            this.Tarih.AppearanceHeader.Options.UseForeColor = true;
            this.Tarih.Caption = "Tarih";
            this.Tarih.FieldName = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.OptionsColumn.AllowEdit = false;
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 1;
            // 
            // GunSayisi
            // 
            this.GunSayisi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.GunSayisi.AppearanceCell.Options.UseFont = true;
            this.GunSayisi.AppearanceCell.Options.UseTextOptions = true;
            this.GunSayisi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GunSayisi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GunSayisi.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.GunSayisi.AppearanceHeader.Options.UseFont = true;
            this.GunSayisi.AppearanceHeader.Options.UseForeColor = true;
            this.GunSayisi.Caption = "Gün Sayısı";
            this.GunSayisi.FieldName = "GunSayisi";
            this.GunSayisi.Name = "GunSayisi";
            this.GunSayisi.OptionsColumn.AllowEdit = false;
            this.GunSayisi.Visible = true;
            this.GunSayisi.VisibleIndex = 2;
            // 
            // Aciklama
            // 
            this.Aciklama.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Aciklama.AppearanceCell.Options.UseFont = true;
            this.Aciklama.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Aciklama.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.Aciklama.AppearanceHeader.Options.UseFont = true;
            this.Aciklama.AppearanceHeader.Options.UseForeColor = true;
            this.Aciklama.Caption = "Açıklama";
            this.Aciklama.FieldName = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.OptionsColumn.AllowEdit = false;
            this.Aciklama.Visible = true;
            this.Aciklama.VisibleIndex = 3;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // CalisanID
            // 
            this.CalisanID.Caption = "Çalışan id";
            this.CalisanID.FieldName = "CalisanID";
            this.CalisanID.Name = "CalisanID";
            // 
            // btnSecilileriSil
            // 
            this.btnSecilileriSil.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnSecilileriSil.Appearance.Font = new System.Drawing.Font("Tahoma", 8.7F, System.Drawing.FontStyle.Bold);
            this.btnSecilileriSil.Appearance.Options.UseBackColor = true;
            this.btnSecilileriSil.Appearance.Options.UseFont = true;
            this.btnSecilileriSil.Appearance.Options.UseTextOptions = true;
            this.btnSecilileriSil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSecilileriSil.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnSecilileriSil.Enabled = false;
            this.btnSecilileriSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSecilileriSil.ImageOptions.Image")));
            this.btnSecilileriSil.Location = new System.Drawing.Point(13, 188);
            this.btnSecilileriSil.Name = "btnSecilileriSil";
            this.btnSecilileriSil.Size = new System.Drawing.Size(208, 51);
            this.btnSecilileriSil.TabIndex = 3;
            this.btnSecilileriSil.Text = "SEÇİLİ OLANLARI SİL";
            this.btnSecilileriSil.Click += new System.EventHandler(this.btnSecilileriSil_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Appearance.Options.UseTextOptions = true;
            this.btnSil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSil.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(13, 131);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(208, 51);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnDuzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDuzenle.Appearance.Options.UseBackColor = true;
            this.btnDuzenle.Appearance.Options.UseFont = true;
            this.btnDuzenle.Appearance.Options.UseTextOptions = true;
            this.btnDuzenle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnDuzenle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(13, 74);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(208, 51);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Appearance.Options.UseBackColor = true;
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.Appearance.Options.UseTextOptions = true;
            this.btnEkle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnEkle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(13, 17);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(208, 51);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnSecilileriSil);
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.btnDuzenle);
            this.xtraTabPage1.Controls.Add(this.btnEkle);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(224, 420);
            // 
            // Müşteriler
            // 
            this.Müşteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Müşteriler.Location = new System.Drawing.Point(0, 0);
            this.Müşteriler.Name = "Müşteriler";
            this.Müşteriler.SelectedTabPage = this.xtraTabPage1;
            this.Müşteriler.Size = new System.Drawing.Size(226, 434);
            this.Müşteriler.TabIndex = 0;
            this.Müşteriler.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
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
            this.splitContainer1.Panel2.Controls.Add(this.grdCalisanCizelgesi);
            this.splitContainer1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer1.Panel2.Controls.Add(this.groupControl4);
            this.splitContainer1.Size = new System.Drawing.Size(1096, 434);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 6;
            // 
            // frmCalisanCizelgesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 434);
            this.Controls.Add(this.splitContainer1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmCalisanCizelgesi.IconOptions.SvgImage")));
            this.Name = "frmCalisanCizelgesi";
            this.Text = "Çalışanlar Çizelgesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCalisanCizelgesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCalisanCizelgesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCalisanCizelgesi)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).EndInit();
            this.Müşteriler.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.Label lblEksikGun;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl grdCalisanCizelgesi;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewCalisanCizelgesi;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn GunSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        public DevExpress.XtraEditors.SimpleButton btnSecilileriSil;
        public DevExpress.XtraEditors.SimpleButton btnSil;
        public DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabControl Müşteriler;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.Columns.GridColumn CalisanID;
        public System.Windows.Forms.Label lblCalisanID;
        private DevExpress.XtraEditors.SimpleButton btnExcele_Aktar;
        private DevExpress.XtraEditors.SimpleButton btnPDFe_Aktar;
        public System.Windows.Forms.Label lblCalisanAdi;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}