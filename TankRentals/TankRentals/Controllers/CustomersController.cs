using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TankRentals.Models;
using TankRentals.ViewModels;

namespace TankRentals.Controllers
{
    public class CustomersController : Controller
    {
        private readonly TanksContext _tanksDbContext;

        public CustomersController(TanksContext tanksDbContext)
        {
            _tanksDbContext = tanksDbContext;
        }

        public IActionResult Index() => View();

        [Route("Customers")]
        public IActionResult ListCustomers()
        {
            var customersList = _tanksDbContext.Customers.Include(c => c.MembershipType).ToList<Customer>();
            return View("CustomersTable", customersList);
        }

        [Route("Customers/Details/{id}")]
        public IActionResult Details(int id)
        {
            var customer = _tanksDbContext.Customers.FirstOrDefault(c => c.Id == id);
            return View("Details", customer);
        }

        [Route("Customers/New")]
        public IActionResult New()
        {
            NewCustomerViewModel newCustomer = new NewCustomerViewModel
            {
                FormName = "Add Customer",
                Customer = new Customer(),
                MembershipTypes = _tanksDbContext.MembershipTypes.ToList<MembershipType>()
            };

            return View("CustomerForm", newCustomer);
        }

        [Route("Customers/Edit/{id}")]
        public IActionResult Edit(int id)
        {

            var customerViewModel = new NewCustomerViewModel
            {
                FormName = "Edit Customer",
                Customer = _tanksDbContext.Customers.First<Customer>(c => c.Id == id),
                MembershipTypes = _tanksDbContext.MembershipTypes.ToList<MembershipType>()
            };

            return View("CustomerForm", customerViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Customer customer, string command)
        {
            if (command.Equals("cancel"))
            {
                return RedirectToAction("Index");
            }
            else if (command.Equals("delete"))
            {
                RemoveCustomer(customer);
                return RedirectToAction("Index");
            }
            else
            {
                //AddOrEdit(customer);
                if (!ModelState.IsValid)
                {
                    var customerViewModel = new NewCustomerViewModel
                    {
                        FormName = "Add Customer",
                        Customer = customer,
                        MembershipTypes = _tanksDbContext.MembershipTypes.ToList<MembershipType>()
                    };

                    return View("CustomerForm", customerViewModel);
                }

                if (customer.Id == 0)
                {
                    _tanksDbContext.Customers.Add(customer);
                }
                else
                {
                    var customerToEdit = _tanksDbContext.Customers.First<Customer>(c => c.Id == customer.Id);
                    {
                        customerToEdit.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
                        customerToEdit.MembershipTypeId = customer.MembershipTypeId;
                        customerToEdit.Name = customer.Name;
                        customerToEdit.BirthDate = customer.BirthDate;
                    }
                }
                _tanksDbContext.SaveChanges();

                return RedirectToAction("ListCustomers", "Customers");
            }
        }

        public void RemoveCustomer(Customer customer)
        {
            var customerToRemove = _tanksDbContext.Customers.SingleOrDefault<Customer>(c => c.Id == customer.Id);

            if (customer != null)
            {
                _tanksDbContext.Customers.Remove(customerToRemove);
                _tanksDbContext.SaveChanges();
            }
        }
    }
}