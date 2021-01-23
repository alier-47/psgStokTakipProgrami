using DevExpress.XtraGrid.Views.Grid;
using PsgMuhendislik.Fonksiyonlar;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PsgMuhendislik.Modul_Musteriler
{
    public partial class frmMusteriler : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        Formlar form = new Formlar();
        Mesajlar msj = new Mesajlar();
        pisagorDBDataContext db = new pisagorDBDataContext();

        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            form.MusteriEkle(true);
        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            var id = int.Parse(gridViewMusteriler.GetFocusedRowCellValue("ID").ToString());
            form.MusteriDuzenle(true, id);
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            var id = int.Parse(gridViewMusteriler.GetFocusedRowCellValue("ID").ToString());
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    db = new pisagorDBDataContext();
                    var musteri = db.Musterilers.First(x => x.ID == id);
                    var musteriDetay = db.MusterilerDetays.Where(a => a.MusteriID == id).ToList();
                    foreach (var item in musteriDetay)
                    {
                        item.Silme = true;
                        item.SilinmeTarihi = DateTime.Now;
                    }
                    musteri.Silme = true;
                    musteri.SilinmeTarihi = DateTime.Now;
                    db.SubmitChanges();
                    form.MusterilerListesi(true);
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        private void btnMusteriDetayi_Click(object sender, EventArgs e)
        {
            MusteriDetayGetir();
        }

        private void gridViewMusteriler_DoubleClick(object sender, EventArgs e)
        {
            MusteriDetayGetir();
        }

        public void MusteriDetayGetir()
        {
            if (gridViewMusteriler.DataRowCount > 0)
            {
                var id = Convert.ToInt32(gridViewMusteriler.GetFocusedRowCellValue("ID").ToString());
                form.MusteriDetay(id);
            }
        }

        private void btnBorcEkle_Click(object sender, EventArgs e)
        {
            var id = gridViewMusteriler.GetFocusedRowCellValue("ID").ToString();
            var musteriAdi = gridViewMusteriler.GetFocusedRowCellValue("AdSoyad").ToString();
            form.MusteriTahislat(true, id, musteriAdi, "BorcEkle");
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            var id = gridViewMusteriler.GetFocusedRowCellValue("ID").ToString();
            var musteriAdi = gridViewMusteriler.GetFocusedRowCellValue("AdSoyad").ToString();
            form.MusteriTahislat(true, id, musteriAdi, "OdemeAl");
        }

        private void btnTumMusterileriSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    foreach (var item in gridViewMusteriler.GetSelectedRows())
                    {
                        var id = Convert.ToInt32(gridViewMusteriler.GetRowCellValue(item, gridViewMusteriler.Columns["ID"]));
                        var musteri = db.Musterilers.Where(x => x.ID == id && x.Silme == false).First();
                        var musteriDetay = db.MusterilerDetays.Where(x => x.MusteriID == id && x.Silme == false).ToList();
                        musteri.Silme = true;
                        musteri.SilinmeTarihi = DateTime.Now;
                        if (musteriDetay.Count != 0)
                        {
                            foreach (var detay in musteriDetay)
                            {
                                detay.Silme = true;
                                detay.SilinmeTarihi = DateTime.Now;
                            }
                        }
                    }
                    db.SubmitChanges();
                    form.MusterilerListesi(true);
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }


        private void btnAra_Click(object sender, EventArgs e)
        {

            pisagorDBDataContext db = new pisagorDBDataContext();
            var result = db.Musterilers.Where(x => x.Tarih >= Convert.ToDateTime(Convert.ToDateTime(dtBaslangic.Text).ToShortDateString()) & x.Tarih <= Convert.ToDateTime(Convert.ToDateTime(dtBitis.Text).ToShortDateString()) & x.Silme == false).ToList();
            //var result = from x in db.Musterilers where x.Tarih >= Convert.ToDateTime(dtBaslangic.Text) && x.Tarih <= Convert.ToDateTime(dtBitis.Text).AddMinutes(1) && x.Silme == false select x;
            grdMusteriler.DataSource = result;
            BorcHesapla();
        }
   

        private void gridViewMusteriler_ColumnFilterChanged(object sender, EventArgs e)
        {
        }
        public void BorcHesapla()
        {
            int toplamBorc = 0;
            for (int i = 0; i < gridViewMusteriler.DataRowCount; ++i)
            {
                toplamBorc += Convert.ToInt32(gridViewMusteriler.GetRowCellValue(i, "Borc")); ;
            }
            lblBorc.Text = toplamBorc.ToString("C");
            butonStatus();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            form.MusterilerListesi(true);
        }

        public void butonStatus()
        {
            if (gridViewMusteriler.DataRowCount <= 0)
            {
                btnMusteriDuzenle.Enabled = false;
                btnMusteriSil.Enabled = false;
                btnBorcEkle.Enabled = false;
                btnTumMusterileriSil.Enabled = false;
                btnOdemeAl.Enabled = false;
                btnMusteriDetayi.Enabled = false;
            }
            else
            {
                btnMusteriDuzenle.Enabled = true;
                btnMusteriSil.Enabled = true;
                btnBorcEkle.Enabled = true;
                btnOdemeAl.Enabled = true;
                btnMusteriDetayi.Enabled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "MusteriEkle");
            formIslem.islem(keyData, "Musteriler");
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnPDFe_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Pdf_Aktar(gridViewMusteriler, "Müşteriler Listesi");
        }

        private void btnExcele_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Excel_Aktar(gridViewMusteriler, "Müşteriler Listesi");
        }

        private void gridViewMusteriler_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gridViewMusteriler.SelectedRowsCount > 0)
            {
                btnTumMusterileriSil.Enabled = true;
            }
            else
            {
                btnTumMusterileriSil.Enabled = false;
            }
        }
        private void gridViewMusteriler_RowStyle(object sender, RowStyleEventArgs e)
        {
            formIslem.Renklendir(sender, e);
        }

        private void gridViewMusteriler_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var id = gridViewMusteriler.GetFocusedRowCellValue("ID").ToString();
            var OdemeTarihi = Convert.ToDateTime(gridViewMusteriler.GetRowCellValue(gridViewMusteriler.FocusedRowHandle, "OdemeTarihi"));
            var musteri = db.Musterilers.Where(x => x.ID == Convert.ToInt32(id)).FirstOrDefault();
            if (msj.Guncelle() == DialogResult.Yes)
            {
                musteri.OdemeTarihi = OdemeTarihi;
                db.SubmitChanges();
                form.MusterilerListeYenileme();
            }
        }

        private void gridViewMusteriler_DoubleClick_1(object sender, EventArgs e)
        {
            MusteriDetayGetir();
        }

        private void gridViewMusteriler_ColumnFilterChanged_1(object sender, EventArgs e)
        {
            BorcHesapla();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            gridViewMusteriler.TopRowIndex = gridViewMusteriler.RowCount - 1;
            gridViewMusteriler.FocusedRowHandle = gridViewMusteriler.RowCount - 1;
        }
    }
}