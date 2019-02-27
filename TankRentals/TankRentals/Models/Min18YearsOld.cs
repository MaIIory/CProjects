using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TankRentals.Models
{
    public class Min18YearsOld : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Customer customer = (Customer)validationContext.ObjectInstance;

            var age = DateTime.Now.Year - customer.BirthDate.Year;

            if ((customer.MembershipTypeId == MembershipType.Platinum || customer.MembershipTypeId == MembershipType.Mithril) && age < 18)
            {
                return new ValidationResult("You must be at least 18 to join as premium customer");
            }

            return ValidationResult.Success;
        }
    }
}
