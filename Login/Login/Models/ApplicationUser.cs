﻿using Microsoft.AspNetCore.Identity;
namespace Login.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}