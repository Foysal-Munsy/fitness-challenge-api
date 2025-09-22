using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class EmployeeRepo
    {
        static AppDbContext dbContext;
        public EmployeeRepo() 
        {
            dbContext = new AppDbContext();
        }
        public static List<Employee> Get()
        {
            return dbContext.Employees.ToList();
        }
        public static Employee Get(int id) 
        { 
            return dbContext.Employees.Find(id);
        }
        public static bool Create(Employee employee) 
        { 
            dbContext.Employees.Add(employee);
            return dbContext.SaveChanges() > 0;
        }
        public static bool Update(Employee employee) 
        { 
            var exemp = dbContext.Employees.Find(employee.Id);
            dbContext.Entry(exemp).CurrentValues.SetValues(employee);
            return dbContext.SaveChanges() > 0;
        }
        public static bool Delete(int id)
        {
            var exemp = Get(id);
            dbContext.Employees.Remove(exemp);
            return dbContext.SaveChanges() > 0;
        }

    }
}
