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

namespace PsgMuhendislik.Modul_Firmalar
{
    public partial class frmFirmaED : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        Mesajlar msj = new Mesajlar();
        Formlar form = new Formlar();
        pisagorDBDataContext db = new pisagorDBDataContext();
        public frmFirmaED()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFirmaAdi.Text.Trim() == "")
            {
                msj.Hata("Firma Adı Boş Geçilemez");
            }
            else
            {
                if (lblID.Text == "")
                {
                    Kaydet();
                }
                else
                {
                    Duzenle();
                }
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Kaydet()
        {
            try
            {
                Firmalar firmalar = new Firmalar();
                firmalar.FirmaAdi = txtFirmaAdi.Text;
                firmalar.Telefon = txtTelefon.Text;
                firmalar.Tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                firmalar.Silme = false;
                firmalar.Borc = 0;
                if (db.Firmalars.Where(x => x.Silme == false).Where(a => a.FirmaAdi == txtFirmaAdi.Text).Count() > 0)
                {
                    msj.Hata("Sistemde bu firma zaten kayıtlıdır!...");
                }
                else
                {
                    db.Firmalars.InsertOnSubmit(firmalar);
                    db.SubmitChanges();
                    msj.YeniKayit(txtFirmaAdi.Text.ToString() + " Firması Başarıyla Eklendi");
                    this.Close();
                    form.FirmalarListesi(true);
                }
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        void Duzenle()
        {
            try
            {
                var id = int.Parse(lblID.Text);
                var firma = db.Firmalars.FirstOrDefault(x => x.ID == id);
                firma.FirmaAdi = txtFirmaAdi.Text;
                firma.Telefon = txtTelefon.Text;
                firma.Silme = false;
                if (db.Firmalars.Where(x => x.Silme == false).Where(a => a.FirmaAdi== txtFirmaAdi.Text).Where(x => x.ID != id).Count() > 0)
                {
                    msj.Hata("Sistemde bu firma zaten kayıtlıdır!...");
                }
                else
                {
                    if (msj.Guncelle() == DialogResult.Yes)
                    {
                        db.SubmitChanges();
                        msj.Guncelle("Firma Bilgisi Güncellenmiştir.");
                        this.Close();
                        form.FirmalarListesi(true);
                    }
                }

            }
            catch (Exception)
            {
                msj.Hata();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "FirmaED");
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}