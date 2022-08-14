using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryEntity.IRepository
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool isTrackChanges);
        Company GetById(Guid id, bool isTrackChanges);
        void Create(Company company);
        void Update(Company company);
        void Delete(Company company);
    }
}
