using System.Collections.Generic;
namespace car_factory.Iterator
{
    class Iterator<T>
    {
        private int _count;
        private int _index;
        private IList<T> _enumerable;

        public Iterator(IList<T> enumerable)
        {
            _index = 0;
            _enumerable = enumerable;
            _count = enumerable.Count;
        }

        public bool HasNext()
        {
            return (_index < _count) ? true : false;
        }

        public T Next()
        {
            return _enumerable[_index++];
        }
    }
}