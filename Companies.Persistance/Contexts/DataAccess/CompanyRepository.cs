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

        public async Task<List<Company>> GetCompaniesList()
        {
            //string sql = @"SELECT
	           //                C.CompanyId
            //                  ,C.CompanyName
	           //               ,P.ProjectId
            //                  ,P.ProjectName
            //                  ,P.CompanyId
            //              FROM Companies AS C
            //              INNER JOIN Projects AS P
	           //             ON P.CompanyId = C.CompanyId;";

            string sql = @"SELECT
	                           C.*
	                          ,P.*
                          FROM Companies AS C
                          INNER JOIN Projects AS P
	                        ON P.CompanyId = C.CompanyId;";

            using var connection = _context.CreateConnection();

             var result = await connection.QueryAsync<Company, Project, Company>(
                sql,
                (company, project) =>
                {
                    company.Projects ??= new List<Project>();
                    company.Projects.Add(project);
                    return company;
                },
                splitOn: "CompanyId"
            );

            return result.ToList();
        }
    }
}
