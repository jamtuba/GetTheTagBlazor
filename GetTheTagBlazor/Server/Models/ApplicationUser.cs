using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetTheTagBlazor.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        public override string Email { get; set; }
        
        [DataType(DataType.Text)]
        public string ProfilePicture { get; set; }
    }
}
