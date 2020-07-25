using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTrackerTest
{
    class HomeSales
    {
        public int SaleID { get; set; }

        public int HomeID { get; set; }

        public DateTime? SoldDate { get; set; }

        public int AgentID { get; set; }

        public decimal SaleAmount { get; set; }

        public int? BuyerID { get; set; }

        public DateTime MarketDate { get; set; }

        public int CompanyID { get; set; }

        public virtual Agent Agent { get; set; }

        public virtual Buyer Buyer { get; set; }

        public virtual Home Home { get; set; }

        public virtual RealEstateCompany RealEstateCompany { get; set; }
    }
}
