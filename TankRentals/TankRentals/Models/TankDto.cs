using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TankRentals.Models
{
    public class TankDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Model attribute must be filled")]
        [MaxLength(15, ErrorMessage = "Max length is 15 characters")]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Tank Type")]
        public int TankTypeId { get; set; }

        public TankType TankType { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Number in Garage")]
        public short NumberInGarage { get; set; }
    }
}
