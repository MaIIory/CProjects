using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TankRentals.Models;

namespace TankRentals.Controllers
{
    public class CustomersController : Controller
    {
        private readonly TanksContext _tanksDbContext;

        public CustomersController(TanksContext tanksDbContext)
        {
            _tanksDbContext = tanksDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Customers")]
        public IActionResult ListCustomers()
        {
            var customersList = _tanksDbContext.Customers.Include(c => c.MembershipType).ToList<Customer>();
            return View("CustomersTable",customersList);
        }

        [Route("Customers/Details/{id}")]
        public IActionResult Details(int id)
        {
            var customer = _tanksDbContext.Customers.FirstOrDefault(c => c.Id == id);
            return View("Details",customer);
        }
    }
}