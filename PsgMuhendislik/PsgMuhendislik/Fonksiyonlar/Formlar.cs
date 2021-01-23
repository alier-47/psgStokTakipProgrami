using DevExpress.XtraGrid.Views.Grid;
using PsgMuhendislik.Modul_Firmalar;
using PsgMuhendislik.Modul_Musteriler;
using PsgMuhendislik.Moduller.Calisanlar;
using PsgMuhendislik.Moduller.GelenOdemeler;
using PsgMuhendislik.Moduller.Harcamalar;
using PsgMuhendislik.Moduller.İdris;
using PsgMuhendislik.Moduller.Yedekleme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsgMuhendislik.Fonksiyonlar
{
    class Formlar
    {
        pisagorDBDataContext db = new pisagorDBDataContext();
        AnaForm af;
        Mesajlar msj = new Mesajlar();

        #region AnaFormEtkinleştirme
        void anaFormAktiflestir()
        {
            if ((AnaForm)Application.OpenForms["AnaForm"] == null)
                af = new AnaForm();
            else
                af = (AnaForm)Application.OpenForms["AnaForm"];
        }
        #endregion

        #region Müşteriler

        frmMusteriler frmMusteri;
        frmMusteriDetay frmMusteriDetay;
        public void MusterilerListesi(bool Secim = false)
        {
            pisagorDBDataContext db = new pisagorDBDataContext();

            if (Secim)
            {
                MusterilerListeYenileme();
                // frm.butonStatus();
                anaFormAktiflestir();
                af.viewChildForm(frmMusteri);

            }
            else
            {
                frmMusteriler fr = new frmMusteriler();
                fr.MdiParent = AnaForm.ActiveForm;
                fr.Show();
            }
        }
        public void MusterilerListeYenileme()
        {
            if ((frmMusteriler)Application.OpenForms["Musteriler"] == null)
            {
                frmMusteri = new frmMusteriler();
            }
            else
            {
                frmMusteri = (frmMusteriler)Application.OpenForms["Musteriler"];
            }
            frmMusteri.Name = "Musteriler";
            frmMusteri.grdMusteriler.DataSource = null;
            frmMusteri.grdMusteriler.DataSource = db.Musterilers.Where(x => x.Silme == false).OrderBy(x => x.AdSoyad).ToList();
            frmMusteri.BorcHesapla();
            frmMusteri.dtBaslangic.Value = Convert.ToDateTime("01.01.2021");
            frmMusteri.btnTumMusterileriSil.Enabled = false;
        }
        public void MusteriEkle(bool Secim = false)
        {
            Modul_Musteriler.frmMusteriED frm = new Modul_Musteriler.frmMusteriED();
            frm.Name = "MusteriED";
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void MusteriDuzenle(bool Secim = false, int ID = 0)
        {
            pisagorDBDataContext db = new pisagorDBDataContext();
            frmMusteriED frm = new frmMusteriED();
            var musteri = db.Musterilers.FirstOrDefault(x => x.ID == ID);
            frm.Name = "MusteriED";
            if (Secim)
            {
                frm.Secim = Secim;
                frm.lblBaslik.Text = "Müşteri Bilgisi";
                frm.txtAdSoyad.Text = musteri.AdSoyad;
                frm.txtTelefon.Text = musteri.Telefon;
                frm.txtBinaAdi.Text = musteri.BinaAdi;
                frm.txtNot.Text = musteri.Not;
                frm.lblID.Text = ID.ToString();
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void MusteriTahislat(bool Secim = false, string id = "", string musteriAdi = "", string Tip = "")
        {

            frmBorc frm = new frmBorc();
            frm.lblID.Text = id;
            frm.lblMusteriAdi.Text = musteriAdi;
            frm.Name = "MusteriTahsilat";
            if (Tip == "OdemeAl")
            {
                frm.lblTarih.Text = "Tarih";
                frm.Text = "Tahsilat";

            }
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void MusteriDetay(int musteriID)
        {
            MusteriDetayListeYenile(musteriID);
            frmMusteriDetay.lblMusteriAdi.Text = db.Musterilers.First(x => x.ID == musteriID).AdSoyad;
            frmMusteriDetay.Show();
        }
        public void MusteriDetayListeYenile(int MusteriID)
        {
            pisagorDBDataContext db = new pisagorDBDataContext();

            if ((frmMusteriDetay)Application.OpenForms["MusteriDetay"] == null)
            {
                frmMusteriDetay = new frmMusteriDetay();
                frmMusteriDetay.Name = "MusteriDetay";
            }
            else
            {
                frmMusteriDetay = (frmMusteriDetay)Application.OpenForms["MusteriDetay"];
            }

            frmMusteriDetay.grdMusteriDetay.DataSource = null;
            frmMusteriDetay.grdMusteriDetay.DataSource = db.MusterilerDetays.Where(d => d.MusteriID == MusteriID).Where(a => a.Silme == false).OrderBy(x => x.ID);
            frmMusteriDetay.BorcHesapla(MusteriID);

        }
        #endregion

        #region Firmalar

        frmFirmalar frmFirma;
        FirmaDetay firmaDetay;
        public void FirmalarListesi(bool Secim = false)
        {
            if (Secim)
            {
                FirmalarListeYenileme();
                anaFormAktiflestir();
                af.viewChildForm(frmFirma);
            }
            else
            {
                frmFirmalar fr = new frmFirmalar();
                fr.MdiParent = AnaForm.ActiveForm;
                fr.Show();
            }
        }
        public void FirmalarListeYenileme()
        {
            db = new pisagorDBDataContext();
            if ((frmFirmalar)Application.OpenForms["Firmalar"] == null)
            {
                frmFirma = new frmFirmalar();
            }
            else
            {
                frmFirma = (frmFirmalar)Application.OpenForms["Firmalar"];
            }
            frmFirma.Name = "Firmalar";
            frmFirma.grdFirmalar.DataSource = null;
            frmFirma.grdFirmalar.DataSource = db.Firmalars.Where(x => x.Silme == false).OrderBy(x => x.FirmaAdi).ToList();
            frmFirma.BorcHesapla();
            frmFirma.butonStatus();
            frmFirma.btnTumFirmalariSil.Enabled = false;
        }
        public void FirmaEkle(bool Secim = false)
        {
            frmFirmaED frm = new frmFirmaED();
            frm.Name = "FirmaED";
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void FirmaDuzenle(bool Secim = false, int ID = 0)
        {
            // pisagorDBDataContext db = new pisagorDBDataContext();
            frmFirmaED frm = new frmFirmaED();
            frm.Name = "FirmaED";
            var firma = db.Firmalars.FirstOrDefault(x => x.ID == ID);
            if (Secim)
            {
                frm.Secim = Secim;
                frm.lblBaslik.Text = "Firma Bilgisi";
                frm.txtFirmaAdi.Text = firma.FirmaAdi;
                frm.txtTelefon.Text = firma.Telefon;
                frm.lblID.Text = ID.ToString();
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void FirmaTahsilat(bool Secim = false, string id = "", string FirmaAdi = "", string Tip = "")
        {

            frmFirmaTahsilat frm = new frmFirmaTahsilat();
            frm.Name = "FirmaTahsilat";
            frm.lblID.Text = id;
            frm.lblFirmaAdi.Text = FirmaAdi;
            if (Tip == "OdemeYap")
            {
                frm.lblOdemeSekli.Enabled = true;
                frm.txtOdemeSekli.Enabled = true;
                frm.lblTarih.Text = "Tarih";
                frm.Tag = "OdemeYap";
                frm.Text = "Firmaya Ödeme Yap";

            }
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void FirmaDetay(int FirmaID)
        {
            FirmaDetayYenileme(FirmaID);
            firmaDetay.Show();
        }
        public void FirmaDetayYenileme(int FirmaID)
        {
            firmaDetay = (FirmaDetay)Application.OpenForms["FirmaDetay"];
            var FirmaAdi = db.Firmalars.Where(x => x.ID == FirmaID).First().FirmaAdi;
            if (firmaDetay == null)
                firmaDetay = new FirmaDetay();
            var musteri = db.FirmalarDetays.Where(d => d.FirmaID == FirmaID).Where(a => a.Silme == false).OrderBy(x => x.ID);
            firmaDetay.Text = "Firma Detay - " + FirmaAdi;
            firmaDetay.Name = "FirmaDetay";
            firmaDetay.lblFirmaAdi.Text = FirmaAdi;
            firmaDetay.BorcHesapla(FirmaID);
            firmaDetay.grdFirmaDetay.DataSource = musteri.OrderBy(x => x.ID);
        }
        #endregion

        #region Çalışanlar
        frmCalisanlar frmCalisanlar;
        frmCalisanDetay frmCalisanDetay;
        frmCalisanEDevlet frmCalisanEDevlet;
        public void CalisanlarListesi(bool Secim = false)
        {
            db = new pisagorDBDataContext();

            if (Secim)
            {
                CalisanListesiYenile();
                anaFormAktiflestir();
                af.viewChildForm(frmCalisanlar);
            }
            else
            {
                frmCalisanlar fr = new frmCalisanlar();
                fr.MdiParent = AnaForm.ActiveForm;
                fr.Show();
            }
        }

        public void CalisanListesiYenile()
        {

            if ((frmCalisanlar)Application.OpenForms["Calisanlar"] == null)
            {
                frmCalisanlar = new frmCalisanlar();
            }
            else
            {
                frmCalisanlar = (frmCalisanlar)Application.OpenForms["Calisanlar"];
            }
            frmCalisanlar.Name = "Calisanlar";
            frmCalisanlar.grdCalisanlar.DataSource = null;
            frmCalisanlar.grdCalisanlar.DataSource = db.Calisanlars.Where(x => x.Silme == false).OrderBy(x => x.AdSoyad).ToList();
            frmCalisanlar.BorcHesapla();
            frmCalisanlar.btnTumCalisanlariSil.Enabled = false;
        }
        public void CalisanEkle(bool Secim = false)
        {
            frmCalisanED frm = new frmCalisanED();
            frm.Name = "CalisanED";
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void CalisanDuzenle(bool Secim = false, int ID = 0)
        {
            // pisagorDBDataContext db = new pisagorDBDataContext();
            frmCalisanED frm = new frmCalisanED();
            frm.Name = "CalisanED";
            var calisan = db.Calisanlars.FirstOrDefault(x => x.ID == ID);
            if (Secim)
            {
                frm.Secim = Secim;
                frm.lblBaslik.Text = "Çalışan Bilgisi";
                frm.txtAdSoyad.Text = calisan.AdSoyad;
                frm.txtTelefon.Text = calisan.Telefon;
                frm.txtMaas.Text = calisan.AlacakTutar.ToString();
                frm.dtIseBaslamaTarihi.Text = calisan.IsBaslangicTarihi.ToString();
                frm.cmbCalismaSekli.Text = calisan.CalismaSekli;
                frm.lblID.Text = ID.ToString();
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void CalisanSil(int id)
        {
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    db = new pisagorDBDataContext();
                    var calisan = db.Calisanlars.First(x => x.ID == id);
                    var calisanDetay = db.CalisanlarDetays.Where(a => a.CalisanID == id).Where(x=>x.Silme == false).ToList();
                    foreach (var item in calisanDetay)
                    {
                        item.Silme = true;
                        item.SilinmeTarihi = DateTime.Now;
                    }
                    calisan.Silme = true;
                    calisan.SilinmeTarihi = DateTime.Now;
                    db.SubmitChanges();
                    this.CalisanlarListesi(true);
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }
        public void CalisanTahsilat(bool Secim = false, string id = "", string CalisanAdi = "", string Tip = "")
        {

            frmCalisanTahsilat frm = new frmCalisanTahsilat();
            frm.Name = "CalisanTahsilat";
            frm.lblID.Text = id;
            frm.lblCalisanAdi.Text = CalisanAdi;
            if (Tip == "MaasEkle")
            {
                frm.lblTarih.Text = "Tarih";
                frm.Tag = "MaasEkle";
                frm.Text = "Çalışan Maaş Ödemesi";

            }
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void CalisanDetay(int CalisanID)
        {
            CalisanlarDetayListeYenileme(CalisanID);
            frmCalisanDetay.Show();
        }

        public void CalisanlarDetayListeYenileme(int CalisanID)
        {
            db = new pisagorDBDataContext();
            if ((frmCalisanDetay)Application.OpenForms["CalisanDetay"] == null)
            {
                frmCalisanDetay = new frmCalisanDetay();
                frmCalisanDetay.Name = "CalisanDetay";
            }
            else
            {
                frmCalisanDetay = (frmCalisanDetay)Application.OpenForms["CalisanDetay"];
            }
            var calisanAdi = db.Calisanlars.Where(x => x.ID == CalisanID).First().AdSoyad;
            var calisan = db.CalisanlarDetays.Where(d => d.CalisanID == CalisanID).Where(a => a.Silme == false).OrderBy(x => x.ID);
            frmCalisanDetay.Text = "Çalışan Detay - " + calisanAdi;
            frmCalisanDetay.lblCalisanAdi.Text = calisanAdi;
            frmCalisanDetay.BorcHesapla(CalisanID);
            frmCalisanDetay.grdCalisanDetay.DataSource = calisan.OrderBy(x => x.ID).Where(x => x.Silme == false);
        }
        public void CalisanCizelgesi(int CalisanID)
        {
            db = new pisagorDBDataContext();
            frmCalisanCizelgesi frm;


            if ((frmCalisanCizelgesi)Application.OpenForms["CalisanCizelgesi"] == null)
            {
                frm = new frmCalisanCizelgesi();
            }
            else
            {
                frm = (frmCalisanCizelgesi)Application.OpenForms["CalisanCizelgesi"];
            }
            frm.lblCalisanID.Text = CalisanID.ToString();
            frm.Name = "CalisanCizelgesi";
            frm.btnSecilileriSil.Enabled = false;
            var calisanAdi = db.Calisanlars.Where(x => x.ID == CalisanID).First().AdSoyad;
            var calisan = db.CalisanCizelgesis.Where(d => d.CalisanID == CalisanID).OrderBy(x => x.ID);
            frm.Text = calisanAdi + " Eksik Gün Sayımı";
            frm.lblCalisanAdi.Text = calisanAdi;
            frm.grdCalisanCizelgesi.DataSource = calisan;
            frm.GunHesapla();
            frm.Show();
        }
        public void CalisanCizelgesiEkle(int CalisanID)
        {

            frmCalisanCizelgesiED frm = new frmCalisanCizelgesiED();
            frm.Name = "CalisanCizelgesiED";
            var calisan = db.Calisanlars.First(x => x.ID == CalisanID);
            frm.lblBaslik.Text = calisan.AdSoyad;
            frm.CalisanID.Text = CalisanID.ToString();
            frm.ShowDialog();
        }
        public void CalisanCizelgesiDuzenle(int ID = 0)
        {
            pisagorDBDataContext db = new pisagorDBDataContext();
            frmCalisanCizelgesiED frm = new frmCalisanCizelgesiED();
            var calisanCizelgesi = db.CalisanCizelgesis.First(x => x.ID == ID);
            var calisan = db.Calisanlars.FirstOrDefault(x => x.ID == calisanCizelgesi.CalisanID); ;
            frm.lblBaslik.Text = calisan.AdSoyad;
            frm.txtAciklama.Text = calisanCizelgesi.Aciklama;
            frm.cmbGun.Text = calisanCizelgesi.GunSayisi == 1 ? "Tam Gün" : "Yarım Gün";
            frm.lblID.Text = ID.ToString();
            frm.CalisanID.Text = calisan.ID.ToString();
            frm.ShowDialog();

        }
        public void CalisanCizelgesiSil(int id)
        {
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    db = new pisagorDBDataContext();
                    var calisan = db.CalisanCizelgesis.Where(x => x.ID == id).First();
                    db.CalisanCizelgesis.DeleteOnSubmit(calisan);
                    db.SubmitChanges();
                    this.CalisanCizelgesi(Convert.ToInt32(calisan.CalisanID));
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }


        public void CalisanEDevlet(int CalisanID)
        {
            CalisanEDevletYenile(CalisanID);
            frmCalisanEDevlet.Show();
        }
        public void CalisanEDevletYenile(int CalisanID)
        {
            db = new pisagorDBDataContext();
            if ((frmCalisanEDevlet)Application.OpenForms["CalisanEDevlet"] == null)
            {
                frmCalisanEDevlet = new frmCalisanEDevlet();
            }
            else
            {
                frmCalisanEDevlet = (frmCalisanEDevlet)Application.OpenForms["CalisanEDevlet"];
            }
            frmCalisanEDevlet.Name = "CalisanEDevlet";
            var calisanAdi = db.Calisanlars.Where(x => x.ID == CalisanID).First().AdSoyad;
            var calisan = db.CalisanEDevlets.Where(d => d.CalisanID == CalisanID).OrderBy(x => x.ID);
            frmCalisanEDevlet.lblCalisanAdi.Text = calisanAdi;
            frmCalisanEDevlet.lblCalisanID.Text = CalisanID.ToString();
            frmCalisanEDevlet.grdCalisanEDevlet.DataSource = calisan;
        }
        public void CalisanEDevletEkle(int CalisanID)
        {

            frmCalisanEDevletED frm = new frmCalisanEDevletED();
            frm.Name = "CalisanEDevletED";
            var calisan = db.Calisanlars.First(x => x.ID == CalisanID);
            frm.lblBaslik.Text = calisan.AdSoyad;
            frm.CalisanID.Text = calisan.ID.ToString();
            frm.ShowDialog();
        }
        public void CalisanEDevletSil(int id)
        {
            int calisanid = 0;
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    db = new pisagorDBDataContext();
                    var calisan = db.CalisanEDevlets.First(x => x.ID == id);
                    calisanid = Convert.ToInt32(calisan.CalisanID);
                    db.CalisanEDevlets.DeleteOnSubmit(calisan);
                    db.SubmitChanges();
                    this.CalisanEDevletYenile(calisanid);
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }


        #endregion

        #region Gelen Ödemeler

        frmGelenOdemeler frmGelenOdeme;
        public void GelenOdemeListesi(bool Secim = false)
        {
            db = new pisagorDBDataContext();
            if (Secim)
            {
                GelenOdemeListeYenileme();
                anaFormAktiflestir();
                af.viewChildForm(frmGelenOdeme);
            }
            else
            {
                frmGelenOdemeler fr = new frmGelenOdemeler();
                fr.MdiParent = AnaForm.ActiveForm;
                fr.Show();
            }
        }
        public void GelenOdemeListeYenileme()
        {
            if ((frmGelenOdemeler)Application.OpenForms["GelenOdemeler"] == null)
            {
                frmGelenOdeme = new frmGelenOdemeler();
            }
            else
            {
                frmGelenOdeme = (frmGelenOdemeler)Application.OpenForms["GelenOdemeler"];
            }
            frmGelenOdeme.Name = "GelenOdemeler";
            frmGelenOdeme.grdGelenOdemeler.DataSource = db.GelenOdemelers.Where(x => x.Silme == false).OrderBy(x => x.ID).ToList();
            frmGelenOdeme.BorcHesapla();
            frmGelenOdeme.dtBaslangic.Value = Convert.ToDateTime("01.01.2021");
            frmGelenOdeme.btnSeciliOdemeleriSil.Enabled = false;
        }
        public void GelenOdemeEkle(bool Secim = false)
        {
            frmOdemeED frm = new frmOdemeED();
            frm.Name = "GelenOdemeED";
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void GelenOdemeDuzenle(bool Secim = false, int ID = 0)
        {
            // pisagorDBDataContext db = new pisagorDBDataContext();
            frmOdemeED frm = new frmOdemeED();
            var odeme = db.GelenOdemelers.FirstOrDefault(x => x.ID == ID);
            frm.Name = "GelenOdemeED";
            if (Secim)
            {
                frm.Secim = Secim;
                frm.lblOdeme.Text = "Ödeme Düzenle";
                frm.txtAciklama.Text = odeme.Aciklama;
                frm.txtTutar.Text = odeme.Tutar.ToString();
                frm.dtTarih.Text = odeme.Tarih.ToString();
                frm.lblID.Text = ID.ToString();
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void GelenOdemeSil(int id)
        {
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    var odeme = db.GelenOdemelers.First(x => x.ID == id);
                    odeme.Silme = true;
                    odeme.SilinmeTarihi = DateTime.Now;
                    db.SubmitChanges();
                    this.GelenOdemeListesi(true);
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }
        #endregion

        #region Harcamalar

        frmHarcamalar frmHarcama;
        public void HarcamaListesi(bool Secim = false)
        {
            db = new pisagorDBDataContext();
            frmHarcamalar frm;
            if (Secim)
            {
                HarcamalarListeYenileme();
                anaFormAktiflestir();
              
                //frm.butonStatus();
                af.viewChildForm(frmHarcama);

            }
            else
            {
                frmHarcamalar fr = new frmHarcamalar();
                fr.MdiParent = AnaForm.ActiveForm;
                fr.Show();
            }
        }
        public void HarcamalarListeYenileme()
        {
            db = new pisagorDBDataContext();
            if ((frmHarcamalar)Application.OpenForms["Harcamalar"] == null)
            {
                frmHarcama = new frmHarcamalar();
            }
            else
            {
                frmHarcama = (frmHarcamalar)Application.OpenForms["Harcamalar"];
            }
            frmHarcama.Name = "Harcamalar";
            frmHarcama.grdHarcamalar.DataSource = null;
            frmHarcama.grdHarcamalar.DataSource = db.Harcamalars.Where(x => x.Silme == false).OrderBy(x => x.ID).ToList();
            frmHarcama.BorcHesapla();
            frmHarcama.dtBaslangic.Value = Convert.ToDateTime("01.01.2021");
            frmHarcama.btnSeciliHarcamalariSil.Enabled = false;
        }
        public void HarcamaEkle(bool Secim = false)
        {
            frmHarcamaED frm = new frmHarcamaED();
            frm.Name = "HarcamaED";
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void HarcamaDuzenle(bool Secim = false, int ID = 0)
        {
            frmHarcamaED frm = new frmHarcamaED();
            var odeme = db.Harcamalars.FirstOrDefault(x => x.ID == ID);
            frm.Name = "HarcamaED";
            if (Secim)
            {
                frm.Secim = Secim;
                frm.lblHarcama.Text = "Harcama Düzenle";
                frm.txtAciklama.Text = odeme.Aciklama;
                frm.txtTutar.Text = odeme.Tutar.ToString();
                frm.dtTarih.Text = odeme.Tarih.ToString();
                frm.lblID.Text = ID.ToString();
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void HarcamaSil(int id)
        {
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    db = new pisagorDBDataContext();
                    var odeme = db.Harcamalars.First(x => x.ID == id);
                    odeme.Silme = true;
                    odeme.SilinmeTarihi = DateTime.Now;
                    db.SubmitChanges();
                    this.HarcamaListesi(true);
                    this.CalisanListesiYenile();
                    this.FirmalarListeYenileme();
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }
        #endregion

        #region İdris Alınan Paralar

        public void idrisAlinanParaListesi(bool Secim = false)
        {
            db = new pisagorDBDataContext();
            frmIdris frm;
            if (Secim)
            {
                if ((frmIdris)Application.OpenForms["İdris"] == null)
                {
                    frm = new frmIdris();
                }
                else
                {
                    frm = (frmIdris)Application.OpenForms["İdris"];
                }
                frm.Name = "İdris";
                frm.grdIdris.DataSource = null;
                frm.grdIdris.DataSource = db.İdris.Where(x => x.Silme == false).OrderBy(x => x.ID).ToList();
                anaFormAktiflestir();
                frm.BorcHesapla();
                frm.btnSeciliSil.Enabled = false;
                frm.dtBaslangic.Value = Convert.ToDateTime("01.01.2021");
                //frm.butonStatus();
                af.viewChildForm(frm);

            }
            else
            {
                frmIdris fr = new frmIdris();
                fr.MdiParent = AnaForm.ActiveForm;
                fr.Show();
            }
        }
        public void idrisAlinanParaEkle(bool Secim = false)
        {
            frmIdrisED frm = new frmIdrisED();
            frm.Name = "idrisED";
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void AlinanParaDuzenle(bool Secim = false, int ID = 0)
        {
            frmIdrisED frm = new frmIdrisED();
            frm.Name = "idrisED";
            var odeme = db.İdris.FirstOrDefault(x => x.ID == ID);
            if (Secim)
            {
                frm.Secim = Secim;
                frm.lblHarcama.Text = "Harcama Düzenle";
                frm.txtAciklama.Text = odeme.Aciklama;
                frm.txtTutar.Text = odeme.Tutar.ToString();
                frm.dtTarih.Text = odeme.Tarih.ToString();
                frm.lblID.Text = ID.ToString();
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void AlinanParaSil(int id)
        {
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    db = new pisagorDBDataContext();
                    var odeme = db.İdris.First(x => x.ID == id);
                    odeme.Silme = true;
                    odeme.SilinmeTarihi = DateTime.Now;
                    db.SubmitChanges();
                    this.idrisAlinanParaListesi(true);
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }
        #endregion

        #region Yedekleme
        public void Yedekleme(bool Secim = false)
        {
            db = new pisagorDBDataContext();
            frmYedekleme frm;
            if (Secim)
            {
                if ((frmYedekleme)Application.OpenForms["Yedekleme"] == null)
                {
                    frm = new frmYedekleme();
                    frm.Name = "Yedekleme";
                }
                else
                {
                    frm = (frmYedekleme)Application.OpenForms["Yedekleme"];
                }
                frm.Show();

            }
            else
            {
                frmYedekleme fr = new frmYedekleme();
                fr.MdiParent = AnaForm.ActiveForm;
                fr.Show();
            }
        }
        #endregion
    }
}
