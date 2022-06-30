using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebAPIDemo.Entities
{
    public class RepositoriesContext2:DbContext
    {
        public RepositoriesContext2(DbContextOptions options) : base(options) { }
        public DbSet<Course> Courses { get; set; }
    }
}
