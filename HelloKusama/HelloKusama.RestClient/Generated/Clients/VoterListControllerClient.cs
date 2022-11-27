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
   using HelloKusama.NetApiExt.Generated.Model.pallet_bags_list.list;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.RestClient.Generated.Interfaces;
   
   public sealed class VoterListControllerClient : BaseClient, IVoterListControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public VoterListControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<Node> GetListNodes(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<Node>(_httpClient, "voterlist/listnodes", HelloKusama.NetApiExt.Generated.Storage.VoterListStorage.ListNodesParams(key));
      }
      public async Task<bool> SubscribeListNodes(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("VoterList.ListNodes", HelloKusama.NetApiExt.Generated.Storage.VoterListStorage.ListNodesParams(key));
      }
      public async Task<U32> GetCounterForListNodes()
      {
         return await SendRequestAsync<U32>(_httpClient, "voterlist/counterforlistnodes");
      }
      public async Task<bool> SubscribeCounterForListNodes()
      {
         return await _subscriptionClient.SubscribeAsync("VoterList.CounterForListNodes");
      }
      public async Task<Bag> GetListBags(U64 key)
      {
         return await SendRequestAsync<Bag>(_httpClient, "voterlist/listbags", HelloKusama.NetApiExt.Generated.Storage.VoterListStorage.ListBagsParams(key));
      }
      public async Task<bool> SubscribeListBags(U64 key)
      {
         return await _subscriptionClient.SubscribeAsync("VoterList.ListBags", HelloKusama.NetApiExt.Generated.Storage.VoterListStorage.ListBagsParams(key));
      }
   }
}
