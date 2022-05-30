using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sector { get; set; }
        public int EmployeesNumber { get; set; }
        public List<JobsOffer> Offers { get; set; }
        public List<Project> Projects { get; set; }
    }
}
