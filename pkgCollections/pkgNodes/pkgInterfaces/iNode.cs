using System;

namespace pkgServices.pkgCollections.pkgNodes.pkgInterfaces
{
    interface iNode<T> where T : IComparable<T>
    {
        #region Getters
        T opGetItem();
        #endregion
        #region Setters
        bool opSetItem(T prmContent);
        #endregion
    }
}
