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
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_common.claims;
   using HelloKusama.RestClient.Generated.Interfaces;
   
   public sealed class ClaimsControllerClient : BaseClient, IClaimsControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ClaimsControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U128> GetClaims(EthereumAddress key)
      {
         return await SendRequestAsync<U128>(_httpClient, "claims/claims", HelloKusama.NetApiExt.Generated.Storage.ClaimsStorage.ClaimsParams(key));
      }
      public async Task<bool> SubscribeClaims(EthereumAddress key)
      {
         return await _subscriptionClient.SubscribeAsync("Claims.Claims", HelloKusama.NetApiExt.Generated.Storage.ClaimsStorage.ClaimsParams(key));
      }
      public async Task<U128> GetTotal()
      {
         return await SendRequestAsync<U128>(_httpClient, "claims/total");
      }
      public async Task<bool> SubscribeTotal()
      {
         return await _subscriptionClient.SubscribeAsync("Claims.Total");
      }
      public async Task<BaseTuple<U128, U128, U32>> GetVesting(EthereumAddress key)
      {
         return await SendRequestAsync<BaseTuple<U128, U128, U32>>(_httpClient, "claims/vesting", HelloKusama.NetApiExt.Generated.Storage.ClaimsStorage.VestingParams(key));
      }
      public async Task<bool> SubscribeVesting(EthereumAddress key)
      {
         return await _subscriptionClient.SubscribeAsync("Claims.Vesting", HelloKusama.NetApiExt.Generated.Storage.ClaimsStorage.VestingParams(key));
      }
      public async Task<EnumStatementKind> GetSigning(EthereumAddress key)
      {
         return await SendRequestAsync<EnumStatementKind>(_httpClient, "claims/signing", HelloKusama.NetApiExt.Generated.Storage.ClaimsStorage.SigningParams(key));
      }
      public async Task<bool> SubscribeSigning(EthereumAddress key)
      {
         return await _subscriptionClient.SubscribeAsync("Claims.Signing", HelloKusama.NetApiExt.Generated.Storage.ClaimsStorage.SigningParams(key));
      }
      public async Task<EthereumAddress> GetPreclaims(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<EthereumAddress>(_httpClient, "claims/preclaims", HelloKusama.NetApiExt.Generated.Storage.ClaimsStorage.PreclaimsParams(key));
      }
      public async Task<bool> SubscribePreclaims(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Claims.Preclaims", HelloKusama.NetApiExt.Generated.Storage.ClaimsStorage.PreclaimsParams(key));
      }
   }
}
