using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;


namespace pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTVector<T> : clsADTLineal<T>, iADTVector<T> where T : IComparable<T>
    {
        #region Atributes
        protected T[] attItems = new T[100];
        protected bool attItsFlexible = false;
        public int attTotalCapacity = 100;
        protected int attGrowinFactor = 100;
        #endregion
        #region Builders 
        public clsADTVector()
        {

        }
        public clsADTVector(int prmCapacity)
        {
            if (prmCapacity > 0 && prmCapacity <= attMaxCapacity)
            {
                attTotalCapacity = prmCapacity;
                attItems = new T[prmCapacity];
                attItsFlexible = false;
                opSetGrowinFactor(prmCapacity);
            }
        }
        #endregion
        #region Operations
        #region Getters
        public int opGetGrowingFactor()
        {
            return attGrowinFactor;
        }
        public int opGetAvailableCapacity()
        {
            return attTotalCapacity - attLength;
        }

        public int opGetTotalCapacity()
        {
            return attTotalCapacity;
        }
        public static int opGetMaxCapacity()
        {
            return attMaxCapacity;
        }

        #endregion
        #region Setters
        public bool opSetCapacity(int prmValue)
        {
            if (prmValue > attMaxCapacity)
            {
                return false;
            }
            else
            {
                attTotalCapacity = prmValue;
                return true;
            }
        }
        public bool opSetGrowinFactor(int prmValue)
        {
            if (prmValue == attTotalCapacity)
            {
                if (prmValue >= attMaxCapacity)
                {
                    attGrowinFactor = 0;
                    return false;
                }
                if (attMaxCapacity - prmValue < 100)
                {
                    attGrowinFactor = attMaxCapacity - prmValue;
                    return true;
                }
                attGrowinFactor = 100;
                return true;
            }
            else
            {
                if ((prmValue + attTotalCapacity) <= attMaxCapacity)
                {
                    attGrowinFactor = prmValue;
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public bool opSetFlexible()
        {
            return attItsFlexible = true;
        }
        public bool opSetInFlexible()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Query
        public bool opItsFull() => attLength == attTotalCapacity;


        public bool opItsFlexible()
        {
            if (attItsFlexible && (attTotalCapacity + attGrowinFactor) <= attMaxCapacity)
                return attGrowinFactor != 0;
            if (attItsFlexible && attLength == attTotalCapacity)
            {
                attGrowinFactor = 0;
                attItsFlexible = false;
            }

            return attItsFlexible;
        }
        #endregion
        #region Serializable 
        public override bool opGo(int prmIdx)
        {
            if (!opIsValid(prmIdx)) return false;
            opGetLength();
            opSetCurrentIndex(prmIdx);
            opSetCurrentItem(attItems[opGetCurrentIndex()]);
            return true;
        }
        public override void opGoFoward()
        {
            base.opGoFoward();
            attCurrentItem = attItems[opGetCurrentIndex()];
        }
        public override void opGoBack()
        {
            base.opGoBack();
            attCurrentItem = attItems[attCurrentIdx];
        }
        public override bool opGoFirst()
        {
            if (!opIsValid(0)) return false;
            attCurrentIdx = 0;
            attCurrentItem = attItems[attCurrentIdx];
            return true;
        }
        public override T[] opToArray() => attItems;

        public override bool opToItems(T[] prmArray)
        {
            if (prmArray.Length > attMaxCapacity) return false;
            attItems = prmArray;
            attLength = attItems.Length;
            attTotalCapacity = attItems.Length;
            if (attMaxCapacity - attLength < 100)
                attGrowinFactor = attMaxCapacity - attLength;
            attItsOrderedAscending = false;
            attItsOrderedDescending = false;
            return true;

        }
        public bool opToItems(T[] prmArray, int prmItemsCount)
        {
            attItems = prmArray;
            attTotalCapacity = prmArray.Length;
            attLength = prmItemsCount;
            opSetGrowinFactor(attTotalCapacity);

            return true;
        }
        public bool opUsingGrowinFactor()
        {
            if (!attItsFlexible || attTotalCapacity == attMaxCapacity) return false;

            if ((attTotalCapacity + attGrowinFactor) <= attMaxCapacity)
            {
                Array.Resize(ref attItems, attTotalCapacity + attGrowinFactor);
                attTotalCapacity += attGrowinFactor;
                return true;
            }
            return false;
        }

        #endregion
        #endregion
    }
}
