using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using pkgServices.pkgCollections.pkgNodes;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgLinked
{
    public class clsLinkedQueue<T> : clsADTLinked<T>, iQueue<T> where T : IComparable<T>
    {
        #region Cruds
        public override bool opToItems(T[] prmArray)
        {
            if (prmArray == null) { return false; }
            if (prmArray.Length == 0) { return false; }
            attFirst = new clsLinkedNode<T>(prmArray[0]);
            attMiddle = attFirst;
            clsLinkedNode<T> varPreviousNode = attFirst;
            clsLinkedNode<T> varCurrentNode = attFirst;
            for (int idx = 0; idx < prmArray.Length; idx++)
            {
                opPush(prmArray[idx]);
            }
            attLast = varCurrentNode;
            return true;
        }
        public override clsLinkedNode<T> opGetLastQuarter()
        {

            if (attLength == 0) return null;
            if (!opGoLastQuarter()) return null;
            if (attLength == 1) attLastQuarter.opSetItem(attItems[0]);
            else if (attLength == 3) attLastQuarter.opSetItem(attItems[1]);
            else if (attLength == 5) attLastQuarter.opSetItem(attItems[3]);
            else attLastQuarter.opSetItem(attItems[(3 * attLength / 4)-1]);
            return attLastQuarter;
        }
        public override bool opPush(T prmItem)
        {
            if (attLength < attMaxCapacity)
            {
                attItems[attLength] = prmItem;
                attLength++;
                return true;
            }
            return false;          
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
    }
}
