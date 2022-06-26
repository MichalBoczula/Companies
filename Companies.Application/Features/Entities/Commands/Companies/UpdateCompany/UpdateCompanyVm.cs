using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Commands.Companies.UpdateCompany
{
    public class UpdateCompanyVm
    {
        public int CompanyId { get; set; }
        public List<ValidationFailure> Errors { get; set; }
    }
}
