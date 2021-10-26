using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.WebApp.Entities
{
    public class Office
    {
        [Key]
        public int OfficeId { get; set; }
        [Required]
        [MaxLength(500)]
        public string OfficeName { get; set; }
        [Required]
        [MaxLength(500)]
        public string Address { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
