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
        public UpdateCompanyCommandValidator()
        {
            RuleFor(x => x.Model.Name).NotEmpty();
            RuleFor(x => x.Model.Sector).NotEmpty();
            RuleFor(x => x.Model.EmployeesNumber).NotEmpty();
        }
    }
}
