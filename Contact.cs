namespace CRMSystem.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public string ContactName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Position { get; set; }
    }
}
