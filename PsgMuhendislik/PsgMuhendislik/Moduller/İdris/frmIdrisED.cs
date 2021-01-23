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

namespace PsgMuhendislik.Moduller.İdris
{
    public partial class frmIdrisED : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        Mesajlar msj = new Mesajlar();
        pisagorDBDataContext db = new pisagorDBDataContext();
        Formlar form = new Formlar();
        public frmIdrisED()
        {
            InitializeComponent();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtTutar.Text.Trim() == "")
            {
                msj.Hata("Tutar Boş Geçilemez");
            }
            else
            {
                Kaydet();
            }
        }

        void Kaydet()
        {
            Fonksiyonlar.İdri idris;
            try
            {
                if (lblID.Text == "")
                    idris = new İdri();
                else
                    idris = db.İdris.Where(x => x.ID == Convert.ToInt32(lblID.Text)).First();
                idris.Aciklama = txtAciklama.Text;
                idris.Tarih = Convert.ToDateTime(dtTarih.Value.ToShortDateString());
                idris.Silme = false;
                idris.Tutar = Convert.ToDecimal(txtTutar.Text);
                if (lblID.Text == "")
                {
                    db.İdris.InsertOnSubmit(idris);
                }
                db.SubmitChanges();
                msj.YeniKayit("Kayıt Başarıyla Yapıldı");
                this.Close();
                form.idrisAlinanParaListesi(true);
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "idrisED");
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}