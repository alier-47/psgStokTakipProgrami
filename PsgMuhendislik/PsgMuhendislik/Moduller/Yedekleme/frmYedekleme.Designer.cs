namespace PsgMuhendislik.Moduller.Yedekleme
{
    partial class frmYedekleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYedekleme));
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabase = new DevExpress.XtraEditors.TextEdit();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnYedekle = new DevExpress.XtraEditors.SimpleButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnKlasorAc = new DevExpress.XtraEditors.SimpleButton();
            this.btnYedeklemeKlasorAc = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.txtBackup = new DevExpress.XtraEditors.TextEdit();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.EditValue = ".";
            this.txtServer.Enabled = false;
            this.txtServer.Location = new System.Drawing.Point(85, 19);
            this.txtServer.Name = "txtServer";
            this.txtServer.Properties.ReadOnly = true;
            this.txtServer.Size = new System.Drawing.Size(151, 20);
            this.txtServer.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.EditValue = "pisagorMuhendislikST";
            this.txtDatabase.Enabled = false;
            this.txtDatabase.Location = new System.Drawing.Point(85, 45);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Properties.ReadOnly = true;
            this.txtDatabase.Size = new System.Drawing.Size(151, 20);
            this.txtDatabase.TabIndex = 9;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 77);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(381, 25);
            this.progressBar.TabIndex = 3;
            // 
            // btnYedekle
            // 
            this.btnYedekle.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnYedekle.Appearance.Options.UseBackColor = true;
            this.btnYedekle.Location = new System.Drawing.Point(417, 77);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(75, 25);
            this.btnYedekle.TabIndex = 1;
            this.btnYedekle.Text = "Yedekle";
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 131);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Durum";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(149, 105);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(27, 13);
            this.lblPercent.TabIndex = 0;
            this.lblPercent.Text = "0 %";
            // 
            // lblSonuc
            // 
            this.lblSonuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSonuc.ForeColor = System.Drawing.Color.Green;
            this.lblSonuc.Location = new System.Drawing.Point(12, 157);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(41, 13);
            this.lblSonuc.TabIndex = 0;
            this.lblSonuc.Text = "Sonuç";
            // 
            // btnKlasorAc
            // 
            this.btnKlasorAc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKlasorAc.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnKlasorAc.Appearance.Options.UseBackColor = true;
            this.btnKlasorAc.Location = new System.Drawing.Point(610, 152);
            this.btnKlasorAc.Name = "btnKlasorAc";
            this.btnKlasorAc.Size = new System.Drawing.Size(70, 23);
            this.btnKlasorAc.TabIndex = 3;
            this.btnKlasorAc.Text = "Klasörü Aç";
            this.btnKlasorAc.Click += new System.EventHandler(this.btnKlasorAc_Click);
            // 
            // btnYedeklemeKlasorAc
            // 
            this.btnYedeklemeKlasorAc.AllowFocus = false;
            this.btnYedeklemeKlasorAc.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnYedeklemeKlasorAc.Appearance.Options.UseBackColor = true;
            this.btnYedeklemeKlasorAc.Location = new System.Drawing.Point(507, 77);
            this.btnYedeklemeKlasorAc.Name = "btnYedeklemeKlasorAc";
            this.btnYedeklemeKlasorAc.Size = new System.Drawing.Size(76, 25);
            this.btnYedeklemeKlasorAc.TabIndex = 2;
            this.btnYedeklemeKlasorAc.Text = "Klasörü Aç";
            this.btnYedeklemeKlasorAc.Click += new System.EventHandler(this.btnYedeklemeKlasorAc_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-posta";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(220, 268);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtSifre
            // 
            this.txtSifre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSifre.Location = new System.Drawing.Point(220, 296);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(151, 20);
            this.txtSifre.TabIndex = 6;
            // 
            // lblBilgi
            // 
            this.lblBilgi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblBilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBilgi.Location = new System.Drawing.Point(102, 194);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(494, 17);
            this.lblBilgi.TabIndex = 9;
            this.lblBilgi.Text = "Yedekleme Dosyasını E postaya Göndermek için aşağıdaki bilgileri kullan";
            // 
            // txtBackup
            // 
            this.txtBackup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBackup.EditValue = "";
            this.txtBackup.Enabled = false;
            this.txtBackup.Location = new System.Drawing.Point(220, 233);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Properties.ReadOnly = true;
            this.txtBackup.Size = new System.Drawing.Size(151, 20);
            this.txtBackup.TabIndex = 1;
            // 
            // btnSec
            // 
            this.btnSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSec.Location = new System.Drawing.Point(387, 233);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(74, 19);
            this.btnSec.TabIndex = 4;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGonder.Appearance.BackColor = System.Drawing.Color.Sienna;
            this.btnGonder.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnGonder.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGonder.Appearance.Options.UseBackColor = true;
            this.btnGonder.Appearance.Options.UseFont = true;
            this.btnGonder.Appearance.Options.UseForeColor = true;
            this.btnGonder.Location = new System.Drawing.Point(283, 341);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(88, 28);
            this.btnGonder.TabIndex = 7;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // frmYedekleme
            // 
            this.AcceptButton = this.btnYedekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 382);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnYedeklemeKlasorAc);
            this.Controls.Add(this.btnKlasorAc);
            this.Controls.Add(this.btnYedekle);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtBackup);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmYedekleme.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "frmYedekleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı Yedekleme";
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackup.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtDatabase;
        private System.Windows.Forms.ProgressBar progressBar;
        private DevExpress.XtraEditors.SimpleButton btnYedekle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblSonuc;
        private DevExpress.XtraEditors.SimpleButton btnKlasorAc;
        private DevExpress.XtraEditors.SimpleButton btnYedeklemeKlasorAc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private System.Windows.Forms.Label lblBilgi;
        private DevExpress.XtraEditors.TextEdit txtBackup;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
    }
}