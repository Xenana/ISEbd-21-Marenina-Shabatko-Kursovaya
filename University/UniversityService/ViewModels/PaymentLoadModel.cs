using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityService.ViewModels
{
    public class PaymentLoadModel
    {
        public string ClientFIO { get; set; }

        public string CourseName { get; set; }

        public decimal Sum { get; set; }

        public string Status { get; set; }
    }
}
