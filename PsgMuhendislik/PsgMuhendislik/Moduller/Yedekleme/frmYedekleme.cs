using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using PsgMuhendislik.Fonksiyonlar;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Net.Mail;
using System.Net;

namespace PsgMuhendislik.Moduller.Yedekleme
{
    public partial class frmYedekleme : DevExpress.XtraEditors.XtraForm
    {
        string DosyaYolu = "";
        public frmYedekleme()
        {
            InitializeComponent();
            btnKlasorAc.Visible = false;
            this.Size = new System.Drawing.Size(699, 220);
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            try
            {
                if (Directory.Exists(@"C:\Yedek") == false) // dizindeki dosya var mı ?
                {
                    Directory.CreateDirectory(@"C:\Yedek");
                }
                Server dbServer = new Server(new ServerConnection(txtServer.Text));
                Backup dbBackup = new Backup();
                dbBackup.Devices.AddDevice(@"C:\Yedek\pisagorMuhendislikST.bak", DeviceType.File);
                dbBackup.Initialize = true;
                dbBackup.Action = BackupActionType.Database;
                dbBackup.Database = txtDatabase.Text;
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackupAsync(dbServer);
                this.Size = new System.Drawing.Size(699, 415);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Value = e.Percent;
                progressBar.Update();
            });
            lblPercent.Invoke((MethodInvoker)delegate
            {
                lblPercent.Text = $"{e.Percent}%";
                lblSonuc.Text = "Yedekleme Dosyası pisagormuhendislik@gmail.com adresine gönderildi ve C:\\Yedek klasörüne eklendi!";
                btnKlasorAc.Visible = true;
            });
        }

        private void btnKlasorAc_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Yedek");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "Yedekleme");
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnYedeklemeKlasorAc_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Yedek") == true)
                Process.Start(@"C:\Yedek");
            else
                MessageBox.Show("Böyle Bir Klasör Bulunamadı", "Klasör Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Backup Dosyası |*.bak";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Backup Dosyası Seçiniz..";

            if (file.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu = file.FileName;
                txtBackup.Text = DosyaYolu;
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("pisagormuhendislik@gmail.com");
            ePosta.To.Add("pisagormuhendislik@gmail.com");
            //
            ePosta.Attachments.Add(new Attachment(@DosyaYolu));
            //
            ePosta.Subject = "Yedekleme Dosyası";
            //
            ePosta.Body = "Pisagor Mühendislik Müşteri Takip";
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential(txtEmail.Text, txtSifre.Text);
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            //smtp.Send(ePosta);
            object userState = ePosta;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
                MessageBox.Show("Yedekleme Dosyası E posta adresinize gönderilmiştir!","Yedekleme",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
        }
    }
}