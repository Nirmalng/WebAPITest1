using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPITest1.Model;

namespace WebAPITest1.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> Option) : base(Option)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
