using Microsoft.EntityFrameworkCore;

namespace EmpPayrollMVCAjax.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        { }
        public DbSet<EmployeeModel> EmpAjax { get; set; }
    }
}
