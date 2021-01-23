using PsgMuhendislik.Fonksiyonlar;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PsgMuhendislik.Modul_Firmalar
{
    public partial class FirmaDetay : DevExpress.XtraEditors.XtraForm
    {
        pisagorDBDataContext db = new pisagorDBDataContext();
        Mesajlar msj = new Mesajlar();
        Formlar form = new Formlar();
        int toplamKalan = 0;
        public FirmaDetay()
        {
            InitializeComponent();
        }

     
        /* BORÇ */
        public void BorcHesapla(int firmaID)
        {
            db = new pisagorDBDataContext();
            var toplamAlinanMalTutari = 0;
            var toplamOdemeTutari = 0;
            foreach (var item in db.FirmalarDetays.Where(x => x.FirmaID == firmaID).Where(x => x.Silme == false))
            {
                toplamAlinanMalTutari += Convert.ToInt32(item.AlinanMalTutari);
                toplamOdemeTutari += Convert.ToInt32(item.OdenenTutar);
            }
            toplamKalan = Convert.ToInt32(toplamOdemeTutari) - Convert.ToInt32(toplamAlinanMalTutari);
            lblYapilanHizmetTutari.Text = toplamAlinanMalTutari.ToString("C");
            lblYapilanOdemeTutari.Text = toplamOdemeTutari.ToString("C");
            lblKalan.Text = toplamKalan.ToString("C") ;
        }

        private void btnSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = Convert.ToInt32(gridViewFirmaDetay.GetFocusedRowCellValue("ID").ToString());
            var firmaID = Convert.ToInt32(gridViewFirmaDetay.GetFocusedRowCellValue("FirmaID").ToString());
            var firma = db.Firmalars.Where(a => a.ID == firmaID).First();
            var firmaDetay = db.FirmalarDetays.First(x => x.ID == id);
            var harcama = db.Harcamalars.First(x => x.harcamaid == firmaID);
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    if (firmaDetay.OdenenTutar != 0)
                    {
                        firma.Borc -= Convert.ToDecimal(gridViewFirmaDetay.GetRowCellValue(gridViewFirmaDetay.FocusedRowHandle, "OdenenTutar"));
                    }
                    if (firmaDetay.AlinanMalTutari != 0)
                    {
                        firma.Borc += Convert.ToDecimal(gridViewFirmaDetay.GetRowCellValue(gridViewFirmaDetay.FocusedRowHandle, "AlinanMalTutari"));
                    }
                    firmaDetay.Silme = true;
                    firmaDetay.SilinmeTarihi = DateTime.Now;
                    if (firmaDetay.OdenenTutar != 0)
                    {
                        harcama.Silme = true;
                        harcama.SilinmeTarihi = DateTime.Now;
                    }
                    db.SubmitChanges();
                    this.BorcHesapla(firmaID);
                    form.FirmaDetay(firmaID);
                    form.FirmalarListesi(true);
                    form.HarcamalarListeYenileme();

                }
            }
            catch (Exception)
            {
                msj.Hata("İşlem Sırasın Bir Hata Oluştu...");
            }
        }

        private void Edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var ID = Convert.ToInt32(gridViewFirmaDetay.GetFocusedRowCellValue("ID").ToString());
            var firmaID = Convert.ToInt32(gridViewFirmaDetay.GetRowCellValue(gridViewFirmaDetay.FocusedRowHandle, gridViewFirmaDetay.Columns["FirmaID"]));
            var OdemeId = Convert.ToInt32(gridViewFirmaDetay.GetRowCellValue(gridViewFirmaDetay.FocusedRowHandle, "OdemeId"));
            var AlinanMalTutari = Convert.ToInt32(gridViewFirmaDetay.GetRowCellValue(gridViewFirmaDetay.FocusedRowHandle, gridViewFirmaDetay.Columns["AlinanMalTutari"]));
            var OdenenTutar = Convert.ToInt32(gridViewFirmaDetay.GetRowCellValue(gridViewFirmaDetay.FocusedRowHandle, "OdenenTutar"));
            var Tarih = Convert.ToDateTime(gridViewFirmaDetay.GetRowCellValue(gridViewFirmaDetay.FocusedRowHandle, "Tarih"));
            var Aciklama = gridViewFirmaDetay.GetRowCellValue(gridViewFirmaDetay.FocusedRowHandle, gridViewFirmaDetay.Columns["Aciklama"]).ToString();

            try
            {
                var user = db.FirmalarDetays.FirstOrDefault(x => x.ID == ID);
                if (user.AlinanMalTutari != AlinanMalTutari || user.OdenenTutar != OdenenTutar || user.Tarih != Tarih || user.Aciklama != Aciklama)
                {
                    if (msj.Guncelle() == DialogResult.Yes)
                    {
                        Harcamalar harcamalar;
                        if (user.OdenenTutar != OdenenTutar || user.OdenenTutar == null)
                        {
                            var d = user.OdemeId;
                        
                                if (user.OdenenTutar == 0 || user.OdenenTutar == null)
                                {
                                    harcamalar = new Harcamalar();
                                    harcamalar.Aciklama = lblFirmaAdi.Text + " / " + Aciklama;
                                    harcamalar.Silme = false;
                                    harcamalar.Tarih = DateTime.Now;
                                    harcamalar.Tutar = OdenenTutar;
                                    db.Harcamalars.InsertOnSubmit(harcamalar);
                                    db.SubmitChanges();
                                    user.OdemeId = harcamalar.ID;
                                }
                                else if (user.OdemeId != 0)
                                {
                                    harcamalar = db.Harcamalars.First(x => x.ID == user.OdemeId);
                                    harcamalar.Aciklama = Aciklama;
                                    harcamalar.Silme = false;
                                    harcamalar.Tarih = Tarih;
                                    harcamalar.Tutar = OdenenTutar;
                                    db.SubmitChanges();
                                    user.OdemeId = harcamalar.ID;
                                }
                            
                        }
                        user.AlinanMalTutari = AlinanMalTutari;
                        user.OdenenTutar = OdenenTutar;
                        user.Tarih = Tarih;
                        user.Aciklama = Aciklama;
                        db.SubmitChanges();
                        var AlinanMal = Convert.ToDecimal(db.FirmalarDetays.Where(d => d.FirmaID == firmaID).Where(x => x.Silme == false).Sum(a => a.AlinanMalTutari));
                        var Odenen = Convert.ToDecimal(db.FirmalarDetays.Where(d => d.FirmaID== firmaID).Where(x => x.Silme == false).Sum(a => a.OdenenTutar));
                        db.Firmalars.First(a => a.ID == firmaID).Borc = Odenen - AlinanMal;
                        db.SubmitChanges();
                        msj.Guncelle("Firma Bilgisi Güncellenmiştir.");
                        this.BorcHesapla(firmaID);
                        form.FirmalarListeYenileme();
                        form.HarcamalarListeYenileme();
                        
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
            formIslem.islem(keyData, "FirmaDetay");
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnExcele_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Excel_Aktar(gridViewFirmaDetay, lblFirmaAdi.Text + " Firması Borç Detayı");
        }

        private void btnPDFe_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Pdf_Aktar(gridViewFirmaDetay, lblFirmaAdi.Text + " Firması Borç Detayı");
        }

        private void gridViewFirmaDetay_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            formIslem.Renklendir(sender, e);
        }

        private void FirmaDetay_Load(object sender, EventArgs e)
        {
            gridViewFirmaDetay.TopRowIndex = gridViewFirmaDetay.RowCount - 1;
            gridViewFirmaDetay.FocusedRowHandle = gridViewFirmaDetay.RowCount - 1;
        }
    }
}