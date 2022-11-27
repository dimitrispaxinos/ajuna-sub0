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
   using HelloKusama.NetApiExt.Generated.Model.sp_core.crypto;
   using HelloKusama.NetApiExt.Generated.Model.sp_arithmetic.per_things;
   using HelloKusama.NetApiExt.Generated.Model.pallet_staking;
   using HelloKusama.NetApiExt.Generated.Model.pallet_staking.slashing;
   using HelloKusama.RestClient.Generated.Interfaces;
   
   public sealed class StakingControllerClient : BaseClient, IStakingControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public StakingControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U32> GetValidatorCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "staking/validatorcount");
      }
      public async Task<bool> SubscribeValidatorCount()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.ValidatorCount");
      }
      public async Task<U32> GetMinimumValidatorCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "staking/minimumvalidatorcount");
      }
      public async Task<bool> SubscribeMinimumValidatorCount()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.MinimumValidatorCount");
      }
      public async Task<BaseVec<AccountId32>> GetInvulnerables()
      {
         return await SendRequestAsync<BaseVec<AccountId32>>(_httpClient, "staking/invulnerables");
      }
      public async Task<bool> SubscribeInvulnerables()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.Invulnerables");
      }
      public async Task<AccountId32> GetBonded(AccountId32 key)
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "staking/bonded", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.BondedParams(key));
      }
      public async Task<bool> SubscribeBonded(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.Bonded", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.BondedParams(key));
      }
      public async Task<U128> GetMinNominatorBond()
      {
         return await SendRequestAsync<U128>(_httpClient, "staking/minnominatorbond");
      }
      public async Task<bool> SubscribeMinNominatorBond()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.MinNominatorBond");
      }
      public async Task<U128> GetMinValidatorBond()
      {
         return await SendRequestAsync<U128>(_httpClient, "staking/minvalidatorbond");
      }
      public async Task<bool> SubscribeMinValidatorBond()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.MinValidatorBond");
      }
      public async Task<Perbill> GetMinCommission()
      {
         return await SendRequestAsync<Perbill>(_httpClient, "staking/mincommission");
      }
      public async Task<bool> SubscribeMinCommission()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.MinCommission");
      }
      public async Task<StakingLedger> GetLedger(AccountId32 key)
      {
         return await SendRequestAsync<StakingLedger>(_httpClient, "staking/ledger", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.LedgerParams(key));
      }
      public async Task<bool> SubscribeLedger(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.Ledger", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.LedgerParams(key));
      }
      public async Task<EnumRewardDestination> GetPayee(AccountId32 key)
      {
         return await SendRequestAsync<EnumRewardDestination>(_httpClient, "staking/payee", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.PayeeParams(key));
      }
      public async Task<bool> SubscribePayee(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.Payee", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.PayeeParams(key));
      }
      public async Task<ValidatorPrefs> GetValidators(AccountId32 key)
      {
         return await SendRequestAsync<ValidatorPrefs>(_httpClient, "staking/validators", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ValidatorsParams(key));
      }
      public async Task<bool> SubscribeValidators(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.Validators", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ValidatorsParams(key));
      }
      public async Task<U32> GetCounterForValidators()
      {
         return await SendRequestAsync<U32>(_httpClient, "staking/counterforvalidators");
      }
      public async Task<bool> SubscribeCounterForValidators()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.CounterForValidators");
      }
      public async Task<U32> GetMaxValidatorsCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "staking/maxvalidatorscount");
      }
      public async Task<bool> SubscribeMaxValidatorsCount()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.MaxValidatorsCount");
      }
      public async Task<Nominations> GetNominators(AccountId32 key)
      {
         return await SendRequestAsync<Nominations>(_httpClient, "staking/nominators", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.NominatorsParams(key));
      }
      public async Task<bool> SubscribeNominators(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.Nominators", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.NominatorsParams(key));
      }
      public async Task<U32> GetCounterForNominators()
      {
         return await SendRequestAsync<U32>(_httpClient, "staking/counterfornominators");
      }
      public async Task<bool> SubscribeCounterForNominators()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.CounterForNominators");
      }
      public async Task<U32> GetMaxNominatorsCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "staking/maxnominatorscount");
      }
      public async Task<bool> SubscribeMaxNominatorsCount()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.MaxNominatorsCount");
      }
      public async Task<U32> GetCurrentEra()
      {
         return await SendRequestAsync<U32>(_httpClient, "staking/currentera");
      }
      public async Task<bool> SubscribeCurrentEra()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.CurrentEra");
      }
      public async Task<ActiveEraInfo> GetActiveEra()
      {
         return await SendRequestAsync<ActiveEraInfo>(_httpClient, "staking/activeera");
      }
      public async Task<bool> SubscribeActiveEra()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.ActiveEra");
      }
      public async Task<U32> GetErasStartSessionIndex(U32 key)
      {
         return await SendRequestAsync<U32>(_httpClient, "staking/erasstartsessionindex", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ErasStartSessionIndexParams(key));
      }
      public async Task<bool> SubscribeErasStartSessionIndex(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.ErasStartSessionIndex", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ErasStartSessionIndexParams(key));
      }
      public async Task<Exposure> GetErasStakers(BaseTuple<U32, AccountId32> key)
      {
         return await SendRequestAsync<Exposure>(_httpClient, "staking/erasstakers", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ErasStakersParams(key));
      }
      public async Task<bool> SubscribeErasStakers(BaseTuple<U32, AccountId32> key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.ErasStakers", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ErasStakersParams(key));
      }
      public async Task<Exposure> GetErasStakersClipped(BaseTuple<U32, AccountId32> key)
      {
         return await SendRequestAsync<Exposure>(_httpClient, "staking/erasstakersclipped", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ErasStakersClippedParams(key));
      }
      public async Task<bool> SubscribeErasStakersClipped(BaseTuple<U32, AccountId32> key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.ErasStakersClipped", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ErasStakersClippedParams(key));
      }
      public async Task<ValidatorPrefs> GetErasValidatorPrefs(BaseTuple<U32, AccountId32> key)
      {
         return await SendRequestAsync<ValidatorPrefs>(_httpClient, "staking/erasvalidatorprefs", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ErasValidatorPrefsParams(key));
      }
      public async Task<bool> SubscribeErasValidatorPrefs(BaseTuple<U32, AccountId32> key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.ErasValidatorPrefs", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ErasValidatorPrefsParams(key));
      }
      public async Task<U128> GetErasValidatorReward(U32 key)
      {
         return await SendRequestAsync<U128>(_httpClient, "staking/erasvalidatorreward", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ErasValidatorRewardParams(key));
      }
      public async Task<bool> SubscribeErasValidatorReward(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.ErasValidatorReward", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ErasValidatorRewardParams(key));
      }
      public async Task<EraRewardPoints> GetErasRewardPoints(U32 key)
      {
         return await SendRequestAsync<EraRewardPoints>(_httpClient, "staking/erasrewardpoints", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ErasRewardPointsParams(key));
      }
      public async Task<bool> SubscribeErasRewardPoints(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.ErasRewardPoints", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ErasRewardPointsParams(key));
      }
      public async Task<U128> GetErasTotalStake(U32 key)
      {
         return await SendRequestAsync<U128>(_httpClient, "staking/erastotalstake", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ErasTotalStakeParams(key));
      }
      public async Task<bool> SubscribeErasTotalStake(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.ErasTotalStake", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ErasTotalStakeParams(key));
      }
      public async Task<EnumForcing> GetForceEra()
      {
         return await SendRequestAsync<EnumForcing>(_httpClient, "staking/forceera");
      }
      public async Task<bool> SubscribeForceEra()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.ForceEra");
      }
      public async Task<Perbill> GetSlashRewardFraction()
      {
         return await SendRequestAsync<Perbill>(_httpClient, "staking/slashrewardfraction");
      }
      public async Task<bool> SubscribeSlashRewardFraction()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.SlashRewardFraction");
      }
      public async Task<U128> GetCanceledSlashPayout()
      {
         return await SendRequestAsync<U128>(_httpClient, "staking/canceledslashpayout");
      }
      public async Task<bool> SubscribeCanceledSlashPayout()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.CanceledSlashPayout");
      }
      public async Task<BaseVec<UnappliedSlash>> GetUnappliedSlashes(U32 key)
      {
         return await SendRequestAsync<BaseVec<UnappliedSlash>>(_httpClient, "staking/unappliedslashes", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.UnappliedSlashesParams(key));
      }
      public async Task<bool> SubscribeUnappliedSlashes(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.UnappliedSlashes", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.UnappliedSlashesParams(key));
      }
      public async Task<BaseVec<BaseTuple<U32, U32>>> GetBondedEras()
      {
         return await SendRequestAsync<BaseVec<BaseTuple<U32, U32>>>(_httpClient, "staking/bondederas");
      }
      public async Task<bool> SubscribeBondedEras()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.BondedEras");
      }
      public async Task<BaseTuple<Perbill, U128>> GetValidatorSlashInEra(BaseTuple<U32, AccountId32> key)
      {
         return await SendRequestAsync<BaseTuple<Perbill, U128>>(_httpClient, "staking/validatorslashinera", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ValidatorSlashInEraParams(key));
      }
      public async Task<bool> SubscribeValidatorSlashInEra(BaseTuple<U32, AccountId32> key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.ValidatorSlashInEra", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.ValidatorSlashInEraParams(key));
      }
      public async Task<U128> GetNominatorSlashInEra(BaseTuple<U32, AccountId32> key)
      {
         return await SendRequestAsync<U128>(_httpClient, "staking/nominatorslashinera", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.NominatorSlashInEraParams(key));
      }
      public async Task<bool> SubscribeNominatorSlashInEra(BaseTuple<U32, AccountId32> key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.NominatorSlashInEra", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.NominatorSlashInEraParams(key));
      }
      public async Task<SlashingSpans> GetSlashingSpans(AccountId32 key)
      {
         return await SendRequestAsync<SlashingSpans>(_httpClient, "staking/slashingspans", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.SlashingSpansParams(key));
      }
      public async Task<bool> SubscribeSlashingSpans(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.SlashingSpans", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.SlashingSpansParams(key));
      }
      public async Task<SpanRecord> GetSpanSlash(BaseTuple<AccountId32, U32> key)
      {
         return await SendRequestAsync<SpanRecord>(_httpClient, "staking/spanslash", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.SpanSlashParams(key));
      }
      public async Task<bool> SubscribeSpanSlash(BaseTuple<AccountId32, U32> key)
      {
         return await _subscriptionClient.SubscribeAsync("Staking.SpanSlash", HelloKusama.NetApiExt.Generated.Storage.StakingStorage.SpanSlashParams(key));
      }
      public async Task<U32> GetCurrentPlannedSession()
      {
         return await SendRequestAsync<U32>(_httpClient, "staking/currentplannedsession");
      }
      public async Task<bool> SubscribeCurrentPlannedSession()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.CurrentPlannedSession");
      }
      public async Task<BaseVec<BaseTuple<U32, Bool>>> GetOffendingValidators()
      {
         return await SendRequestAsync<BaseVec<BaseTuple<U32, Bool>>>(_httpClient, "staking/offendingvalidators");
      }
      public async Task<bool> SubscribeOffendingValidators()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.OffendingValidators");
      }
      public async Task<EnumReleases> GetStorageVersion()
      {
         return await SendRequestAsync<EnumReleases>(_httpClient, "staking/storageversion");
      }
      public async Task<bool> SubscribeStorageVersion()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.StorageVersion");
      }
      public async Task<Percent> GetChillThreshold()
      {
         return await SendRequestAsync<Percent>(_httpClient, "staking/chillthreshold");
      }
      public async Task<bool> SubscribeChillThreshold()
      {
         return await _subscriptionClient.SubscribeAsync("Staking.ChillThreshold");
      }
   }
}
