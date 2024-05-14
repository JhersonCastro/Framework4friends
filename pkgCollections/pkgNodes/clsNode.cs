using pkgServices.pkgCollections.pkgNodes.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgNodes
{
    public class clsNode<T> : iNode<T> where T : IComparable<T>
    {
        #region Attributes
        protected T attItems = default;
        #endregion
        #region Builders
        protected clsNode()
        {

        }
        protected clsNode(T prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Getters
        public T opGetItem()
        {
            return attItems;
        }
        #endregion
        #region Setters
        public bool opSetItem(T prmContent)
        {
            attItems = prmContent;
            return true;
        }
        #endregion
    }
}
