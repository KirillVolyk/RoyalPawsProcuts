using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RoyalPawsProcuts.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<RoyalPawsProcuts.Models.Owner> Owners { get; set; }
        public DbSet<RoyalPawsProcuts.Models.Pet> Pets { get; set; }
    }
}
