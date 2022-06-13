using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Queries.CompanyList
{
    public class CompanyDetailsQuery : IRequest<CompanyDetailsVm>
    {
        public string CompanyId { get; set; }
    }
}
