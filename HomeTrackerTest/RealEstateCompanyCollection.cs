using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTrackerTest
{
    class RealEstateCompanyCollection
            : IEnumerator<RealEstateCompanyCollection>, IEnumerable<RealEstateCompanyCollection>
    {
        public RealEstateCompanyCollection()
        {
            _realEstateCompanies = new List<RealEstateCompany>();
        }

        public RealEstateCompanyCollection Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
           // throw new NotImplementedException();
        }

        public IEnumerator<RealEstateCompanyCollection> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private List<RealEstateCompany> _realEstateCompanies;

        public void Add(RealEstateCompany realEstateCompany)
        {
            var re = _realEstateCompanies.SingleOrDefault(r => r.CompanyId == realEstateCompany.CompanyId);
            if (re == null)
            {
                _realEstateCompanies.Add(realEstateCompany);
            }
        }

    }
}
