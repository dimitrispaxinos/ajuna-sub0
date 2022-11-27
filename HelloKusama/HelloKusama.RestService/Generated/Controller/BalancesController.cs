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
using HelloKusama.RestService.Generated.Storage;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace HelloKusama.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// BalancesController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class BalancesController : ControllerBase
    {
        
        private IBalancesStorage _balancesStorage;
        
        /// <summary>
        /// BalancesController constructor.
        /// </summary>
        public BalancesController(IBalancesStorage balancesStorage)
        {
            _balancesStorage = balancesStorage;
        }
        
        /// <summary>
        /// >> TotalIssuance
        ///  The total units issued in the system.
        /// </summary>
        [HttpGet("TotalIssuance")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.BalancesStorage), "TotalIssuanceParams")]
        public IActionResult GetTotalIssuance()
        {
            return this.Ok(_balancesStorage.GetTotalIssuance());
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
        [HttpGet("Account")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.pallet_balances.AccountData), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.BalancesStorage), "AccountParams", typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetAccount(string key)
        {
            return this.Ok(_balancesStorage.GetAccount(key));
        }
        
        /// <summary>
        /// >> Locks
        ///  Any liquidity locks on some account balances.
        ///  NOTE: Should only be accessed when setting, changing and freeing a lock.
        /// </summary>
        [HttpGet("Locks")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT3), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.BalancesStorage), "LocksParams", typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetLocks(string key)
        {
            return this.Ok(_balancesStorage.GetLocks(key));
        }
        
        /// <summary>
        /// >> Reserves
        ///  Named reserves on some account balances.
        /// </summary>
        [HttpGet("Reserves")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT4), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.BalancesStorage), "ReservesParams", typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetReserves(string key)
        {
            return this.Ok(_balancesStorage.GetReserves(key));
        }
        
        /// <summary>
        /// >> StorageVersion
        ///  Storage version of the pallet.
        /// 
        ///  This is set to v2.0.0 for new networks.
        /// </summary>
        [HttpGet("StorageVersion")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.pallet_balances.EnumReleases), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.BalancesStorage), "StorageVersionParams")]
        public IActionResult GetStorageVersion()
        {
            return this.Ok(_balancesStorage.GetStorageVersion());
        }
    }
}
