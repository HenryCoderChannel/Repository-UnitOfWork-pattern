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
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(TechCompanyContext context) : base(context)
        {
        }

        public void CreateCompany(Company company)
        {
            Create(company);
        }

        public void DeleteCompany(Company company)
        {
            Delete(company);
        }

        public IEnumerable<Company> GetAllCompanies(bool isTrackChanges)
        {
            return FindAll(isTrackChanges);
        }

        public Company GetById(Guid id, bool isTrackChanges)
        {
            return FindByCondition(c => c.Id == id, isTrackChanges).FirstOrDefault();
        }

        public void UpdateCompany(Company company)
        {
            Update(company);
        }
    }
}
