using AutoMapper;
using Companies.Application.Contracts;
using Companies.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Commands.Companies.AddCompany
{
    public class AddCompanyCommandHandler : IRequestHandler<AddCompanyCommand, AddCompanyVm>
    {
        private readonly ICompanyRepository _context;
        private readonly IMapper _mapper;

        public AddCompanyCommandHandler(ICompanyRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<AddCompanyVm> Handle(AddCompanyCommand request, CancellationToken cancellationToken)
        {
            var company = _mapper.Map<Company>(request.Model);

            var result = await _context.AddCompanyAsync(company);

            return new AddCompanyVm { CreatedCompanyId = result };
        }
    }
}
