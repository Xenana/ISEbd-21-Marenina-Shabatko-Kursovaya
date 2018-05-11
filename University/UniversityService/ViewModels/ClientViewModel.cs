using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityService.ViewModels
{
    public class ClientViewModel
    {
        public int Id { get; set; }

        public string ClientFIO { get; set; }

        public string ClientLogin { get; set; }

        public decimal Bonus { get; set; }

        public decimal Fine { get; set; }

        public string Locking { get; set; }
    }
}
