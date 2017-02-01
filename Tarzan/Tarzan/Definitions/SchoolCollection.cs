using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarzan.Definitions
{
    class SchoolCollection : ICollection<School>
    {
        protected readonly ISet<School> internalCollection = new SortedSet<School>();

        public int Count
        {
            get
            {
                return internalCollection.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(School item)
        {
            internalCollection.Add(item);
        }

        public void Clear()
        {
            internalCollection.Clear();
        }

        public bool Contains(School item)
        {
            return internalCollection.Contains(item);
        }

        public void CopyTo(School[] array, int arrayIndex)
        {
            internalCollection.CopyTo(array, arrayIndex);
        }

        public IEnumerator<School> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(School item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
