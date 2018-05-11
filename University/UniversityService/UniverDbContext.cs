using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University;

namespace UniversityService
{
    [Table("UniverDatabase")]
    public class UniverDbContext : DbContext
    {
        public UniverDbContext()
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<Admin> Admins { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Payment> Payments { get; set; }
    }
}
