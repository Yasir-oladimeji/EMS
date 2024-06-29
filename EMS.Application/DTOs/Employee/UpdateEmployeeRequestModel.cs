using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.DTOs.Employee
{
    public class UpdateEmployeeRequestModel : EmployeeRequestModel
    {

        public static readonly CreateEmployeeRequestModel NotPermitted = new CreateEmployeeRequestModel(
            false,
           "",
            "You don't have sufficient permissions to perform this action.");



        public UpdateEmployeeRequestModel(bool status,
                                  string code,
                                  string message,
                                  Guid? id = (Guid?)null,
                                  string field = "",
                                  int count = 0) : base(status,
                                                           code,
                                                           message,
                                                           field,
                                                           count)
        {
            Id = id;
        }
        public Guid? Id { get; }
    }
}
