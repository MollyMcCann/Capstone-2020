using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTrackerTest
{
    class Home
    {
        public int HomeID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string Zip { get; set; }
        public int OwnerID { get; set; }
        public virtual Owner Owner { get; set; }//fill in data for owner and 
    }
}
