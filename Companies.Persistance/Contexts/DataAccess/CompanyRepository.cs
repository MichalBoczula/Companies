using Companies.Application.Contracts;
using Companies.Domain.Entities;
using Companies.Persistance.Contexts.Abstract;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Persistance.Contexts.DataAccess
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly IDapperContext _context;

        public CompanyRepository(IDapperContext context)
        {
            _context = context;
        }

        public async Task<Company> GetCompanyDetailsAsync(int companyId)
        {
            using var connection = _context.CreateConnection();

            var sql = @"SELECT * FROM Companies AS C WHERE C.Id= @companyId;
                        SELECT * FROM CompanyDetails AS CD WHERE CD.CompanyId = @companyId;
                        SELECT * FROM Projects AS P WHERE P.CompanyId = @companyId;";

            var query = await connection.QueryMultipleAsync(sql, new { companyId });

            var company = query.Read<Company>().FirstOrDefault();
            var companyDetails = query.Read<CompanyDetail>().FirstOrDefault();
            var projects = query.Read<Project>().ToList();

            company.CompanyDetails = companyDetails;
            company.Projects= projects;

            return company;
        }

        public async Task<int> AddCompanyAsync(Company company)
        {
            using var connection = _context.CreateConnection();

            var sql = $@"INSERT INTO [dbo].[Companies]
                               ([Name]
                               ,[Sector]
                               ,[EmployeesNumber])
		                       OUTPUT INSERTED.[Id]
                         VALUES
                               (@name
                               ,@sector
                               ,@empNumber);";

            var result = 
                await connection.QueryAsync<int>(
                    sql, 
                new { name = company.Name, sector = company.Sector, empNumber = company.EmployeesNumber });

            return result.FirstOrDefault();
        }
    }
}
