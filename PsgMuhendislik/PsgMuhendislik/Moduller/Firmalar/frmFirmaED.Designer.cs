namespace PsgMuhendislik.Modul_Firmalar
{
    partial class frmFirmaED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirmaED));
            this.btnİptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtFirmaAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnİptal
            // 
            this.btnİptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnİptal.ImageOptions.Image")));
            this.btnİptal.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnİptal.Location = new System.Drawing.Point(230, 132);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 28);
            this.btnİptal.TabIndex = 18;
            this.btnİptal.Text = "İptal";
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnKaydet.Location = new System.Drawing.Point(147, 132);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 28);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(101, 89);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTelefon.Size = new System.Drawing.Size(204, 20);
            this.txtTelefon.TabIndex = 14;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefon.Location = new System.Drawing.Point(36, 92);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(52, 14);
            this.lblTelefon.TabIndex = 9;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(101, 56);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(204, 20);
            this.txtFirmaAdi.TabIndex = 13;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.Green;
            this.lblBaslik.Location = new System.Drawing.Point(118, 23);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(111, 17);
            this.lblBaslik.TabIndex = 10;
            this.lblBaslik.Text = "Yeni Firma Ekle";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(22, 140);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 14);
            this.lblID.TabIndex = 11;
            this.lblID.Visible = false;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblAdSoyad.Location = new System.Drawing.Point(22, 59);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(63, 14);
            this.lblAdSoyad.TabIndex = 12;
            this.lblAdSoyad.Text = "Firma Adı";
            // 
            // frmFirmaED
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 172);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAdSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmFirmaED.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFirmaED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Firma Ekle - Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirmaAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnİptal;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        public DevExpress.XtraEditors.TextEdit txtTelefon;
        public System.Windows.Forms.Label lblTelefon;
        public DevExpress.XtraEditors.TextEdit txtFirmaAdi;
        public System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblAdSoyad;
    }
}