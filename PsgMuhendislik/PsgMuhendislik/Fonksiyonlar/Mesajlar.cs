using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsgMuhendislik.Fonksiyonlar
{
    class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili Kayıt Güncellenecektir\n Güncelleme İşlemini Onaylıyor Musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili Kayıt Kalıcı Olarak Silinecektir\n Silme İşlemini Onaylıyor Musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Guncelle(string mesaj)
        {
            MessageBox.Show(mesaj, "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Hata()
        {
            MessageBox.Show("İşlem Sırasın Hata Meydana Geldi \n Lütfen İşleminizi Tekrarlayınız...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void Hata(string mesaj)
        {
            MessageBox.Show(mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
