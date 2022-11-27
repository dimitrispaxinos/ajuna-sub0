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
    /// PreimageController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class PreimageController : ControllerBase
    {
        
        private IPreimageStorage _preimageStorage;
        
        /// <summary>
        /// PreimageController constructor.
        /// </summary>
        public PreimageController(IPreimageStorage preimageStorage)
        {
            _preimageStorage = preimageStorage;
        }
        
        /// <summary>
        /// >> StatusFor
        ///  The request status of a given hash.
        /// </summary>
        [HttpGet("StatusFor")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.pallet_preimage.EnumRequestStatus), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.PreimageStorage), "StatusForParams", typeof(HelloKusama.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetStatusFor(string key)
        {
            return this.Ok(_preimageStorage.GetStatusFor(key));
        }
        
        /// <summary>
        /// >> PreimageFor
        /// </summary>
        [HttpGet("PreimageFor")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT29), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.PreimageStorage), "PreimageForParams", typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Primitive.U32>))]
        public IActionResult GetPreimageFor(string key)
        {
            return this.Ok(_preimageStorage.GetPreimageFor(key));
        }
    }
}