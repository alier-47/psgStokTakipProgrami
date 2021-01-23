namespace PsgMuhendislik.Moduller.Calisanlar
{
    partial class frmCalisanCizelgesiED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalisanCizelgesiED));
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.btnİptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtAciklama = new DevExpress.XtraEditors.TextEdit();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblIseBaslamaTarihi = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbGun = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblCalismaSekli = new System.Windows.Forms.Label();
            this.CalisanID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGun.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTarih
            // 
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(96, 51);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(204, 21);
            this.dtTarih.TabIndex = 0;
            // 
            // btnİptal
            // 
            this.btnİptal.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnİptal.Appearance.Options.UseBackColor = true;
            this.btnİptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnİptal.ImageOptions.Image")));
            this.btnİptal.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnİptal.Location = new System.Drawing.Point(225, 157);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 28);
            this.btnİptal.TabIndex = 4;
            this.btnİptal.Text = "İptal";
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnKaydet.Location = new System.Drawing.Point(142, 157);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 28);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(96, 124);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(204, 20);
            this.txtAciklama.TabIndex = 2;
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaas.Location = new System.Drawing.Point(23, 126);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(60, 14);
            this.lblMaas.TabIndex = 35;
            this.lblMaas.Text = "Açıklama";
            // 
            // lblIseBaslamaTarihi
            // 
            this.lblIseBaslamaTarihi.AutoSize = true;
            this.lblIseBaslamaTarihi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblIseBaslamaTarihi.Location = new System.Drawing.Point(46, 56);
            this.lblIseBaslamaTarihi.Name = "lblIseBaslamaTarihi";
            this.lblIseBaslamaTarihi.Size = new System.Drawing.Size(37, 14);
            this.lblIseBaslamaTarihi.TabIndex = 36;
            this.lblIseBaslamaTarihi.Text = "Tarih";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.Green;
            this.lblBaslik.Location = new System.Drawing.Point(126, 18);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(82, 17);
            this.lblBaslik.TabIndex = 38;
            this.lblBaslik.Text = "Çalısan Adı";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(-21, 191);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 14);
            this.lblID.TabIndex = 39;
            this.lblID.Visible = false;
            // 
            // cmbGun
            // 
            this.cmbGun.EditValue = "Tam Gün";
            this.cmbGun.Location = new System.Drawing.Point(96, 88);
            this.cmbGun.Name = "cmbGun";
            this.cmbGun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGun.Properties.Items.AddRange(new object[] {
            "Tam Gün",
            "Yarım Gün"});
            this.cmbGun.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbGun.Size = new System.Drawing.Size(204, 20);
            this.cmbGun.TabIndex = 1;
            // 
            // lblCalismaSekli
            // 
            this.lblCalismaSekli.AutoSize = true;
            this.lblCalismaSekli.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalismaSekli.Location = new System.Drawing.Point(52, 91);
            this.lblCalismaSekli.Name = "lblCalismaSekli";
            this.lblCalismaSekli.Size = new System.Drawing.Size(31, 14);
            this.lblCalismaSekli.TabIndex = 34;
            this.lblCalismaSekli.Text = "Gün";
            // 
            // CalisanID
            // 
            this.CalisanID.AutoSize = true;
            this.CalisanID.Location = new System.Drawing.Point(23, 166);
            this.CalisanID.Name = "CalisanID";
            this.CalisanID.Size = new System.Drawing.Size(47, 13);
            this.CalisanID.TabIndex = 48;
            this.CalisanID.Text = "calisanid";
            this.CalisanID.Visible = false;
            // 
            // frmCalisanCizelgesiED
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 223);
            this.Controls.Add(this.CalisanID);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblCalismaSekli);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.lblIseBaslamaTarihi);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmbGun);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmCalisanCizelgesiED.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalisanCizelgesiED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Eksik Gün Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGun.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtTarih;
        private DevExpress.XtraEditors.SimpleButton btnİptal;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        public DevExpress.XtraEditors.TextEdit txtAciklama;
        public System.Windows.Forms.Label lblMaas;
        public System.Windows.Forms.Label lblIseBaslamaTarihi;
        public System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.Label lblID;
        public DevExpress.XtraEditors.ComboBoxEdit cmbGun;
        public System.Windows.Forms.Label lblCalismaSekli;
        public System.Windows.Forms.Label CalisanID;
    }
}