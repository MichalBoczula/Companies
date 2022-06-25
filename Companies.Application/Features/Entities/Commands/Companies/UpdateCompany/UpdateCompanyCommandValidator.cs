using Companies.Application.Contracts;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Commands.Companies.UpdateCompany
{
    public class UpdateCompanyCommandValidator : AbstractValidator<UpdateCompanyCommand>
    {
        private readonly ICompanyRepository _context;

        public UpdateCompanyCommandValidator(ICompanyRepository context)
        {
            _context = context;

            RuleFor(x => x.Model.Name).NotEmpty();
            RuleFor(x => x.Model.Sector).NotEmpty();
            RuleFor(x => x.Model.EmployeesNumber).NotEmpty();
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
