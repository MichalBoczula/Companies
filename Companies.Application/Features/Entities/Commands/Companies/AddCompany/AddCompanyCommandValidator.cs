using Companies.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Commands.Companies.AddCompany
{
    public class AddCompanyCommandValidator : AbstractValidator<AddCompanyCommand>
    {
        public AddCompanyCommandValidator()
        {
            RuleFor(x => x.Model.Name).NotNull().NotEmpty();
            RuleFor(x => x.Model.Sector).NotNull().NotEmpty();
            RuleFor(x => x.Model.EmployeesNumber).NotNull().GreaterThan(0);
        }
    }
}
