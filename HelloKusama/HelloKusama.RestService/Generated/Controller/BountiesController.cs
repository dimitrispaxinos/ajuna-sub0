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
    /// BountiesController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class BountiesController : ControllerBase
    {
        
        private IBountiesStorage _bountiesStorage;
        
        /// <summary>
        /// BountiesController constructor.
        /// </summary>
        public BountiesController(IBountiesStorage bountiesStorage)
        {
            _bountiesStorage = bountiesStorage;
        }
        
        /// <summary>
        /// >> BountyCount
        ///  Number of bounty proposals that have been made.
        /// </summary>
        [HttpGet("BountyCount")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.BountiesStorage), "BountyCountParams")]
        public IActionResult GetBountyCount()
        {
            return this.Ok(_bountiesStorage.GetBountyCount());
        }
        
        /// <summary>
        /// >> Bounties
        ///  Bounties that have been made.
        /// </summary>
        [HttpGet("Bounties")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.pallet_bounties.Bounty), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.BountiesStorage), "BountiesParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetBounties(string key)
        {
            return this.Ok(_bountiesStorage.GetBounties(key));
        }
        
        /// <summary>
        /// >> BountyDescriptions
        ///  The description of each bounty.
        /// </summary>
        [HttpGet("BountyDescriptions")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT30), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.BountiesStorage), "BountyDescriptionsParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetBountyDescriptions(string key)
        {
            return this.Ok(_bountiesStorage.GetBountyDescriptions(key));
        }
        
        /// <summary>
        /// >> BountyApprovals
        ///  Bounty indices that have been approved but not yet funded.
        /// </summary>
        [HttpGet("BountyApprovals")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT15), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.BountiesStorage), "BountyApprovalsParams")]
        public IActionResult GetBountyApprovals()
        {
            return this.Ok(_bountiesStorage.GetBountyApprovals());
        }
    }
}
