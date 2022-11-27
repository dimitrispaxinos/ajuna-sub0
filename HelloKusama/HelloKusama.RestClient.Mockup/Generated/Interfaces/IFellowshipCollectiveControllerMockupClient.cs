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
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.pallet_ranked_collective;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.crypto;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   
   public interface IFellowshipCollectiveControllerMockupClient
   {
      Task<bool> SetMemberCount(U32 value, U16 key);
      Task<bool> SetMembers(MemberRecord value, AccountId32 key);
      Task<bool> SetIdToIndex(U32 value, Ajuna.NetApi.Model.Types.Base.BaseTuple<U16, AccountId32> key);
      Task<bool> SetIndexToId(AccountId32 value, Ajuna.NetApi.Model.Types.Base.BaseTuple<U16, U32> key);
      Task<bool> SetVoting(EnumVoteRecord value, Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, AccountId32> key);
      Task<bool> SetVotingCleanup(BoundedVecT19 value, U32 key);
   }
}