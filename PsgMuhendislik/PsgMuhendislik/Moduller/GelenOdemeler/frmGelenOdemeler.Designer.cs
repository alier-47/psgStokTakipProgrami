namespace PsgMuhendislik.Moduller.GelenOdemeler
{
    partial class frmGelenOdemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGelenOdemeler));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Müşteriler = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSeciliOdemeleriSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeEkle = new DevExpress.XtraEditors.SimpleButton();
            this.grdGelenOdemeler = new DevExpress.XtraGrid.GridControl();
            this.gridViewGelenOdemeler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.lblGelenOdemeToplami = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.btnPDFe_Aktar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcele_Aktar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).BeginInit();
            this.Müşteriler.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGelenOdemeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGelenOdemeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.grdGelenOdemeler);
            this.splitContainer1.Panel2.Controls.Add(this.groupControl5);
            this.splitContainer1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 529);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 3;
            // 
            // Müşteriler
            // 
            this.Müşteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Müşteriler.Location = new System.Drawing.Point(0, 0);
            this.Müşteriler.Name = "Müşteriler";
            this.Müşteriler.SelectedTabPage = this.xtraTabPage1;
            this.Müşteriler.Size = new System.Drawing.Size(221, 529);
            this.Müşteriler.TabIndex = 0;
            this.Müşteriler.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnSeciliOdemeleriSil);
            this.xtraTabPage1.Controls.Add(this.btnOdemeSil);
            this.xtraTabPage1.Controls.Add(this.btnOdemeDuzenle);
            this.xtraTabPage1.Controls.Add(this.btnOdemeEkle);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(219, 515);
            // 
            // btnSeciliOdemeleriSil
            // 
            this.btnSeciliOdemeleriSil.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnSeciliOdemeleriSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSeciliOdemeleriSil.Appearance.Options.UseBackColor = true;
            this.btnSeciliOdemeleriSil.Appearance.Options.UseFont = true;
            this.btnSeciliOdemeleriSil.Appearance.Options.UseTextOptions = true;
            this.btnSeciliOdemeleriSil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSeciliOdemeleriSil.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnSeciliOdemeleriSil.Enabled = false;
            this.btnSeciliOdemeleriSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeciliOdemeleriSil.ImageOptions.Image")));
            this.btnSeciliOdemeleriSil.Location = new System.Drawing.Point(13, 188);
            this.btnSeciliOdemeleriSil.Name = "btnSeciliOdemeleriSil";
            this.btnSeciliOdemeleriSil.Size = new System.Drawing.Size(198, 51);
            this.btnSeciliOdemeleriSil.TabIndex = 2;
            this.btnSeciliOdemeleriSil.Text = "SEÇİLİ ÖDEMELERİ SİL";
            this.btnSeciliOdemeleriSil.Click += new System.EventHandler(this.btnTumCalisanlariSil_Click);
            // 
            // btnOdemeSil
            // 
            this.btnOdemeSil.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnOdemeSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnOdemeSil.Appearance.Options.UseBackColor = true;
            this.btnOdemeSil.Appearance.Options.UseFont = true;
            this.btnOdemeSil.Appearance.Options.UseTextOptions = true;
            this.btnOdemeSil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnOdemeSil.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnOdemeSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeSil.ImageOptions.Image")));
            this.btnOdemeSil.Location = new System.Drawing.Point(13, 131);
            this.btnOdemeSil.Name = "btnOdemeSil";
            this.btnOdemeSil.Size = new System.Drawing.Size(198, 51);
            this.btnOdemeSil.TabIndex = 2;
            this.btnOdemeSil.Text = "ÖDEME SİL";
            this.btnOdemeSil.Click += new System.EventHandler(this.btnOdemeSil_Click);
            // 
            // btnOdemeDuzenle
            // 
            this.btnOdemeDuzenle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnOdemeDuzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnOdemeDuzenle.Appearance.Options.UseBackColor = true;
            this.btnOdemeDuzenle.Appearance.Options.UseFont = true;
            this.btnOdemeDuzenle.Appearance.Options.UseTextOptions = true;
            this.btnOdemeDuzenle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnOdemeDuzenle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnOdemeDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeDuzenle.ImageOptions.Image")));
            this.btnOdemeDuzenle.Location = new System.Drawing.Point(13, 74);
            this.btnOdemeDuzenle.Name = "btnOdemeDuzenle";
            this.btnOdemeDuzenle.Size = new System.Drawing.Size(198, 51);
            this.btnOdemeDuzenle.TabIndex = 2;
            this.btnOdemeDuzenle.Text = "ÖDEME DÜZENLE";
            this.btnOdemeDuzenle.Click += new System.EventHandler(this.btnOdemeDuzenle_Click);
            // 
            // btnOdemeEkle
            // 
            this.btnOdemeEkle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnOdemeEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnOdemeEkle.Appearance.Options.UseBackColor = true;
            this.btnOdemeEkle.Appearance.Options.UseFont = true;
            this.btnOdemeEkle.Appearance.Options.UseTextOptions = true;
            this.btnOdemeEkle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnOdemeEkle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnOdemeEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeEkle.ImageOptions.Image")));
            this.btnOdemeEkle.Location = new System.Drawing.Point(13, 17);
            this.btnOdemeEkle.Name = "btnOdemeEkle";
            this.btnOdemeEkle.Size = new System.Drawing.Size(198, 51);
            this.btnOdemeEkle.TabIndex = 2;
            this.btnOdemeEkle.Text = "ÖDEME EKLE";
            this.btnOdemeEkle.Click += new System.EventHandler(this.btnOdemeEkle_Click);
            // 
            // grdGelenOdemeler
            // 
            this.grdGelenOdemeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdGelenOdemeler.Location = new System.Drawing.Point(0, 48);
            this.grdGelenOdemeler.MainView = this.gridViewGelenOdemeler;
            this.grdGelenOdemeler.Name = "grdGelenOdemeler";
            this.grdGelenOdemeler.Size = new System.Drawing.Size(839, 439);
            this.grdGelenOdemeler.TabIndex = 0;
            this.grdGelenOdemeler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGelenOdemeler,
            this.gridView1});
            this.grdGelenOdemeler.Click += new System.EventHandler(this.grdGelenOdemeler_Click);
            // 
            // gridViewGelenOdemeler
            // 
            this.gridViewGelenOdemeler.ActiveFilterEnabled = false;
            this.gridViewGelenOdemeler.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewGelenOdemeler.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewGelenOdemeler.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewGelenOdemeler.Appearance.Row.Options.UseBackColor = true;
            this.gridViewGelenOdemeler.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridViewGelenOdemeler.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewGelenOdemeler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Aciklama,
            this.Tutar,
            this.Tarih,
            this.ID});
            this.gridViewGelenOdemeler.GridControl = this.grdGelenOdemeler;
            this.gridViewGelenOdemeler.Name = "gridViewGelenOdemeler";
            this.gridViewGelenOdemeler.OptionsSelection.MultiSelect = true;
            this.gridViewGelenOdemeler.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewGelenOdemeler.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewGelenOdemeler_RowStyle);
            this.gridViewGelenOdemeler.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewGelenOdemeler_SelectionChanged);
            this.gridViewGelenOdemeler.ColumnFilterChanged += new System.EventHandler(this.gridViewGelenOdemeler_ColumnFilterChanged);
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
            this.Aciklama.VisibleIndex = 1;
            // 
            // Tutar
            // 
            this.Tutar.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Tutar.AppearanceCell.Options.UseFont = true;
            this.Tutar.AppearanceCell.Options.UseTextOptions = true;
            this.Tutar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Tutar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Tutar.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.Tutar.AppearanceHeader.Options.UseFont = true;
            this.Tutar.AppearanceHeader.Options.UseForeColor = true;
            this.Tutar.Caption = "Tutar";
            this.Tutar.DisplayFormat.FormatString = "C";
            this.Tutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Tutar.FieldName = "Tutar";
            this.Tutar.Name = "Tutar";
            this.Tutar.OptionsColumn.AllowEdit = false;
            this.Tutar.Visible = true;
            this.Tutar.VisibleIndex = 3;
            // 
            // Tarih
            // 
            this.Tarih.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Tarih.AppearanceCell.Options.UseFont = true;
            this.Tarih.AppearanceCell.Options.UseTextOptions = true;
            this.Tarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Tarih.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Tarih.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.Tarih.AppearanceHeader.Options.UseFont = true;
            this.Tarih.AppearanceHeader.Options.UseForeColor = true;
            this.Tarih.Caption = "Tarih";
            this.Tarih.FieldName = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.OptionsColumn.AllowEdit = false;
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 2;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdGelenOdemeler;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.lblGelenOdemeToplami);
            this.groupControl5.Controls.Add(this.label1);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl5.Location = new System.Drawing.Point(0, 487);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.ShowCaption = false;
            this.groupControl5.Size = new System.Drawing.Size(839, 42);
            this.groupControl5.TabIndex = 5;
            this.groupControl5.Text = "groupControl5";
            // 
            // lblGelenOdemeToplami
            // 
            this.lblGelenOdemeToplami.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGelenOdemeToplami.AutoSize = true;
            this.lblGelenOdemeToplami.BackColor = System.Drawing.Color.Aqua;
            this.lblGelenOdemeToplami.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblGelenOdemeToplami.Location = new System.Drawing.Point(642, 16);
            this.lblGelenOdemeToplami.Name = "lblGelenOdemeToplami";
            this.lblGelenOdemeToplami.Size = new System.Drawing.Size(157, 17);
            this.lblGelenOdemeToplami.TabIndex = 0;
            this.lblGelenOdemeToplami.Text = "Gelen Ödeme Toplamı";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(479, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gelen Ödeme Toplamı";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.splitContainer2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(839, 48);
            this.groupControl1.TabIndex = 3;
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
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.btnAra);
            this.splitContainer2.Panel1.Controls.Add(this.btnTemizle);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.dtBitis);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.dtBaslangic);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.btnPDFe_Aktar);
            this.splitContainer2.Panel2.Controls.Add(this.btnExcele_Aktar);
            this.splitContainer2.Size = new System.Drawing.Size(835, 44);
            this.splitContainer2.SplitterDistance = 610;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(440, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(521, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Başlangıç Tarihi";
            // 
            // dtBitis
            // 
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitis.Location = new System.Drawing.Point(294, 13);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(117, 21);
            this.dtBitis.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bitiş Tarihi";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslangic.Location = new System.Drawing.Point(94, 13);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(117, 21);
            this.dtBaslangic.TabIndex = 2;
            this.dtBaslangic.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // btnPDFe_Aktar
            // 
            this.btnPDFe_Aktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDFe_Aktar.Appearance.BackColor = System.Drawing.Color.Firebrick;
            this.btnPDFe_Aktar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPDFe_Aktar.Appearance.Options.UseBackColor = true;
            this.btnPDFe_Aktar.Appearance.Options.UseFont = true;
            this.btnPDFe_Aktar.Location = new System.Drawing.Point(110, 11);
            this.btnPDFe_Aktar.Name = "btnPDFe_Aktar";
            this.btnPDFe_Aktar.Size = new System.Drawing.Size(89, 24);
            this.btnPDFe_Aktar.TabIndex = 10;
            this.btnPDFe_Aktar.Text = "PDF\'e Aktar";
            this.btnPDFe_Aktar.Click += new System.EventHandler(this.btnPDFe_Aktar_Click);
            // 
            // btnExcele_Aktar
            // 
            this.btnExcele_Aktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcele_Aktar.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnExcele_Aktar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExcele_Aktar.Appearance.Options.UseBackColor = true;
            this.btnExcele_Aktar.Appearance.Options.UseFont = true;
            this.btnExcele_Aktar.Location = new System.Drawing.Point(15, 10);
            this.btnExcele_Aktar.Name = "btnExcele_Aktar";
            this.btnExcele_Aktar.Size = new System.Drawing.Size(89, 24);
            this.btnExcele_Aktar.TabIndex = 11;
            this.btnExcele_Aktar.Text = "Exel\'e Aktar";
            this.btnExcele_Aktar.Click += new System.EventHandler(this.btnExcele_Aktar_Click);
            // 
            // frmGelenOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 529);
            this.Controls.Add(this.splitContainer1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmGelenOdemeler.IconOptions.SvgImage")));
            this.Name = "frmGelenOdemeler";
            this.Text = "Gelen Ödemeler Listesi";
            this.Load += new System.EventHandler(this.frmGelenOdemeler_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).EndInit();
            this.Müşteriler.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGelenOdemeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGelenOdemeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
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
        private DevExpress.XtraEditors.SimpleButton btnOdemeSil;
        private DevExpress.XtraEditors.SimpleButton btnOdemeDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnOdemeEkle;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraGrid.GridControl grdGelenOdemeler;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewGelenOdemeler;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn Tutar;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lblGelenOdemeToplami;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
        public DevExpress.XtraEditors.SimpleButton btnSeciliOdemeleriSil;
        private DevExpress.XtraEditors.SimpleButton btnExcele_Aktar;
        private DevExpress.XtraEditors.SimpleButton btnPDFe_Aktar;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.DateTimePicker dtBaslangic;
    }
}