
namespace PsgMuhendislik.Moduller.Calisanlar
{
    partial class frmCalisanEDevletED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalisanEDevletED));
            this.CalisanID = new System.Windows.Forms.Label();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnİptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CalisanID
            // 
            this.CalisanID.AutoSize = true;
            this.CalisanID.Location = new System.Drawing.Point(46, 149);
            this.CalisanID.Name = "CalisanID";
            this.CalisanID.Size = new System.Drawing.Size(47, 13);
            this.CalisanID.TabIndex = 59;
            this.CalisanID.Text = "calisanid";
            this.CalisanID.Visible = false;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(119, 107);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(204, 20);
            this.txtSifre.TabIndex = 2;
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaas.Location = new System.Drawing.Point(58, 109);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(35, 14);
            this.lblMaas.TabIndex = 55;
            this.lblMaas.Text = "Şifre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(-11, 214);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 14);
            this.lblID.TabIndex = 58;
            this.lblID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(51, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 55;
            this.label1.Text = "TC No";
            // 
            // btnİptal
            // 
            this.btnİptal.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnİptal.Appearance.Options.UseBackColor = true;
            this.btnİptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnİptal.ImageOptions.Image")));
            this.btnİptal.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnİptal.Location = new System.Drawing.Point(248, 140);
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
            this.btnKaydet.Location = new System.Drawing.Point(165, 140);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 28);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(3, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(387, 20);
            this.textBox1.TabIndex = 60;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBaslik.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblBaslik.Location = new System.Drawing.Point(161, 31);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(71, 17);
            this.lblBaslik.TabIndex = 61;
            this.lblBaslik.Text = "Çalışan Adı";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(119, 70);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(204, 21);
            this.txtTcNo.TabIndex = 1;
            this.txtTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTcNo_KeyPress);
            // 
            // frmCalisanEDevletED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 207);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CalisanID);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.lblID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalisanEDevletED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan E Devlet Ekle";
            this.Load += new System.EventHandler(this.frmCalisanEDevletED_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label CalisanID;
        private DevExpress.XtraEditors.SimpleButton btnİptal;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        public DevExpress.XtraEditors.TextEdit txtSifre;
        public System.Windows.Forms.Label lblMaas;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TextBox txtTcNo;
    }
}