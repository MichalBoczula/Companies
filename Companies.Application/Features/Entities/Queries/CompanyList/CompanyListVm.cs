using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Application.Features.Entities.Queries.CompanyList
{
    public class CompanyListVm
    {
        public string CompanyName { get; set; }
        public List<ProjectVm> Projects { get; set; } = new List<ProjectVm>();
    }
}
