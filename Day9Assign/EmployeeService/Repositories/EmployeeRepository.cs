using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Repositories
{
    public class EmployeeRepository
    {
        private readonly employeedbContext repo ;

        public EmployeeRepository(employeedbContext context)
        {
            repo = context;
        }

        public IEnumerable<Employees> getAll()
        {
            return repo.Employees.ToList();
        }

        public Employees getById(string eid)
        {
            return repo.Employees.Find(eid);
        }

        public void addEmployee(Employees e)
        {
            repo.Employees.Add(e);
            repo.SaveChanges();
        }

        public void updateEmployee(Employees e)
        {
            repo.Employees.Update(e);
            repo.SaveChanges();
        }

        public void deleteEmployee(string eid)
        {
            Employees e = repo.Employees.Find(eid);

            repo.Employees.Remove(e);
            repo.SaveChanges();
        }

    }
}
