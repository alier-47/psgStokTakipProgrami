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
using DevExpress.XtraGrid.Views.Grid;
using PsgMuhendislik.Fonksiyonlar;
using System.Drawing.Printing;

namespace PsgMuhendislik.Moduller.GelenOdemeler
{
    public partial class frmGelenOdemeler : DevExpress.XtraEditors.XtraForm
    {

        Mesajlar msj = new Mesajlar();
        Formlar form = new Formlar();
        public frmGelenOdemeler()
        {
            InitializeComponent();
        }

        private void frmGelenOdemeler_Load(object sender, EventArgs e)
        {
            gridViewGelenOdemeler.TopRowIndex = gridViewGelenOdemeler.RowCount - 1;
            gridViewGelenOdemeler.FocusedRowHandle = gridViewGelenOdemeler.RowCount - 1; BorcHesapla();
        }

        private void gridViewGelenOdemeler_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if(gridViewGelenOdemeler.SelectedRowsCount > 0)
            {
                btnSeciliOdemeleriSil.Enabled = true;
            }
            else
            {
                btnSeciliOdemeleriSil.Enabled = false;
            }
        }

        private void btnTumCalisanlariSil_Click(object sender, EventArgs e)
        {
            pisagorDBDataContext db = new pisagorDBDataContext();
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    foreach (var item in gridViewGelenOdemeler.GetSelectedRows())
                    {
                        var id = Convert.ToInt32(gridViewGelenOdemeler.GetRowCellValue(item, gridViewGelenOdemeler.Columns["ID"]));
                        var odeme = db.GelenOdemelers.Where(x => x.ID == id).First();
                        odeme.Silme = true;
                        odeme.SilinmeTarihi = DateTime.Now;
                       
                    }
                    db.SubmitChanges();
                    form.GelenOdemeListesi(true);
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            form.GelenOdemeEkle(true);
        }

        private void btnOdemeDuzenle_Click(object sender, EventArgs e)
        {
            var id = int.Parse(gridViewGelenOdemeler.GetFocusedRowCellValue("ID").ToString());
            form.GelenOdemeDuzenle(true, id);
        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            var id = int.Parse(gridViewGelenOdemeler.GetFocusedRowCellValue("ID").ToString());
            form.GelenOdemeSil(id);
            BorcHesapla();
        }
        public void BorcHesapla()
        {
            int toplamAlinanOdemeler = 0;
            pisagorDBDataContext db = new pisagorDBDataContext();
           for (int i = 0; i < gridViewGelenOdemeler.DataRowCount; ++i)
            {
                toplamAlinanOdemeler += Convert.ToInt32(gridViewGelenOdemeler.GetRowCellValue(i, "Tutar")); ;
            }
            lblGelenOdemeToplami.Text = toplamAlinanOdemeler.ToString("C");
            butonStatus();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            pisagorDBDataContext db = new pisagorDBDataContext();
            var result = db.GelenOdemelers.Where(x => x.Tarih >= Convert.ToDateTime(Convert.ToDateTime(dtBaslangic.Text).ToShortDateString()) & x.Tarih <= Convert.ToDateTime(Convert.ToDateTime(dtBitis.Text).ToShortDateString()) & x.Silme == false).ToList();
            grdGelenOdemeler.DataSource = result;
            BorcHesapla();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            form.GelenOdemeListesi(true);
        }
        public void butonStatus()
        {
            if (gridViewGelenOdemeler.DataRowCount <= 0)
            {
                btnOdemeDuzenle.Enabled = false;
                btnOdemeSil.Enabled = false;
                btnSeciliOdemeleriSil.Enabled = false;
            }
            else
            {
                btnOdemeDuzenle.Enabled = true;
                btnOdemeSil.Enabled = true;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "GelenOdemeEkle");
            formIslem.islem(keyData, "GelenOdemeler");
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnPDFe_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Pdf_Aktar(gridViewGelenOdemeler, "Gelen Ödemeler Listesi");
        }

        private void btnExcele_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Excel_Aktar(gridViewGelenOdemeler, "Gelen Ödemeler Listesi");
        }

        private void grdGelenOdemeler_Click(object sender, EventArgs e)
        {

        }

        private void gridViewGelenOdemeler_RowStyle(object sender, RowStyleEventArgs e)
        {
            formIslem.Renklendir(sender, e);
        }

        private void gridViewGelenOdemeler_ColumnFilterChanged(object sender, EventArgs e)
        {
            BorcHesapla();
        }
    }
}