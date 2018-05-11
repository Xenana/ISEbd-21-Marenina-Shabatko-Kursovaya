using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityModel;
using UniversityService.BindingModels;
using UniversityService.Interfaces;
using UniversityService.ViewModels;

namespace UniversityService.Implementations
{
    public class MainServiceList : IMainService
    {
        private UniverDbContext context;

        public MainServiceList(UniverDbContext context)
        {
            this.context = context;
        }

        public List<OrderViewModel> GetList()
        {
            List<OrderViewModel> result = context.Orders
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    ClientId = rec.ClientId,
                    CourseId = rec.CourseId,
                    DateCreate = SqlFunctions.DateName("dd", rec.DateCreate) + " " +
                                SqlFunctions.DateName("mm", rec.DateCreate) + " " +
                                SqlFunctions.DateName("yyyy", rec.DateCreate),
                    Status = rec.Status.ToString(),
                    Count = rec.Count,
                    Sum = rec.Sum,
                    //CourseName = rec.Course.CourseName,
                    ClientFIO = rec.Client.ClientFIO,

                })
                .ToList();
            return result;
        }

        public void CreateOrder(OrderBindingModel model)
        {
            context.Orders.Add(new Order
            {
                ClientId = model.ClientId,
                DateCreate = DateTime.Now,
                Count = model.Count,
                Sum = model.Sum,
                Status = PaymentState.Не_оплачено
            });
            context.SaveChanges();
        }

        public void PayOrder(OrderBindingModel model)
        {
            context.Orders.Add(new Order
            {
                Sum = model.Sum,
                Status = PaymentState.Оплачено
            });
            context.SaveChanges();
        }

        public void PartialPayment(OrderBindingModel model)
        {
            context.Orders.Add(new Order
            {
                BalanceSum = model.BalanceSum,
                Sum = model.Sum,
                Status = PaymentState.Оплачено_частично
            });
            context.SaveChanges();
        }
    }
}
