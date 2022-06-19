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
    public class ProjectDto : IMapFrom<Project>
    {
        public string Name { get; set; }
        public string Desc { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Project, ProjectDto>();
        }
    }
}
