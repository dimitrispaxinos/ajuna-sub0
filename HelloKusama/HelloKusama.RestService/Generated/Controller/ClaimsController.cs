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
    /// ClaimsController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ClaimsController : ControllerBase
    {
        
        private IClaimsStorage _claimsStorage;
        
        /// <summary>
        /// ClaimsController constructor.
        /// </summary>
        public ClaimsController(IClaimsStorage claimsStorage)
        {
            _claimsStorage = claimsStorage;
        }
        
        /// <summary>
        /// >> Claims
        /// </summary>
        [HttpGet("Claims")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.ClaimsStorage), "ClaimsParams", typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_common.claims.EthereumAddress))]
        public IActionResult GetClaims(string key)
        {
            return this.Ok(_claimsStorage.GetClaims(key));
        }
        
        /// <summary>
        /// >> Total
        /// </summary>
        [HttpGet("Total")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.ClaimsStorage), "TotalParams")]
        public IActionResult GetTotal()
        {
            return this.Ok(_claimsStorage.GetTotal());
        }
        
        /// <summary>
        /// >> Vesting
        ///  Vesting schedule for a claim.
        ///  First balance is the total amount that should be held for vesting.
        ///  Second balance is how much should be unlocked per block.
        ///  The block number is when the vesting should start.
        /// </summary>
        [HttpGet("Vesting")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.NetApi.Model.Types.Primitive.U32>), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.ClaimsStorage), "VestingParams", typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_common.claims.EthereumAddress))]
        public IActionResult GetVesting(string key)
        {
            return this.Ok(_claimsStorage.GetVesting(key));
        }
        
        /// <summary>
        /// >> Signing
        ///  The statement kind that must be signed, if any.
        /// </summary>
        [HttpGet("Signing")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_common.claims.EnumStatementKind), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.ClaimsStorage), "SigningParams", typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_common.claims.EthereumAddress))]
        public IActionResult GetSigning(string key)
        {
            return this.Ok(_claimsStorage.GetSigning(key));
        }
        
        /// <summary>
        /// >> Preclaims
        ///  Pre-claimed Ethereum accounts, by the Account ID that they are claimed to.
        /// </summary>
        [HttpGet("Preclaims")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_common.claims.EthereumAddress), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.ClaimsStorage), "PreclaimsParams", typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetPreclaims(string key)
        {
            return this.Ok(_claimsStorage.GetPreclaims(key));
        }
    }
}