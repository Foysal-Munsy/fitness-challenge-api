using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService
    {
        public List<Employee> Get()
        {
            // to get the data from EmployeeRepo
            // EmployeeRepo Extract the data
            return EmployeeRepo.Get();
        }

        //logic implementation for test
        public List<Employee> Get10()
        {
            var data = from e in EmployeeRepo.Get()
                       where e.Id < 11
                       select e;
            return data.ToList();
        }
        public Employee Get(int id)
        {
            return EmployeeRepo.Get(id);
        }
        public bool Create(Employee employee)
        {
            return EmployeeRepo.Create(employee);
        }
        public bool Update(Employee employee)
        {
            return EmployeeRepo.Update(employee);
        }
        public bool Delete(int id)
        {
            return EmployeeRepo.Delete(id);
        }
    }
}
