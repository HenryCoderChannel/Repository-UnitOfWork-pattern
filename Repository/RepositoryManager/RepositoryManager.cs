using Entities.Context;
using Repository.RepositoryEntity.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryManager
{
    public class RepositoryManager : IRepositoryManager
    {
        private TechCompanyContext _context;
        public RepositoryManager(TechCompanyContext context)
        {
            _context = context;
        }

        private CompanyRepository _companyRepository;
        public CompanyRepository Company
        {
            get
            {
                if (_companyRepository == null)
                    _companyRepository = new CompanyRepository(_context);
                return _companyRepository;
            }
        }

        private EmployeeRepository _employeeRepository;
        public EmployeeRepository Employee
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(_context);
                return _employeeRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
