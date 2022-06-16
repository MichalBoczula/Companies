using Companies.API.Common;
using Companies.Application.Features.Entities.Queries.CompanyDetails;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companies.API.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : BaseController
    {
        [HttpGet("{companyId}")]
        public async Task<ActionResult> GetExperienceLevels(int companyId)
        {
            var vm = await Mediator.Send(new CompanyDetailsQuery() { CompanyId = companyId} );
            return Ok(vm);
        }
    }
}
