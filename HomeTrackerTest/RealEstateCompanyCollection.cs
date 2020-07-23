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


        private List<RealEstateCompany> _realEstateCompanies;
        int position = -1;

        public void Add(RealEstateCompany realEstateCompany)
        {
            var re = _realEstateCompanies.SingleOrDefault(r => r.CompanyId == realEstateCompany.CompanyId);
            if (re == null)
            {
                _realEstateCompanies.Add(realEstateCompany);
            }
        }
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
            position++;
            return (position < _realEstateCompanies.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<RealEstateCompany>)this;
        }


        public RealEstateCompany Get(int id)
        {
            return _realEstateCompanies.SingleOrDefault(re => re.CompanyId == id);
        }

    }
}
