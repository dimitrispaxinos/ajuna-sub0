//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.pallet_democracy.types;
   using HelloKusama.NetApiExt.Generated.Model.pallet_democracy.vote;
   using HelloKusama.NetApiExt.Generated.Model.frame_support.traits.preimages;
   using HelloKusama.NetApiExt.Generated.Model.pallet_democracy.vote_threshold;
   using HelloKusama.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class DemocracyControllerMockupClient : MockupBaseClient, IDemocracyControllerMockupClient
   {
      private HttpClient _httpClient;
      public DemocracyControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetPublicPropCount(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Democracy/PublicPropCount", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.DemocracyStorage.PublicPropCountParams());
      }
      public async Task<bool> SetPublicProps(BoundedVecT9 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Democracy/PublicProps", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.DemocracyStorage.PublicPropsParams());
      }
      public async Task<bool> SetDepositOf(BaseTuple<BoundedVecT10, U128> value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Democracy/DepositOf", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.DemocracyStorage.DepositOfParams(key));
      }
      public async Task<bool> SetReferendumCount(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Democracy/ReferendumCount", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.DemocracyStorage.ReferendumCountParams());
      }
      public async Task<bool> SetLowestUnbaked(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Democracy/LowestUnbaked", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.DemocracyStorage.LowestUnbakedParams());
      }
      public async Task<bool> SetReferendumInfoOf(EnumReferendumInfo value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Democracy/ReferendumInfoOf", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.DemocracyStorage.ReferendumInfoOfParams(key));
      }
      public async Task<bool> SetVotingOf(EnumVoting value, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Democracy/VotingOf", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.DemocracyStorage.VotingOfParams(key));
      }
      public async Task<bool> SetLastTabledWasExternal(Bool value)
      {
         return await SendMockupRequestAsync(_httpClient, "Democracy/LastTabledWasExternal", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.DemocracyStorage.LastTabledWasExternalParams());
      }
      public async Task<bool> SetNextExternal(BaseTuple<EnumBounded, EnumVoteThreshold> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Democracy/NextExternal", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.DemocracyStorage.NextExternalParams());
      }
      public async Task<bool> SetBlacklist(BaseTuple<U32, BoundedVecT10> value, HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Democracy/Blacklist", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.DemocracyStorage.BlacklistParams(key));
      }
      public async Task<bool> SetCancellations(Bool value, HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Democracy/Cancellations", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.DemocracyStorage.CancellationsParams(key));
      }
   }
}
