//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace HelloKusama.NetApiExt.Generated.Storage
{
    
    
    public sealed class BalancesStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public BalancesStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Balances", "TotalIssuance"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Balances", "Account"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(HelloKusama.NetApiExt.Generated.Model.pallet_balances.AccountData)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Balances", "Locks"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT3)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Balances", "Reserves"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Balances", "StorageVersion"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(HelloKusama.NetApiExt.Generated.Model.pallet_balances.EnumReleases)));
        }
        
        /// <summary>
        /// >> TotalIssuanceParams
        ///  The total units issued in the system.
        /// </summary>
        public static string TotalIssuanceParams()
        {
            return RequestGenerator.GetStorage("Balances", "TotalIssuance", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> TotalIssuance
        ///  The total units issued in the system.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U128> TotalIssuance(CancellationToken token)
        {
            string parameters = BalancesStorage.TotalIssuanceParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U128>(parameters, token);
        }
        
        /// <summary>
        /// >> AccountParams
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
        public static string AccountParams(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Balances", "Account", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
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
        public async Task<HelloKusama.NetApiExt.Generated.Model.pallet_balances.AccountData> Account(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = BalancesStorage.AccountParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.pallet_balances.AccountData>(parameters, token);
        }
        
        /// <summary>
        /// >> LocksParams
        ///  Any liquidity locks on some account balances.
        ///  NOTE: Should only be accessed when setting, changing and freeing a lock.
        /// </summary>
        public static string LocksParams(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Balances", "Locks", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Locks
        ///  Any liquidity locks on some account balances.
        ///  NOTE: Should only be accessed when setting, changing and freeing a lock.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT3> Locks(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = BalancesStorage.LocksParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT3>(parameters, token);
        }
        
        /// <summary>
        /// >> ReservesParams
        ///  Named reserves on some account balances.
        /// </summary>
        public static string ReservesParams(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Balances", "Reserves", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Reserves
        ///  Named reserves on some account balances.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4> Reserves(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = BalancesStorage.ReservesParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4>(parameters, token);
        }
        
        /// <summary>
        /// >> StorageVersionParams
        ///  Storage version of the pallet.
        /// 
        ///  This is set to v2.0.0 for new networks.
        /// </summary>
        public static string StorageVersionParams()
        {
            return RequestGenerator.GetStorage("Balances", "StorageVersion", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> StorageVersion
        ///  Storage version of the pallet.
        /// 
        ///  This is set to v2.0.0 for new networks.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.pallet_balances.EnumReleases> StorageVersion(CancellationToken token)
        {
            string parameters = BalancesStorage.StorageVersionParams();
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.pallet_balances.EnumReleases>(parameters, token);
        }
    }
    
    public sealed class BalancesCalls
    {
        
        /// <summary>
        /// >> transfer
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Transfer(HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(4, "Balances", 0, "transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_balance
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetBalance(HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> new_free, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> new_reserved)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(new_free.Encode());
            byteArray.AddRange(new_reserved.Encode());
            return new Method(4, "Balances", 1, "set_balance", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_transfer
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceTransfer(HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress source, HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(source.Encode());
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(4, "Balances", 2, "force_transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_keep_alive
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method TransferKeepAlive(HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(4, "Balances", 3, "transfer_keep_alive", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_all
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method TransferAll(HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Ajuna.NetApi.Model.Types.Primitive.Bool keep_alive)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(keep_alive.Encode());
            return new Method(4, "Balances", 4, "transfer_all", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_unreserve
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceUnreserve(HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who, Ajuna.NetApi.Model.Types.Primitive.U128 amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(amount.Encode());
            return new Method(4, "Balances", 5, "force_unreserve", byteArray.ToArray());
        }
    }
    
    public enum BalancesErrors
    {
        
        /// <summary>
        /// >> VestingBalance
        /// Vesting balance too high to send value
        /// </summary>
        VestingBalance,
        
        /// <summary>
        /// >> LiquidityRestrictions
        /// Account liquidity restrictions prevent withdrawal
        /// </summary>
        LiquidityRestrictions,
        
        /// <summary>
        /// >> InsufficientBalance
        /// Balance too low to send value
        /// </summary>
        InsufficientBalance,
        
        /// <summary>
        /// >> ExistentialDeposit
        /// Value too low to create account due to existential deposit
        /// </summary>
        ExistentialDeposit,
        
        /// <summary>
        /// >> KeepAlive
        /// Transfer/payment would kill account
        /// </summary>
        KeepAlive,
        
        /// <summary>
        /// >> ExistingVestingSchedule
        /// A vesting schedule already exists for this account
        /// </summary>
        ExistingVestingSchedule,
        
        /// <summary>
        /// >> DeadAccount
        /// Beneficiary account must pre-exist
        /// </summary>
        DeadAccount,
        
        /// <summary>
        /// >> TooManyReserves
        /// Number of named reserves exceed MaxReserves
        /// </summary>
        TooManyReserves,
    }
}
