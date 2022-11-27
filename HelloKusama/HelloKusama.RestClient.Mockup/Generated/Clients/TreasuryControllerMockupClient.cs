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
   using HelloKusama.NetApiExt.Generated.Model.pallet_treasury;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using HelloKusama.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class TreasuryControllerMockupClient : MockupBaseClient, ITreasuryControllerMockupClient
   {
      private HttpClient _httpClient;
      public TreasuryControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetProposalCount(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Treasury/ProposalCount", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.TreasuryStorage.ProposalCountParams());
      }
      public async Task<bool> SetProposals(Proposal value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Treasury/Proposals", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.TreasuryStorage.ProposalsParams(key));
      }
      public async Task<bool> SetApprovals(BoundedVecT15 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Treasury/Approvals", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.TreasuryStorage.ApprovalsParams());
      }
   }
}