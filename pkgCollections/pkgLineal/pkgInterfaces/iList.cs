using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    interface iList<T> where T : IComparable<T>
    {
        #region Cruds
        bool opAdd(T prmItem);
        bool opInsert(int prmidx, T prmItem);
        bool opRemove(int prmIdx, ref T prmItem);
        #endregion
    }
}
