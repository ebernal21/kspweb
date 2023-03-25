using KSPExam.Models;
using Microsoft.EntityFrameworkCore;

namespace KSPExam.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }
    }
}
