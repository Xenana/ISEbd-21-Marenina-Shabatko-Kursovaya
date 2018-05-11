using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityService.BindingModels
{
    public class CourseBindingModel
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public int Price { get; set; }
    }
}
