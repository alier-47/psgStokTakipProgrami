using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsgMuhendislik.Models.db
{
    class CalisanCizelgesi
    {
        [Key]
        public int ID{ get; set; }
        public int CalisanID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Tarih { get; set; }
        public double GunSayisi { get; set; }
        [MaxLength(250)]
        public string Aciklama { get; set; }
    }
}
