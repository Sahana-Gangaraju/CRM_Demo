using System;

namespace CRMSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string Company { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedBy { get; set; }
    }
}
