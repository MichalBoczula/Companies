using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Queries.CompanyDetails
{
    public class CompanyDeatailsQuery : IRequest<CompanyDetailsVm>
    {
        public int Id { get; set; }
    }
}
