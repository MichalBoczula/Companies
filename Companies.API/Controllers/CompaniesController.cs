using Companies.API.Common;
using Companies.Application.Features.Entities.Commands.Companies.AddCompany;
using Companies.Application.Features.Entities.Commands.Companies.DeleteCompany;
using Companies.Application.Features.Entities.Commands.Companies.UpdateCompany;
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
        public async Task<ActionResult> GetCompanyDetails(int companyId)
        {
            var vm = await Mediator.Send(new CompanyDetailsQuery() { CompanyId = companyId} );
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult> AddCompany(AddCompanyExternal model)
        {
            var vm = await Mediator.Send(new AddCompanyCommand() { Model = model });
            return Ok(vm);
        }

        [HttpDelete("{companyId}")]
        public async Task<ActionResult> DeleteCompany(int companyId)
        {
            var vm = await Mediator.Send(new DeleteCompanyCommand() { CompanyId = companyId});
            return Ok(vm);
        }

        [HttpPut("{companyId}")]
        public async Task<ActionResult> UpdateCompany([FromBody]UpdateCompanyExternal model, [FromRoute] int companyId)
        {
            var vm = await Mediator.Send(new UpdateCompanyCommand() { CompanyId = companyId, Model = model});
            return Ok(vm);
        }
    }
}
