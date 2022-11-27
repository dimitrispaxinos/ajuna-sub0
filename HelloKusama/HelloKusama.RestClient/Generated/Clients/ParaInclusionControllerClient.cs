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
   using HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2;
   using HelloKusama.RestClient.Generated.Interfaces;
   
   public sealed class ParaInclusionControllerClient : BaseClient, IParaInclusionControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ParaInclusionControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<AvailabilityBitfieldRecord> GetAvailabilityBitfields(ValidatorIndex key)
      {
         return await SendRequestAsync<AvailabilityBitfieldRecord>(_httpClient, "parainclusion/availabilitybitfields", HelloKusama.NetApiExt.Generated.Storage.ParaInclusionStorage.AvailabilityBitfieldsParams(key));
      }
      public async Task<bool> SubscribeAvailabilityBitfields(ValidatorIndex key)
      {
         return await _subscriptionClient.SubscribeAsync("ParaInclusion.AvailabilityBitfields", HelloKusama.NetApiExt.Generated.Storage.ParaInclusionStorage.AvailabilityBitfieldsParams(key));
      }
      public async Task<CandidatePendingAvailability> GetPendingAvailability(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
      {
         return await SendRequestAsync<CandidatePendingAvailability>(_httpClient, "parainclusion/pendingavailability", HelloKusama.NetApiExt.Generated.Storage.ParaInclusionStorage.PendingAvailabilityParams(key));
      }
      public async Task<bool> SubscribePendingAvailability(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
      {
         return await _subscriptionClient.SubscribeAsync("ParaInclusion.PendingAvailability", HelloKusama.NetApiExt.Generated.Storage.ParaInclusionStorage.PendingAvailabilityParams(key));
      }
      public async Task<CandidateCommitments> GetPendingAvailabilityCommitments(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
      {
         return await SendRequestAsync<CandidateCommitments>(_httpClient, "parainclusion/pendingavailabilitycommitments", HelloKusama.NetApiExt.Generated.Storage.ParaInclusionStorage.PendingAvailabilityCommitmentsParams(key));
      }
      public async Task<bool> SubscribePendingAvailabilityCommitments(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
      {
         return await _subscriptionClient.SubscribeAsync("ParaInclusion.PendingAvailabilityCommitments", HelloKusama.NetApiExt.Generated.Storage.ParaInclusionStorage.PendingAvailabilityCommitmentsParams(key));
      }
   }
}
