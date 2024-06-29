using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Domain.Entities
{
    public class Address : BaseEntity
    {
        public int PhoneNumber { get; set; }
        public string address { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
