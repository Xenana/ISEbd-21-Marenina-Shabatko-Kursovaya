using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityModel
{
   public  class Payment
    {
        public int Id { get; set; } // идентификатор 

        [Required]
        public int value { get; set; } // значение 

        public int IdStudy { get; set; } // идентификатор_обучения 

        public int IdClient { get; set; } // идентификатор_студента 
    }
}
