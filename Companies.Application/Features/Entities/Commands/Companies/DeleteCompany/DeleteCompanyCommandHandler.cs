using AutoMapper;
using Companies.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Commands.Companies.DeleteCompany
{
    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand, DeleteCompanyVm>
    {
        private readonly ICompanyRepository _context;

        public DeleteCompanyCommandHandler(ICompanyRepository context)
        {
            _context = context;
        }

        public async Task<DeleteCompanyVm> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            var result = await _context.DeleteCompanyByIdAsync(request.CompanyId);

            return new DeleteCompanyVm { CompanyId = result };
        }
    }
}
