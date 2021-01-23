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

namespace PsgMuhendislik.Modul_Musteriler
{
    public partial class frmBorc : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        Mesajlar msj = new Mesajlar();
        Formlar form = new Formlar();
        pisagorDBDataContext db = new pisagorDBDataContext();
        
        public frmBorc()
        {
            InitializeComponent();
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
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Kaydet()
        {
            try
            {
                MusterilerDetay musterilerDetay = new MusterilerDetay();
                Harcamalar harcamalar = new Harcamalar();
                GelenOdemeler gelenOdemeler = new GelenOdemeler();
                var musteri = db.Musterilers.Where(x => x.ID == Convert.ToInt32(lblID.Text)).First();
                if(Text == "Tahsilat")
                {
                    if (musteri.Borc == null)
                        musteri.Borc = 0;
                    musteri.Borc -= Convert.ToDecimal(txtTutar.Text);
                    musterilerDetay.OdenenTutar = Convert.ToDecimal(txtTutar.Text);
                    musterilerDetay.OdemeSekli = txtOdemeSekli.Text;
                    musterilerDetay.EklenenTutar = 0;
                    if(txtOdemeSekli.Text == "Nakit")
                    {
                        gelenOdemeler.Aciklama = lblMusteriAdi.Text + " / " + txtAciklama.Text + " -- Sistemden -- ";
                        gelenOdemeler.gelenOdemeId = Convert.ToInt32(lblID.Text);
                        gelenOdemeler.Tarih = Convert.ToDateTime(dtTarih.Value.ToShortDateString());
                        gelenOdemeler.Tutar = Convert.ToDecimal(txtTutar.Text);
                        gelenOdemeler.Silme = false;
                        db.GelenOdemelers.InsertOnSubmit(gelenOdemeler);
                    }
                }
                else
                {

                    if(musteri.Borc == null)
                    {
                        musteri.Borc = Convert.ToDecimal(txtTutar.Text);
                    }
                    else
                    {
                        musteri.Borc += Convert.ToDecimal(txtTutar.Text);
                    }
                    musteri.Tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString()); ;
                    musteri.OdemeTarihi = Convert.ToDateTime(dtTarih.Text);
                    musteri.OdemeSekli = txtOdemeSekli.Text;
                    musterilerDetay.EklenenTutar = Convert.ToDecimal(txtTutar.Text);
                    musterilerDetay.OdenenTutar = 0;
                    musterilerDetay.OdemeSekli = txtOdemeSekli.Text;
                }
                musterilerDetay.Aciklama = txtAciklama.Text;
                musterilerDetay.MusteriID = Convert.ToInt32(lblID.Text);
                musterilerDetay.Tarih = Convert.ToDateTime(dtTarih.Value.ToShortDateString());
                musterilerDetay.Silme = false;

                db.MusterilerDetays.InsertOnSubmit(musterilerDetay);
                db.SubmitChanges();
                musterilerDetay.OdemeId = gelenOdemeler.ID;
                db.SubmitChanges();
                this.Close();
                form.MusterilerListesi(true);
                form.GelenOdemeListeYenileme();
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "MusteriTahsilat");
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}