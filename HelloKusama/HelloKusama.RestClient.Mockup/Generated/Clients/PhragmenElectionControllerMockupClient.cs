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
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.pallet_elections_phragmen;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class PhragmenElectionControllerMockupClient : MockupBaseClient, IPhragmenElectionControllerMockupClient
   {
      private HttpClient _httpClient;
      public PhragmenElectionControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetMembers(BaseVec<SeatHolder> value)
      {
         return await SendMockupRequestAsync(_httpClient, "PhragmenElection/Members", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.PhragmenElectionStorage.MembersParams());
      }
      public async Task<bool> SetRunnersUp(BaseVec<SeatHolder> value)
      {
         return await SendMockupRequestAsync(_httpClient, "PhragmenElection/RunnersUp", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.PhragmenElectionStorage.RunnersUpParams());
      }
      public async Task<bool> SetCandidates(BaseVec<BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, U128>> value)
      {
         return await SendMockupRequestAsync(_httpClient, "PhragmenElection/Candidates", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.PhragmenElectionStorage.CandidatesParams());
      }
      public async Task<bool> SetElectionRounds(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "PhragmenElection/ElectionRounds", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.PhragmenElectionStorage.ElectionRoundsParams());
      }
      public async Task<bool> SetVoting(Voter value, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "PhragmenElection/Voting", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.PhragmenElectionStorage.VotingParams(key));
      }
   }
}