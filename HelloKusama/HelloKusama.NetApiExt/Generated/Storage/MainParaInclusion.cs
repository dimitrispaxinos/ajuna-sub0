//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace HelloKusama.NetApiExt.Generated.Storage
{
    
    
    public sealed class ParaInclusionStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public ParaInclusionStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaInclusion", "AvailabilityBitfields"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex), typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.AvailabilityBitfieldRecord)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaInclusion", "PendingAvailability"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id), typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.CandidatePendingAvailability)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaInclusion", "PendingAvailabilityCommitments"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id), typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateCommitments)));
        }
        
        /// <summary>
        /// >> AvailabilityBitfieldsParams
        ///  The latest bitfield for each validator, referred to by their index in the validator set.
        /// </summary>
        public static string AvailabilityBitfieldsParams(HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex key)
        {
            return RequestGenerator.GetStorage("ParaInclusion", "AvailabilityBitfields", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AvailabilityBitfields
        ///  The latest bitfield for each validator, referred to by their index in the validator set.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.AvailabilityBitfieldRecord> AvailabilityBitfields(HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex key, CancellationToken token)
        {
            string parameters = ParaInclusionStorage.AvailabilityBitfieldsParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.AvailabilityBitfieldRecord>(parameters, token);
        }
        
        /// <summary>
        /// >> PendingAvailabilityParams
        ///  Candidates pending availability by `ParaId`.
        /// </summary>
        public static string PendingAvailabilityParams(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
        {
            return RequestGenerator.GetStorage("ParaInclusion", "PendingAvailability", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PendingAvailability
        ///  Candidates pending availability by `ParaId`.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.CandidatePendingAvailability> PendingAvailability(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key, CancellationToken token)
        {
            string parameters = ParaInclusionStorage.PendingAvailabilityParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.CandidatePendingAvailability>(parameters, token);
        }
        
        /// <summary>
        /// >> PendingAvailabilityCommitmentsParams
        ///  The commitments of candidates pending availability, by `ParaId`.
        /// </summary>
        public static string PendingAvailabilityCommitmentsParams(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
        {
            return RequestGenerator.GetStorage("ParaInclusion", "PendingAvailabilityCommitments", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PendingAvailabilityCommitments
        ///  The commitments of candidates pending availability, by `ParaId`.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateCommitments> PendingAvailabilityCommitments(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key, CancellationToken token)
        {
            string parameters = ParaInclusionStorage.PendingAvailabilityCommitmentsParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateCommitments>(parameters, token);
        }
    }
    
    public sealed class ParaInclusionCalls
    {
    }
    
    public enum ParaInclusionErrors
    {
        
        /// <summary>
        /// >> UnsortedOrDuplicateValidatorIndices
        /// Validator indices are out of order or contains duplicates.
        /// </summary>
        UnsortedOrDuplicateValidatorIndices,
        
        /// <summary>
        /// >> UnsortedOrDuplicateDisputeStatementSet
        /// Dispute statement sets are out of order or contain duplicates.
        /// </summary>
        UnsortedOrDuplicateDisputeStatementSet,
        
        /// <summary>
        /// >> UnsortedOrDuplicateBackedCandidates
        /// Backed candidates are out of order (core index) or contain duplicates.
        /// </summary>
        UnsortedOrDuplicateBackedCandidates,
        
        /// <summary>
        /// >> UnexpectedRelayParent
        /// A different relay parent was provided compared to the on-chain stored one.
        /// </summary>
        UnexpectedRelayParent,
        
        /// <summary>
        /// >> WrongBitfieldSize
        /// Availability bitfield has unexpected size.
        /// </summary>
        WrongBitfieldSize,
        
        /// <summary>
        /// >> BitfieldAllZeros
        /// Bitfield consists of zeros only.
        /// </summary>
        BitfieldAllZeros,
        
        /// <summary>
        /// >> BitfieldDuplicateOrUnordered
        /// Multiple bitfields submitted by same validator or validators out of order by index.
        /// </summary>
        BitfieldDuplicateOrUnordered,
        
        /// <summary>
        /// >> ValidatorIndexOutOfBounds
        /// Validator index out of bounds.
        /// </summary>
        ValidatorIndexOutOfBounds,
        
        /// <summary>
        /// >> InvalidBitfieldSignature
        /// Invalid signature
        /// </summary>
        InvalidBitfieldSignature,
        
        /// <summary>
        /// >> UnscheduledCandidate
        /// Candidate submitted but para not scheduled.
        /// </summary>
        UnscheduledCandidate,
        
        /// <summary>
        /// >> CandidateScheduledBeforeParaFree
        /// Candidate scheduled despite pending candidate already existing for the para.
        /// </summary>
        CandidateScheduledBeforeParaFree,
        
        /// <summary>
        /// >> WrongCollator
        /// Candidate included with the wrong collator.
        /// </summary>
        WrongCollator,
        
        /// <summary>
        /// >> ScheduledOutOfOrder
        /// Scheduled cores out of order.
        /// </summary>
        ScheduledOutOfOrder,
        
        /// <summary>
        /// >> HeadDataTooLarge
        /// Head data exceeds the configured maximum.
        /// </summary>
        HeadDataTooLarge,
        
        /// <summary>
        /// >> PrematureCodeUpgrade
        /// Code upgrade prematurely.
        /// </summary>
        PrematureCodeUpgrade,
        
        /// <summary>
        /// >> NewCodeTooLarge
        /// Output code is too large
        /// </summary>
        NewCodeTooLarge,
        
        /// <summary>
        /// >> CandidateNotInParentContext
        /// Candidate not in parent context.
        /// </summary>
        CandidateNotInParentContext,
        
        /// <summary>
        /// >> InvalidGroupIndex
        /// Invalid group index in core assignment.
        /// </summary>
        InvalidGroupIndex,
        
        /// <summary>
        /// >> InsufficientBacking
        /// Insufficient (non-majority) backing.
        /// </summary>
        InsufficientBacking,
        
        /// <summary>
        /// >> InvalidBacking
        /// Invalid (bad signature, unknown validator, etc.) backing.
        /// </summary>
        InvalidBacking,
        
        /// <summary>
        /// >> NotCollatorSigned
        /// Collator did not sign PoV.
        /// </summary>
        NotCollatorSigned,
        
        /// <summary>
        /// >> ValidationDataHashMismatch
        /// The validation data hash does not match expected.
        /// </summary>
        ValidationDataHashMismatch,
        
        /// <summary>
        /// >> IncorrectDownwardMessageHandling
        /// The downward message queue is not processed correctly.
        /// </summary>
        IncorrectDownwardMessageHandling,
        
        /// <summary>
        /// >> InvalidUpwardMessages
        /// At least one upward message sent does not pass the acceptance criteria.
        /// </summary>
        InvalidUpwardMessages,
        
        /// <summary>
        /// >> HrmpWatermarkMishandling
        /// The candidate didn't follow the rules of HRMP watermark advancement.
        /// </summary>
        HrmpWatermarkMishandling,
        
        /// <summary>
        /// >> InvalidOutboundHrmp
        /// The HRMP messages sent by the candidate is not valid.
        /// </summary>
        InvalidOutboundHrmp,
        
        /// <summary>
        /// >> InvalidValidationCodeHash
        /// The validation code hash of the candidate is not valid.
        /// </summary>
        InvalidValidationCodeHash,
        
        /// <summary>
        /// >> ParaHeadMismatch
        /// The `para_head` hash in the candidate descriptor doesn't match the hash of the actual para head in the
        /// commitments.
        /// </summary>
        ParaHeadMismatch,
        
        /// <summary>
        /// >> BitfieldReferencesFreedCore
        /// A bitfield that references a freed core,
        /// either intentionally or as part of a concluded
        /// invalid dispute.
        /// </summary>
        BitfieldReferencesFreedCore,
    }
}
