using Microsoft.AspNetCore.Identity;

namespace RoyalPawsProcuts.Models
{
    public class Owner
    {
        public int OwnerId { get; set; } // Primary key
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // Navigation: One Owner to Many Pets
        public List<Pets> Pets { get; set; } = new();
    }
}
