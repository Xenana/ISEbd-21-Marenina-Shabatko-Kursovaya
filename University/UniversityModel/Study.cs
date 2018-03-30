using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace UniversityModel
{
    public class Study
    {

        public int Id { get; set; }

        public int IdCourse { get; set; } // идентификатор курсов 

        public int IdPayment { get; set; } // идентификатор оплаты 


        [ForeignKey("StudyId")]
        public virtual List<Order> Orders { get; set; }

        [ForeignKey("StudyId")]
        public virtual List<CourseStudy> CourseStudy { get; set; }
    }
}
