using Companies.Application.Contracts;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Commands.Companies.DeleteCompany
{
    public class DeleteCompanyCommandValidator : AbstractValidator<DeleteCompanyCommand>
    {
        private readonly ICompanyRepository _context;

        public DeleteCompanyCommandValidator(ICompanyRepository context)
        {
            _context = context;

            When(x => _context.CheckIfCompanyExistAsync(x.CompanyId).Result == false, () =>
            {
                RuleFor(x => x.CompanyId).Custom((companyId, context) =>
                {
                    context.AddFailure(new ValidationFailure("companyId",
                                                             $"Company identify by {companyId} does not exist",
                                                             $"{companyId}"));
                });
            });
        } 
    }
}
