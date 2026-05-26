namespace RoyalPawsProcuts.Models
{
    public class Pets
    {
        public int PetId { get; set; } // Primary key
        public string PetName { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public int OwnerId { get; set; } // Foreign key to Owner

        // Navigation: Many Pets to One Owner
        public Owner? Owner { get; set; }
    }
}
