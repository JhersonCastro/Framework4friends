using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgVector
{
    public class clsVectorStack<T> : clsADTVector<T>, iStack<T> where T : IComparable<T>
    {
        #region Builders
        public clsVectorStack() : base()
        {

        }
        public clsVectorStack(int prmcapacity) : base(prmcapacity)
        {

        }
        #endregion
        #region Cruds
        public bool opPeek(ref T prmItem)
        {
            if (opItsEmpty())
            {
                prmItem = default;
                return false;
            }
            prmItem = attItems[0];
            return true;
        }

        public bool opPop(ref T prmItem)
        {
            if (opItsEmpty()) return false;
            prmItem = attItems[0];
            for (int i = 0; i < attItems.Length - 1; i++)
            {
                attItems[i] = attItems[i + 1];
            }
            attLength--;
            return true;
        }

        public bool opPush(T prmItem)
        {
            if (attLength >= attTotalCapacity && attItsFlexible)
            {
                opUsingGrowinFactor();
                for (int i = attLength; i > 0; i--)
                {
                    attItems[i] = attItems[i - 1];
                }
                attItems[0] = prmItem;
                attLength++;
                opSetGrowinFactor(attTotalCapacity);
                return true;
            }
            else if (attLength < attTotalCapacity)
            {
                for (int i = attLength; i > 0; i--)
                {
                    attItems[i] = attItems[i - 1];
                }
                attItems[0] = prmItem;
                attLength++;
                opSetGrowinFactor(attTotalCapacity);
                return true;
            }
            return false;
        }
        #endregion
    }
}
