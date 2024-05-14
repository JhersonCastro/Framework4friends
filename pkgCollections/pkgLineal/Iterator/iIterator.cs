using System;

namespace pkgServices.pkgCollections.pkgLineal.Iterator
{
    interface iIterator<T> where T : IComparable<T>
    {
        #region Cruds
        bool opGoFirst();
        bool opGoFirstQuarter();
        bool opGoPrevious();
        bool opGoMiddle();
        bool opGoLastQuarter();
        bool opGoNext();
        bool opGoLast();
        bool opGo(int prmIndex);
        void opGoBack();
        void opGoFoward();
        int opGetLength();
        int opGetCurrentIndex();
        bool opSetCurrentIndex(int prmIndex);
        T opGetCurrentItem();
        bool opSetCurrentItem(T prmContent);
        bool opIsValid(int prmIndex);
        bool opIsThereNext();
        bool opIsTherePrevious();
        


        #endregion
    }
}
