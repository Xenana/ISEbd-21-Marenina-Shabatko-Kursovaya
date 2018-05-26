using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModel
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        public string ClientFIO { get; set; }

        [Required]
        public string ClientPassword { get; set; }

        [Required]
        public string ClientLogin { get; set; }

        public string ClientMail { get; set; }

        public decimal Bonus { get; set; }

        public decimal Fine { get; set; } 

        public string Locking { get; set; } 

        [ForeignKey("ClientId")]
        public virtual List<Order> Orders { get; set; }
    }
}
