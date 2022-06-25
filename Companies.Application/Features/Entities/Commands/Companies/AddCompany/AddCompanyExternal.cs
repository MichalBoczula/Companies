using AutoMapper;
using Companies.Application.Mapping;
using Companies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Commands.Companies.AddCompany
{
    public class AddCompanyExternal : IMapFrom<Company>
    {
        public string Name { get; set; }
        public string Sector { get; set; }
        public int EmployeesNumber { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddCompanyExternal, Company>();
        }
    }
}
