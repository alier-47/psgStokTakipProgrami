namespace PsgMuhendislik.Modul_Musteriler
{
    partial class frmMusteriED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriED));
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.lblBinaAdi = new System.Windows.Forms.Label();
            this.txtBinaAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnİptal = new DevExpress.XtraEditors.SimpleButton();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNot = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBinaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNot.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblAdSoyad.Location = new System.Drawing.Point(8, 48);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(66, 14);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(87, 45);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(204, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefon.Location = new System.Drawing.Point(22, 81);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(52, 14);
            this.lblTelefon.TabIndex = 0;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(87, 78);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefon.Size = new System.Drawing.Size(204, 20);
            this.txtTelefon.TabIndex = 2;
            // 
            // lblBinaAdi
            // 
            this.lblBinaAdi.AutoSize = true;
            this.lblBinaAdi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblBinaAdi.Location = new System.Drawing.Point(17, 114);
            this.lblBinaAdi.Name = "lblBinaAdi";
            this.lblBinaAdi.Size = new System.Drawing.Size(57, 14);
            this.lblBinaAdi.TabIndex = 0;
            this.lblBinaAdi.Text = "Bina Adı";
            // 
            // txtBinaAdi
            // 
            this.txtBinaAdi.Location = new System.Drawing.Point(87, 111);
            this.txtBinaAdi.Name = "txtBinaAdi";
            this.txtBinaAdi.Size = new System.Drawing.Size(204, 20);
            this.txtBinaAdi.TabIndex = 3;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.Green;
            this.lblBaslik.Location = new System.Drawing.Point(104, 12);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(124, 17);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Yeni Müşteri Ekle";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnKaydet.Location = new System.Drawing.Point(133, 174);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 28);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnİptal.Appearance.Options.UseBackColor = true;
            this.btnİptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnİptal.ImageOptions.Image")));
            this.btnİptal.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnİptal.Location = new System.Drawing.Point(216, 174);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 28);
            this.btnİptal.TabIndex = 6;
            this.btnİptal.Text = "İptal";
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(8, 164);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 14);
            this.lblID.TabIndex = 0;
            this.lblID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(87, 137);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(204, 20);
            this.txtNot.TabIndex = 4;
            // 
            // frmMusteriED
            // 
            this.AcceptButton = this.btnKaydet;
            this.ActiveGlowColor = System.Drawing.SystemColors.ActiveBorder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 229);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBinaAdi);
            this.Controls.Add(this.lblBinaAdi);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAdSoyad);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmMusteriED.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusteriED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri ";
            this.Load += new System.EventHandler(this.frmMusteriED_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBinaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNot.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnİptal;
        public System.Windows.Forms.Label lblAdSoyad;
        public System.Windows.Forms.Label lblTelefon;
        public System.Windows.Forms.Label lblBinaAdi;
        public DevExpress.XtraEditors.TextEdit txtAdSoyad;
        public DevExpress.XtraEditors.TextEdit txtTelefon;
        public DevExpress.XtraEditors.TextEdit txtBinaAdi;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.TextEdit txtNot;
    }
}