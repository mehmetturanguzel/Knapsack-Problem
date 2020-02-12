using System;
using System.Collections.Generic;
using KansasStateUniversity.TreeViewer2;

namespace SirtCantasi
{
    public class OncelikSirasi<TPriority, TValue> where TPriority : IComparable<TPriority>
    {
        private LeftistTree<KeyValuePair<TPriority, TValue>> _elementler = null;

        private int _count = 0;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public TPriority YuksekOncelik
        {
            get
            {
                if (_elementler == null)
                    throw new InvalidOperationException();
                else
                    return _elementler.Data.Key;
            }
        }

        public TreeForm HeapDrawing
        {
            get
            {
                return new TreeForm(_elementler, 100);
            }
        }

        private static LeftistTree<KeyValuePair<TPriority, TValue>> Merge(LeftistTree<KeyValuePair<TPriority, TValue>> h1,
            LeftistTree<KeyValuePair<TPriority, TValue>> h2)
        {
            if (h1 == null)
                return h2;

            else if (h2 == null)
                return h1;

            else
            {
                int compare = h1.Data.Key.CompareTo(h2.Data.Key);

                if (compare > 0)
                    return new LeftistTree<KeyValuePair<TPriority, TValue>>(h1.Data, h1.LeftChild, Merge(h1.RightChild, h2));
                else
                    return new LeftistTree<KeyValuePair<TPriority, TValue>>(h2.Data, h2.LeftChild, Merge(h2.RightChild, h1));
            }
        }

        public void Add(TValue x, TPriority p)
        {
            LeftistTree<KeyValuePair<TPriority, TValue>> node =
                new LeftistTree<KeyValuePair<TPriority, TValue>>(new KeyValuePair<TPriority, TValue>(p, x), null, null);

            _elementler = Merge(_elementler, node);
            _count++;
        }

        public TValue RemoveYuksekOncelik()
        {
            if (_elementler == null)
                throw new InvalidOperationException();

            else
            {
                TValue tempValue = _elementler.Data.Value;
                _count--;
                _elementler = Merge(_elementler.LeftChild, _elementler.RightChild);

                return tempValue;
            }
        }
    }
}
