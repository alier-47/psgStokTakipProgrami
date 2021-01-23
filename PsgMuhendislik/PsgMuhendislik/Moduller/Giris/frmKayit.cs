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
    public partial class frmKayit : DevExpress.XtraEditors.XtraForm
    {
        private string hash = "";
        public frmKayit()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                pisagorDBDataContext db = new pisagorDBDataContext();
                Kullanıcılar kullanıcılar = new Kullanıcılar();
                kullanıcılar.KullaniciAdi = txtKullaniciAdi.Text;
                kullanıcılar.Sifre = MD5sifrele(txtSifre.Text);
                db.Kullanıcılars.InsertOnSubmit(kullanıcılar);
                db.SubmitChanges();
                lblKayit.Text = "Kaydınız Gerçekleşti! Giriş Yapmak İçin Yandaki Butonu Kullanın";
                lblKayit.Visible = true;
                btnGirisYap.Visible = true;
                this.Size = new Size(496, 335);
            }
            catch (Exception ex)
            {
                lblKayit.Text = ex.Message;
                lblKayit.Visible = true;
            }
        }

        public string MD5sifrele(string sifre)
        {
            var sonuc ="";
            byte[] data = UTF8Encoding.UTF8.GetBytes(sifre);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    sonuc =Convert.ToBase64String(results, 0, results.Length);

                }
            }
            return sonuc;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Hide();
            frmGiris.ShowDialog();
            Application.Exit();
        }

        private void frmKayit_Load(object sender, EventArgs e)
        {
            this.Size = new Size(496, 285);
        }
    }
}