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
   using HelloKusama.NetApiExt.Generated.Model.pallet_nomination_pools;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using HelloKusama.RestClient.Generated.Interfaces;
   
   public sealed class NominationPoolsControllerClient : BaseClient, INominationPoolsControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public NominationPoolsControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U128> GetMinJoinBond()
      {
         return await SendRequestAsync<U128>(_httpClient, "nominationpools/minjoinbond");
      }
      public async Task<bool> SubscribeMinJoinBond()
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.MinJoinBond");
      }
      public async Task<U128> GetMinCreateBond()
      {
         return await SendRequestAsync<U128>(_httpClient, "nominationpools/mincreatebond");
      }
      public async Task<bool> SubscribeMinCreateBond()
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.MinCreateBond");
      }
      public async Task<U32> GetMaxPools()
      {
         return await SendRequestAsync<U32>(_httpClient, "nominationpools/maxpools");
      }
      public async Task<bool> SubscribeMaxPools()
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.MaxPools");
      }
      public async Task<U32> GetMaxPoolMembers()
      {
         return await SendRequestAsync<U32>(_httpClient, "nominationpools/maxpoolmembers");
      }
      public async Task<bool> SubscribeMaxPoolMembers()
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.MaxPoolMembers");
      }
      public async Task<U32> GetMaxPoolMembersPerPool()
      {
         return await SendRequestAsync<U32>(_httpClient, "nominationpools/maxpoolmembersperpool");
      }
      public async Task<bool> SubscribeMaxPoolMembersPerPool()
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.MaxPoolMembersPerPool");
      }
      public async Task<PoolMember> GetPoolMembers(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<PoolMember>(_httpClient, "nominationpools/poolmembers", HelloKusama.NetApiExt.Generated.Storage.NominationPoolsStorage.PoolMembersParams(key));
      }
      public async Task<bool> SubscribePoolMembers(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.PoolMembers", HelloKusama.NetApiExt.Generated.Storage.NominationPoolsStorage.PoolMembersParams(key));
      }
      public async Task<U32> GetCounterForPoolMembers()
      {
         return await SendRequestAsync<U32>(_httpClient, "nominationpools/counterforpoolmembers");
      }
      public async Task<bool> SubscribeCounterForPoolMembers()
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.CounterForPoolMembers");
      }
      public async Task<BondedPoolInner> GetBondedPools(U32 key)
      {
         return await SendRequestAsync<BondedPoolInner>(_httpClient, "nominationpools/bondedpools", HelloKusama.NetApiExt.Generated.Storage.NominationPoolsStorage.BondedPoolsParams(key));
      }
      public async Task<bool> SubscribeBondedPools(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.BondedPools", HelloKusama.NetApiExt.Generated.Storage.NominationPoolsStorage.BondedPoolsParams(key));
      }
      public async Task<U32> GetCounterForBondedPools()
      {
         return await SendRequestAsync<U32>(_httpClient, "nominationpools/counterforbondedpools");
      }
      public async Task<bool> SubscribeCounterForBondedPools()
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.CounterForBondedPools");
      }
      public async Task<RewardPool> GetRewardPools(U32 key)
      {
         return await SendRequestAsync<RewardPool>(_httpClient, "nominationpools/rewardpools", HelloKusama.NetApiExt.Generated.Storage.NominationPoolsStorage.RewardPoolsParams(key));
      }
      public async Task<bool> SubscribeRewardPools(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.RewardPools", HelloKusama.NetApiExt.Generated.Storage.NominationPoolsStorage.RewardPoolsParams(key));
      }
      public async Task<U32> GetCounterForRewardPools()
      {
         return await SendRequestAsync<U32>(_httpClient, "nominationpools/counterforrewardpools");
      }
      public async Task<bool> SubscribeCounterForRewardPools()
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.CounterForRewardPools");
      }
      public async Task<SubPools> GetSubPoolsStorage(U32 key)
      {
         return await SendRequestAsync<SubPools>(_httpClient, "nominationpools/subpoolsstorage", HelloKusama.NetApiExt.Generated.Storage.NominationPoolsStorage.SubPoolsStorageParams(key));
      }
      public async Task<bool> SubscribeSubPoolsStorage(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.SubPoolsStorage", HelloKusama.NetApiExt.Generated.Storage.NominationPoolsStorage.SubPoolsStorageParams(key));
      }
      public async Task<U32> GetCounterForSubPoolsStorage()
      {
         return await SendRequestAsync<U32>(_httpClient, "nominationpools/counterforsubpoolsstorage");
      }
      public async Task<bool> SubscribeCounterForSubPoolsStorage()
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.CounterForSubPoolsStorage");
      }
      public async Task<BoundedVecT33> GetMetadata(U32 key)
      {
         return await SendRequestAsync<BoundedVecT33>(_httpClient, "nominationpools/metadata", HelloKusama.NetApiExt.Generated.Storage.NominationPoolsStorage.MetadataParams(key));
      }
      public async Task<bool> SubscribeMetadata(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.Metadata", HelloKusama.NetApiExt.Generated.Storage.NominationPoolsStorage.MetadataParams(key));
      }
      public async Task<U32> GetCounterForMetadata()
      {
         return await SendRequestAsync<U32>(_httpClient, "nominationpools/counterformetadata");
      }
      public async Task<bool> SubscribeCounterForMetadata()
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.CounterForMetadata");
      }
      public async Task<U32> GetLastPoolId()
      {
         return await SendRequestAsync<U32>(_httpClient, "nominationpools/lastpoolid");
      }
      public async Task<bool> SubscribeLastPoolId()
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.LastPoolId");
      }
      public async Task<U32> GetReversePoolIdLookup(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<U32>(_httpClient, "nominationpools/reversepoolidlookup", HelloKusama.NetApiExt.Generated.Storage.NominationPoolsStorage.ReversePoolIdLookupParams(key));
      }
      public async Task<bool> SubscribeReversePoolIdLookup(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.ReversePoolIdLookup", HelloKusama.NetApiExt.Generated.Storage.NominationPoolsStorage.ReversePoolIdLookupParams(key));
      }
      public async Task<U32> GetCounterForReversePoolIdLookup()
      {
         return await SendRequestAsync<U32>(_httpClient, "nominationpools/counterforreversepoolidlookup");
      }
      public async Task<bool> SubscribeCounterForReversePoolIdLookup()
      {
         return await _subscriptionClient.SubscribeAsync("NominationPools.CounterForReversePoolIdLookup");
      }
   }
}
