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

namespace PsgMuhendislik.Modul_Firmalar
{
    public partial class frmFirmaTahsilat : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        Mesajlar msj = new Mesajlar();
        pisagorDBDataContext db = new pisagorDBDataContext();
        Formlar form = new Formlar();
        public frmFirmaTahsilat()
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

        void Kaydet()
        {
            try
            {
                FirmalarDetay firmalarDetay = new FirmalarDetay();
                Harcamalar harcamalar= new Harcamalar();
                var firma = db.Firmalars.Where(x => x.ID == Convert.ToInt32(lblID.Text)).First();
                if (Tag == "OdemeYap")
                {
                    if (firma.Borc == null || firma.Borc== 0)
                    {
                        firma.Borc = Convert.ToDecimal(txtTutar.Text);
                    }
                    else
                    {
                        firma.Borc += Convert.ToDecimal(txtTutar.Text);
                    }
                    firmalarDetay.OdenenTutar = Convert.ToDecimal(txtTutar.Text);
                    firmalarDetay.AlinanMalTutari = 0;
                    if (txtOdemeSekli.Text == "Nakit")
                    {
                        harcamalar.Aciklama = firma.FirmaAdi + " / " + txtAciklama.Text + " / " + "-- Sistemden --";
                        harcamalar.Tarih = Convert.ToDateTime(dtTarih.Value.ToShortDateString());
                        harcamalar.Tutar = Convert.ToDecimal(txtTutar.Text);
                        harcamalar.harcamaid = Convert.ToInt32(lblID.Text);
                        harcamalar.Silme = false;
                        db.Harcamalars.InsertOnSubmit(harcamalar);
                        db.SubmitChanges();
                    }
                }
                else
                {
                    if (firma.Borc == null || firma.Borc == 0)
                    {
                        firma.Borc = -Convert.ToDecimal(txtTutar.Text);
                    }
                    else
                    {
                        firma.Borc -= Convert.ToDecimal(txtTutar.Text);
                    }
                    firmalarDetay.AlinanMalTutari = Convert.ToDecimal(txtTutar.Text);
                    firmalarDetay.OdenenTutar = 0;
                }
                firmalarDetay.Aciklama = txtAciklama.Text;
                firmalarDetay.FirmaID = Convert.ToInt32(lblID.Text);
                firmalarDetay.Tarih = Convert.ToDateTime(dtTarih.Text);
                firmalarDetay.OdemeSekli = txtOdemeSekli.Text;
                firmalarDetay.OdemeId = harcamalar.ID;
                firmalarDetay.Silme = false;

                db.FirmalarDetays.InsertOnSubmit(firmalarDetay);
                db.SubmitChanges();
                msj.YeniKayit("İşlem Başarıyla Yapıldı.");
                this.Close();
                form.FirmalarListesi(true);
                form.HarcamalarListeYenileme();
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "FirmaTahsilat");
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}