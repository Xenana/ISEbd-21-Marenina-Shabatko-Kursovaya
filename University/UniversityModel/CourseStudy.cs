using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModel
{
    public class CourseStudy
    {
        public int Id { get; set; }

        public int CourseId { get; set; } // идентификатор курсов 

        public int StudyId { get; set; }  // идентификатор обучения 

        public virtual Course Course { get; set; } // ?? 
        public virtual Study Study { get; set; } // ???
    }
}
