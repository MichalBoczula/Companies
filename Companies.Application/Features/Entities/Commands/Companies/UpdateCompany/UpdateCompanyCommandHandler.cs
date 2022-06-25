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

namespace Companies.Application.Features.Entities.Commands.Companies.UpdateCompany
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, int>
    {
        private readonly ICompanyRepository _context;
        private readonly IMapper _mapper;

        public UpdateCompanyCommandHandler(ICompanyRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<Company>(request.Model);
            model.Id = request.CompanyId;
            var result = await _context.UpdateCompanyAsync(model);
            return result;
        }
    }
}
