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
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2;
   
   public interface IParaInherentControllerClient
   {
      Task<BaseTuple> GetIncluded();
      Task<bool> SubscribeIncluded();
      Task<ScrapedOnChainVotes> GetOnChainVotes();
      Task<bool> SubscribeOnChainVotes();
   }
}
