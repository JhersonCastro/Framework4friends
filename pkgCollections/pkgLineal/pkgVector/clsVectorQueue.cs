using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgVector
{
    public class clsVectorQueue<T> : clsADTVector<T>, iQueue<T> where T : IComparable<T>
    {
        #region Builders
        public clsVectorQueue()
        {
        }
        public clsVectorQueue(int prmcapacity) : base(prmcapacity)
        {
        }

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
        #endregion
        #region Cruds

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
                attItems[attLength] = prmItem;
                attLength++;
                opSetGrowinFactor(attTotalCapacity);
                return true;
            }
            else if (attLength < attTotalCapacity)
            {
                attItems[attLength] = prmItem;
                attLength++;
                opSetGrowinFactor(attTotalCapacity);
                return true;
            }
            return false;
        }
        #endregion
    }
}
