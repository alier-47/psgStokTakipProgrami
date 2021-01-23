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
using DevExpress.XtraGrid.Views.Grid;

namespace PsgMuhendislik.Modul_Firmalar
{
    public partial class frmFirmalar : DevExpress.XtraEditors.XtraForm
    {
        Formlar form = new Formlar();
        Mesajlar msj = new Mesajlar();
        pisagorDBDataContext db = new pisagorDBDataContext();
        public frmFirmalar()
        {
            InitializeComponent();
        }

        private void frmFirmalar_Load(object sender, EventArgs e)
        {

        }

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            form.FirmaEkle(true);
        }

        private void btnFirmaDuzenle_Click(object sender, EventArgs e)
        {
            var id = int.Parse(gridViewFirmalar.GetFocusedRowCellValue("ID").ToString());
            form.FirmaDuzenle(true, id);
        }

        private void btnBorcEkle_Click(object sender, EventArgs e)
        {
            var id = gridViewFirmalar.GetFocusedRowCellValue("ID").ToString();
            var firmaAdi = gridViewFirmalar.GetFocusedRowCellValue("FirmaAdi").ToString();
            form.FirmaTahsilat(true, id, firmaAdi);
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            var id = gridViewFirmalar.GetFocusedRowCellValue("ID").ToString();
            var firmaAdi = gridViewFirmalar.GetFocusedRowCellValue("FirmaAdi").ToString();
            form.FirmaTahsilat(true, id, firmaAdi, "OdemeYap");
        }

        private void btnFirmaDetayi_Click(object sender, EventArgs e)
        {
            if (gridViewFirmalar.DataRowCount > 0)
            {
                var id = Convert.ToInt32(gridViewFirmalar.GetFocusedRowCellValue("ID").ToString());
                form.FirmaDetay(id);
            }
        }

        private void btnFirmaSil_Click(object sender, EventArgs e)
        {
            var id = int.Parse(gridViewFirmalar.GetFocusedRowCellValue("ID").ToString());
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    db = new pisagorDBDataContext();
                    var firma = db.Firmalars.First(x => x.ID == id);
                    var firmaDetay = db.FirmalarDetays.Where(a => a.FirmaID == id).ToList();
                    foreach (var item in firmaDetay)
                    {
                        item.Silme = true;
                        //item.SilinmeTarihi = DateTime.Now;
                    }
                    firma.Silme = true;
                    firma.SilinmeTarihi = DateTime.Now;
                    db.SubmitChanges();
                    form.FirmalarListesi(true);
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        private void btnTumFirmalariSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    foreach (var item in gridViewFirmalar.GetSelectedRows())
                    {
                        var id = Convert.ToInt32(gridViewFirmalar.GetRowCellValue(item, gridViewFirmalar.Columns["ID"]));
                        var firma = db.Firmalars.Where(x => x.ID == id).First();
                        var firmaDetay = db.FirmalarDetays.Where(x => x.FirmaID == id).ToList();
                        firma.Silme = true;
                        firma.SilinmeTarihi = DateTime.Now;
                        if (firmaDetay.Count != 0)
                        {
                            foreach (var detay in firmaDetay)
                            {
                                detay.Silme = true;
                                detay.SilinmeTarihi = DateTime.Now;
                            }
                        }
                    }
                    db.SubmitChanges();
                    form.FirmalarListesi(true);
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        private void gridViewFirmalar_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewFirmalar.DataRowCount > 0)
            {
                var id = Convert.ToInt32(gridViewFirmalar.GetFocusedRowCellValue("ID").ToString());
                form.FirmaDetay(id);
            }
        }

        private void gridViewFirmalar_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gridViewFirmalar.SelectedRowsCount > 0)
            {
                btnTumFirmalariSil.Enabled = true;
            }
            else
            {
                btnTumFirmalariSil.Enabled = false;
            }
        }
        public void BorcHesapla()
        {
            int borc = 0;
            pisagorDBDataContext db = new pisagorDBDataContext();
            for (int i = 0; i < gridViewFirmalar.DataRowCount; ++i)
            {
                borc += Convert.ToInt32(gridViewFirmalar.GetRowCellValue(i, "Borc")); ;
            }
            lblBorc.Text = borc.ToString("C");
            butonStatus();
        }

        private void gridViewFirmalar_ColumnFilterChanged(object sender, EventArgs e)
        {
            BorcHesapla();
        }

        public void butonStatus()
        {
            if (gridViewFirmalar.DataRowCount <= 0)
            {
                btnBorcEkle.Enabled = false;
                btnFirmaDetayi.Enabled = false;
                btnFirmaDuzenle.Enabled = false;
                btnFirmaSil.Enabled = false;
                btnOdemeYap.Enabled = false;
                btnTumFirmalariSil.Enabled = false;
            }
            else
            {
                btnBorcEkle.Enabled = true;
                btnFirmaDetayi.Enabled = true;
                btnFirmaDuzenle.Enabled = true;
                btnFirmaSil.Enabled = true;
                btnOdemeYap.Enabled = true;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "FirmaEkle");
            formIslem.islem(keyData, "Firmalar");
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void gridViewFirmalar_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            formIslem.Renklendir(sender, e);
        }

        private void frmFirmalar_Load_1(object sender, EventArgs e)
        {
            gridViewFirmalar.TopRowIndex = gridViewFirmalar.RowCount - 1;
            gridViewFirmalar.FocusedRowHandle = gridViewFirmalar.RowCount - 1;
        }
    }
}