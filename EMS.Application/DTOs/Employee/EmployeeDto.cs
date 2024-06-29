using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.DTOs.Employee
{
    public class EmployeeDto
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string salary { get; set; }
        public bool IsActive { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
