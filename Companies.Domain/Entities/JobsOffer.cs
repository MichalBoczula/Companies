using Companies.Domain.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Domain.Entities
{
    public class JobsOffer
    {
        public int JobsOfferId { get; set; }
        public int CompanyId { get; set; }
        public string IntegrationId { get; set; }
        public int StatusId { get; set; }
        public JobStatus Status{ get; set; }
    }
}
