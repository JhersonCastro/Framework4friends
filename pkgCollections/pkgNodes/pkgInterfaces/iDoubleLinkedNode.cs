using System;

namespace pkgServices.pkgCollections.pkgNodes.pkgInterfaces
{
    interface iDoubleLinkedNode<T> where T : IComparable<T>
    {
        #region Getters
        clsDoubleLinkedNode<T> opGetPrevious();
        clsDoubleLinkedNode<T> opGetNext();
        #endregion
        #region Setters
        bool opSetPrevious(clsDoubleLinkedNode<T> prmNode);
        bool opSetNext(clsDoubleLinkedNode<T> prmNode);
        #endregion
    }
}
