using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsgMuhendislik.Models.db
{
    class CalisanEDevlet
    {
        [Key]
        public int ID { get; set; }
        public int CalisanID { get; set; }
        [MaxLength(11)]
        public string TcNo { get; set; }
        [MaxLength(50)]
        public string Sifre { get; set; }
    }
}
