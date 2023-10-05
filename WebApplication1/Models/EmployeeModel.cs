using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        [DataType(DataType.Date)]
        public DateTime Hire_date { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get;set; }
        [DataType(DataType.Date)]
        public DateTime Joining_date { get; set; }
        public int salary  { get; set; }

    }
}
