using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsgMuhendislik.Models.db
{
    class GelenOdemeler
    {
        [Key]
        public int ID { get; set; }
        public int gelenOdemeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Tutar { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SilinmeTarihi { get; set; }
        public bool Silme { get; set; }
    }
}
