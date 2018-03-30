﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityModel
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        public string ClientFIO { get; set; }

        [Required]
        public string Password  { get; set; }

        [Required]
        public string Login { get; set; }

        [ForeignKey("ClientId")]
        public virtual List<Order> Orders { get; set; }

    }
}
