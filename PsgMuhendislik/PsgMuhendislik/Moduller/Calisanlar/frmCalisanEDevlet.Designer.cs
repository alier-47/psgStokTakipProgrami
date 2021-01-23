
namespace PsgMuhendislik.Moduller.Calisanlar
{
    partial class frmCalisanEDevlet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalisanEDevlet));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Müşteriler = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.grdCalisanEDevlet = new DevExpress.XtraGrid.GridControl();
            this.gridViewCalisanEDevlet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TcNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sifre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CalisanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.lblCalisanAdi = new System.Windows.Forms.Label();
            this.lblCalisanID = new System.Windows.Forms.Label();
            this.lblEksikGun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).BeginInit();
            this.Müşteriler.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCalisanEDevlet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCalisanEDevlet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.grdCalisanEDevlet);
            this.splitContainer1.Panel2.Controls.Add(this.groupControl4);
            this.splitContainer1.Size = new System.Drawing.Size(888, 416);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 7;
            // 
            // Müşteriler
            // 
            this.Müşteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Müşteriler.Location = new System.Drawing.Point(0, 0);
            this.Müşteriler.Name = "Müşteriler";
            this.Müşteriler.SelectedTabPage = this.xtraTabPage1;
            this.Müşteriler.Size = new System.Drawing.Size(226, 416);
            this.Müşteriler.TabIndex = 0;
            this.Müşteriler.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.btnEkle);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(224, 402);
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
            this.btnSil.Location = new System.Drawing.Point(13, 74);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(208, 51);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            // grdCalisanEDevlet
            // 
            this.grdCalisanEDevlet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCalisanEDevlet.Location = new System.Drawing.Point(0, 0);
            this.grdCalisanEDevlet.MainView = this.gridViewCalisanEDevlet;
            this.grdCalisanEDevlet.Name = "grdCalisanEDevlet";
            this.grdCalisanEDevlet.Size = new System.Drawing.Size(658, 366);
            this.grdCalisanEDevlet.TabIndex = 0;
            this.grdCalisanEDevlet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCalisanEDevlet,
            this.gridView1});
            // 
            // gridViewCalisanEDevlet
            // 
            this.gridViewCalisanEDevlet.ActiveFilterEnabled = false;
            this.gridViewCalisanEDevlet.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCalisanEDevlet.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCalisanEDevlet.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewCalisanEDevlet.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridViewCalisanEDevlet.Appearance.Row.Options.UseBackColor = true;
            this.gridViewCalisanEDevlet.Appearance.Row.Options.UseFont = true;
            this.gridViewCalisanEDevlet.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewCalisanEDevlet.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCalisanEDevlet.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridViewCalisanEDevlet.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewCalisanEDevlet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TcNo,
            this.Sifre,
            this.ID,
            this.CalisanID});
            this.gridViewCalisanEDevlet.GridControl = this.grdCalisanEDevlet;
            this.gridViewCalisanEDevlet.Name = "gridViewCalisanEDevlet";
            this.gridViewCalisanEDevlet.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewCalisanEDevlet.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewCalisanEDevlet_RowStyle);
            // 
            // TcNo
            // 
            this.TcNo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TcNo.AppearanceCell.Options.UseFont = true;
            this.TcNo.AppearanceCell.Options.UseTextOptions = true;
            this.TcNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TcNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TcNo.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.TcNo.AppearanceHeader.Options.UseFont = true;
            this.TcNo.AppearanceHeader.Options.UseForeColor = true;
            this.TcNo.Caption = "Tc Kimlik Numarası";
            this.TcNo.FieldName = "TcNo";
            this.TcNo.Name = "TcNo";
            this.TcNo.OptionsColumn.AllowEdit = false;
            this.TcNo.Visible = true;
            this.TcNo.VisibleIndex = 0;
            // 
            // Sifre
            // 
            this.Sifre.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Sifre.AppearanceCell.Options.UseFont = true;
            this.Sifre.AppearanceCell.Options.UseTextOptions = true;
            this.Sifre.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Sifre.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Sifre.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.Sifre.AppearanceHeader.Options.UseFont = true;
            this.Sifre.AppearanceHeader.Options.UseForeColor = true;
            this.Sifre.Caption = "Şifre";
            this.Sifre.FieldName = "Sifre";
            this.Sifre.Name = "Sifre";
            this.Sifre.OptionsColumn.AllowEdit = false;
            this.Sifre.Visible = true;
            this.Sifre.VisibleIndex = 1;
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
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCalisanEDevlet;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.lblCalisanAdi);
            this.groupControl4.Controls.Add(this.lblCalisanID);
            this.groupControl4.Controls.Add(this.lblEksikGun);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl4.Location = new System.Drawing.Point(0, 366);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.ShowCaption = false;
            this.groupControl4.Size = new System.Drawing.Size(658, 50);
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
            this.lblEksikGun.Location = new System.Drawing.Point(489, 18);
            this.lblEksikGun.Name = "lblEksikGun";
            this.lblEksikGun.Size = new System.Drawing.Size(0, 17);
            this.lblEksikGun.TabIndex = 0;
            // 
            // frmCalisanEDevlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 416);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCalisanEDevlet";
            this.Text = "Çalışan E Devlet Bilgisi";
            this.Load += new System.EventHandler(this.frmCalisanEDevlet_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Müşteriler)).EndInit();
            this.Müşteriler.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCalisanEDevlet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCalisanEDevlet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTab.XtraTabControl Müşteriler;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        public DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        public DevExpress.XtraGrid.GridControl grdCalisanEDevlet;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewCalisanEDevlet;
        private DevExpress.XtraGrid.Columns.GridColumn TcNo;
        private DevExpress.XtraGrid.Columns.GridColumn Sifre;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CalisanID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        public System.Windows.Forms.Label lblCalisanAdi;
        public System.Windows.Forms.Label lblCalisanID;
        private System.Windows.Forms.Label lblEksikGun;
    }
}