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
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Types.Base;
   using HelloKusama.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class AuctionsControllerMockupClient : MockupBaseClient, IAuctionsControllerMockupClient
   {
      private HttpClient _httpClient;
      public AuctionsControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAuctionCounter(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Auctions/AuctionCounter", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.AuctionsStorage.AuctionCounterParams());
      }
      public async Task<bool> SetAuctionInfo(BaseTuple<U32, U32> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Auctions/AuctionInfo", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.AuctionsStorage.AuctionInfoParams());
      }
      public async Task<bool> SetReservedAmounts(U128 value, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id> key)
      {
         return await SendMockupRequestAsync(_httpClient, "Auctions/ReservedAmounts", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.AuctionsStorage.ReservedAmountsParams(key));
      }
      public async Task<bool> SetWinning(Arr36BaseOpt value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Auctions/Winning", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.AuctionsStorage.WinningParams(key));
      }
   }
}
