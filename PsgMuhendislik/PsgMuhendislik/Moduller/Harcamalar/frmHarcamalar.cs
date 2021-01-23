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

namespace PsgMuhendislik.Moduller.Harcamalar
{
    public partial class frmHarcamalar : DevExpress.XtraEditors.XtraForm
    {
        Formlar form = new Formlar();
        Mesajlar msj = new Mesajlar();
        public frmHarcamalar()
        {
            InitializeComponent();
        }
        public void BorcHesapla()
        {
            int toplamHarcamalar = 0;
            pisagorDBDataContext db = new pisagorDBDataContext();
            for (int i = 0; i < gridViewHarcamalar.DataRowCount; ++i)
            {
                toplamHarcamalar += Convert.ToInt32(gridViewHarcamalar.GetRowCellValue(i, "Tutar")); ;
            }
            lblHarcamalar.Text = toplamHarcamalar.ToString("C");
            butonStatus();
        }

        private void btnHarcamaSil_Click(object sender, EventArgs e)
        {
            var id = int.Parse(gridViewHarcamalar.GetFocusedRowCellValue("ID").ToString());
            form.HarcamaSil(id);
            BorcHesapla();
        }

        private void btnHarcamaDuzenle_Click(object sender, EventArgs e)
        {
            var id = int.Parse(gridViewHarcamalar.GetFocusedRowCellValue("ID").ToString());
            form.HarcamaDuzenle(true, id);
        }

        private void btnSeciliHarcamalariSil_Click(object sender, EventArgs e)
        {
            pisagorDBDataContext db = new pisagorDBDataContext();
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    foreach (var item in gridViewHarcamalar.GetSelectedRows())
                    {
                        var id = Convert.ToInt32(gridViewHarcamalar.GetRowCellValue(item, gridViewHarcamalar.Columns["ID"]));
                        var harcama = db.Harcamalars.Where(x => x.ID == id).First();
                        harcama.Silme = true;
                        harcama.SilinmeTarihi = DateTime.Now;
                    }
                        db.SubmitChanges();
                        form.HarcamaListesi(true);
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        private void gridViewHarcamalar_ColumnFilterChanged(object sender, EventArgs e)
        {
            BorcHesapla();
        }

        private void btnHarcamaEkle_Click(object sender, EventArgs e)
        {
            form.HarcamaEkle(true);
        }

        public void butonStatus()
        {
            if (gridViewHarcamalar.DataRowCount <= 0)
            {
                btnHarcamaDuzenle.Enabled = false;
                btnHarcamaSil.Enabled = false;
                btnSeciliHarcamalariSil.Enabled = false;
            }
            else
            {
                btnHarcamaDuzenle.Enabled = true;
                btnHarcamaSil.Enabled = true;
            }
        }

        private void gridViewHarcamalar_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gridViewHarcamalar.SelectedRowsCount > 0)
            {
                btnSeciliHarcamalariSil.Enabled = true;
            }
            else
            {
                btnSeciliHarcamalariSil.Enabled = false;
            }
        }



        private void btnAra_Click(object sender, EventArgs e)
        {
            pisagorDBDataContext db = new pisagorDBDataContext();
            var result = db.Harcamalars.Where(x => x.Tarih >= Convert.ToDateTime(Convert.ToDateTime(dtBaslangic.Text).ToShortDateString()) & x.Tarih <= Convert.ToDateTime(Convert.ToDateTime(dtBitis.Text).ToShortDateString()) & x.Silme == false).ToList();
            grdHarcamalar.DataSource = result;
            BorcHesapla();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            form.GelenOdemeListesi(true);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "HarcamaEkle");
            formIslem.islem(keyData, "Harcamalar");
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnPDFe_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Pdf_Aktar(gridViewHarcamalar, "Harcamalar Listesi");
        }

        private void btnExcele_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Excel_Aktar(gridViewHarcamalar, "Harcamalar Listesi");
        }

        private void gridViewHarcamalar_RowStyle(object sender, RowStyleEventArgs e)
        {
            formIslem.Renklendir(sender, e);
        }

        private void frmHarcamalar_Load(object sender, EventArgs e)
        {
            gridViewHarcamalar.TopRowIndex = gridViewHarcamalar.RowCount - 1;
            gridViewHarcamalar.FocusedRowHandle = gridViewHarcamalar.RowCount - 1;
        }
    }
}