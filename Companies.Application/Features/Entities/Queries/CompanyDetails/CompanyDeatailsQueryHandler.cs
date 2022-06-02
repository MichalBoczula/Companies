using Companies.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Queries.CompanyDetails
{
    public class CompanyDeatailsQueryHandler : IRequestHandler<CompanyDeatailsQuery, CompanyDetailsVm>
    {
        private readonly ICompanyRepository _context;

        public CompanyDeatailsQueryHandler(ICompanyRepository context)
        {
            _context = context;
        }

        public Task<CompanyDetailsVm> Handle(CompanyDeatailsQuery request, CancellationToken cancellationToken)
        {
            var result = _context.GetCompaniesList();
            return null;
        }
    }
}
