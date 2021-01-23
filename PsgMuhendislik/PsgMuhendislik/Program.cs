using PsgMuhendislik.Fonksiyonlar;
using PsgMuhendislik.Moduller.Bilgilendirme;
using PsgMuhendislik.Moduller.Giris;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PsgMuhendislik
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            pisagorDBDataContext db = new pisagorDBDataContext();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (db.Kullanıcılars.Count() > 0)
                Application.Run(new frmGiris());
            else
                Application.Run(new frmKayit());

        }
    }
}
