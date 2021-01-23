using DevExpress.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using PsgMuhendislik.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PsgMuhendislik.Modul_Musteriler
{
    public partial class frmMusteriDetay : DevExpress.XtraEditors.XtraForm
    {
        pisagorDBDataContext db = new pisagorDBDataContext();
        Mesajlar msj = new Mesajlar();
        Formlar form = new Formlar();
        int toplamKalan;
        public frmMusteriDetay()
        {
            InitializeComponent();
        }
        /* BORÇ */
        public void BorcHesapla(int musteriID)
        {
            var toplamHizmetTutari = 0;
            var toplamOdemeTutari = 0;
            foreach (var item in db.MusterilerDetays.Where(x => x.MusteriID == musteriID).Where(x => x.Silme == false))
            {
                toplamHizmetTutari += Convert.ToInt32(item.EklenenTutar);
                toplamOdemeTutari += Convert.ToInt32(item.OdenenTutar);
            }
            toplamKalan = Convert.ToInt32(toplamHizmetTutari) - Convert.ToInt32(toplamOdemeTutari);
            lblYapilanHizmetTutari.Text = toplamHizmetTutari.ToString("C") + " TL";
            lblYapilanOdemeTutari.Text = toplamOdemeTutari.ToString("C") + " TL";
            lblKalan.Text = toplamKalan.ToString("C") + " TL";
        }

        /* SİLME */
        private void Sil_Click(object sender, EventArgs e)
        { 
            var id = Convert.ToInt32(gridViewMusteriDetay.GetFocusedRowCellValue("ID").ToString());
            var MusteriID = Convert.ToInt32(gridViewMusteriDetay.GetFocusedRowCellValue("MusteriID").ToString());
            var musteri = db.Musterilers.Where(a => a.ID == MusteriID).First();
            var musteriDetay = db.MusterilerDetays.First(x => x.ID == id);
            var gelenOdeme = db.GelenOdemelers.Where(x => x.ID == musteriDetay.OdemeId).First();
            if (msj.Sil() == DialogResult.Yes)
            {
                if (musteriDetay.OdenenTutar.ToString() != "")
                {
                    musteri.Borc += Convert.ToDecimal(gridViewMusteriDetay.GetRowCellValue(gridViewMusteriDetay.FocusedRowHandle, "OdenenTutar"));
                }
                if (musteriDetay.EklenenTutar.ToString() != "")
                {
                    musteri.Borc -= Convert.ToDecimal(gridViewMusteriDetay.GetRowCellValue(gridViewMusteriDetay.FocusedRowHandle, "EklenenTutar"));
                }
                musteriDetay.Silme = true;
                musteriDetay.SilinmeTarihi = DateTime.Now;
                if (gelenOdeme != null)
                {
                    gelenOdeme.SilinmeTarihi = DateTime.Now;
                    gelenOdeme.Silme = true;
                }
                db.SubmitChanges();
                this.BorcHesapla(MusteriID);
                form.MusteriDetay(MusteriID);
                form.MusterilerListesi(true);
                form.GelenOdemeListeYenileme();

            }
        }

        /* DÜZENLEME */
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var ID = Convert.ToInt32(gridViewMusteriDetay.GetFocusedRowCellValue("ID").ToString());
            var MusteriID = Convert.ToInt32(gridViewMusteriDetay.GetRowCellValue(gridViewMusteriDetay.FocusedRowHandle, gridViewMusteriDetay.Columns["MusteriID"]));
            var HizmetTutari = Convert.ToInt32(gridViewMusteriDetay.GetRowCellValue(gridViewMusteriDetay.FocusedRowHandle, gridViewMusteriDetay.Columns["EklenenTutar"]));
            var OdenenTutar = Convert.ToInt32(gridViewMusteriDetay.GetRowCellValue(gridViewMusteriDetay.FocusedRowHandle, "OdenenTutar"));
            var OdemeID = Convert.ToInt32(gridViewMusteriDetay.GetRowCellValue(gridViewMusteriDetay.FocusedRowHandle, "OdemeId"));
            var Tarih = Convert.ToDateTime(gridViewMusteriDetay.GetRowCellValue(gridViewMusteriDetay.FocusedRowHandle, "Tarih"));
            var Aciklama = gridViewMusteriDetay.GetRowCellValue(gridViewMusteriDetay.FocusedRowHandle, gridViewMusteriDetay.Columns["Aciklama"]).ToString();
            try
            {
                var user = db.MusterilerDetays.FirstOrDefault(x => x.ID == ID);
                if (user.EklenenTutar != HizmetTutari || user.OdenenTutar != OdenenTutar || user.Tarih != Tarih || user.Aciklama != Aciklama)
                {
                    if (user.OdenenTutar == null)
                    {
                        user.OdenenTutar = 0;
                    }

                    if (msj.Guncelle() == DialogResult.Yes)
                    {
                        if (user.OdenenTutar != OdenenTutar)
                        {
                            if (OdemeID != 0)
                            {
                                var gelenOdeme = db.GelenOdemelers.First(x => x.ID == OdemeID);
                                gelenOdeme.Tutar = Convert.ToDecimal(OdenenTutar);
                                gelenOdeme.Aciklama = lblMusteriAdi.Text + " / " + Aciklama;
                                gelenOdeme.Tarih = Tarih;
                            }
                            else
                            {
                                GelenOdemeler gelenOdemeler = new GelenOdemeler();
                                gelenOdemeler.Aciklama = lblMusteriAdi.Text + " / " + Aciklama;
                                gelenOdemeler.Silme = false;
                                gelenOdemeler.Tarih = DateTime.Now;
                                gelenOdemeler.Tutar = OdenenTutar;
                                db.GelenOdemelers.InsertOnSubmit(gelenOdemeler);
                                db.SubmitChanges();
                                user.OdemeId = gelenOdemeler.ID;
                            }
                        }
                        user.EklenenTutar = HizmetTutari;
                        user.OdenenTutar = OdenenTutar;
                        user.Tarih = Tarih;
                        user.Aciklama = Aciklama;
                        db.SubmitChanges();
                        var Eklenen = Convert.ToDecimal(db.MusterilerDetays.Where(d => d.MusteriID == MusteriID).Where(x => x.Silme == false).Sum(a => a.EklenenTutar));
                        var Odenen = Convert.ToDecimal(db.MusterilerDetays.Where(d => d.MusteriID == MusteriID).Where(x => x.Silme == false).Sum(a => a.OdenenTutar));
                        db.Musterilers.First(a => a.ID == MusteriID).Borc = Eklenen - Odenen;
                        db.SubmitChanges();
                        //msj.Guncelle("Müşteri Bilgisi Güncellenmiştir.");
                        form.MusteriDetayListeYenile(MusteriID);
                        form.MusterilerListeYenileme();
                        form.GelenOdemeListeYenileme();
                        this.BorcHesapla(MusteriID);
                    }
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        private void frmMusteriDetay_Load(object sender, EventArgs e)
        {
            gridViewMusteriDetay.TopRowIndex = gridViewMusteriDetay.RowCount - 1;
            gridViewMusteriDetay.FocusedRowHandle = gridViewMusteriDetay.RowCount - 1;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "MusteriDetay");
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnExcele_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Excel_Aktar(gridViewMusteriDetay, lblMusteriAdi.Text + " Borç Detayı");
        }
        private void btnPDFe_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Pdf_Aktar(gridViewMusteriDetay,lblMusteriAdi.Text + " Borç Detayı");
        }

        private void grdMusteriDetay_Click(object sender, EventArgs e)
        {

        }

        private void gridViewMusteriDetay_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridViewMusteriDetay_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            formIslem.Renklendir(sender, e);
        }
    }
}