﻿using Companies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Contracts
{
    public interface ICompanyRepository
    {
        Task<Company> GetCompanyDetails(int companyId);
    }
}