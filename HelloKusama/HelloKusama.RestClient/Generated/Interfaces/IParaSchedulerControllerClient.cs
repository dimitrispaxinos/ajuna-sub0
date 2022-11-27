//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.scheduler;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IParaSchedulerControllerClient
   {
      Task<BaseVec<BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex>>> GetValidatorGroups();
      Task<bool> SubscribeValidatorGroups();
      Task<ParathreadClaimQueue> GetParathreadQueue();
      Task<bool> SubscribeParathreadQueue();
      Task<BaseVec<BaseOpt<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.EnumCoreOccupied>>> GetAvailabilityCores();
      Task<bool> SubscribeAvailabilityCores();
      Task<BaseVec<Id>> GetParathreadClaimIndex();
      Task<bool> SubscribeParathreadClaimIndex();
      Task<U32> GetSessionStartBlock();
      Task<bool> SubscribeSessionStartBlock();
      Task<BaseVec<CoreAssignment>> GetScheduled();
      Task<bool> SubscribeScheduled();
   }
}
