using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    interface iQueue<T> where T : IComparable<T>
    {
        #region Cruds
        bool opPush(T prmItem);
        bool opPop(ref T prmItem);
        bool opPeek(ref T prmItem);
        #endregion
    }
}
