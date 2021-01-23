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
using MaterialSkin;
using PsgMuhendislik.Fonksiyonlar;

namespace PsgMuhendislik.Moduller.Bilgilendirme
{
    public partial class frmBilgilendirme : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        public frmBilgilendirme()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green900, Primary.Green900, Accent.LightBlue200, TextShade.WHITE);
        }

        private void frmBilgilendirme_Load(object sender, EventArgs e)
        {
            pisagorDBDataContext db = new pisagorDBDataContext();
            var data = db.Musterilers.Where(x=>x.OdemeTarihi == DateTime.Today).Where(x => x.Silme == false);
            foreach (var item in data)
            {
                ListViewItem listViewItem = new ListViewItem(item.AdSoyad);
                listViewItem.SubItems.Add(item.Not);
                listViewItem.SubItems.Add(item.Borc.ToString());
                listViewItem.SubItems.Add(item.Telefon);
                materialListView1.Items.Add(listViewItem);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            formIslem.islem(keyData, "Bilgilendirme");
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}