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

namespace PsgMuhendislik.Moduller.Harcamalar
{
    public partial class frmHarcamaED : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        Mesajlar msj = new Mesajlar();
        pisagorDBDataContext db = new pisagorDBDataContext();
        Formlar form = new Formlar();
        public frmHarcamaED()
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
            Fonksiyonlar.Harcamalar harcamalar;
            try
            {
                if (lblID.Text == "")
                    harcamalar = new Fonksiyonlar.Harcamalar();
                else
                    harcamalar = db.Harcamalars.Where(x => x.ID == Convert.ToInt32(lblID.Text)).First();
                harcamalar.Aciklama = txtAciklama.Text;
                harcamalar.Tarih = Convert.ToDateTime(dtTarih.Value.ToShortDateString());
                harcamalar.Silme = false;
                harcamalar.Tutar = Convert.ToDecimal(txtTutar.Text);
                if (lblID.Text == "")
                {
                    db.Harcamalars.InsertOnSubmit(harcamalar);
                }
                db.SubmitChanges();
                msj.YeniKayit("Kayıt Başarıyla Yapıldı");
                this.Close();
                form.HarcamaListesi(true);
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "HarcamaED");
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}