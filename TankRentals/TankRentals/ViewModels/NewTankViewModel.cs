using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TankRentals.Models;

namespace TankRentals.ViewModels
{
    public class NewTankViewModel
    {
        public string FormName { get; set; }
        public IEnumerable<TankType> TankType { get; set; }
        public Tank Tank { get; set; }
    }
}
