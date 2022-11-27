//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.ServiceLayer.Attributes;
using Ajuna.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace HelloKusama.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IBalancesStorage interface definition.
    /// </summary>
    public interface IBalancesStorage : IStorage
    {
        
        /// <summary>
        /// >> TotalIssuance
        ///  The total units issued in the system.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U128 GetTotalIssuance();
        
        /// <summary>
        /// >> Account
        ///  The Balances pallet example of storing the balance of an account.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///     type AccountStore = StorageMapShim<Self::Account<Runtime>, frame_system::Provider<Runtime>, AccountId, Self::AccountData<Balance>>
        ///   }
        ///  ```
        /// 
        ///  You can also store the balance of an account in the `System` pallet.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///    type AccountStore = System
        ///   }
        ///  ```
        /// 
        ///  But this comes with tradeoffs, storing account balances in the system pallet stores
        ///  `frame_system` data alongside the account data contrary to storing account balances in the
        ///  `Balances` pallet, which uses a `StorageMap` to store balances data only.
        ///  NOTE: This is only used in the case that this pallet is used to store balances.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.pallet_balances.AccountData GetAccount(string key);
        
        /// <summary>
        /// >> Locks
        ///  Any liquidity locks on some account balances.
        ///  NOTE: Should only be accessed when setting, changing and freeing a lock.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT3 GetLocks(string key);
        
        /// <summary>
        /// >> Reserves
        ///  Named reserves on some account balances.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4 GetReserves(string key);
        
        /// <summary>
        /// >> StorageVersion
        ///  Storage version of the pallet.
        /// 
        ///  This is set to v2.0.0 for new networks.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.pallet_balances.EnumReleases GetStorageVersion();
    }
    
    /// <summary>
    /// BalancesStorage class definition.
    /// </summary>
    public sealed class BalancesStorage : IBalancesStorage
    {
        
        /// <summary>
        /// _totalIssuanceTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U128> _totalIssuanceTypedStorage;
        
        /// <summary>
        /// _accountTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.pallet_balances.AccountData> _accountTypedStorage;
        
        /// <summary>
        /// _locksTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT3> _locksTypedStorage;
        
        /// <summary>
        /// _reservesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4> _reservesTypedStorage;
        
        /// <summary>
        /// _storageVersionTypedStorage typed storage field
        /// </summary>
        private TypedStorage<HelloKusama.NetApiExt.Generated.Model.pallet_balances.EnumReleases> _storageVersionTypedStorage;
        
        /// <summary>
        /// BalancesStorage constructor.
        /// </summary>
        public BalancesStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.TotalIssuanceTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U128>("Balances.TotalIssuance", storageDataProvider, storageChangeDelegates);
            this.AccountTypedStorage = new TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.pallet_balances.AccountData>("Balances.Account", storageDataProvider, storageChangeDelegates);
            this.LocksTypedStorage = new TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT3>("Balances.Locks", storageDataProvider, storageChangeDelegates);
            this.ReservesTypedStorage = new TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4>("Balances.Reserves", storageDataProvider, storageChangeDelegates);
            this.StorageVersionTypedStorage = new TypedStorage<HelloKusama.NetApiExt.Generated.Model.pallet_balances.EnumReleases>("Balances.StorageVersion", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _totalIssuanceTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U128> TotalIssuanceTypedStorage
        {
            get
            {
                return _totalIssuanceTypedStorage;
            }
            set
            {
                _totalIssuanceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _accountTypedStorage property
        /// </summary>
        public TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.pallet_balances.AccountData> AccountTypedStorage
        {
            get
            {
                return _accountTypedStorage;
            }
            set
            {
                _accountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _locksTypedStorage property
        /// </summary>
        public TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT3> LocksTypedStorage
        {
            get
            {
                return _locksTypedStorage;
            }
            set
            {
                _locksTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _reservesTypedStorage property
        /// </summary>
        public TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4> ReservesTypedStorage
        {
            get
            {
                return _reservesTypedStorage;
            }
            set
            {
                _reservesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _storageVersionTypedStorage property
        /// </summary>
        public TypedStorage<HelloKusama.NetApiExt.Generated.Model.pallet_balances.EnumReleases> StorageVersionTypedStorage
        {
            get
            {
                return _storageVersionTypedStorage;
            }
            set
            {
                _storageVersionTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await TotalIssuanceTypedStorage.InitializeAsync("Balances", "TotalIssuance");
            await AccountTypedStorage.InitializeAsync("Balances", "Account");
            await LocksTypedStorage.InitializeAsync("Balances", "Locks");
            await ReservesTypedStorage.InitializeAsync("Balances", "Reserves");
            await StorageVersionTypedStorage.InitializeAsync("Balances", "StorageVersion");
        }
        
        /// <summary>
        /// Implements any storage change for Balances.TotalIssuance
        /// </summary>
        [StorageChange("Balances", "TotalIssuance")]
        public void OnUpdateTotalIssuance(string data)
        {
            TotalIssuanceTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> TotalIssuance
        ///  The total units issued in the system.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U128 GetTotalIssuance()
        {
            return TotalIssuanceTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Balances.Account
        /// </summary>
        [StorageChange("Balances", "Account")]
        public void OnUpdateAccount(string key, string data)
        {
            AccountTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Account
        ///  The Balances pallet example of storing the balance of an account.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///     type AccountStore = StorageMapShim<Self::Account<Runtime>, frame_system::Provider<Runtime>, AccountId, Self::AccountData<Balance>>
        ///   }
        ///  ```
        /// 
        ///  You can also store the balance of an account in the `System` pallet.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///    type AccountStore = System
        ///   }
        ///  ```
        /// 
        ///  But this comes with tradeoffs, storing account balances in the system pallet stores
        ///  `frame_system` data alongside the account data contrary to storing account balances in the
        ///  `Balances` pallet, which uses a `StorageMap` to store balances data only.
        ///  NOTE: This is only used in the case that this pallet is used to store balances.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.pallet_balances.AccountData GetAccount(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AccountTypedStorage.Dictionary.TryGetValue(key, out HelloKusama.NetApiExt.Generated.Model.pallet_balances.AccountData result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Balances.Locks
        /// </summary>
        [StorageChange("Balances", "Locks")]
        public void OnUpdateLocks(string key, string data)
        {
            LocksTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Locks
        ///  Any liquidity locks on some account balances.
        ///  NOTE: Should only be accessed when setting, changing and freeing a lock.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT3 GetLocks(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (LocksTypedStorage.Dictionary.TryGetValue(key, out HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT3 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Balances.Reserves
        /// </summary>
        [StorageChange("Balances", "Reserves")]
        public void OnUpdateReserves(string key, string data)
        {
            ReservesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Reserves
        ///  Named reserves on some account balances.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4 GetReserves(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ReservesTypedStorage.Dictionary.TryGetValue(key, out HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Balances.StorageVersion
        /// </summary>
        [StorageChange("Balances", "StorageVersion")]
        public void OnUpdateStorageVersion(string data)
        {
            StorageVersionTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> StorageVersion
        ///  Storage version of the pallet.
        /// 
        ///  This is set to v2.0.0 for new networks.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.pallet_balances.EnumReleases GetStorageVersion()
        {
            return StorageVersionTypedStorage.Get();
        }
    }
}
