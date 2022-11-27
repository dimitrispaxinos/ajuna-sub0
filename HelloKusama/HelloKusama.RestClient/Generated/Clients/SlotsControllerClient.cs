//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.RestClient.Generated.Interfaces;
   
   public sealed class SlotsControllerClient : BaseClient, ISlotsControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public SlotsControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseVec<BaseOpt<BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>>>> GetLeases(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
      {
         return await SendRequestAsync<BaseVec<BaseOpt<BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>>>>(_httpClient, "slots/leases", HelloKusama.NetApiExt.Generated.Storage.SlotsStorage.LeasesParams(key));
      }
      public async Task<bool> SubscribeLeases(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
      {
         return await _subscriptionClient.SubscribeAsync("Slots.Leases", HelloKusama.NetApiExt.Generated.Storage.SlotsStorage.LeasesParams(key));
      }
   }
}
