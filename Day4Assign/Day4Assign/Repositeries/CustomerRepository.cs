using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day4Assign.Entities;
namespace Day4Assign.Repositeries
{
    public class CustomerRepository
    {
        CustomerContext db = new CustomerContext();

        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        public Customer GetById(int Cid)
        {
            return db.Customers.SingleOrDefault(c => c.Cid == Cid);
        }

        public void CreateCustomer(Customer c)
        {
            db.Customers.Add(c);
            db.SaveChanges();
        }

        public void UpdateCustomer(Customer c)
        {
            db.Customers.Update(c);
            db.SaveChanges();
        }

        public void DeleteCustomer(Customer c)
        {
            db.Customers.Remove(c);
            db.SaveChanges();
        }
    }
}
