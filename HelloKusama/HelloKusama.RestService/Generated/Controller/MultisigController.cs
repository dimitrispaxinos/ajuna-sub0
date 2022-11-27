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
    /// MultisigController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class MultisigController : ControllerBase
    {
        
        private IMultisigStorage _multisigStorage;
        
        /// <summary>
        /// MultisigController constructor.
        /// </summary>
        public MultisigController(IMultisigStorage multisigStorage)
        {
            _multisigStorage = multisigStorage;
        }
        
        /// <summary>
        /// >> Multisigs
        ///  The set of open multisig operations.
        /// </summary>
        [HttpGet("Multisigs")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.pallet_multisig.Multisig), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.MultisigStorage), "MultisigsParams", typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Types.Base.Arr32U8>))]
        public IActionResult GetMultisigs(string key)
        {
            return this.Ok(_multisigStorage.GetMultisigs(key));
        }
    }
}
