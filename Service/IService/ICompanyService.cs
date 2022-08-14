using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetAllCompanies(bool isTrackChanges);
        Company GetById(Guid id, bool isTrackChanges);
        void CreateCompany(Company company);
        void UpdateCompany(Company company);
        void DeleteCompany(Company company);
    }
}
