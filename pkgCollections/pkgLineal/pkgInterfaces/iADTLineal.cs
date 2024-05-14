using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    interface iADTLineal<T> where T : IComparable<T>
    {
        #region Getters
        #endregion            
        #region Query
        int opFind(T prmItem);
        bool opExists(T prmItem);
        bool opItsEmpty();
        bool opItsOrderedAscending();
        bool opItsOrderedDescending();
        #endregion
        #region Serialize/DeSerialize
        T[] opToArray();
        string opToString();
        bool opToItems(T[] prmArray);
        #endregion
        #region Crud
        bool opModify(int prmIndex, T prmItem);
        bool opRetrieve(int prmIndex, ref T prmItem);
        bool opReverse();
        #endregion
    }
}
