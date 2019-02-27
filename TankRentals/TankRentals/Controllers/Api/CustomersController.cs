using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TankRentals.Models;

namespace TankRentals.Controllers.Api
{

    /* Right now, our web API exposes the database entities to the client.The client receives data that maps directly to your database tables.
     * However, that's not always a good idea. Sometimes you want to change the shape of the data that you send to client. 
     * TanksController is implemented to handle Data Transfer Objects. */

    [Route("api/[controller]")] // /api/customers/...
    [ApiController] //This attribute indicates that the controller responds to web API request
    public class CustomersController : ControllerBase
    {
        private readonly TanksContext _tanksDbContext;

        //Dependency Injection of DB context
        public CustomersController(TanksContext tanksDbContext)
        {
            _tanksDbContext = tanksDbContext;
        }

        //GET /api/customers/list
        [HttpGet("list")]
        /*ASP.NET Core automatically serializes the object to JSON and writes the JSON into the body of the response message.
          * The response code for this return type is 200, assuming there are no unhandled exceptions.
          * Unhandled exceptions are translated into 5xx errors.
          * If no item matches the requested ID, the method returns a 404 NotFound error code.
          * Otherwise, the method returns 200 with a JSON response body. Returning item results in an HTTP 200 response. */
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await _tanksDbContext.Customers.Include(c => c.MembershipType).ToListAsync();
        }

        //GET /api/customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _tanksDbContext.Customers.Include(c => c.MembershipType).FirstOrDefaultAsync<Customer>(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        //POST /api/customer
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            _tanksDbContext.Customers.Add(customer);
            await _tanksDbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer); //produces http 201 code 
        }

        //PUT /api/customers/1
        [HttpPut("{id}")]
        public async Task<ActionResult> PutCustomer(int id, Customer customer)
        {
            var dbCustomer = await _tanksDbContext.Customers.FirstOrDefaultAsync(c => c.Id == id);

            if (dbCustomer == null)
                return NotFound();

            dbCustomer.BirthDate = customer.BirthDate;
            dbCustomer.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            dbCustomer.MembershipTypeId = customer.MembershipTypeId;
            dbCustomer.Name = customer.Name;

            _tanksDbContext.Update(dbCustomer);
            await _tanksDbContext.SaveChangesAsync();

            return NoContent();
        }

        //DELETE /api/customer/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _tanksDbContext.Customers.Include(c => c.MembershipType).FirstOrDefaultAsync<Customer>(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            _tanksDbContext.Customers.Remove(customer);
            await _tanksDbContext.SaveChangesAsync();

            return NoContent();
        }

    }
}