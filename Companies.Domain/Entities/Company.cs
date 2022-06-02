using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Domain.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanySector { get; set; }
        public int CompanyEmployeesNumber { get; set; }
        public List<JobsOffer> Offers { get; set; }
        public List<Project> Projects { get; set; }
    }
}
