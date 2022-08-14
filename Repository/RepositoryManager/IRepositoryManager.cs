using Repository.RepositoryEntity.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryManager
{
    public interface IRepositoryManager
    {
        
        void Save();

        /// <summary>
        /// These are Property inside Interface (Not a method). 
        /// I just define GET method for them
        /// </summary>
        CompanyRepository Company { get; }
        EmployeeRepository Employee { get; } 
    }
}
