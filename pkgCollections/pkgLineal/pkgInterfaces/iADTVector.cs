using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    interface iADTVector<T> where T : IComparable<T>
    {
        #region Getters
        int opGetTotalCapacity();
        int opGetGrowingFactor();
        int opGetAvailableCapacity();
        #endregion
        #region Setters
        bool opSetCapacity(int prmValue);
        bool opSetGrowinFactor(int prmValue);
        bool opSetFlexible();
        bool opSetInFlexible();
        #endregion
        #region Query
        bool opItsFull();
        bool opItsFlexible();
        #endregion
        #region Serializable/Deserealize
        bool opToItems(T[] prmArray, int prmItemsCount);
        #endregion
    }
}
