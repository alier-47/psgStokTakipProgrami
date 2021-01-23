using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsgMuhendislik.Models.db
{
    class Musteriler
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(150)]
        public string AdSoyad { get; set; }
        [MaxLength(50)]
        public string Telefon { get; set; }
        [MaxLength(150)]
        public string BinaAdi { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Borc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Tarih { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime OdemeTarihi { get; set; }
        [MaxLength(50)]
        public string OdemeSekli { get; set; }
        public string Not { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SilinmeTarihi { get; set; }
        public bool Silme { get; set; }
    }
}
