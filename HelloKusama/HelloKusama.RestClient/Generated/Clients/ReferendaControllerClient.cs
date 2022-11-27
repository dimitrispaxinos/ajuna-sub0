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
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.pallet_referenda.types;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using HelloKusama.RestClient.Generated.Interfaces;
   
   public sealed class ReferendaControllerClient : BaseClient, IReferendaControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ReferendaControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U32> GetReferendumCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "referenda/referendumcount");
      }
      public async Task<bool> SubscribeReferendumCount()
      {
         return await _subscriptionClient.SubscribeAsync("Referenda.ReferendumCount");
      }
      public async Task<EnumReferendumInfo> GetReferendumInfoFor(U32 key)
      {
         return await SendRequestAsync<EnumReferendumInfo>(_httpClient, "referenda/referenduminfofor", HelloKusama.NetApiExt.Generated.Storage.ReferendaStorage.ReferendumInfoForParams(key));
      }
      public async Task<bool> SubscribeReferendumInfoFor(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Referenda.ReferendumInfoFor", HelloKusama.NetApiExt.Generated.Storage.ReferendaStorage.ReferendumInfoForParams(key));
      }
      public async Task<BoundedVecT18> GetTrackQueue(U16 key)
      {
         return await SendRequestAsync<BoundedVecT18>(_httpClient, "referenda/trackqueue", HelloKusama.NetApiExt.Generated.Storage.ReferendaStorage.TrackQueueParams(key));
      }
      public async Task<bool> SubscribeTrackQueue(U16 key)
      {
         return await _subscriptionClient.SubscribeAsync("Referenda.TrackQueue", HelloKusama.NetApiExt.Generated.Storage.ReferendaStorage.TrackQueueParams(key));
      }
      public async Task<U32> GetDecidingCount(U16 key)
      {
         return await SendRequestAsync<U32>(_httpClient, "referenda/decidingcount", HelloKusama.NetApiExt.Generated.Storage.ReferendaStorage.DecidingCountParams(key));
      }
      public async Task<bool> SubscribeDecidingCount(U16 key)
      {
         return await _subscriptionClient.SubscribeAsync("Referenda.DecidingCount", HelloKusama.NetApiExt.Generated.Storage.ReferendaStorage.DecidingCountParams(key));
      }
   }
}
