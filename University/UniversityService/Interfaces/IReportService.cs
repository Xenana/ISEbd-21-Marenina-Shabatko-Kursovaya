using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityService.BindingModels;
using UniversityService.ViewModels;

namespace UniversityService.Interfaces
{
    public interface IReportService
    {
        List<PaymentLoadModel> GetPaymentLoad(ReportBindingModel model);

        void SavePaymentLoad(ReportBindingModel model);
    }
}
