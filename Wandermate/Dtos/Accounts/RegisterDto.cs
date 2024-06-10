using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Wandermate.Dtos.Accounts
{
    public class RegisterDto
    {

        [Required]
        public string? Username {get; set;} 

        [Required]
        [EmailAddress]

        public String? Email {get; set;} 
        [Required]

        public string? Password{get; set;}

        
    }
}