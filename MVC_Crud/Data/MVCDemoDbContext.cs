using Microsoft.EntityFrameworkCore;
using MVC_Crud.Models.Domains;

namespace MVC_Crud.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        // put the domain model "Employee" inside
        public DbSet<Employee> Employees { get; set; }

    }
}
