//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.scheduler;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IParaSchedulerControllerMockupClient
   {
      Task<bool> SetValidatorGroups(BaseVec<BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex>> value);
      Task<bool> SetParathreadQueue(ParathreadClaimQueue value);
      Task<bool> SetAvailabilityCores(BaseVec<BaseOpt<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.EnumCoreOccupied>> value);
      Task<bool> SetParathreadClaimIndex(BaseVec<Id> value);
      Task<bool> SetSessionStartBlock(U32 value);
      Task<bool> SetScheduled(BaseVec<CoreAssignment> value);
   }
}
