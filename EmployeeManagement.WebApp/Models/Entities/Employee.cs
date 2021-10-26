using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.WebApp.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(500)]
        public string EmployeeName { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required]
        [MaxLength(500)]
        public string Address { get; set; }
        [Required]
        public DateTime StartedDate { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
        [Required]
        [MaxLength(500)]
        public string Skill { get; set; }
        [Required]
        public int OfficeId { get; set; }
        public Office Office { get; set; }
    }
}
