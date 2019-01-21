using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TankRentals.Models;

namespace TankRentals.ViewModels
{
    public class RandomTankViewModel
    {
        public Customer Customer { get; set; }
        public Tank Tank { get; set; }
    }
}
