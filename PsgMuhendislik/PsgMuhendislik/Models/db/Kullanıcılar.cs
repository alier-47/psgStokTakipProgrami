using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsgMuhendislik.Models.db
{
    class Kullanıcılar
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string KullaniciAdi { get; set; }
        [MaxLength(50)]
        public string Sifre { get; set; }
    }
}
