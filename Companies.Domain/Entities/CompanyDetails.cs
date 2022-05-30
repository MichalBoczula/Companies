using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Domain.Entities
{
    public class CompanyDetails
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
        public string Offer { get; set; }
        public string Information { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
