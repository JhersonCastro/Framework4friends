using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using pkgServices.pkgCollections.pkgNodes;
using pkgServices.pkgCollections.pkgNodes.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTDoubleLinked<T> : clsADTLineal<T>, iADTDoubleLinked<T> where T : IComparable<T>
    {
        #region Atributes
        protected clsDoubleLinkedNode<T> attFirst;
        protected clsDoubleLinkedNode<T> attFirstQuarter;
        protected clsDoubleLinkedNode<T> attLastQuarter;
        protected clsDoubleLinkedNode<T> attMiddle;
        protected clsDoubleLinkedNode<T> attLast;
        protected clsDoubleLinkedNode<T> attCurrentNode;
        protected clsDoubleLinkedNode<T> attNextNode;
        protected clsDoubleLinkedNode<T> attPreviousNode;
        #endregion
        #region Builders
        protected clsADTDoubleLinked()
        {

        }
        #endregion
        #region Getters
        
        public clsDoubleLinkedNode<T> opGetFirst()
        {
            throw new NotImplementedException();
        }
        public clsDoubleLinkedNode<T> opGetMiddle()
        {
            throw new NotImplementedException();
        }
        public clsDoubleLinkedNode<T> opGetLast()
        {
            throw new NotImplementedException();
        }
        public clsDoubleLinkedNode<T> opGetLastQuarter()
        {
            throw new NotImplementedException();
        }
        public clsDoubleLinkedNode<T> opGetFirstQuarter()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Setters

        public bool opSetFirst(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();

        }
        public bool opSetFirstQuarter(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();

        }
        public bool opSetMiddle(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();

        }
        public bool opSetLast(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();

        }
        public bool opSetLastQuarter(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();

        }
        #endregion
        #region Iterator
        
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
            attCurrentIdx = (attLength/2)+(attLength / 4);
            return true;
        }
        public override void opGoFoward()
        {
            base.opGoFoward();
            attCurrentNode = attCurrentNode.opGetNext();
            attCurrentItem = attCurrentNode.opGetItem();

        }
        public override void opGoBack()
        {
            base.opGoBack();
            attCurrentNode = attCurrentNode.opGetPrevious();
            attCurrentItem = attCurrentNode.opGetItem();
        }
        public override bool opModify(int prmIndex, T prmItem)
        {
            return base.opModify(prmIndex, prmItem);
        }

        #endregion
    }
}
