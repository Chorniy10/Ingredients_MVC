using Microsoft.AspNetCore.Identity;

namespace PetProject_MVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}
