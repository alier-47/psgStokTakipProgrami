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
    public partial class frmCalisanEDevletED : DevExpress.XtraEditors.XtraForm
    {
        pisagorDBDataContext db = new pisagorDBDataContext();
        Formlar form = new Formlar();
        Mesajlar msj = new Mesajlar();
        public frmCalisanEDevletED()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
            form.CalisanEDevletYenile(Convert.ToInt32(CalisanID.Text));
        }
        void Kaydet()
        {
            try
            {
                CalisanEDevlet calisanEDevlet = new CalisanEDevlet();
                calisanEDevlet.TcNo = txtTcNo.Text;
                calisanEDevlet.Sifre = txtSifre.Text;
                calisanEDevlet.CalisanID = Convert.ToInt32(CalisanID.Text);
                db.CalisanEDevlets.InsertOnSubmit(calisanEDevlet);
                db.SubmitChanges();
                this.Close();
                form.CalisanEDevletYenile(Convert.ToInt32(CalisanID.Text));
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "CalisanEDevlet");
            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void frmCalisanEDevletED_Load(object sender, EventArgs e)
        {
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}