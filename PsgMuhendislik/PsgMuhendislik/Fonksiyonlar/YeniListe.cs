using PsgMuhendislik.Modul_Firmalar;
using PsgMuhendislik.Modul_Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsgMuhendislik.Fonksiyonlar
{
    public class YeniListe
    {
        pisagorDBDataContext db = new pisagorDBDataContext();

        #region Müşteriler
        public void Musteriler()
        {
            frmMusteriler f = (frmMusteriler)Application.OpenForms["Musteriler"];
            AnaForm an = (AnaForm)Application.OpenForms["AnaForm"];
            f.grdMusteriler.DataSource = db.Musterilers.Where(a=>a.Silme== false).OrderBy(x=>x.AdSoyad);
            an.viewChildForm(f);
        }
        public void MusteriDetay(int musteriID)
        {
            frmMusteriDetay fr = (frmMusteriDetay)Application.OpenForms["frmMusteriDetay"];
            if (fr == null)
                fr = new frmMusteriDetay();
            var musteri = db.MusterilerDetays.Where(d => d.MusteriID == musteriID).Where(a => a.Silme == false).OrderBy(x => x.Tarih);
            fr.Text = "Müşteri Detay - " + db.Musterilers.Where(x => x.ID == musteriID).First().AdSoyad;
            fr.BorcHesapla(musteriID);
            fr.grdMusteriDetay.DataSource = musteri.OrderBy(x => x.Tarih);
            fr.Show();
        }

        #endregion

        public void Firmalar()
        {
            frmFirmalar f = (frmFirmalar)Application.OpenForms["Firmalar"];
            AnaForm an = (AnaForm)Application.OpenForms["AnaForm"];
            f.grdFirmalar.DataSource = db.Firmalars.Where(a => a.Silme == false).OrderBy(x => x.FirmaAdi);
            an.viewChildForm(f);
        }
        public void FirmalarDetay(int firmaID)
        {
            FirmaDetay fr = (FirmaDetay)Application.OpenForms["frmFirmaDetay"];
            if (fr == null)
                fr = new FirmaDetay();
            var firma = db.FirmalarDetays.Where(d => d.FirmaID == firmaID).Where(a => a.Silme == false).OrderBy(x => x.Tarih);
            fr.Text = "Firma Detay - " + db.Firmalars.Where(x => x.ID == firmaID).First().FirmaAdi;
            fr.BorcHesapla(firmaID);
            fr.grdFirmaDetay.DataSource = firma.OrderBy(x => x.Tarih);
            fr.Show();
        }
    }
}
