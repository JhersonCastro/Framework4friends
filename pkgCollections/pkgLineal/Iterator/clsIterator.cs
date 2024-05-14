using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace pkgServices.pkgCollections.pkgLineal.Iterator
{

    public class clsIterator<T> : iIterator<T> where T : IComparable<T>
    {
        protected int attLength = 0;
        protected int attCurrentIdx = -1;
        protected T attCurrentItem;
        public int opGetCurrentIndex()
        {
            return attCurrentIdx;
        }

        public T opGetCurrentItem()
        {
            return (T)attCurrentItem;
        }

        public int opGetLength()
        {
            return attLength;
        }

        public virtual bool opGo(int prmIndex)
        {
            if (!opIsValid(prmIndex)) return false;
            if (prmIndex < attLength / 2)
                opGoFirst();
            else opGoMiddle();

            while (attCurrentIdx < prmIndex)
                opGoNext();
            return true;
        }

        public virtual void opGoBack()
        {
            attCurrentIdx--;
        }

        public virtual bool opGoFirst()
        {
            throw new NotImplementedException();
        }
        public virtual bool opGoFirstQuarter()
        {
            throw new NotImplementedException();
        }
        public virtual void opGoFoward()
        {
            attCurrentIdx++;
        }

        public bool opGoLast()
        {
            throw new NotImplementedException();
        }

        public virtual bool opGoLastQuarter()
        {
            throw new NotImplementedException();
        }

        public bool opGoMiddle()
        {
            throw new NotImplementedException();
        }

        public bool opGoNext()
        {
            if(!opIsThereNext())return false;
            opGoFoward();
            return true;
        }

        public bool  opGoPrevious()
        {
           if(!opIsTherePrevious()) return false;
           opGoBack();
            return true;
        }

        public bool opIsThereNext()
        {
            if (attCurrentIdx == attLength-1) return false;
            if(attCurrentIdx > attLength-1) return false;
            return true;
        }

        public virtual bool opIsTherePrevious()
        {
            if(attCurrentIdx<=0) return false;
            return true;
        }

        public bool opIsValid(int prmIndex)
        {
            if (prmIndex < 0 || prmIndex >= attLength) return false;
            return true;
        }
        
        public bool opSetCurrentIndex(int prmIndex)
        {
            if (attLength < prmIndex) return false;
            attCurrentIdx = prmIndex;
            return true;
        }

        public virtual bool opSetCurrentItem(T prmContent)
        {
            attCurrentItem = prmContent;
            return true;
        }
    }
}
