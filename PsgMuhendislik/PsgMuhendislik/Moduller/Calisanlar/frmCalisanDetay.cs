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
    public partial class frmCalisanDetay : DevExpress.XtraEditors.XtraForm
    {
        pisagorDBDataContext db = new pisagorDBDataContext();
        Mesajlar msj = new Mesajlar();
        Formlar form = new Formlar();
        int kalan = 0;

        public frmCalisanDetay()
        {
            InitializeComponent();
        }

        /* BORÇ */
        public void BorcHesapla(int CalisanID)
        {
            var maas = 0;
            var odenen = 0;
            var calisan = db.Calisanlars.Where(a => a.ID == CalisanID).First();
            foreach (var item in db.CalisanlarDetays.Where(x => x.CalisanID == CalisanID).Where(x => x.Silme == false))
            {
                maas += Convert.ToInt32(item.AlacakTutar);
                odenen += Convert.ToInt32(item.OdenenTutar);
            }
            kalan = Convert.ToInt32(maas) - Convert.ToInt32(odenen);
            lblMaas.Text = maas.ToString("C");
            lblYapilanOdemeTutari.Text = odenen.ToString("C");
            lblKalan.Text = kalan.ToString("C");
        }

        private void btnSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = Convert.ToInt32(gridViewCalisanDetay.GetFocusedRowCellValue("ID").ToString());
            var CalisanID = Convert.ToInt32(gridViewCalisanDetay.GetFocusedRowCellValue("CalisanID").ToString());
            var odenen = Convert.ToDecimal(gridViewCalisanDetay.GetRowCellValue(gridViewCalisanDetay.FocusedRowHandle, "OdenenTutar"));
            var eklenen = Convert.ToDecimal(gridViewCalisanDetay.GetRowCellValue(gridViewCalisanDetay.FocusedRowHandle, "AlacakTutar"));
            var calisan = db.Calisanlars.Where(a => a.ID == CalisanID).First();
            var calisanDetay = db.CalisanlarDetays.First(x => x.ID == id);
            var harcama = db.Harcamalars.First(x => x.ID == calisanDetay.OdemeId);
            var sonuc = odenen - eklenen;
            if (msj.Sil() == DialogResult.Yes)
            {
                calisan.AlacakTutar += sonuc;
                calisanDetay.Silme = true;
                calisanDetay.SilinmeTarihi = DateTime.Now;
                harcama.Silme = true;
                harcama.SilinmeTarihi = DateTime.Now;
                db.SubmitChanges();
                this.BorcHesapla(CalisanID);
                form.CalisanDetay(CalisanID);
                form.CalisanlarListesi(true);
                form.CalisanListesiYenile();
                form.HarcamalarListeYenileme();

            }
        }

        private void Edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            grdCalisanDetay.Refresh();
            var ID = Convert.ToInt32(gridViewCalisanDetay.GetFocusedRowCellValue("ID").ToString());
            var CalisanID = Convert.ToInt32(gridViewCalisanDetay.GetRowCellValue(gridViewCalisanDetay.FocusedRowHandle, gridViewCalisanDetay.Columns["CalisanID"]));
            var OdemeId = Convert.ToInt32(gridViewCalisanDetay.GetRowCellValue(gridViewCalisanDetay.FocusedRowHandle, "OdemeId"));
            var AlacakTutar = Convert.ToInt32(gridViewCalisanDetay.GetRowCellValue(gridViewCalisanDetay.FocusedRowHandle, gridViewCalisanDetay.Columns["AlacakTutar"]));
            var OdenenTutar = Convert.ToInt32(gridViewCalisanDetay.GetRowCellValue(gridViewCalisanDetay.FocusedRowHandle, "OdenenTutar"));
            var Tarih = Convert.ToDateTime(gridViewCalisanDetay.GetRowCellValue(gridViewCalisanDetay.FocusedRowHandle, "Tarih"));
            var Aciklama = gridViewCalisanDetay.GetRowCellValue(gridViewCalisanDetay.FocusedRowHandle, gridViewCalisanDetay.Columns["Aciklama"]).ToString();

            try
            {
                var user = db.CalisanlarDetays.FirstOrDefault(x => x.ID == ID);
                if (user.AlacakTutar != AlacakTutar || user.OdenenTutar != OdenenTutar || user.Tarih != Tarih || user.Aciklama != Aciklama)
                {
                    if (msj.Guncelle() == DialogResult.Yes)
                    {
                        Fonksiyonlar.Harcamalar harcamalar = new Fonksiyonlar.Harcamalar();
                        if (user.OdenenTutar != OdenenTutar)
                        {
                            if (OdemeId != 0)
                                harcamalar = db.Harcamalars.First(x => x.ID == OdemeId);

                            harcamalar.Aciklama = lblCalisanAdi.Text + "/" + " Maaş Ödemesi/ " + Aciklama;
                            harcamalar.Tutar = OdenenTutar;
                            harcamalar.Silme = false;
                            harcamalar.Tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            harcamalar.Tutar = OdenenTutar;
                            if (user.OdenenTutar == 0)
                            {
                                db.Harcamalars.InsertOnSubmit(harcamalar);
                                db.SubmitChanges();
                                user.OdemeId = harcamalar.ID;
                            }
                            //db.SubmitChanges();
                        }
                        user.AlacakTutar = AlacakTutar;
                        user.OdenenTutar = OdenenTutar;
                        user.Tarih = Tarih;
                        user.Aciklama = Aciklama;
                        db.SubmitChanges();
                        var Maas = Convert.ToDecimal(db.CalisanlarDetays.Where(d => d.CalisanID == CalisanID).Where(x => x.Silme == false).Sum(a => a.AlacakTutar));
                        var Odenen = Convert.ToDecimal(db.CalisanlarDetays.Where(d => d.CalisanID == CalisanID).Where(x => x.Silme == false).Sum(a => a.OdenenTutar));
                        db.Calisanlars.First(a => a.ID == CalisanID).AlacakTutar = Maas - Odenen;
                        db.SubmitChanges();
                        form.CalisanDetay(CalisanID);
                        this.BorcHesapla(CalisanID);
                        form.CalisanListesiYenile();
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
            formIslem.islem(keyData, "CalisanDetay");
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnExcele_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Excel_Aktar(gridViewCalisanDetay, lblCalisanAdi.Text + " Çalışma Detayı");
        }

        private void btnPDFe_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Pdf_Aktar(gridViewCalisanDetay, lblCalisanAdi.Text + " Çalışma Detayı");
        }

        private void gridViewCalisanDetay_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            formIslem.Renklendir(sender, e);
        }

        private void frmCalisanDetay_Load(object sender, EventArgs e)
        {
            gridViewCalisanDetay.TopRowIndex = gridViewCalisanDetay.RowCount - 1;
            gridViewCalisanDetay.FocusedRowHandle = gridViewCalisanDetay.RowCount - 1;
        }
    }
}