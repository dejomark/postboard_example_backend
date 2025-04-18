using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace postboard_example_backend.Models
{
    public class User : IdentityUser
    {
        public string Bio { get; set; } = string.Empty;
    }
}