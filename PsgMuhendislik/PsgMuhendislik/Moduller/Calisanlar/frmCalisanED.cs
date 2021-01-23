using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PsgMuhendislik.Fonksiyonlar;

namespace PsgMuhendislik.Moduller.Calisanlar
{
    public partial class frmCalisanED : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        Mesajlar msj = new Mesajlar();
        pisagorDBDataContext db = new pisagorDBDataContext();
        Formlar form = new Formlar();
        public frmCalisanED()
        {
            InitializeComponent();
        }

        private void frmCalisanED_Load(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text.Trim() == "")
            {
                msj.Hata("Çalışan Adı Boş Geçilemez");
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

        void Kaydet()
        {
            try
            {
                Fonksiyonlar.Calisanlar calisan = new Fonksiyonlar.Calisanlar();
                CalisanlarDetay calisanlarDetay = new CalisanlarDetay();
                calisan.AdSoyad = txtAdSoyad.Text;
                calisan.Telefon = txtTelefon.Text;
                calisan.AlacakTutar = Convert.ToDecimal(txtMaas.Text);
                calisan.CalismaSekli = cmbCalismaSekli.Text;
                calisan.IsBaslangicTarihi = Convert.ToDateTime(dtIseBaslamaTarihi.Value.ToShortDateString());
               // calisan.MaasGirisiDurum = 0;
                calisan.Silme = false;
                if (db.Calisanlars.Where(x => x.Silme == false).Where(a => a.AdSoyad == txtAdSoyad.Text).Count() > 0)
                {
                    msj.Hata("Sistemde bu çalışan zaten kayıtlıdır!...");
                }
                else
                {
                    db.Calisanlars.InsertOnSubmit(calisan);
                    db.SubmitChanges();

                    calisanlarDetay.Aciklama = txtAdSoyad.Text;
                    calisanlarDetay.AlacakTutar = Convert.ToDecimal(txtMaas.Text);
                    calisanlarDetay.OdenenTutar = 0;
                    calisanlarDetay.CalisanID = calisan.ID;
                    calisanlarDetay.Silme = false;
                    calisanlarDetay.Tarih = dtIseBaslamaTarihi.Value;

                    db.CalisanlarDetays.InsertOnSubmit(calisanlarDetay);
                    db.SubmitChanges();
                    msj.YeniKayit(txtAdSoyad.Text.ToString() + " Kişisi Başarıyla Eklendi");
                    this.Close();
                    form.CalisanlarListesi(true);
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
                var calisan = db.Calisanlars.FirstOrDefault(x => x.ID == id);
                calisan.AdSoyad = txtAdSoyad.Text;
                calisan.Telefon = txtTelefon.Text;
                calisan.AlacakTutar = Convert.ToDecimal(txtMaas.Text);
                calisan.CalismaSekli = cmbCalismaSekli.Text;
                calisan.IsBaslangicTarihi = Convert.ToDateTime(dtIseBaslamaTarihi.Text);
                calisan.MaasGirisiDurum = 0;
                calisan.Silme = false;
                if (db.Calisanlars.Where(x => x.Silme == false).Where(a => a.AdSoyad == txtAdSoyad.Text).Where(x => x.ID != id).Count() > 0)
                {
                    msj.Hata("Sistemde bu çalışan zaten kayıtlıdır!...");
                }
                else
                {
                    if (msj.Guncelle() == DialogResult.Yes)
                    {
                        db.SubmitChanges();
                        msj.Guncelle("Çalışan Bilgisi Güncellenmiştir.");
                        this.Close();
                        form.CalisanlarListesi(true);
                    }
                }

            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "CalisanED");
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}