using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgLinked
{
    public class clsLinkedStack<T> : clsADTLinked<T>, iStack<T> where T : IComparable<T>
    {
        #region Cruds
        public override bool opPush(T prmItem)
        {
            if(attLength < attMaxCapacity)
            {
                for (int i = attLength; i > 0; i--)
                {
                    attItems[i] = attItems[i - 1];
                }
                attItems[0] = prmItem;
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
