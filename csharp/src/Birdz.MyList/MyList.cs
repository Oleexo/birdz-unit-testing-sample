using System.Collections.Generic;

namespace Birdz.MyList
{
    public class MyList
    {
        private readonly IList<object> _elements;

        public MyList()
        {
            _elements = new List<object>();
        }

        public int Count()
        {
            return _elements.Count;
        }

        public void Add(string element)
        {
            _elements.Add(element);
        }

        public object this[int i] => _elements[0];
    }
}