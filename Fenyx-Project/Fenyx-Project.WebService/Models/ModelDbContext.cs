using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fenyx_Project.WebService.Models
{
    public class ModelDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Address> Address { get; set; }

        public ModelDbContext()
            : base("name=ModelDbContext")
        {
        }
    }
}