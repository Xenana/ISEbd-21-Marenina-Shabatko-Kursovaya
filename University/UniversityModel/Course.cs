using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModel
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string CourseName { get; set; } 

        public int PriceCourse { get; set; } 

        [ForeignKey("CourseId")]
        public virtual List<Order> Orders { get; set; }
    }
}
