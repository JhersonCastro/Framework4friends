using pkgServices.pkgCollections.pkgLineal.Iterator;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;
using System.Runtime.InteropServices.WindowsRuntime;


namespace pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTLineal<T> : clsIterator<T>, iADTLineal<T> where T : IComparable<T>
    {
        #region Atributes
        protected static int attMaxCapacity = 250; // int.MaxValue / 16
        protected bool attItsOrderedAscending = false;
        protected bool attItsOrderedDescending = false;
        #endregion
        #region Operations
        #region Getters

        #endregion
        #region Query
        public static int opGetMaxCapacity()
        {
            return attMaxCapacity;
        }
        public bool opExists(T prmItem)
        {
            throw new NotImplementedException();
        }
        public int opFind(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opItsEmpty() => attLength == 0;

        public bool opItsOrderedAscending()
        {
            return attItsOrderedAscending;
        }
        public bool opItsOrderedDescending()
        {
            return attItsOrderedDescending;
        }

        #endregion
        #region Serialize/Deserialize
        public virtual T[] opToArray()
        {
                        throw new NotImplementedException();

        }

        public virtual bool opToItems(T[] prmArray)
        {
            throw new NotImplementedException();
        }
        public string opToString()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Cruds
        public virtual bool opModify(int prmIndex, T prmItem)
        {
            if (!opGo(prmIndex)) return false;
            return opSetCurrentItem(prmItem);
        }

        public virtual bool opRetrieve(int prmIndex, ref T prmItem)
        {
            if (!opGo(prmIndex)) return false;
            return opSetCurrentItem(prmItem);
        }
        public bool opReverse()
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
