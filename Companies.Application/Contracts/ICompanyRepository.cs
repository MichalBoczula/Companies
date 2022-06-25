using Companies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Contracts
{
    public interface ICompanyRepository
    {
        Task<Company> GetCompanyDetailsAsync(int companyId);
        Task<int> AddCompanyAsync(Company company);
        Task<int> DeleteCompanyByIdAsync(int companyId);
        Task<int> UpdateCompanyAsync(Company model);
        Task<bool> CheckIfCompanyExistAsync(int companyId);
    }
}
