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

namespace PsgMuhendislik.Moduller.İdris
{
    public partial class frmIdris : DevExpress.XtraEditors.XtraForm
    {
        Formlar form = new Formlar();
        Mesajlar msj = new Mesajlar();
        public frmIdris()
        {
            InitializeComponent();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            var id = int.Parse(gridViewIdris.GetFocusedRowCellValue("ID").ToString());
            form.AlinanParaDuzenle(true, id);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            form.idrisAlinanParaEkle(true);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = int.Parse(gridViewIdris.GetFocusedRowCellValue("ID").ToString());
            form.AlinanParaSil(id);
            BorcHesapla();
        }

        public void butonStatus()
        {
            if (gridViewIdris.DataRowCount <= 0)
            {
                btnDuzenle.Enabled = false;
                btnSil.Enabled = false;
                btnSeciliSil.Enabled = false;
            }
            else
            {
                btnDuzenle.Enabled = true;
                btnSil.Enabled = true;
            }
        }

        public void BorcHesapla()
        {
            int toplam = 0;
            pisagorDBDataContext db = new pisagorDBDataContext();
            for (int i = 0; i < gridViewIdris.DataRowCount; ++i)
            {
                toplam += Convert.ToInt32(gridViewIdris.GetRowCellValue(i, "Tutar")); ;
            }
            lblToplam.Text = toplam.ToString("C");
            butonStatus();
        }

        private void btnSeciliSil_Click(object sender, EventArgs e)
        {
            pisagorDBDataContext db = new pisagorDBDataContext();
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    foreach (var item in gridViewIdris.GetSelectedRows())
                    {
                        var id = Convert.ToInt32(gridViewIdris.GetRowCellValue(item, gridViewIdris.Columns["ID"]));
                        var alinan = db.İdris.Where(x => x.ID == id).First();
                        alinan.Silme = true;
                        alinan.SilinmeTarihi = DateTime.Now;
                    }
                    db.SubmitChanges();
                    form.idrisAlinanParaListesi(true);
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        private void gridViewIdris_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gridViewIdris.SelectedRowsCount > 0)
            {
                btnSeciliSil.Enabled = true;
            }
            else
            {
                btnSeciliSil.Enabled = false;
            }
        }

        private void gridViewIdris_ColumnFilterChanged(object sender, EventArgs e)
        {
            BorcHesapla();
        }

        private void btnExcele_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Excel_Aktar(gridViewIdris, "İdris Harcama Listesi");
        }

        private void btnPDFe_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Pdf_Aktar(gridViewIdris, "İdris Harcama Listesi");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "idrisAlinanParaEkle");
            formIslem.islem(keyData, "İdris");
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void gridViewIdris_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            formIslem.Renklendir(sender, e);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            pisagorDBDataContext db = new pisagorDBDataContext();
            var result = db.İdris.Where(x => x.Tarih >= Convert.ToDateTime(dtBaslangic.Text) & x.Tarih <= Convert.ToDateTime(dtBitis.Text) & x.Silme == false).ToList();
            grdIdris.DataSource = result;
            BorcHesapla();
        }

        private void frmIdris_Load(object sender, EventArgs e)
        {
            gridViewIdris.TopRowIndex = gridViewIdris.RowCount - 1;
            gridViewIdris.FocusedRowHandle = gridViewIdris.RowCount - 1;
        }
    }
}