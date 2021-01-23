using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsgMuhendislik.Models.db
{
    class Calisanlar
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string AdSoyad { get; set; }
        [MaxLength(50)]
        public string Telefon { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime IsBaslangicTarihi { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal AlacakTutar { get; set; }
        [MaxLength(50)]
        public string CalismaSekli { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SilinmeTarihi { get; set; }
        public int MaasGirisiDurum { get; set; }
        public bool Silme { get; set; }
    }
}
