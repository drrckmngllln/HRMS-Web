using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Settings;

namespace API.Dtos
{
    public class EmployeeToReturnDto
    {
        public int Id { get; set; }
        [Required]
        public string EmployeeNumber { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string ContractStart { get; set; }
        [Required]
        public string ContractEnd { get; set; }
        [Required]
        public string Status { get; set; }
    }
}