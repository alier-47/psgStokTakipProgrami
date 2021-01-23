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

namespace PsgMuhendislik.Moduller.Calisanlar
{
    public partial class frmCalisanlar : DevExpress.XtraEditors.XtraForm
    {
        Formlar form = new Formlar();
        Mesajlar msj = new Mesajlar();
        pisagorDBDataContext db = new pisagorDBDataContext();
        public frmCalisanlar()
        {
            InitializeComponent();
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            form.CalisanEkle(true);
        }

        private void btnCalisanDuzenle_Click(object sender, EventArgs e)
        {
            var id = int.Parse(gridViewCalisanlar.GetFocusedRowCellValue("ID").ToString());
            form.CalisanDuzenle(true, id);
        }

        private void btnCalisanSil_Click(object sender, EventArgs e)
        {
            if (gridViewCalisanlar.DataRowCount > 0)
            {
                var id = int.Parse(gridViewCalisanlar.GetFocusedRowCellValue("ID").ToString());
                form.CalisanSil(id);
            }
        }

        private void btnMaasEkle_Click(object sender, EventArgs e)
        {
            var id = gridViewCalisanlar.GetFocusedRowCellValue("ID").ToString();
            var calisanAdi = gridViewCalisanlar.GetFocusedRowCellValue("AdSoyad").ToString();
            form.CalisanTahsilat(true, id, calisanAdi, "MaasEkle");
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            var id = gridViewCalisanlar.GetFocusedRowCellValue("ID").ToString();
            var calisanAdi = gridViewCalisanlar.GetFocusedRowCellValue("AdSoyad").ToString();
            form.CalisanTahsilat(true, id, calisanAdi);
        }

        private void btnCalisanDetayi_Click(object sender, EventArgs e)
        {
            if (gridViewCalisanlar.DataRowCount > 0)
            {
                var id = Convert.ToInt32(gridViewCalisanlar.GetFocusedRowCellValue("ID").ToString());
                form.CalisanDetay(id);
            }
        }
        private void btnTumCalisanlariSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    foreach (var item in gridViewCalisanlar.GetSelectedRows())
                    {
                        var id = Convert.ToInt32(gridViewCalisanlar.GetRowCellValue(item, gridViewCalisanlar.Columns["ID"]));
                        var calisan = db.Calisanlars.Where(x => x.ID == id).First();
                        var calisanDetay = db.CalisanlarDetays.Where(x => x.CalisanID == id).ToList();
                        calisan.Silme = true;
                        calisan.SilinmeTarihi = DateTime.Now;
                        if (calisanDetay.Count != 0)
                        {
                            foreach (var detay in calisanDetay)
                            {
                                detay.Silme = true;
                                detay.SilinmeTarihi = DateTime.Now;
                            }
                        }
                    }
                    db.SubmitChanges();
                    form.CalisanlarListesi(true);
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }



        public void BorcHesapla()
        {
            int toplamBorc = 0;
            for (int i = 0; i < gridViewCalisanlar.DataRowCount; ++i)
            {
                toplamBorc += Convert.ToInt32(gridViewCalisanlar.GetRowCellValue(i, "AlacakTutar")); ;
            }
            lblToplam.Text = toplamBorc.ToString("C");
            butonStatus();
        }

        private void gridViewCalisanlar_ColumnFilterChanged(object sender, EventArgs e)
        {
            BorcHesapla();
        }
        public void butonStatus()
        {
            if (gridViewCalisanlar.DataRowCount <= 0)
            {
                btnCalisanDuzenle.Enabled = false;
                btnCalisanSil.Enabled = false;
                btnMaasEkle.Enabled = false;
                btnCalisanDetayi.Enabled = false;
                btnOdemeYap.Enabled = false;
                btnTumCalisanlariSil.Enabled = false;
                btnCalisanCizelgesi.Enabled = false;
                btnCalisanEDevlet.Enabled = false;
            }
            else
            {
                btnCalisanDuzenle.Enabled = true;
                btnCalisanSil.Enabled = true;
                btnMaasEkle.Enabled = true;
                btnCalisanDetayi.Enabled = true;
                btnOdemeYap.Enabled = true;
                btnCalisanCizelgesi.Enabled = true;
                btnCalisanEDevlet.Enabled = true;
            }
        }

        private void gridViewCalisanlar_SelectionChanged_1(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gridViewCalisanlar.SelectedRowsCount > 0)
            {
                btnTumCalisanlariSil.Enabled = true;
            }
            else
            {
                btnTumCalisanlariSil.Enabled = false;
            }
        }

        private void btnCalisanCizelgesi_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(gridViewCalisanlar.GetFocusedRowCellValue("ID").ToString());
            form.CalisanCizelgesi(id);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "CalisanEkle");
            formIslem.islem(keyData, "Calisanlar");
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void gridViewCalisanlar_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            formIslem.Renklendir(sender, e);
        }

        private void gridViewCalisanlar_DoubleClick_1(object sender, EventArgs e)
        {
            if (gridViewCalisanlar.DataRowCount > 0)
            {
                var id = Convert.ToInt32(gridViewCalisanlar.GetFocusedRowCellValue("ID").ToString());
                form.CalisanDetay(id);
            }
        }

        private void btnCalisanEDevlet_Click(object sender, EventArgs e)
        {
            if (gridViewCalisanlar.DataRowCount > 0)
            {
                var id = Convert.ToInt32(gridViewCalisanlar.GetFocusedRowCellValue("ID").ToString());
                form.CalisanEDevlet(id);
            }
        }

        private void frmCalisanlar_Load(object sender, EventArgs e)
        {
            gridViewCalisanlar.TopRowIndex = gridViewCalisanlar.RowCount - 1;
            gridViewCalisanlar.FocusedRowHandle = gridViewCalisanlar.RowCount - 1;
        }
    }
}