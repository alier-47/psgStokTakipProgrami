namespace PsgMuhendislik
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.btnFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCalisanlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnGelenOdemeler = new DevExpress.XtraBars.BarButtonItem();
            this.btnHarcamalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnİdris = new DevExpress.XtraBars.BarButtonItem();
            this.btnYedekle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 503);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(930, 24);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnMusteriler,
            this.btnFirmalar,
            this.btnCalisanlar,
            this.btnGelenOdemeler,
            this.btnHarcamalar,
            this.btnİdris,
            this.btnYedekle,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(930, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Caption = "MÜŞTERİLER";
            this.btnMusteriler.Id = 1;
            this.btnMusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.ImageOptions.LargeImage")));
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriler_ItemClick);
            // 
            // btnFirmalar
            // 
            this.btnFirmalar.Caption = "FİRMALAR";
            this.btnFirmalar.Id = 2;
            this.btnFirmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFirmalar.ImageOptions.LargeImage")));
            this.btnFirmalar.Name = "btnFirmalar";
            this.btnFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFirmalar_ItemClick);
            // 
            // btnCalisanlar
            // 
            this.btnCalisanlar.Caption = "ÇALIŞANLAR";
            this.btnCalisanlar.Id = 3;
            this.btnCalisanlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCalisanlar.ImageOptions.LargeImage")));
            this.btnCalisanlar.Name = "btnCalisanlar";
            this.btnCalisanlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCalisanlar_ItemClick);
            // 
            // btnGelenOdemeler
            // 
            this.btnGelenOdemeler.Caption = "GELEN ÖDEMELER";
            this.btnGelenOdemeler.Id = 4;
            this.btnGelenOdemeler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGelenOdemeler.ImageOptions.LargeImage")));
            this.btnGelenOdemeler.LargeWidth = 100;
            this.btnGelenOdemeler.Name = "btnGelenOdemeler";
            this.btnGelenOdemeler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGelenOdemeler_ItemClick);
            // 
            // btnHarcamalar
            // 
            this.btnHarcamalar.Caption = "HARCAMALAR";
            this.btnHarcamalar.Id = 5;
            this.btnHarcamalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHarcamalar.ImageOptions.LargeImage")));
            this.btnHarcamalar.Name = "btnHarcamalar";
            this.btnHarcamalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHarcamalar_ItemClick);
            // 
            // btnİdris
            // 
            this.btnİdris.Caption = "İDRİS";
            this.btnİdris.Id = 6;
            this.btnİdris.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnİdris.ImageOptions.LargeImage")));
            this.btnİdris.LargeWidth = 75;
            this.btnİdris.Name = "btnİdris";
            this.btnİdris.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnİdris_ItemClick);
            // 
            // btnYedekle
            // 
            this.btnYedekle.Caption = "YEDEKLEME";
            this.btnYedekle.Id = 7;
            this.btnYedekle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYedekle.ImageOptions.LargeImage")));
            this.btnYedekle.LargeWidth = 80;
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYedekle_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFirmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCalisanlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGelenOdemeler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHarcamalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnİdris);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYedekle);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 527);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("AnaForm.IconOptions.Image")));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("AnaForm.IconOptions.LargeImage")));
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Pisagor Mühendislik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnMusteriler;
        private DevExpress.XtraBars.BarButtonItem btnFirmalar;
        private DevExpress.XtraBars.BarButtonItem btnCalisanlar;
        private DevExpress.XtraBars.BarButtonItem btnGelenOdemeler;
        private DevExpress.XtraBars.BarButtonItem btnHarcamalar;
        private DevExpress.XtraBars.BarButtonItem btnİdris;
        private DevExpress.XtraBars.BarButtonItem btnYedekle;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}