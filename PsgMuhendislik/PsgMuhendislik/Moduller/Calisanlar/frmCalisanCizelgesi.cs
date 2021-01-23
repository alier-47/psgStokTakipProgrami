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
    public partial class frmCalisanCizelgesi : DevExpress.XtraEditors.XtraForm
    {
        Formlar form = new Formlar();
        public frmCalisanCizelgesi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            form.CalisanCizelgesiEkle(Convert.ToInt32(lblCalisanID.Text));
        }

        public void GunHesapla()
        {
            double toplamGunSayisi = 0;
            for (int i = 0; i < gridViewCalisanCizelgesi.DataRowCount; ++i)
            {

                toplamGunSayisi += Convert.ToDouble(gridViewCalisanCizelgesi.GetRowCellValue(i, "GunSayisi"));
            }
            lblEksikGun.Text = toplamGunSayisi.ToString();
            butonStatus();
        }

        public void butonStatus()
        {
            if (gridViewCalisanCizelgesi.DataRowCount <= 0)
            {
                btnDuzenle.Enabled = false;
                btnSecilileriSil.Enabled = false;
                btnSil.Enabled = false;
            }
            else
            {
                btnDuzenle.Enabled = true;
                btnSecilileriSil.Enabled = false;
                btnSil.Enabled = true;
            }
        }

        private void gridViewCalisanCizelgesi_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gridViewCalisanCizelgesi.SelectedRowsCount > 0)
            {
                btnSecilileriSil.Enabled = true;
            }
            else
            {
                btnSecilileriSil.Enabled = false;
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            var id = int.Parse(gridViewCalisanCizelgesi.GetFocusedRowCellValue("ID").ToString());
            form.CalisanCizelgesiDuzenle(id);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = int.Parse(gridViewCalisanCizelgesi.GetFocusedRowCellValue("ID").ToString());
            form.CalisanCizelgesiSil(id);
        }

        private void btnSecilileriSil_Click(object sender, EventArgs e)
        {
            pisagorDBDataContext db = new pisagorDBDataContext();
            Mesajlar msj = new Mesajlar();
            try
            {
                if (msj.Sil() == DialogResult.Yes)
                {
                    foreach (var item in gridViewCalisanCizelgesi.GetSelectedRows())
                    {
                        var id = Convert.ToInt32(gridViewCalisanCizelgesi.GetRowCellValue(item, gridViewCalisanCizelgesi.Columns["ID"]));
                        var calisanlarCizelgesi = db.CalisanCizelgesis.FirstOrDefault(x => x.ID == id);
                        db.CalisanCizelgesis.DeleteOnSubmit(calisanlarCizelgesi);
                        db.SubmitChanges();
                    }
                    form.CalisanCizelgesi(Convert.ToInt32(lblCalisanID.Text));
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            form.CalisanCizelgesi(Convert.ToInt32(lblCalisanID.Text));
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            pisagorDBDataContext db = new pisagorDBDataContext();
            var result = from x in db.CalisanCizelgesis where x.Tarih >= Convert.ToDateTime(dtBaslangic.Text) && x.Tarih <= Convert.ToDateTime(dtBitis.Text).AddDays(1) select x;
            grdCalisanCizelgesi.DataSource = result;
            GunHesapla();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            formIslem.islem(keyData, "CalisanCizelgesi");
            if (keyData == Keys.F5)
            {
                form.CalisanCizelgesiEkle(Convert.ToInt32(lblCalisanID.Text));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnExcele_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Excel_Aktar(gridViewCalisanCizelgesi, lblCalisanAdi.Text + " Eksik Gün Sayımı");
        }

        private void btnPDFe_Aktar_Click(object sender, EventArgs e)
        {
            formIslem.Pdf_Aktar(gridViewCalisanCizelgesi, lblCalisanAdi.Text + " Eksik Gün Sayımı");
        }

        private void gridViewCalisanCizelgesi_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            formIslem.Renklendir(sender, e);
        }

        private void frmCalisanCizelgesi_Load(object sender, EventArgs e)
        {
            gridViewCalisanCizelgesi.TopRowIndex = gridViewCalisanCizelgesi.RowCount - 1;
            gridViewCalisanCizelgesi.FocusedRowHandle = gridViewCalisanCizelgesi.RowCount - 1;
        }
    }
}