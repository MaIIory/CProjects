using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TankRentals.Models
{

    public class Tank
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public TankType TankType { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public short NumberInGarage { get; set; }
    }
}
