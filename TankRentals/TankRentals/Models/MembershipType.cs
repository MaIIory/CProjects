﻿namespace TankRentals.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float DiscountLevel { get; set; }
        public bool Contract { get; set; }
        public int ContractDurationInMonths { get; set; }
    }
}
