using Microsoft.AspNetCore.Identity;

namespace RoyalPawsProcuts.Models
{
    public class Owner
    {
        // Searched it up, apperently since it ends with "Id", it is automatically considered a primary key by Entity Framework, so no need to add [Key] attribute?
        public int OwnerId { get; set; } // Primary key
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // Navigation: One Owner to Many Pets
        public List<Pets> Pet { get; set; } = new();
    }
}
