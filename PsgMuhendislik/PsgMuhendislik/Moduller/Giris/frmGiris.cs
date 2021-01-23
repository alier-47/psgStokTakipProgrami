using DevExpress.XtraEditors;
using PsgMuhendislik.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsgMuhendislik.Moduller.Giris
{
    public partial class frmGiris : DevExpress.XtraEditors.XtraForm
    {

        pisagorDBDataContext db = new pisagorDBDataContext();
        private string hash = "";
        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            this.Name = "Giris";
            foreach (var item in db.Kullanıcılars)
            {
                cmbKullaniciAdi.Properties.Items.Add(item.KullaniciAdi);
                cmbKullaniciAdi.SelectedIndex = 0;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
          
                var kullanici = db.Kullanıcılars.FirstOrDefault(x => x.KullaniciAdi == cmbKullaniciAdi.Text);
                if (txtSifre.Text == MD5sifreCoz(kullanici.Sifre) && kullanici != null)
                {
                    AnaForm anaForm = new AnaForm();
                    this.Hide();
                    anaForm.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        public void MD5sifrele()
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txtSifre.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    var sifreliText = Convert.ToBase64String(results, 0, results.Length);
                    
                }
            }
        }
        private string MD5sifreCoz(string sifre)
        {
            byte[] data = Convert.FromBase64String(sifre);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                //Decrypt data by hash key
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Encoding.Default.GetString(results);
                }
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "Giris");
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}