using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebAPIDemo.Entities
{
    public class RepositoriesContext1 : DbContext
    {
        public RepositoriesContext1(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

    }
}
