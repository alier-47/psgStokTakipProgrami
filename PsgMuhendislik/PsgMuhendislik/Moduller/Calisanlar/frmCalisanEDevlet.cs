using DevExpress.XtraEditors;
using PsgMuhendislik.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsgMuhendislik.Moduller.Calisanlar
{
    public partial class frmCalisanEDevlet : DevExpress.XtraEditors.XtraForm
    {
        Formlar form = new Formlar();
        public frmCalisanEDevlet()
        {
            InitializeComponent();
        }
        private void frmCalisanEDevlet_Load(object sender, EventArgs e)
        {
            ButtonStatus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            form.CalisanEDevletEkle(Convert.ToInt32(lblCalisanID.Text));
            ButtonStatus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gridViewCalisanEDevlet.DataRowCount > 0)
            {
                var id = int.Parse(gridViewCalisanEDevlet.GetFocusedRowCellValue("ID").ToString());
                form.CalisanEDevletSil(id);
                ButtonStatus();
            }
        }

        private void ButtonStatus()
        {
            if (gridViewCalisanEDevlet.DataRowCount == 1)
            {
                btnEkle.Enabled = false;
                btnSil.Enabled = true;
            }
            else
            {
                btnEkle.Enabled = true;
                btnSil.Enabled = false;
            }
        }

        private void gridViewCalisanEDevlet_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            formIslem.Renklendir(sender, e);
        }
    }
}