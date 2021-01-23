using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using PsgMuhendislik.Fonksiyonlar;
using PsgMuhendislik.Modul_Musteriler;
using PsgMuhendislik.Modul_Firmalar;
using PsgMuhendislik.Moduller.Bilgilendirme;

namespace PsgMuhendislik
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        Formlar form = new Formlar();
        Timer t = new Timer();
        public AnaForm()
        {
            InitializeComponent();
        }


        private void AnaForm_Load(object sender, EventArgs e)
        {
            pisagorDBDataContext db = new pisagorDBDataContext();
            var data = db.Musterilers.Where(x => x.OdemeTarihi == DateTime.Today).Where(x => x.Silme == false);
            if (data.Count() > 0)
            {
                t.Interval = 1000;
                t.Tick += new EventHandler(OnTimerTicked);
                t.Start();
            }
        }
        public void OnTimerTicked(object sender, EventArgs e)
        {
            t.Stop();
            frmBilgilendirme frmBilgilendirme = new frmBilgilendirme();
            frmBilgilendirme.Name = "Bilgilendirme";
            frmBilgilendirme.ShowDialog();

        }
        public void viewChildForm(Form _form)
        {
            if (!IsFormActived(_form))
            {
                _form.MdiParent = this;

                _form.Show();
            }
        }
        private bool IsFormActived(Form form)
        {
            bool IsOpened = false;

            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        IsOpened = true;
                    }
                }
            }
            return IsOpened;
        }

        private void btnMusteriler_ItemClick(object sender, ItemClickEventArgs e)
        {
            form.MusterilerListesi(true);
        }
        private void btnFirmalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            form.FirmalarListesi(true);
        }

        
        private void btnCalisanlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            form.CalisanlarListesi(true);
        }

        private void btnGelenOdemeler_ItemClick(object sender, ItemClickEventArgs e)
        {
            form.GelenOdemeListesi(true);
        }


        private void btnHarcamalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            form.HarcamaListesi(true);
        }

        private void btnİdris_ItemClick(object sender, ItemClickEventArgs e)
        {
            form.idrisAlinanParaListesi(true);
        }

        private void btnYedekle_ItemClick(object sender, ItemClickEventArgs e)
        {
            form.Yedekleme(true);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.M:
                    form.MusterilerListesi(true);
                    break;
                case Keys.F:
                    form.FirmalarListesi(true);
                    break;
                case Keys.C:
                    form.CalisanlarListesi(true);
                    break;
                case Keys.G:
                    form.GelenOdemeListesi(true);
                    break;
                case Keys.H:
                    form.HarcamaListesi(true);
                    break;
                case Keys.I:
                    form.idrisAlinanParaListesi(true);
                    break;
                case Keys.Y:
                    form.Yedekleme(true);
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}