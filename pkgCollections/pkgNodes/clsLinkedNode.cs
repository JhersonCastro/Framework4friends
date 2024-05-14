using pkgServices.pkgCollections.pkgNodes.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgNodes
{
    public class clsLinkedNode<T> : clsNode<T>, iLinkedNode<T> where T : IComparable<T>
    {
        #region Attributes
        public clsLinkedNode<T> attNext;
        public clsDoubleLinkedNode<T> attPrevious;
        #endregion
        #region Builders
        public clsLinkedNode()
        {

        }
        public clsLinkedNode(T prmItem)
        {
        }
        #endregion
        #region Getters
        public clsLinkedNode<T> opGetNext()
        {
            throw new NotImplementedException();

        }
        #endregion
        #region Setters
        public bool opSetNext(clsLinkedNode<T> prmNode)
        {
            return true;
        }
        //public override bool opGoFirstQuarter()
        //{
        //    if (attFirstQuarter == null) return false;
        //    attCurrentItem = attFirstQuarter.opGetItem();
        //    attCurrentIdx = attLength / 4;
        //    return true;
        //}
        //public clsLinkedNode<T> opGetFirstQuarter()
        //{
        //    if (!opGoFirstQuarter()) return null;
        //    attFirstQuarter = atCurrentNode;
        //    return attFirstQuarter;
        //}
        #endregion
    }
}
