using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityService.BindingModels
{
    public class PaymentBindingModel
    {
        public int ClientId { get; set; }

        public decimal Sum { get; set; }
    }
}
