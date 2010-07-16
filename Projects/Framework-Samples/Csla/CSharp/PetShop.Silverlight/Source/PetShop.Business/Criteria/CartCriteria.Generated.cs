﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Cart.cs'.
//
//     Template: Criteria.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using Csla.Core;
#if SILVERLIGHT
using Csla.Serialization;
#endif
using Csla.Serialization.Mobile;

#if !SILVERLIGHT
using System.Data.SqlClient;
#endif

using Csla;

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class CartCriteria : CriteriaBase<CartCriteria>, IGeneratedCriteria
    {
        #region Private Read-Only Members
        
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #endregion
        
        #region Constructors

        public CartCriteria(){}

        public CartCriteria(System.Int32 cartId)
        {
            CartId = cartId;
        }
        
        #endregion
        
        #region Public Properties
        
        #region Read-Write

        public System.Int32 CartId
        {
            get { return GetValue< System.Int32 >("CartId"); }
            set { _bag["CartId"] = value; }
        }

        public System.Int32 UniqueID
        {
            get { return GetValue< System.Int32 >("UniqueID"); }
            set { _bag["UniqueID"] = value; }
        }

        public System.String ItemId
        {
            get { return GetValue< System.String >("ItemId"); }
            set { _bag["ItemId"] = value; }
        }

        public System.String Name
        {
            get { return GetValue< System.String >("Name"); }
            set { _bag["Name"] = value; }
        }

        public System.String Type
        {
            get { return GetValue< System.String >("Type"); }
            set { _bag["Type"] = value; }
        }

        public System.Decimal Price
        {
            get { return GetValue< System.Decimal >("Price"); }
            set { _bag["Price"] = value; }
        }

        public System.String CategoryId
        {
            get { return GetValue< System.String >("CategoryId"); }
            set { _bag["CategoryId"] = value; }
        }

        public System.String ProductId
        {
            get { return GetValue< System.String >("ProductId"); }
            set { _bag["ProductId"] = value; }
        }

        public System.Boolean IsShoppingCart
        {
            get { return GetValue< System.Boolean >("IsShoppingCart"); }
            set { _bag["IsShoppingCart"] = value; }
        }

        public System.Int32 Quantity
        {
            get { return GetValue< System.Int32 >("Quantity"); }
            set { _bag["Quantity"] = value; }
        }

        #endregion
        
        #region Read-Only

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public Dictionary<string, object> StateBag
        {
            get
            {
                return _bag;
            }
        }

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public string TableFullName
        {
            get
            {
                return "[dbo].Cart";
            }
        }

        #endregion

        #endregion

        #region Overrides
        
        public override string ToString()
        {
            var result = string.Empty;
            var cancel = false;
            
            OnToString(ref result, ref cancel);
            if(cancel && !string.IsNullOrEmpty(result))
                return result;
            
            if (_bag.Count == 0)
                return "No criterion was specified.";

            foreach (KeyValuePair<string, object> key in _bag)
            {
                result += string.Format("[{0}] = '{1}' AND ", key.Key, key.Value);
            }

            return result.Remove(result.Length - 5, 5);
        }

        #endregion

        #region Private Methods
        
        private T GetValue<T>(string name)
        {
            object value;
            if (_bag.TryGetValue(name, out value))
                return (T) value;
        
            return default(T);
        }
        
        #endregion
        
        #region Partial Methods
        
        partial void OnToString(ref string result, ref bool cancel);
        
        #endregion
        
        #region Serialization
        
        protected override void OnGetState(SerializationInfo info, StateMode mode)
        {
            base.OnGetState(info, mode);
            if (_bag.ContainsKey("CartId")) info.AddValue("CartId", GetValue< System.Int32 >("CartId"));
            if (_bag.ContainsKey("UniqueID")) info.AddValue("UniqueID", GetValue< System.Int32 >("UniqueID"));
            if (_bag.ContainsKey("ItemId")) info.AddValue("ItemId", GetValue< System.String >("ItemId"));
            if (_bag.ContainsKey("Name")) info.AddValue("Name", GetValue< System.String >("Name"));
            if (_bag.ContainsKey("Type")) info.AddValue("Type", GetValue< System.String >("Type"));
            if (_bag.ContainsKey("Price")) info.AddValue("Price", GetValue< System.Decimal >("Price"));
            if (_bag.ContainsKey("CategoryId")) info.AddValue("CategoryId", GetValue< System.String >("CategoryId"));
            if (_bag.ContainsKey("ProductId")) info.AddValue("ProductId", GetValue< System.String >("ProductId"));
            if (_bag.ContainsKey("IsShoppingCart")) info.AddValue("IsShoppingCart", GetValue< System.Boolean >("IsShoppingCart"));
            if (_bag.ContainsKey("Quantity")) info.AddValue("Quantity", GetValue< System.Int32 >("Quantity"));
        }

        protected override void OnSetState(SerializationInfo info, StateMode mode)
        {
            base.OnSetState(info, mode);
            if(info.Values.ContainsKey("CartId")) _bag["CartId"] = info.GetValue< System.Int32 >("CartId");
            if(info.Values.ContainsKey("UniqueID")) _bag["UniqueID"] = info.GetValue< System.Int32 >("UniqueID");
            if(info.Values.ContainsKey("ItemId")) _bag["ItemId"] = info.GetValue< System.String >("ItemId");
            if(info.Values.ContainsKey("Name")) _bag["Name"] = info.GetValue< System.String >("Name");
            if(info.Values.ContainsKey("Type")) _bag["Type"] = info.GetValue< System.String >("Type");
            if(info.Values.ContainsKey("Price")) _bag["Price"] = info.GetValue< System.Decimal >("Price");
            if(info.Values.ContainsKey("CategoryId")) _bag["CategoryId"] = info.GetValue< System.String >("CategoryId");
            if(info.Values.ContainsKey("ProductId")) _bag["ProductId"] = info.GetValue< System.String >("ProductId");
            if(info.Values.ContainsKey("IsShoppingCart")) _bag["IsShoppingCart"] = info.GetValue< System.Boolean >("IsShoppingCart");
            if(info.Values.ContainsKey("Quantity")) _bag["Quantity"] = info.GetValue< System.Int32 >("Quantity");
        }

        #endregion
    }
}