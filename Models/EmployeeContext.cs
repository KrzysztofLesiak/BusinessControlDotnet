using Microsoft.EntityFrameworkCore;

namespace BusinessControlDotnet.Models;

public class EmployeeContext(DbContextOptions<EmployeeContext> options) : DbContext(options)
{
    public DbSet<Employee> Employee { get; set; } = null!;
}