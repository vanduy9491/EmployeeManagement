using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.WebApp.Entities
{
    public class AppIdentityUser : IdentityUser
    {
        [MaxLength(300)]
        public string Avatar { get; set; }
    }
}
