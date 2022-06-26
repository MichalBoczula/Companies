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
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, UpdateCompanyVm>
    {
        private readonly ICompanyRepository _context;
        private readonly IMapper _mapper;

        public UpdateCompanyCommandHandler(ICompanyRepository context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UpdateCompanyVm> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<Company>(request.Model);
            model.Id = request.CompanyId;
            var validator = new UpdateCompanyCommandBusinessValidator(_context);
            var validation = await validator.ValidateAsync(model, cancellationToken);
            if (validation.Errors.Any())
            {
                return new UpdateCompanyVm()
                {
                    CompanyId = 0,
                    Errors = validation.Errors
                };
            }
            var result = await _context.UpdateCompanyAsync(model);
            return new UpdateCompanyVm()
            {
                CompanyId = result,
                Errors = null
            };
        }
    }
}
