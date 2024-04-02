using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ColaborareDocumente.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [StringLength(100)]
        [MaxLength(100)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(100)]
        [MaxLength(100)]
        [Required]
        public string LastName { get; set; }
        public string RolName { get; set; }

        public string FullName => $"{LastName} {FirstName}";

    }

}
