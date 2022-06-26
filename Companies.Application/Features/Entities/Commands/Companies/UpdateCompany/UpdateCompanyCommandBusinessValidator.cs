using Companies.Application.Contracts;
using Companies.Domain.Entities;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Commands.Companies.UpdateCompany
{
    public class UpdateCompanyCommandBusinessValidator : AbstractValidator<Company>
    {
        private readonly ICompanyRepository _context;

        public UpdateCompanyCommandBusinessValidator(ICompanyRepository context)
        {
            _context = context;

            WhenAsync(async (x, ct) => !await _context.CheckIfCompanyExistAsync(x.Id), () =>
            {
                RuleFor(x => x.Id).Custom((companyId, context) =>
                {
                    context.AddFailure(new ValidationFailure("companyId",
                                                                $"Company identify by {companyId} does not exist",
                                                                $"{companyId}"));
                });
            });
        }
    }
}
