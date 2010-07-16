﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'CartList.cs'.
//
//     Template: EditableChildList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;

using Csla;
#if SILVERLIGHT
using Csla.Serialization;
#else
using Csla.Data;
#endif

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class CartList : BusinessListBase< CartList, Cart >
    {
        #region Constructor(s)

#if !SILVERLIGHT
        private CartList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
#else
        public CartList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
#endif
        
        #endregion

#if !SILVERLIGHT
        #region Synchronous Factory Methods 
        
        internal static CartList NewList()
        {
            return DataPortal.CreateChild< CartList >();
        }     

        internal static CartList GetByCartId(System.Int32 cartId)
        {
			var criteria = new CartCriteria{CartId = cartId};
			
            
            return DataPortal.FetchChild< CartList >(criteria);
        }

        internal static CartList GetByUniqueID(System.Int32 uniqueID)
        {
			var criteria = new CartCriteria{UniqueID = uniqueID};
			
            
            return DataPortal.FetchChild< CartList >(criteria);
        }

        internal static CartList GetByIsShoppingCart(System.Boolean isShoppingCart)
        {
			var criteria = new CartCriteria{IsShoppingCart = isShoppingCart};
			
            
            return DataPortal.FetchChild< CartList >(criteria);
        }

        internal static CartList GetAll()
        {
            return DataPortal.FetchChild< CartList >(new CartCriteria());
        }

		#endregion

#endif  
        #region Asynchronous Factory Methods
        
        internal static void NewCartListAsync(EventHandler<DataPortalResult<Cart>> handler)
		{
			var dp = new DataPortal<Cart>();
			dp.CreateCompleted += handler;
			dp.BeginCreate();
		}
        
        //Child objects do not expose asynchronous factory get methods
 
        #endregion
        
        #region Method Overrides
        
#if !SILVERLIGHT
        protected override Cart AddNewCore()
        {
            Cart item = PetShop.Business.Cart.NewCart();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Business.Cart.NewCart();

                // Pass the parent value down to the child.
                Profile profile = this.Parent as Profile;
                if(profile != null)
                    item.UniqueID = profile.UniqueID;


                Add(item);
            }

            return item;
        }
#else
        protected override void AddNewCore()
        {
            Cart item = PetShop.Business.Cart.NewCart();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Business.Cart.NewCart();

                // Pass the parent value down to the child.
                Profile profile = this.Parent as Profile;
                if(profile != null)
                    item.UniqueID = profile.UniqueID;


                Add(item);
            }
        }
#endif
		protected void AddNewCoreAsync(EventHandler<DataPortalResult<object>> handler)
		{
			PetShop.Business.Cart.NewCartAsync((o, e) =>
			{
				if(e.Error == null)
				{
					Add(e.Object);
					handler.Invoke(this, new DataPortalResult<object>(e.Object, null, null));
				}
			});
		}

        
        #endregion

        #region DataPortal partial methods

#if !SILVERLIGHT
        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(CartCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
#endif
        partial void OnAddNewCore(ref Cart item, ref bool cancel);

        #endregion

        #region Exists Command

#if !SILVERLIGHT
        public static bool Exists(CartCriteria criteria)
        {
            return PetShop.Business.Cart.Exists(criteria);
        }
#endif

        #endregion

    }
}