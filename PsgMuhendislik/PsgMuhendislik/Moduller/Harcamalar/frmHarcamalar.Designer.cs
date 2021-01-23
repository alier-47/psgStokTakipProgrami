namespace PsgMuhendislik.Moduller.Harcamalar
{
    partial class frmHarcamalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHarcamalar));
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblHarcamalar = new System.Windows.Forms.Label();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
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
            this.grdHarcamalar = new DevExpress.XtraGrid.GridControl();
            this.gridViewHarcamalar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSeciliHarcamalariSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnHarcamaSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnHarcamaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnHarcamaDuzenle = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdHarcamalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHarcamalar)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).BeginInit();
            this.Müşteriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(534, 10);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblHarcamalar
            // 
            this.lblHarcamalar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHarcamalar.AutoSize = true;
            this.lblHarcamalar.BackColor = System.Drawing.Color.Aqua;
            this.lblHarcamalar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblHarcamalar.Location = new System.Drawing.Point(654, 18);
            this.lblHarcamalar.Name = "lblHarcamalar";
            this.lblHarcamalar.Size = new System.Drawing.Size(0, 17);
            this.lblHarcamalar.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.lblHarcamalar);
            this.groupControl4.Controls.Add(this.label1);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl4.Location = new System.Drawing.Point(0, 356);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.ShowCaption = false;
            this.groupControl4.Size = new System.Drawing.Size(823, 50);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "groupControl4";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(509, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harcama Toplamı";
            // 
            // dtBitis
            // 
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitis.Location = new System.Drawing.Point(303, 11);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(117, 21);
            this.dtBitis.TabIndex = 2;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslangic.Location = new System.Drawing.Point(103, 11);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(117, 21);
            this.dtBaslangic.TabIndex = 2;
            this.dtBaslangic.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(449, 10);
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
            this.label4.Location = new System.Drawing.Point(242, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bitiş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Başlangıç Tarihi";
            // 
            // groupControl2
            // 
            this.groupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl2.Controls.Add(this.splitContainer2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(823, 46);
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
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.dtBaslangic);
            this.splitContainer2.Panel1.Controls.Add(this.btnTemizle);
            this.splitContainer2.Panel1.Controls.Add(this.dtBitis);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.btnAra);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.btnExcele_Aktar);
            this.splitContainer2.Panel2.Controls.Add(this.btnPDFe_Aktar);
            this.splitContainer2.Size = new System.Drawing.Size(819, 42);
            this.splitContainer2.SplitterDistance = 611;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnExcele_Aktar
            // 
            this.btnExcele_Aktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcele_Aktar.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnExcele_Aktar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExcele_Aktar.Appearance.Options.UseBackColor = true;
            this.btnExcele_Aktar.Appearance.Options.UseFont = true;
            this.btnExcele_Aktar.Location = new System.Drawing.Point(10, 10);
            this.btnExcele_Aktar.Name = "btnExcele_Aktar";
            this.btnExcele_Aktar.Size = new System.Drawing.Size(89, 24);
            this.btnExcele_Aktar.TabIndex = 11;
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
            this.btnPDFe_Aktar.Location = new System.Drawing.Point(105, 10);
            this.btnPDFe_Aktar.Name = "btnPDFe_Aktar";
            this.btnPDFe_Aktar.Size = new System.Drawing.Size(89, 24);
            this.btnPDFe_Aktar.TabIndex = 10;
            this.btnPDFe_Aktar.Text = "PDF\'e Aktar";
            this.btnPDFe_Aktar.Click += new System.EventHandler(this.btnPDFe_Aktar_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdHarcamalar;
            this.gridView1.Name = "gridView1";
            // 
            // grdHarcamalar
            // 
            this.grdHarcamalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHarcamalar.Location = new System.Drawing.Point(0, 46);
            this.grdHarcamalar.MainView = this.gridViewHarcamalar;
            this.grdHarcamalar.Name = "grdHarcamalar";
            this.grdHarcamalar.Size = new System.Drawing.Size(823, 310);
            this.grdHarcamalar.TabIndex = 0;
            this.grdHarcamalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHarcamalar,
            this.gridView1});
            // 
            // gridViewHarcamalar
            // 
            this.gridViewHarcamalar.ActiveFilterEnabled = false;
            this.gridViewHarcamalar.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewHarcamalar.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewHarcamalar.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewHarcamalar.Appearance.Row.Options.UseBackColor = true;
            this.gridViewHarcamalar.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridViewHarcamalar.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewHarcamalar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Tarih,
            this.Aciklama,
            this.Tutar,
            this.ID});
            this.gridViewHarcamalar.GridControl = this.grdHarcamalar;
            this.gridViewHarcamalar.Name = "gridViewHarcamalar";
            this.gridViewHarcamalar.OptionsSelection.MultiSelect = true;
            this.gridViewHarcamalar.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewHarcamalar.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewHarcamalar_RowStyle);
            this.gridViewHarcamalar.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewHarcamalar_SelectionChanged);
            this.gridViewHarcamalar.ColumnFilterChanged += new System.EventHandler(this.gridViewHarcamalar_ColumnFilterChanged);
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
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // btnSeciliHarcamalariSil
            // 
            this.btnSeciliHarcamalariSil.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnSeciliHarcamalariSil.Appearance.Font = new System.Drawing.Font("Tahoma", 8.7F, System.Drawing.FontStyle.Bold);
            this.btnSeciliHarcamalariSil.Appearance.Options.UseBackColor = true;
            this.btnSeciliHarcamalariSil.Appearance.Options.UseFont = true;
            this.btnSeciliHarcamalariSil.Appearance.Options.UseTextOptions = true;
            this.btnSeciliHarcamalariSil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSeciliHarcamalariSil.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnSeciliHarcamalariSil.Enabled = false;
            this.btnSeciliHarcamalariSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeciliHarcamalariSil.ImageOptions.Image")));
            this.btnSeciliHarcamalariSil.Location = new System.Drawing.Point(13, 188);
            this.btnSeciliHarcamalariSil.Name = "btnSeciliHarcamalariSil";
            this.btnSeciliHarcamalariSil.Size = new System.Drawing.Size(208, 51);
            this.btnSeciliHarcamalariSil.TabIndex = 2;
            this.btnSeciliHarcamalariSil.Text = "SEÇİLİ HARCAMALARI SİL";
            this.btnSeciliHarcamalariSil.Click += new System.EventHandler(this.btnSeciliHarcamalariSil_Click);
            // 
            // btnHarcamaSil
            // 
            this.btnHarcamaSil.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnHarcamaSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnHarcamaSil.Appearance.Options.UseBackColor = true;
            this.btnHarcamaSil.Appearance.Options.UseFont = true;
            this.btnHarcamaSil.Appearance.Options.UseTextOptions = true;
            this.btnHarcamaSil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnHarcamaSil.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnHarcamaSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHarcamaSil.ImageOptions.Image")));
            this.btnHarcamaSil.Location = new System.Drawing.Point(13, 131);
            this.btnHarcamaSil.Name = "btnHarcamaSil";
            this.btnHarcamaSil.Size = new System.Drawing.Size(208, 51);
            this.btnHarcamaSil.TabIndex = 2;
            this.btnHarcamaSil.Text = "HARCAMA SİL";
            this.btnHarcamaSil.Click += new System.EventHandler(this.btnHarcamaSil_Click);
            // 
            // btnHarcamaEkle
            // 
            this.btnHarcamaEkle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnHarcamaEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnHarcamaEkle.Appearance.Options.UseBackColor = true;
            this.btnHarcamaEkle.Appearance.Options.UseFont = true;
            this.btnHarcamaEkle.Appearance.Options.UseTextOptions = true;
            this.btnHarcamaEkle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnHarcamaEkle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnHarcamaEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHarcamaEkle.ImageOptions.Image")));
            this.btnHarcamaEkle.Location = new System.Drawing.Point(13, 17);
            this.btnHarcamaEkle.Name = "btnHarcamaEkle";
            this.btnHarcamaEkle.Size = new System.Drawing.Size(208, 51);
            this.btnHarcamaEkle.TabIndex = 2;
            this.btnHarcamaEkle.Text = "HARCAMA EKLE";
            this.btnHarcamaEkle.Click += new System.EventHandler(this.btnHarcamaEkle_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnSeciliHarcamalariSil);
            this.xtraTabPage1.Controls.Add(this.btnHarcamaSil);
            this.xtraTabPage1.Controls.Add(this.btnHarcamaDuzenle);
            this.xtraTabPage1.Controls.Add(this.btnHarcamaEkle);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(224, 392);
            // 
            // btnHarcamaDuzenle
            // 
            this.btnHarcamaDuzenle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnHarcamaDuzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnHarcamaDuzenle.Appearance.Options.UseBackColor = true;
            this.btnHarcamaDuzenle.Appearance.Options.UseFont = true;
            this.btnHarcamaDuzenle.Appearance.Options.UseTextOptions = true;
            this.btnHarcamaDuzenle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnHarcamaDuzenle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnHarcamaDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHarcamaDuzenle.ImageOptions.Image")));
            this.btnHarcamaDuzenle.Location = new System.Drawing.Point(13, 74);
            this.btnHarcamaDuzenle.Name = "btnHarcamaDuzenle";
            this.btnHarcamaDuzenle.Size = new System.Drawing.Size(208, 51);
            this.btnHarcamaDuzenle.TabIndex = 2;
            this.btnHarcamaDuzenle.Text = "HARCAMA DÜZENLE";
            this.btnHarcamaDuzenle.Click += new System.EventHandler(this.btnHarcamaDuzenle_Click);
            // 
            // Müşteriler
            // 
            this.Müşteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Müşteriler.Location = new System.Drawing.Point(0, 0);
            this.Müşteriler.Name = "Müşteriler";
            this.Müşteriler.SelectedTabPage = this.xtraTabPage1;
            this.Müşteriler.Size = new System.Drawing.Size(226, 406);
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
            this.splitContainer1.Panel2.Controls.Add(this.grdHarcamalar);
            this.splitContainer1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer1.Panel2.Controls.Add(this.groupControl4);
            this.splitContainer1.Size = new System.Drawing.Size(1053, 406);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 4;
            // 
            // frmHarcamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 406);
            this.Controls.Add(this.splitContainer1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmHarcamalar.IconOptions.SvgImage")));
            this.Name = "frmHarcamalar";
            this.Text = "Harcamalar Listesi";
            this.Load += new System.EventHandler(this.frmHarcamalar_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdHarcamalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHarcamalar)).EndInit();
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

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblHarcamalar;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl grdHarcamalar;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewHarcamalar;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn Tutar;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton btnHarcamaEkle;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabControl Müşteriler;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public DevExpress.XtraEditors.SimpleButton btnHarcamaDuzenle;
        public DevExpress.XtraEditors.SimpleButton btnHarcamaSil;
        public DevExpress.XtraEditors.SimpleButton btnSeciliHarcamalariSil;
        private DevExpress.XtraEditors.SimpleButton btnExcele_Aktar;
        private DevExpress.XtraEditors.SimpleButton btnPDFe_Aktar;
        private System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.DateTimePicker dtBaslangic;
    }
}