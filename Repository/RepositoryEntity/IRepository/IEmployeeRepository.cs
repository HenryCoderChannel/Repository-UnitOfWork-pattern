using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryEntity.IRepository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees(bool isTrackChanges);
        Employee GetById(Guid id, bool isTrackChanges);
        void CreateEmployee(Guid companyId, Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
