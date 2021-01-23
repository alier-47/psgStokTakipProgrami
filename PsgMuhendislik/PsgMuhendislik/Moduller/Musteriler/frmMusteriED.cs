using PsgMuhendislik.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PsgMuhendislik.Modul_Musteriler
{
    public partial class frmMusteriED : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        Mesajlar msj = new Mesajlar();
        YeniListe yl = new YeniListe();
        Formlar form = new Formlar();

        pisagorDBDataContext db = new pisagorDBDataContext();
        public frmMusteriED()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text.Trim() == "")
            {
                msj.Hata("Müşteri Adı Boş Geçilemez");
            }
            else
            {
                if (lblID.Text == "")
                {
                    Kaydet();
                }
                else
                {
                    Duzenle();
                }
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Kaydet()
        {
            try
            {
                Musteriler musteri = new Musteriler();
                musteri.AdSoyad = txtAdSoyad.Text;
                musteri.BinaAdi = txtBinaAdi.Text;
                musteri.Telefon = txtTelefon.Text;
                musteri.Tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                musteri.Not = txtNot.Text;
                musteri.Silme = false;
                musteri.Borc = 0;
                if (db.Musterilers.Where(x => x.Silme == false).Where(a => a.AdSoyad == txtAdSoyad.Text).Count() > 0)
                {
                    msj.Hata("Sistemde bu müşteri zaten kayıtlıdır!...");
                }
                else
                {
                    db.Musterilers.InsertOnSubmit(musteri);
                    db.SubmitChanges();
                    this.Close();
                    form.MusterilerListesi(true);
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        void Duzenle()
        {
            try
            {
                var id = int.Parse(lblID.Text);
                var musteri = db.Musterilers.FirstOrDefault(x => x.ID == id);
                musteri.AdSoyad = txtAdSoyad.Text;
                musteri.Telefon = txtTelefon.Text;
                musteri.BinaAdi = txtBinaAdi.Text;
                musteri.Not = txtNot.Text;
                musteri.Silme = false;
                if (db.Musterilers.Where(x => x.Silme == false).Where(a => a.AdSoyad == txtAdSoyad.Text).Where(x => x.ID != id).Count() > 0)
                {
                    msj.Hata("Sistemde bu müşteri zaten kayıtlıdır!...");
                }
                else
                {
                    if (msj.Guncelle() == DialogResult.Yes)
                    {
                        db.SubmitChanges();
                        this.Close();
                        form.MusterilerListesi(true);
                    }
                }

            }
            catch (Exception)
            {
                msj.Hata();
            }
        }
        private void frmMusteriED_Load(object sender, EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "MusteriED");
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}