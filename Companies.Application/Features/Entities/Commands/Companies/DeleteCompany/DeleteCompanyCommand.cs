using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Commands.Companies.DeleteCompany
{
    public class DeleteCompanyCommand : IRequest<DeleteCompanyVm>
    {
        public int CompanyId { get; set; }
    }
}
