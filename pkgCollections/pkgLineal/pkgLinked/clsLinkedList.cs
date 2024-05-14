using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using pkgServices.pkgCollections.pkgNodes;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgLinked
{
    public class clsLinkedList<T> : clsADTLinked<T>, iList<T> where T : IComparable<T>
    {
        #region Cruds
        public override bool opToItems(T[] prmArray)
        {
            for (int i = 0; i < prmArray.Length; i++)
            {
                opAdd(prmArray[i]);
            }
            return true;
        }

        public bool opAdd(T prmItem)
        {
            if(attMaxCapacity > attLength)
            {
                attItems[attLength] = prmItem;
                attLength++;
                return true;
            }
            return false;
        }
        public bool opInsert(int prmIdx, T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opRemove(int prmIdx, ref T prmItem)
        {
            if (opItsEmpty()) return false;
            if (prmIdx < 0 || prmIdx >= attLength) return false;
                
            prmItem = attItems[prmIdx];
            for (int i = prmIdx; i < attLength; i++)
            {
                attItems[i] = attItems[i + 1];
            }
            attLength--;
            return true;
        }
        public override clsLinkedNode<T> opGetMiddle()
        {
            if (attLength == 0) return null;
            attMiddle.opSetItem(attItems[(attLength / 2) - 1]);
            return attMiddle;
        }
        public override clsLinkedNode<T> opGetLastQuarter()
        {

            if (attLength == 0) return null;
            else attLastQuarter.opSetItem(attItems[(3 * attLength / 4)-1]);
            return attLastQuarter;
        }
        #endregion
    }
}
