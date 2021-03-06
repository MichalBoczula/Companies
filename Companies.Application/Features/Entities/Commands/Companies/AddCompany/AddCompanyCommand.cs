using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Commands.Companies.AddCompany
{
    public class AddCompanyCommand : IRequest<AddCompanyVm>
    {
        public AddCompanyExternal Model{ get; set; }
    }
}
