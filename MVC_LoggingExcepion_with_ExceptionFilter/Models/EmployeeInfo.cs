using System.ComponentModel.DataAnnotations;

namespace MVC_LoggingExcepion_with_ExceptionFilter.Models
{
    public class EmployeeInfo
    {
        [Key]
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
    }
}