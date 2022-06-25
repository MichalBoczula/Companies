using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Commands.Companies.UpdateCompany
{
    public class UpdateCompanyCommand : IRequest<int>
    {
        public int CompanyId { get; set; }
        public UpdateCompanyExternal Model { get; set; }
    }
}
