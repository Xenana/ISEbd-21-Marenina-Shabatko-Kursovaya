using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModel
{
    public class Order
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int ClientFIO { get; set; }

        public int CourseId { get; set; }

        public int CourseName { get; set; }

        public int Count { get; set; }

        public decimal Sum { get; set; }

        public decimal BalanceSum { get; set; } 

        public PaymentState Status { get; set; }

        public DateTime DateCreate { get; set; }

        //  public DateTime? DateImplement { get; set; } //

        public virtual Client Client { get; set; }

        public virtual Course Course { get; set; }
    }
}
