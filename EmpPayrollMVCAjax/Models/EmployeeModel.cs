using System;
using System.ComponentModel.DataAnnotations;

namespace EmpPayrollMVCAjax.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Emp_Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string Profileimage { get; set; }
        public DateTime StartDate { get; set; }
        public double Salary { get; set; }
        public string Notes { get; set; }
    }
}
