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
    public class CompanyListQueryHandler : IRequestHandler<CompanyDetailsQuery, CompanyDetailsVm>
    {
        private readonly ICompanyRepository _context;

        public CompanyListQueryHandler(ICompanyRepository context)
        {
            _context = context;
        }
        
        public async Task<CompanyDetailsVm> Handle(CompanyDetailsQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.GetCompanyDetails(1);
             /// mapper

            return null;
        }
    }
}
