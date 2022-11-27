//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.initializer;
   
   public interface IInitializerControllerClient
   {
      Task<BaseTuple> GetHasInitialized();
      Task<bool> SubscribeHasInitialized();
      Task<BaseVec<BufferedSessionChange>> GetBufferedSessionChanges();
      Task<bool> SubscribeBufferedSessionChanges();
   }
}