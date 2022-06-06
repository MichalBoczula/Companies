using Companies.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Queries.CompanyList
{
    public class CompanyListQueryHandler : IRequestHandler<CompanyListQuery, HashSet<CompanyListVm>>
    {
        private readonly ICompanyRepository _context;

        public CompanyListQueryHandler(ICompanyRepository context)
        {
            _context = context;
        }

        public async Task<HashSet<CompanyListVm>> Handle(CompanyListQuery request, CancellationToken cancellationToken)
        {

            var query = await _context.GetCompaniesList();
            var result = new HashSet<CompanyListVm>();

            query.Select(x => x.CompanyName)
                .Distinct()
                .ToList()
                .ForEach(x => result.Add(
                    new CompanyListVm 
                    { 
                        CompanyName = x, 
                        Projects = new List<ProjectVm>() 
                    }));

            return result;
        }
    }
}
