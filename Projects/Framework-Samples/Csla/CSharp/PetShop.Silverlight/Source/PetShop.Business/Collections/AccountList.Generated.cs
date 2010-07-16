﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'AccountList.cs'.
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
    public partial class AccountList : BusinessListBase< AccountList, Account >
    {
        #region Constructor(s)

#if !SILVERLIGHT
        private AccountList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
#else
        public AccountList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
#endif
        
        #endregion

#if !SILVERLIGHT
        #region Synchronous Factory Methods 
        
        internal static AccountList NewList()
        {
            return DataPortal.CreateChild< AccountList >();
        }     

        internal static AccountList GetByAccountId(System.Int32 accountId)
        {
			var criteria = new AccountCriteria{AccountId = accountId};
			
            
            return DataPortal.FetchChild< AccountList >(criteria);
        }

        internal static AccountList GetByUniqueID(System.Int32 uniqueID)
        {
			var criteria = new AccountCriteria{UniqueID = uniqueID};
			
            
            return DataPortal.FetchChild< AccountList >(criteria);
        }

        internal static AccountList GetAll()
        {
            return DataPortal.FetchChild< AccountList >(new AccountCriteria());
        }

		#endregion

#endif  
        #region Asynchronous Factory Methods
        
        internal static void NewAccountListAsync(EventHandler<DataPortalResult<Account>> handler)
		{
			var dp = new DataPortal<Account>();
			dp.CreateCompleted += handler;
			dp.BeginCreate();
		}
        
        //Child objects do not expose asynchronous factory get methods
 
        #endregion
        
        #region Method Overrides
        
#if !SILVERLIGHT
        protected override Account AddNewCore()
        {
            Account item = PetShop.Business.Account.NewAccount();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Business.Account.NewAccount();

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
            Account item = PetShop.Business.Account.NewAccount();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Business.Account.NewAccount();

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
			PetShop.Business.Account.NewAccountAsync((o, e) =>
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
        partial void OnFetching(AccountCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
#endif
        partial void OnAddNewCore(ref Account item, ref bool cancel);

        #endregion

        #region Exists Command

#if !SILVERLIGHT
        public static bool Exists(AccountCriteria criteria)
        {
            return PetShop.Business.Account.Exists(criteria);
        }
#endif

        #endregion

    }
}