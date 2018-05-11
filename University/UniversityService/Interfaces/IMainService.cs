using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityService.BindingModels;
using UniversityService.ViewModels;

namespace UniversityService.Interfaces
{
    public interface IMainService
    {
        List<OrderViewModel> GetList();

        void CreateOrder(OrderBindingModel model);

        void PartialPayment(OrderBindingModel model);

        void PayOrder(OrderBindingModel model);
    }
}
