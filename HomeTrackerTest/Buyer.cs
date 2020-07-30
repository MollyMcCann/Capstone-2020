using HomeTrackerDatamodelLibrary;
using System.Collections.Generic;

namespace HomeTrackerTest
{
    public class Buyer
    {
        private Person person;

        public int BuyerID { get; set; }

        public int? CreditRating { get; set; }

        //public virtual Person Person { get => person; set => person = value; }
        // public virtual ICollection<HomeSaleCollection> HomeSales { get; set; }

    }
}