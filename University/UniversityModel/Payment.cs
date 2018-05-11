using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModel
{
    public class Payment
    {
        public int Id { get; set; }  

        [Required]
        public int Value { get; set; }  
    }
}
