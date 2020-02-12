using KansasStateUniversity.TreeViewer2;

namespace SirtCantasi
{
    public class LeftistTree<T> : ITree
    {
        private T _data;

        public T Data
        {
            get
            {
                return _data;
            }
        }

        private LeftistTree<T> _leftChild;

        public LeftistTree<T> LeftChild
        {
            get
            {
                return _leftChild;
            }
        }

        private LeftistTree<T> _rightChild;

        public LeftistTree<T> RightChild
        {
            get
            {
                return _rightChild;
            }
        }

        private int _nullPathLength;

        public LeftistTree(T data, LeftistTree<T> child1, LeftistTree<T> child2)
        {
            _data = data;
            if (NullPathLength(child1) < NullPathLength(child2))
            {
                _rightChild = child1;
                _leftChild = child2;
            }
            else
            {
                _rightChild = child2;
                _leftChild = child1;
            }

            _nullPathLength = NullPathLength(_rightChild) + 1;

        }

        public static int NullPathLength(LeftistTree<T> t)
        {
            if (t == null)
                return 0;

            else
                return t._nullPathLength;
        }

        #region Properties needed for the ITree interface

        ITree[] ITree.Children
        {
            get
            {
                ITree[] children = new ITree[2];
                children[0] = _leftChild;
                children[1] = _rightChild;
                return children;
            }
        }

        bool ITree.IsEmpty
        {
            get
            {
                return false;
            }
        }

        object ITree.Root
        {
            get
            {
                return _data;
            }
        }

        #endregion

    }
}
