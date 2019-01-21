using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TankRentals.Models
{
    public class Customer
    {
        public int Id { get; set; }
        //Data annotations
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId;
    }
}
