using AutoMapper;
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
    public class CompanyListQueryHandler : IRequestHandler<CompanyDetailsQuery, CompanyDetailsVm>
    {
        private readonly ICompanyRepository _context;
        private readonly IMapper _mapper;

        public CompanyListQueryHandler(ICompanyRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CompanyDetailsVm> Handle(CompanyDetailsQuery request, CancellationToken cancellationToken)
        {
            var query = await _context.GetCompanyDetails(request.CompanyId);
            var result = _mapper.Map<CompanyDetailsVm>(query);
            return result;
        }
    }
}
