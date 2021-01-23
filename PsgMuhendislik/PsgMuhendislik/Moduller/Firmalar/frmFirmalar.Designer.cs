namespace PsgMuhendislik.Modul_Firmalar
{
    partial class frmFirmalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirmalar));
            this.Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FirmaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewFirmalar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Borc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdFirmalar = new DevExpress.XtraGrid.GridControl();
            this.btnTumFirmalariSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirmaDetayi = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeYap = new DevExpress.XtraEditors.SimpleButton();
            this.btnBorcEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirmaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnFirmaSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirmaDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.Müşteriler = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblBorc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFirmalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFirmalar)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).BeginInit();
            this.Müşteriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
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
            // FirmaAdi
            // 
            this.FirmaAdi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FirmaAdi.AppearanceCell.Options.UseFont = true;
            this.FirmaAdi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FirmaAdi.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.FirmaAdi.AppearanceHeader.Options.UseFont = true;
            this.FirmaAdi.AppearanceHeader.Options.UseForeColor = true;
            this.FirmaAdi.Caption = "Firma Adı";
            this.FirmaAdi.FieldName = "FirmaAdi";
            this.FirmaAdi.Name = "FirmaAdi";
            this.FirmaAdi.OptionsColumn.AllowEdit = false;
            this.FirmaAdi.Visible = true;
            this.FirmaAdi.VisibleIndex = 1;
            // 
            // gridViewFirmalar
            // 
            this.gridViewFirmalar.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewFirmalar.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Navy;
            this.gridViewFirmalar.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewFirmalar.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewFirmalar.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewFirmalar.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewFirmalar.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewFirmalar.Appearance.Row.Options.UseBackColor = true;
            this.gridViewFirmalar.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewFirmalar.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewFirmalar.Appearance.SelectedRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewFirmalar.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewFirmalar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirmaAdi,
            this.Telefon,
            this.Borc,
            this.Tarih,
            this.ID});
            this.gridViewFirmalar.GridControl = this.grdFirmalar;
            this.gridViewFirmalar.Name = "gridViewFirmalar";
            this.gridViewFirmalar.OptionsDetail.ShowDetailTabs = false;
            this.gridViewFirmalar.OptionsSelection.MultiSelect = true;
            this.gridViewFirmalar.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewFirmalar.OptionsView.ShowDetailButtons = false;
            this.gridViewFirmalar.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewFirmalar_RowStyle);
            this.gridViewFirmalar.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewFirmalar_SelectionChanged);
            this.gridViewFirmalar.ColumnFilterChanged += new System.EventHandler(this.gridViewFirmalar_ColumnFilterChanged);
            this.gridViewFirmalar.DoubleClick += new System.EventHandler(this.gridViewFirmalar_DoubleClick);
            // 
            // Borc
            // 
            this.Borc.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Borc.AppearanceCell.Options.UseFont = true;
            this.Borc.AppearanceCell.Options.UseTextOptions = true;
            this.Borc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Borc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Borc.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.Borc.AppearanceHeader.Options.UseFont = true;
            this.Borc.AppearanceHeader.Options.UseForeColor = true;
            this.Borc.Caption = "Bakiye";
            this.Borc.DisplayFormat.FormatString = "C2";
            this.Borc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Borc.FieldName = "Borc";
            this.Borc.Name = "Borc";
            this.Borc.OptionsColumn.AllowEdit = false;
            this.Borc.Visible = true;
            this.Borc.VisibleIndex = 3;
            // 
            // Tarih
            // 
            this.Tarih.Caption = "Kayıt Tarihi";
            this.Tarih.FieldName = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 4;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // grdFirmalar
            // 
            this.grdFirmalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFirmalar.Location = new System.Drawing.Point(2, 2);
            this.grdFirmalar.MainView = this.gridViewFirmalar;
            this.grdFirmalar.Name = "grdFirmalar";
            this.grdFirmalar.Size = new System.Drawing.Size(533, 360);
            this.grdFirmalar.TabIndex = 0;
            this.grdFirmalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFirmalar});
            // 
            // btnTumFirmalariSil
            // 
            this.btnTumFirmalariSil.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnTumFirmalariSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnTumFirmalariSil.Appearance.Options.UseBackColor = true;
            this.btnTumFirmalariSil.Appearance.Options.UseFont = true;
            this.btnTumFirmalariSil.Appearance.Options.UseTextOptions = true;
            this.btnTumFirmalariSil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnTumFirmalariSil.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnTumFirmalariSil.Enabled = false;
            this.btnTumFirmalariSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTumFirmalariSil.ImageOptions.Image")));
            this.btnTumFirmalariSil.Location = new System.Drawing.Point(13, 359);
            this.btnTumFirmalariSil.Name = "btnTumFirmalariSil";
            this.btnTumFirmalariSil.Size = new System.Drawing.Size(198, 51);
            this.btnTumFirmalariSil.TabIndex = 2;
            this.btnTumFirmalariSil.Text = "SEÇİLİ FİRMALARI SİL";
            this.btnTumFirmalariSil.Click += new System.EventHandler(this.btnTumFirmalariSil_Click);
            // 
            // btnFirmaDetayi
            // 
            this.btnFirmaDetayi.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnFirmaDetayi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnFirmaDetayi.Appearance.Options.UseBackColor = true;
            this.btnFirmaDetayi.Appearance.Options.UseFont = true;
            this.btnFirmaDetayi.Appearance.Options.UseTextOptions = true;
            this.btnFirmaDetayi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnFirmaDetayi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnFirmaDetayi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaDetayi.ImageOptions.Image")));
            this.btnFirmaDetayi.Location = new System.Drawing.Point(13, 302);
            this.btnFirmaDetayi.Name = "btnFirmaDetayi";
            this.btnFirmaDetayi.Size = new System.Drawing.Size(198, 51);
            this.btnFirmaDetayi.TabIndex = 2;
            this.btnFirmaDetayi.Text = "FİRMA DETAYI";
            this.btnFirmaDetayi.Click += new System.EventHandler(this.btnFirmaDetayi_Click);
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
            this.btnOdemeYap.Location = new System.Drawing.Point(13, 245);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(198, 51);
            this.btnOdemeYap.TabIndex = 2;
            this.btnOdemeYap.Text = "ÖDEME YAP";
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // btnBorcEkle
            // 
            this.btnBorcEkle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnBorcEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnBorcEkle.Appearance.Options.UseBackColor = true;
            this.btnBorcEkle.Appearance.Options.UseFont = true;
            this.btnBorcEkle.Appearance.Options.UseTextOptions = true;
            this.btnBorcEkle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnBorcEkle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnBorcEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBorcEkle.ImageOptions.Image")));
            this.btnBorcEkle.Location = new System.Drawing.Point(13, 188);
            this.btnBorcEkle.Name = "btnBorcEkle";
            this.btnBorcEkle.Size = new System.Drawing.Size(198, 51);
            this.btnBorcEkle.TabIndex = 2;
            this.btnBorcEkle.Text = "BORÇ EKLE";
            this.btnBorcEkle.Click += new System.EventHandler(this.btnBorcEkle_Click);
            // 
            // btnFirmaEkle
            // 
            this.btnFirmaEkle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnFirmaEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnFirmaEkle.Appearance.Options.UseBackColor = true;
            this.btnFirmaEkle.Appearance.Options.UseFont = true;
            this.btnFirmaEkle.Appearance.Options.UseTextOptions = true;
            this.btnFirmaEkle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnFirmaEkle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnFirmaEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaEkle.ImageOptions.Image")));
            this.btnFirmaEkle.Location = new System.Drawing.Point(13, 17);
            this.btnFirmaEkle.Name = "btnFirmaEkle";
            this.btnFirmaEkle.Size = new System.Drawing.Size(198, 51);
            this.btnFirmaEkle.TabIndex = 2;
            this.btnFirmaEkle.Text = "FİRMA EKLE";
            this.btnFirmaEkle.Click += new System.EventHandler(this.btnFirmaEkle_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnTumFirmalariSil);
            this.xtraTabPage1.Controls.Add(this.btnFirmaDetayi);
            this.xtraTabPage1.Controls.Add(this.btnOdemeYap);
            this.xtraTabPage1.Controls.Add(this.btnBorcEkle);
            this.xtraTabPage1.Controls.Add(this.btnFirmaSil);
            this.xtraTabPage1.Controls.Add(this.btnFirmaDuzenle);
            this.xtraTabPage1.Controls.Add(this.btnFirmaEkle);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(219, 393);
            // 
            // btnFirmaSil
            // 
            this.btnFirmaSil.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnFirmaSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnFirmaSil.Appearance.Options.UseBackColor = true;
            this.btnFirmaSil.Appearance.Options.UseFont = true;
            this.btnFirmaSil.Appearance.Options.UseTextOptions = true;
            this.btnFirmaSil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnFirmaSil.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnFirmaSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaSil.ImageOptions.Image")));
            this.btnFirmaSil.Location = new System.Drawing.Point(13, 131);
            this.btnFirmaSil.Name = "btnFirmaSil";
            this.btnFirmaSil.Size = new System.Drawing.Size(198, 51);
            this.btnFirmaSil.TabIndex = 2;
            this.btnFirmaSil.Text = "FİRMA SİL";
            this.btnFirmaSil.Click += new System.EventHandler(this.btnFirmaSil_Click);
            // 
            // btnFirmaDuzenle
            // 
            this.btnFirmaDuzenle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnFirmaDuzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnFirmaDuzenle.Appearance.Options.UseBackColor = true;
            this.btnFirmaDuzenle.Appearance.Options.UseFont = true;
            this.btnFirmaDuzenle.Appearance.Options.UseTextOptions = true;
            this.btnFirmaDuzenle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnFirmaDuzenle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnFirmaDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaDuzenle.ImageOptions.Image")));
            this.btnFirmaDuzenle.Location = new System.Drawing.Point(13, 74);
            this.btnFirmaDuzenle.Name = "btnFirmaDuzenle";
            this.btnFirmaDuzenle.Size = new System.Drawing.Size(198, 51);
            this.btnFirmaDuzenle.TabIndex = 2;
            this.btnFirmaDuzenle.Text = "FİRMA DÜZENLE";
            this.btnFirmaDuzenle.Click += new System.EventHandler(this.btnFirmaDuzenle_Click);
            // 
            // Müşteriler
            // 
            this.Müşteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Müşteriler.Location = new System.Drawing.Point(0, 0);
            this.Müşteriler.Name = "Müşteriler";
            this.Müşteriler.SelectedTabPage = this.xtraTabPage1;
            this.Müşteriler.Size = new System.Drawing.Size(221, 407);
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
            this.splitContainer1.Panel2.Controls.Add(this.groupControl3);
            this.splitContainer1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer1.Size = new System.Drawing.Size(762, 407);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.grdFirmalar);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(537, 364);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "groupControl3";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblBorc);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 364);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(537, 43);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "groupControl2";
            // 
            // lblBorc
            // 
            this.lblBorc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBorc.AutoSize = true;
            this.lblBorc.BackColor = System.Drawing.Color.Aqua;
            this.lblBorc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblBorc.Location = new System.Drawing.Point(409, 13);
            this.lblBorc.Name = "lblBorc";
            this.lblBorc.Size = new System.Drawing.Size(0, 17);
            this.lblBorc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(301, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam Borç";
            // 
            // frmFirmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 407);
            this.Controls.Add(this.splitContainer1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmFirmalar.IconOptions.SvgImage")));
            this.Name = "frmFirmalar";
            this.Text = "Firmalar Listesi";
            this.Load += new System.EventHandler(this.frmFirmalar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFirmalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFirmalar)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).EndInit();
            this.Müşteriler.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn Telefon;
        private DevExpress.XtraGrid.Columns.GridColumn FirmaAdi;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewFirmalar;
        private DevExpress.XtraGrid.Columns.GridColumn Borc;
        public DevExpress.XtraGrid.GridControl grdFirmalar;
        private DevExpress.XtraEditors.SimpleButton btnFirmaDetayi;
        private DevExpress.XtraEditors.SimpleButton btnOdemeYap;
        private DevExpress.XtraEditors.SimpleButton btnBorcEkle;
        private DevExpress.XtraEditors.SimpleButton btnFirmaEkle;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnFirmaSil;
        private DevExpress.XtraEditors.SimpleButton btnFirmaDuzenle;
        private DevExpress.XtraTab.XtraTabControl Müşteriler;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label lblBorc;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton btnTumFirmalariSil;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
    }
}