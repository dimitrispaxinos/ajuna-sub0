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
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using HelloKusama.NetApiExt.Generated.Model.pallet_vesting;
   using HelloKusama.RestClient.Generated.Interfaces;
   
   public sealed class VestingControllerClient : BaseClient, IVestingControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public VestingControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT25> GetVesting(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BoundedVecT25>(_httpClient, "vesting/vesting", HelloKusama.NetApiExt.Generated.Storage.VestingStorage.VestingParams(key));
      }
      public async Task<bool> SubscribeVesting(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Vesting.Vesting", HelloKusama.NetApiExt.Generated.Storage.VestingStorage.VestingParams(key));
      }
      public async Task<EnumReleases> GetStorageVersion()
      {
         return await SendRequestAsync<EnumReleases>(_httpClient, "vesting/storageversion");
      }
      public async Task<bool> SubscribeStorageVersion()
      {
         return await _subscriptionClient.SubscribeAsync("Vesting.StorageVersion");
      }
   }
}