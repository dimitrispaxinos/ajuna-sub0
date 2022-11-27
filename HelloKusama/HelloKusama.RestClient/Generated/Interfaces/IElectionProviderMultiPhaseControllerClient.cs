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
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.pallet_election_provider_multi_phase;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_btree_map;
   using HelloKusama.NetApiExt.Generated.Model.pallet_election_provider_multi_phase.signed;
   using HelloKusama.NetApiExt.Generated.Model.sp_npos_elections;
   
   public interface IElectionProviderMultiPhaseControllerClient
   {
      Task<U32> GetRound();
      Task<bool> SubscribeRound();
      Task<EnumPhase> GetCurrentPhase();
      Task<bool> SubscribeCurrentPhase();
      Task<ReadySolution> GetQueuedSolution();
      Task<bool> SubscribeQueuedSolution();
      Task<RoundSnapshot> GetSnapshot();
      Task<bool> SubscribeSnapshot();
      Task<U32> GetDesiredTargets();
      Task<bool> SubscribeDesiredTargets();
      Task<SolutionOrSnapshotSize> GetSnapshotMetadata();
      Task<bool> SubscribeSnapshotMetadata();
      Task<U32> GetSignedSubmissionNextIndex();
      Task<bool> SubscribeSignedSubmissionNextIndex();
      Task<BoundedBTreeMapT1> GetSignedSubmissionIndices();
      Task<bool> SubscribeSignedSubmissionIndices();
      Task<SignedSubmission> GetSignedSubmissionsMap(U32 key);
      Task<bool> SubscribeSignedSubmissionsMap(U32 key);
      Task<ElectionScore> GetMinimumUntrustedScore();
      Task<bool> SubscribeMinimumUntrustedScore();
   }
}
