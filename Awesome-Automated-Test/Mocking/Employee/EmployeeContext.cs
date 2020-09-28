using Microsoft.EntityFrameworkCore;

namespace Awesome_Automated_Test.Mocking.Employee
{
    public class EmployeeContext
    {
        public DbSet<Employee> Employees { get; set; }

        public void SaveChanges()
        {
        }
    }
}