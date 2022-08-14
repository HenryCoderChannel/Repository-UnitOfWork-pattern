using Entities.Context;
using Entities.Models;
using Repository.RepositoryBase;
using Repository.RepositoryEntity.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryEntity.Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(TechCompanyContext context) : base(context)
        {

        }

        public void CreateEmployee(Guid companyId, Employee employee)
        {
            employee.CompanyId = companyId;
            Create(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }

        public IEnumerable<Employee> GetAllEmployees(bool isTrackChanges)
        {
            return FindAll(isTrackChanges);
        }

        public Employee GetById(Guid id, bool isTrackChanges)
        {
            return FindByCondition(e => e.Id == id, isTrackChanges).FirstOrDefault();
        }

        public void UpdateEmployee(Employee employee)
        {
            Update(employee);
        }
    }
}
