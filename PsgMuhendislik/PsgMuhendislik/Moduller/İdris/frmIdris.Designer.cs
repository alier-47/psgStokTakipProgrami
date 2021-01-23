namespace PsgMuhendislik.Moduller.İdris
{
    partial class frmIdris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdris));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Müşteriler = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSeciliSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.grdIdris = new DevExpress.XtraGrid.GridControl();
            this.gridViewIdris = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnExcele_Aktar = new DevExpress.XtraEditors.SimpleButton();
            this.btnPDFe_Aktar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).BeginInit();
            this.Müşteriler.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIdris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIdris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.grdIdris);
            this.splitContainer1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer1.Panel2.Controls.Add(this.groupControl4);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 438);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 5;
            // 
            // Müşteriler
            // 
            this.Müşteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Müşteriler.Location = new System.Drawing.Point(0, 0);
            this.Müşteriler.Name = "Müşteriler";
            this.Müşteriler.SelectedTabPage = this.xtraTabPage1;
            this.Müşteriler.Size = new System.Drawing.Size(226, 438);
            this.Müşteriler.TabIndex = 0;
            this.Müşteriler.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnSeciliSil);
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.btnDuzenle);
            this.xtraTabPage1.Controls.Add(this.btnEkle);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(224, 424);
            // 
            // btnSeciliSil
            // 
            this.btnSeciliSil.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnSeciliSil.Appearance.Font = new System.Drawing.Font("Tahoma", 8.7F, System.Drawing.FontStyle.Bold);
            this.btnSeciliSil.Appearance.Options.UseBackColor = true;
            this.btnSeciliSil.Appearance.Options.UseFont = true;
            this.btnSeciliSil.Appearance.Options.UseTextOptions = true;
            this.btnSeciliSil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSeciliSil.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnSeciliSil.Enabled = false;
            this.btnSeciliSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeciliSil.ImageOptions.Image")));
            this.btnSeciliSil.Location = new System.Drawing.Point(13, 188);
            this.btnSeciliSil.Name = "btnSeciliSil";
            this.btnSeciliSil.Size = new System.Drawing.Size(208, 51);
            this.btnSeciliSil.TabIndex = 2;
            this.btnSeciliSil.Text = "SEÇİLİLERİ SİL";
            this.btnSeciliSil.Click += new System.EventHandler(this.btnSeciliSil_Click);
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
            this.btnDuzenle.TabIndex = 2;
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
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // grdIdris
            // 
            this.grdIdris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdIdris.Location = new System.Drawing.Point(0, 46);
            this.grdIdris.MainView = this.gridViewIdris;
            this.grdIdris.Name = "grdIdris";
            this.grdIdris.Size = new System.Drawing.Size(913, 342);
            this.grdIdris.TabIndex = 0;
            this.grdIdris.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewIdris,
            this.gridView1});
            // 
            // gridViewIdris
            // 
            this.gridViewIdris.ActiveFilterEnabled = false;
            this.gridViewIdris.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewIdris.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewIdris.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewIdris.Appearance.Row.Options.UseBackColor = true;
            this.gridViewIdris.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridViewIdris.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewIdris.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Tarih,
            this.Aciklama,
            this.Tutar,
            this.ID});
            this.gridViewIdris.GridControl = this.grdIdris;
            this.gridViewIdris.Name = "gridViewIdris";
            this.gridViewIdris.OptionsSelection.MultiSelect = true;
            this.gridViewIdris.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewIdris.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewIdris_RowStyle);
            this.gridViewIdris.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewIdris_SelectionChanged);
            this.gridViewIdris.ColumnFilterChanged += new System.EventHandler(this.gridViewIdris_ColumnFilterChanged);
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
            // gridView1
            // 
            this.gridView1.GridControl = this.grdIdris;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Controls.Add(this.splitContainer2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(913, 46);
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
            this.splitContainer2.Panel1.Controls.Add(this.btnTemizle);
            this.splitContainer2.Panel1.Controls.Add(this.dtBaslangic);
            this.splitContainer2.Panel1.Controls.Add(this.dtBitis);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.btnAra);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnExcele_Aktar);
            this.splitContainer2.Panel2.Controls.Add(this.btnPDFe_Aktar);
            this.splitContainer2.Size = new System.Drawing.Size(909, 42);
            this.splitContainer2.SplitterDistance = 695;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(525, 9);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslangic.Location = new System.Drawing.Point(94, 10);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtBaslangic.Size = new System.Drawing.Size(117, 21);
            this.dtBaslangic.TabIndex = 2;
            this.dtBaslangic.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // dtBitis
            // 
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitis.Location = new System.Drawing.Point(294, 10);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtBitis.Size = new System.Drawing.Size(117, 21);
            this.dtBitis.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 14);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bitiş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Başlangıç Tarihi";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(440, 9);
            this.btnAra.Name = "btnAra";
            this.btnAra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 1;
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
            this.btnExcele_Aktar.Location = new System.Drawing.Point(16, 9);
            this.btnExcele_Aktar.Name = "btnExcele_Aktar";
            this.btnExcele_Aktar.Size = new System.Drawing.Size(89, 24);
            this.btnExcele_Aktar.TabIndex = 13;
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
            this.btnPDFe_Aktar.Location = new System.Drawing.Point(111, 9);
            this.btnPDFe_Aktar.Name = "btnPDFe_Aktar";
            this.btnPDFe_Aktar.Size = new System.Drawing.Size(89, 24);
            this.btnPDFe_Aktar.TabIndex = 12;
            this.btnPDFe_Aktar.Text = "PDF\'e Aktar";
            this.btnPDFe_Aktar.Click += new System.EventHandler(this.btnPDFe_Aktar_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.lblToplam);
            this.groupControl4.Controls.Add(this.label1);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl4.Location = new System.Drawing.Point(0, 388);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.ShowCaption = false;
            this.groupControl4.Size = new System.Drawing.Size(913, 50);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "groupControl4";
            // 
            // lblToplam
            // 
            this.lblToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Aqua;
            this.lblToplam.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplam.Location = new System.Drawing.Point(744, 18);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(0, 17);
            this.lblToplam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(656, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam";
            // 
            // frmIdris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 438);
            this.Controls.Add(this.splitContainer1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmIdris.IconOptions.LargeImage")));
            this.Name = "frmIdris";
            this.Text = "İdris Alınan Para Listesi";
            this.Load += new System.EventHandler(this.frmIdris_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).EndInit();
            this.Müşteriler.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdIdris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIdris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTab.XtraTabControl Müşteriler;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        public DevExpress.XtraEditors.SimpleButton btnSeciliSil;
        public DevExpress.XtraEditors.SimpleButton btnSil;
        public DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        public DevExpress.XtraGrid.GridControl grdIdris;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewIdris;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn Tutar;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraEditors.SimpleButton btnExcele_Aktar;
        private DevExpress.XtraEditors.SimpleButton btnPDFe_Aktar;
        public System.Windows.Forms.DateTimePicker dtBaslangic;
    }
}