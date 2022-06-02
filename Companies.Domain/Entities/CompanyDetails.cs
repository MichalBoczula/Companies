using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Domain.Entities
{
    public class CompanyDetails
    {
        public int CompanyDetailsId { get; set; }
        public string CompanyDetailsDescription { get; set; }
        public string CompanyDetailsHistory { get; set; }
        public string CompanyDetailsOffer { get; set; }
        public string CompanyDetailsInformation { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
