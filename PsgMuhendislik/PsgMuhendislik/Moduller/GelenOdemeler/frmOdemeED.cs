using PsgMuhendislik.Fonksiyonlar;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PsgMuhendislik.Moduller.GelenOdemeler
{
    public partial class frmOdemeED : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        Mesajlar msj = new Mesajlar();
        pisagorDBDataContext db = new pisagorDBDataContext();
        Formlar form = new Formlar();
        public frmOdemeED()
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
            Fonksiyonlar.GelenOdemeler gelenOdemeler;
            try
            {
                if (lblID.Text == "")
                    gelenOdemeler = new Fonksiyonlar.GelenOdemeler();
                else
                    gelenOdemeler = db.GelenOdemelers.Where(x => x.ID == Convert.ToInt32(lblID.Text)).First();
                gelenOdemeler.Aciklama = txtAciklama.Text;
                gelenOdemeler.Tarih = Convert.ToDateTime(dtTarih.Value.ToShortDateString());
                gelenOdemeler.Silme = false;
                gelenOdemeler.Tutar = Convert.ToDecimal(txtTutar.Text);
                if (lblID.Text == "")
                {
                    db.GelenOdemelers.InsertOnSubmit(gelenOdemeler);
                }
                db.SubmitChanges();
                msj.YeniKayit("Kayıt Başarıyla Yapıldı");
                this.Close();
                form.GelenOdemeListeYenileme();
                //form.GelenOdemeListesi(true);
            }
            catch (Exception)
            {
                msj.Hata();
            }
        }

        private void frmOdemeED_Load(object sender, EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "GelenOdemeED");
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}