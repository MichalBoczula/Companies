﻿using AutoMapper;
using Companies.Application.Mapping;
using Companies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Queries.CompanyDetails
{
    public class CompanyDetailsDto : IMapFrom<CompanyDetail>
    {
        public string Description { get; set; }
        public string History { get; set; }
        public string Offer { get; set; }
        public string Information { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CompanyDetail, CompanyDetailsDto>();
        }
    }
}
