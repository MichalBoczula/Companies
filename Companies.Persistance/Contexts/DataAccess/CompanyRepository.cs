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

        public async Task<int> DeleteCompanyByIdAsync(int companyId)
        {
            using var connection = _context.CreateConnection();

            var sql = $@"delete from Companies
                        OUTPUT DELETED.[Id]
                        where Id = @companyId";

            var result =
                await connection.QueryAsync<int>(
                    sql,
                new { companyId });

            return result.FirstOrDefault();
        }

        public async Task<int> UpdateCompanyAsync(Company model)
        {
            using var connection = _context.CreateConnection();

            var sql = $@"UPDATE C
                       SET C.Name = @name
                          ,C.Sector = @sector
                          ,C.EmployeesNumber = @empNumber
                       FROM Companies AS C WITH(NOLOCK)
                       WHERE Id = @companyId;";

            var result =
                await connection.ExecuteAsync(
                    sql,
                new { companyId = model.Id ,name = model.Name, sector = model.Sector, empNumber = model.EmployeesNumber });

            return result;
        }

        public async Task<bool> CheckIfCompanyExistAsync(int companyId)
        {
            using var connection = _context.CreateConnection();

            var sql = $@"SELECT 1 FROM Companies AS C WITH(NOLOCK)
                        WHERE C.Id = @companyId;";

            var result =
                await connection.QueryAsync<bool>(
                    sql,
                new { companyId });

            return result.FirstOrDefault();
        }
    }
}
