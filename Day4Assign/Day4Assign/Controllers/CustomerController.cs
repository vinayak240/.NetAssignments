using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day4Assign.Repositeries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Day4Assign.Entities;
namespace Day4Assign.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepository repo = new CustomerRepository();
        // GET: CustomerController
        public ActionResult Index()
        {
            List<Customer> list = repo.GetAll();
            return View(list);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            Console.WriteLine(id);
            Customer c = repo.GetById(id);
            return View(c);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer c)
        {
            try
            {
                repo.CreateCustomer(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            Customer c = repo.GetById(id);

            return View(c);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer c)
        {
            try
            {
                repo.UpdateCustomer(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            Customer c = repo.GetById(id);
            return View(c);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Customer c)
        {
            try
            {
                repo.DeleteCustomer(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
