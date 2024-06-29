using EMS.Application.DTOs.Employee;
using EMS.Application.Interface.Repository;
using EMS.Domain.Entities;
using EMS.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace EMS.Persistence.Repository
{
    public class
        EmployeeRepository : RepositoryAsync, IEmployeeRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public EmployeeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _applicationDbContext = dbContext;
        }

        public Employee GetByDepartmentId(Guid Departmentid)
        {
            return _applicationDbContext.Employees.Where(s => s.DepartmentId == Departmentid).FirstOrDefault()!;
        }

        public Employee GetById(Guid id)
        {
            return _applicationDbContext.Employees.Where(s => s.Id == id).FirstOrDefault()!;
        }

        public async Task<List<EmployeeDto>> GetAllEmployeeDtos()
        {
            return await _applicationDbContext.Employees.Select(x => new EmployeeDto
            {
              FirstName= x.FirstName, 
              Surname = x.Surname,
              DepartmentId = x.DepartmentId,
            }).ToListAsync();
        }

        public List<Employee> GetEmployees()
        {
           return _applicationDbContext.Employees.ToList();
        }

        public async Task<EmployeeDto?> LoadEmployeeDetailAsync(Guid id) =>
            await _applicationDbContext.Employees
            .Where(x => x.Id == id)
            .Select(x => new EmployeeDto
            {
                Surname = x.Surname,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Gender = x.Gender,
                salary = x.salary,
                IsActive = x.IsActive,
                DepartmentId = x.DepartmentId,
            }).FirstOrDefaultAsync();
    }
}
