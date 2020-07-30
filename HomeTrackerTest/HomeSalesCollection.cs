using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTrackerDatamodelLibrary;

namespace HomeTrackerTest
{
    class HomeSalesCollection
        : IEnumerator, IEnumerable
    {
        public HomeSalesCollection()
        {
            _homeSales = new List<HomeSales>();
            using (HomeTrackerModel1 db = new HomeTrackerModel1())
            {
                //retrieve data:
                HomeSales homeSales = (from hs in db.HomeSales
                             select hs).FirstOrDefault();
                Add(homeSales);
            }
        }
        private List<HomeSales> _homeSales;
        int position = -1;

        public HomeSalesCollection Current => _homeSales[position];

        object IEnumerator.Current => _homeSales[position];

        public void Add(HomeSales homeSales)
        {

            var re = _homeSales.SingleOrDefault(hs => hs.HomeID == homeSales.HomeID);
            if (re == null)
            {
                _homeSales.Add(homeSales);
            }
        }

        public void Dispose()
        {
            //   throw new NotImplementedException();
        }

        public IEnumerator<HomeCollection> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            position++;
            return (position < _homeSales.Count);
        }
        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<HomeSales>)this;
        }

        IEnumerator<HomeSalesCollection> IEnumerable<HomeSalesCollection>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
