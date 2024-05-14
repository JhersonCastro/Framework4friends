using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using pkgServices.pkgCollections.pkgNodes;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTLinked<T> : clsADTLineal<T>, iADTLinked<T> where T : IComparable<T>
    {
		#region Attributes
		protected T[] attItems = new T[attMaxCapacity];
		protected clsLinkedNode<T> attFirst = null;
        protected clsLinkedNode<T> attMiddle = null;
        protected clsLinkedNode<T> attLast = null;
        protected clsLinkedNode<T> attFirstQuarter = null;
        protected clsLinkedNode<T> attLastQuarter = null;
        protected clsLinkedNode<T> attCurrentNode;
        #endregion
        #region Builders
        protected clsADTLinked()
        {
            attFirst = new clsLinkedNode<T> ();
            attMiddle = new clsLinkedNode<T> ();
            attLast = new clsLinkedNode<T> ();
            attFirstQuarter = new clsLinkedNode<T> ();
            attLastQuarter = new clsLinkedNode<T> ();
            attCurrentNode = new clsLinkedNode<T> ();
        }
        #endregion
        #region Getters
       
        public clsLinkedNode<T> opGetFirst()
        {
           if (attLength == 0) return null;
           attFirst.opSetItem(attItems[0]);
           return attFirst;
        }
        public clsLinkedNode<T> opGetFirstQuarter()
        {
            if (attLength == 0) return null;
            if (!opGoFirstQuarter()) return null;
            attFirstQuarter.opSetItem(attItems[attLength / 4]);
            return attFirstQuarter;
        }
		public virtual clsLinkedNode<T> opGetLastQuarter()
		{

            if (attLength == 0) return null;
            if (!opGoLastQuarter()) return null;
            if (attLength == 3) attLastQuarter.opSetItem(attItems[1]);
            else attLastQuarter.opSetItem(attItems[(3 * attLength / 4)]);
			return attLastQuarter;
		}
		public clsLinkedNode<T> opGetLast()
        {
            if (attLength == 0) return null;
            if (attLength == 1) attLast.opSetItem(attItems[0]);
            else attLast.opSetItem(attItems[attLength-1]);
            return attLast;
        }
        public virtual clsLinkedNode<T> opGetMiddle()
        {
            if (attLength == 0) return null;
            attMiddle.opSetItem(attItems[attLength / 2]);
            return attMiddle;
        }
        #endregion
        #region Setters
        public override T[] opToArray()
        {
            if(attLength ==0) return null;
            T[] temp = new T[attLength];
            for (int i = 0; i < attLength; i++)
            {
                temp[i] = attItems[i];
            }
            return temp;
        }
        public bool opSetFirst(clsLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        public bool opSetLast(clsLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();

        }
        public bool opSetMiddle(clsLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Iterator
        public override bool opGo(int prmIndex)
        {
            if (!opIsValid(prmIndex)) return false;
            if (prmIndex < attLength / 4) { opGoFirst(); }
            if (prmIndex >= attLength / 4 && prmIndex < attLength / 2) { opGoFirstQuarter(); }
            if (prmIndex >= attLength / 2 && prmIndex < (attLength / 2 + attLength / 4)) { opGoMiddle(); }
            if (prmIndex >= (attLength / 2 + attLength / 4) && prmIndex < attLength) { opGoLastQuarter(); }
            if (prmIndex == attLength - 1) { opGoLast(); }
            while (attCurrentIdx < prmIndex) { opGoNext(); }
            return true;
        }
        public override void opGoFoward()
        {
            base.opGoFoward();
            attCurrentNode = attCurrentNode.opGetNext();
            attCurrentItem = attCurrentNode.opGetItem();

        }
        public override bool opToItems(T[] prmArray)
        {
            if (prmArray == null) { return false; }
            if (prmArray.Length == 0) { return false; }
            attFirst = new clsLinkedNode<T>(prmArray[0]);
            attMiddle = attFirst;
            clsLinkedNode<T> varPreviousNode = attFirst;
            clsLinkedNode<T> varCurrentNode = attFirst;
            for (int idx = prmArray.Length-1; idx>=0; idx--)
            {
                opPush(prmArray[idx]);
            }
            attLast = varCurrentNode;
            return true;
        }
        public override bool opGoFirst()
        {
            if (attFirst == null) return false;
            attCurrentItem = attFirst.opGetItem();
            attCurrentIdx = 0;
            return true;
        }
        public override bool opGoFirstQuarter()
        {
            if (attFirstQuarter == null) return false;
            attCurrentItem = attFirstQuarter.opGetItem();
            attCurrentIdx = attLength / 4;
            return true;
        }
        public override bool opGoLastQuarter()
        {
            if (attLastQuarter == null) return false;
            attCurrentItem = attLastQuarter.opGetItem();
            attCurrentIdx = (attLength / 2) + (attLength / 4);
            return true;
        }

        public virtual bool opPush(T prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
