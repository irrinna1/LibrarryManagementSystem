using Microsoft.AspNetCore.Identity;

namespace LibraryManagementSystem.Data.Models
{
    public class User : IdentityUser
    {
        public virtual Reader Reader { get; set; }
    }
}
