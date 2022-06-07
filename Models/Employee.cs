using System;
using System.ComponentModel.DataAnnotations;
namespace MVCAdoDemo.Models
{
    public class Employee { 
        public int EmployeeId { get; set; }  
        [Required] public string Name { get; set; } 
        [Required] public string Address { get; set; } 
        [Required] public string Designation { get; set; }
        [Required] public decimal Salary { get; set; } 
        [Required] public DateTime JoiningDate { get; set; }         
        } 
    }