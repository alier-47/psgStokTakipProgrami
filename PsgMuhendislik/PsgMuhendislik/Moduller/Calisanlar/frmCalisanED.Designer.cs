namespace PsgMuhendislik.Moduller.Calisanlar
{
    partial class frmCalisanED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalisanED));
            this.btnİptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaas = new DevExpress.XtraEditors.TextEdit();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblIseBaslamaTarihi = new System.Windows.Forms.Label();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblCalismaSekli = new System.Windows.Forms.Label();
            this.cmbCalismaSekli = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtIseBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCalismaSekli.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnİptal
            // 
            this.btnİptal.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnİptal.Appearance.Options.UseBackColor = true;
            this.btnİptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnİptal.ImageOptions.Image")));
            this.btnİptal.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnİptal.Location = new System.Drawing.Point(256, 203);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 28);
            this.btnİptal.TabIndex = 6;
            this.btnİptal.Text = "İptal";
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnKaydet.Location = new System.Drawing.Point(173, 203);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 28);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(127, 139);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(204, 20);
            this.txtMaas.TabIndex = 3;
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaas.Location = new System.Drawing.Point(83, 141);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(38, 14);
            this.lblMaas.TabIndex = 7;
            this.lblMaas.Text = "Maaş";
            // 
            // lblIseBaslamaTarihi
            // 
            this.lblIseBaslamaTarihi.AutoSize = true;
            this.lblIseBaslamaTarihi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblIseBaslamaTarihi.Location = new System.Drawing.Point(6, 113);
            this.lblIseBaslamaTarihi.Name = "lblIseBaslamaTarihi";
            this.lblIseBaslamaTarihi.Size = new System.Drawing.Size(115, 14);
            this.lblIseBaslamaTarihi.TabIndex = 8;
            this.lblIseBaslamaTarihi.Text = "İşe Başlama Tarihi";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(127, 78);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefon.Size = new System.Drawing.Size(204, 20);
            this.txtTelefon.TabIndex = 1;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefon.Location = new System.Drawing.Point(69, 80);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(52, 14);
            this.lblTelefon.TabIndex = 9;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(127, 48);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(204, 20);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.Green;
            this.lblBaslik.Location = new System.Drawing.Point(111, 15);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(121, 17);
            this.lblBaslik.TabIndex = 10;
            this.lblBaslik.Text = "Yeni Çalışan Ekle";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(8, 180);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 14);
            this.lblID.TabIndex = 11;
            this.lblID.Visible = false;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblAdSoyad.Location = new System.Drawing.Point(55, 50);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(66, 14);
            this.lblAdSoyad.TabIndex = 12;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblCalismaSekli
            // 
            this.lblCalismaSekli.AutoSize = true;
            this.lblCalismaSekli.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalismaSekli.Location = new System.Drawing.Point(37, 171);
            this.lblCalismaSekli.Name = "lblCalismaSekli";
            this.lblCalismaSekli.Size = new System.Drawing.Size(84, 14);
            this.lblCalismaSekli.TabIndex = 7;
            this.lblCalismaSekli.Text = "Çalışma Şekli";
            // 
            // cmbCalismaSekli
            // 
            this.cmbCalismaSekli.EditValue = "Sabit";
            this.cmbCalismaSekli.Location = new System.Drawing.Point(127, 169);
            this.cmbCalismaSekli.Name = "cmbCalismaSekli";
            this.cmbCalismaSekli.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCalismaSekli.Properties.Items.AddRange(new object[] {
            "Sabit",
            "Götürü"});
            this.cmbCalismaSekli.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbCalismaSekli.Size = new System.Drawing.Size(204, 20);
            this.cmbCalismaSekli.TabIndex = 4;
            // 
            // dtIseBaslamaTarihi
            // 
            this.dtIseBaslamaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIseBaslamaTarihi.Location = new System.Drawing.Point(127, 108);
            this.dtIseBaslamaTarihi.Name = "dtIseBaslamaTarihi";
            this.dtIseBaslamaTarihi.Size = new System.Drawing.Size(204, 21);
            this.dtIseBaslamaTarihi.TabIndex = 2;
            // 
            // frmCalisanED
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 245);
            this.Controls.Add(this.dtIseBaslamaTarihi);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblCalismaSekli);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.lblIseBaslamaTarihi);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.cmbCalismaSekli);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmCalisanED.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalisanED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Ekle - Düzenle";
            this.Load += new System.EventHandler(this.frmCalisanED_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCalismaSekli.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnİptal;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        public DevExpress.XtraEditors.TextEdit txtMaas;
        public System.Windows.Forms.Label lblMaas;
        public System.Windows.Forms.Label lblIseBaslamaTarihi;
        public DevExpress.XtraEditors.TextEdit txtTelefon;
        public System.Windows.Forms.Label lblTelefon;
        public DevExpress.XtraEditors.TextEdit txtAdSoyad;
        public System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblAdSoyad;
        public System.Windows.Forms.Label lblCalismaSekli;
        public DevExpress.XtraEditors.ComboBoxEdit cmbCalismaSekli;
        public System.Windows.Forms.DateTimePicker dtIseBaslamaTarihi;
    }
}