using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TankRentals.Models;

namespace TankRentals.ViewModels
{
    public class NewCustomerViewModel
    {
        public string FormName { get; set; }
        public IEnumerable<MembershipType> MembershipTypes{ get; set; }
        public Customer Customer { get; set; }
    }
}
