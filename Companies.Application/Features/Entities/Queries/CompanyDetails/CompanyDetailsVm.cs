using AutoMapper;
using Companies.Application.Mapping;
using Companies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Queries.CompanyDetails
{
    public class CompanyDetailsVm : IMapFrom<Company>
    {
        public string Name { get; set; }
        public string Sector { get; set; }
        public int EmployeesNumber { get; set; }
        public CompanyDetailsDto CompanyDetailsDto { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Company, CompanyDetailsVm>()
                .ForMember(x => x.CompanyDetailsDto, opt => opt.MapFrom(x => x.CompanyDetails));
        }
    }
}
