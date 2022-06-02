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
            //string sql = @"select * from Companies as c
            //            inner join Projects as p
            //            on p.CompanyId = c.Id
            //            inner join JobsOffers as jo
            //            on jo.CompanyId = c.Id ";

            string sql = @"select 
	                        c.Id
	                        ,c.Name	
	                        ,c.Sector
	                        ,c.EmployeesNumber	
	                        ,p.Name	
	                        ,p.[Desc]
	                        ,p.CompanyId
                        from Companies as c
	                        inner join Projects as p
		                        on p.CompanyId = c.Id";

            using var connection = _context.CreateConnection();
            var orderDetails = connection.Query<Company, Project, Company>(
                sql, 
                (companies, project) =>
                {
                    companies.Projects = new List<Project>();
                    companies.Projects.Add(project);
                    return companies;
                },
                splitOn: "CompanyId"
            ).ToList();
            return orderDetails;
        }
    }
}
