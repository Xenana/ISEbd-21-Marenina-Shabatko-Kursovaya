using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using UniversityModel;

namespace UniversityService
{
    [Table("UniversityDatabase")]
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext()
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
                Configuration.LazyLoadingEnabled = false;
                var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            }

            public virtual DbSet<Client> Clients { get; set; }

            public virtual DbSet<Course> Courses { get; set; }

            public virtual DbSet<Study> Studyes { get; set; }

            public virtual DbSet<Payment> Payments { get; set; }

            public virtual DbSet<CourseStudy> CourseStudyes { get; set; }
       
    }
}
