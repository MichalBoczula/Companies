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

        public List<Company> GetCompaniesList()
        {
            string sql = @"SELECT
	                           C.CompanyId
                              ,C.CompanyName
                              ,C.CompanySector
                              ,C.CompanyEmployeesNumber
	                          ,P.ProjectId
                              ,P.ProjectName
                              ,P.ProjectDesc
                              ,P.CompanyId
                          FROM Companies AS C
                          INNER JOIN Projects AS P
	                        ON P.CompanyId = C.CompanyId;";

            using var connection = _context.CreateConnection();

            //var result2 = connection.Query<JobsOffer>(sql3);

            var result = connection.Query<Company, JobsOffer, Company>(
                sql,
                (company, offer) =>
                {
                    company.Offers ??= new List<JobsOffer>();
                    company.Offers.Add(offer);
                    return company;
                },
                splitOn: "CompanyId"
            ).ToList();
            return null;
        }
    }
}
