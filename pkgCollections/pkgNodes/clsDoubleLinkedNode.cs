using pkgServices.pkgCollections.pkgNodes.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgNodes
{
    public class clsDoubleLinkedNode<T> : clsNode<T>, iDoubleLinkedNode<T> where T : IComparable<T>
    {
        #region Attributes
        public clsDoubleLinkedNode<T> attNext;
        public clsDoubleLinkedNode<T> attPrevious;
        #endregion
        #region Builders
        public clsDoubleLinkedNode()
        {

        }
        public clsDoubleLinkedNode(T prmItems)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Getters
        public clsDoubleLinkedNode<T> opGetPrevious()
        {
            throw new NotImplementedException();

        }
        public clsDoubleLinkedNode<T> opGetNext()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Setters
        public bool opSetPrevious(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        public bool opSetNext(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();

        }
        #endregion

    }
}
