using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsgMuhendislik.Models.db
{
    class MusterilerDetay
    {
        [Key]
        public int ID { get; set; }
        public int MusteriID { get; set; }
        public int OdemeId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal EklenenTutar { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal OdenenTutar { get; set; }
        [MaxLength(50)]
        public string OdemeSekli { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Tarih { get; set; }
        [MaxLength(150)]
        public string Aciklama { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SilinmeTarihi { get; set; }
        public bool Silme { get; set; }

    }
}
