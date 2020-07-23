using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTrackerTest
{
    class RealEstateCompany
    {
        public string CompanyName { get; set; }
        public int CompanyId { get; set; }
        public int PhoneNumber { get; set; }

        RealEstateCompany()
        {
            Agents = new List<Agent>();
        }
        public virtual ICollection<Agent> Agents { get; set; }
        //add data to Agent
    }
}
