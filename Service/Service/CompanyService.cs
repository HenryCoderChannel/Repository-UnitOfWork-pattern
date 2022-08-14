using Entities.Models;
using Repository.RepositoryManager;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class CompanyService : ICompanyService
    {
        private IRepositoryManager _repository;
        public CompanyService(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public void CreateCompany(Company company)
        {
            _repository.Company.CreateCompany(company);
            _repository.Save();
        }

        public void DeleteCompany(Company company)
        {
            _repository.Company.DeleteCompany(company);
            _repository.Save();
        }

        public IEnumerable<Company> GetAllCompanies(bool isTrackChanges)
        {
            return _repository.Company.GetAllCompanies(isTrackChanges);
        }

        public Company GetById(Guid id, bool isTrackChanges)
        {
            return _repository.Company.GetById(id, isTrackChanges);
        }

        public void UpdateCompany(Company company)
        {
            _repository.Company.Update(company);
            _repository.Save();
        }
    }
}
