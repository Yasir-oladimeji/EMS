using EMS.Application.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.Interface.Service
{
    public interface IEmployeeService
    {
        Task<CreateEmployeeRequestModel> Create(EmployeeDto request);
        Task <List<EmployeeDto>> LoadAllEmployee();
        Task <EmployeeDto> LoadEmployeeDetail(Guid id);
        Task<UpdateEmployeeRequestModel> Update(Guid id, EmployeeDto UpdateEmployeeDto);
        Task<CreateEmployeeRequestModel> Delete(Guid id);
        
    }
}
