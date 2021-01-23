using PsgMuhendislik.Fonksiyonlar;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PsgMuhendislik.Moduller.Calisanlar
{
    public partial class frmCalisanTahsilat : DevExpress.XtraEditors.XtraForm
    {
        pisagorDBDataContext db = new pisagorDBDataContext();
        Mesajlar msj = new Mesajlar();
        Formlar form = new Formlar();

        public bool Secim = false;
        public frmCalisanTahsilat()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtTutar.Text.Trim() == "")
            {
                msj.Hata("Tutar Boş Geçilemez");
            }
            else
            {
                Kaydet();
            }
        }

        void Kaydet()
        {
            try
            {
                CalisanlarDetay calisanlarDetay = new CalisanlarDetay();
                Fonksiyonlar.Harcamalar harcamalar = new Fonksiyonlar.Harcamalar();
                var calisan = db.Calisanlars.Where(x => x.ID == Convert.ToInt32(lblID.Text)).First();
                if (Tag == "MaasEkle")
                {
                    if (calisan.AlacakTutar == null || calisan.AlacakTutar == 0)
                    {
                        calisan.AlacakTutar = Convert.ToDecimal(txtTutar.Text);
                    }
                    else
                    {
                        calisan.AlacakTutar += Convert.ToDecimal(txtTutar.Text);
                    }
                    calisanlarDetay.AlacakTutar = Convert.ToDecimal(txtTutar.Text);
                    calisanlarDetay.OdenenTutar = 0;
                }
                else
                {
                    if (calisan.AlacakTutar == null || calisan.AlacakTutar == 0)
                    {
                        calisan.AlacakTutar = -Convert.ToDecimal(txtTutar.Text);
                    }
                    else
                    {
                        calisan.AlacakTutar -= Convert.ToDecimal(txtTutar.Text);
                    }
                    calisanlarDetay.OdenenTutar = Convert.ToDecimal(txtTutar.Text);
                    calisanlarDetay.AlacakTutar = 0;
                    harcamalar.Aciklama = lblCalisanAdi.Text + " / " + " Maaş Ödemesi / " + txtAciklama.Text;
                    harcamalar.Tarih = Convert.ToDateTime(dtTarih.Value.ToShortDateString()); 
                    harcamalar.Tutar = Convert.ToDecimal(txtTutar.Text);
                    harcamalar.harcamaid = Convert.ToInt32(calisan.ID);
                    harcamalar.Silme = false;
                    db.Harcamalars.InsertOnSubmit(harcamalar);
                    db.SubmitChanges();
                    form.HarcamalarListeYenileme();
                }
                calisanlarDetay.Aciklama = txtAciklama.Text;
                calisanlarDetay.CalisanID = Convert.ToInt32(lblID.Text);
                //calisan.AlacakTutar = Convert.ToDecimal(txtTutar.Text);
                calisanlarDetay.Tarih = Convert.ToDateTime(dtTarih.Value.ToShortDateString());
                calisanlarDetay.Silme = false;
                calisanlarDetay.OdemeId = harcamalar.ID;
                calisanlarDetay.Silme = false;
                db.CalisanlarDetays.InsertOnSubmit(calisanlarDetay);
                db.SubmitChanges();
                calisanlarDetay.OdemeId = harcamalar.ID;
                db.SubmitChanges();
                msj.YeniKayit("İşlem Başarıyla Yapıldı.");
                this.Close();
                form.CalisanlarListesi(true);
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "CalisanTahsilat");
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}