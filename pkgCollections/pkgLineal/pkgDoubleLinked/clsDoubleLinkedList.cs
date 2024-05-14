using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgDoubleLinked
{
    public class clsDoubleLinkedList<T> : clsADTDoubleLinked<T>, iList<T> where T : IComparable<T>
    {
        #region Cruds
        public bool opAdd(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opInsert(int prmIdx, T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opRemove(int prmIdx, ref T prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
