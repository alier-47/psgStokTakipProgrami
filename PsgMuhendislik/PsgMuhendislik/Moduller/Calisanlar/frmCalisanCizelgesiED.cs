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
    public partial class frmCalisanCizelgesiED : DevExpress.XtraEditors.XtraForm
    {
        pisagorDBDataContext db = new pisagorDBDataContext();
        Mesajlar msj = new Mesajlar();
        Formlar form = new Formlar();
        public frmCalisanCizelgesiED()
        {
            InitializeComponent();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        void Kaydet()
        {
            try
            {
                CalisanCizelgesi calisanCizelgesi;
                double GunSayisi = 1;

                if (cmbGun.Text == "Yarım Gün")
                {
                    GunSayisi = 0.5;
                }
                if (lblID.Text == "")
                {
                    calisanCizelgesi = new CalisanCizelgesi();
                }
                else
                {
                    calisanCizelgesi = db.CalisanCizelgesis.First(x => x.ID == Convert.ToInt32(lblID.Text));
                }
                calisanCizelgesi.Tarih = Convert.ToDateTime(dtTarih.Value.ToShortDateString());
                calisanCizelgesi.GunSayisi = GunSayisi;
                calisanCizelgesi.Aciklama = txtAciklama.Text;
                calisanCizelgesi.CalisanID = Convert.ToInt32(CalisanID.Text);

                if (lblID.Text == "")
                {
                    db.CalisanCizelgesis.InsertOnSubmit(calisanCizelgesi);
                }
                db.SubmitChanges();
                msj.YeniKayit("İşlem Başarıyla Eklendi");
                this.Close();
                form.CalisanCizelgesi(Convert.ToInt32(calisanCizelgesi.CalisanID));
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "CalisanCizelgesiED");
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}