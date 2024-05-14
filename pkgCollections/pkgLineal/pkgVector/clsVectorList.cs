using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;


namespace pkgServices.pkgCollections.pkgLineal.pkgVector
{
    public class clsVectorList<T> : clsADTVector<T>, iList<T> where T : IComparable<T>
    {
        #region Builders
        public clsVectorList()
        {
            attLength = 0;
        }
        public clsVectorList(int prmcapacity) : base(prmcapacity)
        {
            attLength = 0;
        }
        #endregion
        #region Cruds
        public bool opAdd(T prmItem)
        {
            if (attTotalCapacity > attLength || attItsFlexible)
            {
                if (attItsFlexible && attLength < attMaxCapacity)
                {
                    opUsingGrowinFactor();
                    attItems[attLength] = prmItem;
                    attLength++;
                    return true;
                }
                attItems[attLength] = prmItem;

                attLength++;
                return true;
            }
            return false;
        }
        public bool opInsert(int prmidx, T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opModify(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opRemove(ref T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opRemove(int prmIdx, ref T prmItem)
        {
            if (opItsEmpty()) return false;
            if (prmIdx == attLength - 1)
            {
                prmItem = attItems[prmIdx];
                attLength = attLength - 1;
                return true;
            }
            if (opIsValid(prmIdx))
            {
                prmItem = attItems[prmIdx];
                for (int i = prmIdx; i < attItems.Length - 1; i++)
                {
                    attItems[i] = attItems[i + 1];
                }
                attLength = attLength - 1;
                return true;
            }
            prmItem = default;
            return false;

            
        }
        public override bool opRetrieve(int prmIndex, ref T prmItem)
        {
            if (!opGo(prmIndex) || prmIndex >= attLength) return false;
            prmItem = attItems[prmIndex];
            return opSetCurrentItem(prmItem);
        }
        #endregion
    }
}
