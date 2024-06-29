using EMS.Application.DTOs.Employee;
using EMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.Interface.Repository
{
 public interface IEmployeeRepository: IRepository
    {
        List <Employee> GetEmployees();
        Employee GetById(Guid Id);
        Employee GetByDepartmentId(Guid DepartmenId);
        Task <List<EmployeeDto>> GetAllEmployeeDtos();
        Task<EmployeeDto?> LoadEmployeeDetailAsync(Guid Id);
    }
}
