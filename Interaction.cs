using System;

namespace CRMSystem.Models
{
    public class Interaction
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int UserId { get; set; }

        public string Notes { get; set; }

        public string InteractionType { get; set; }

        public DateTime FollowUpDate { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
