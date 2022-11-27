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
    
    
    public sealed class ParaInherentStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public ParaInherentStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaInherent", "Included"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaInherent", "OnChainVotes"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ScrapedOnChainVotes)));
        }
        
        /// <summary>
        /// >> IncludedParams
        ///  Whether the paras inherent was included within this block.
        /// 
        ///  The `Option<()>` is effectively a `bool`, but it never hits storage in the `None` variant
        ///  due to the guarantees of FRAME's storage APIs.
        /// 
        ///  If this is `None` at the end of the block, we panic and render the block invalid.
        /// </summary>
        public static string IncludedParams()
        {
            return RequestGenerator.GetStorage("ParaInherent", "Included", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Included
        ///  Whether the paras inherent was included within this block.
        /// 
        ///  The `Option<()>` is effectively a `bool`, but it never hits storage in the `None` variant
        ///  due to the guarantees of FRAME's storage APIs.
        /// 
        ///  If this is `None` at the end of the block, we panic and render the block invalid.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Base.BaseTuple> Included(CancellationToken token)
        {
            string parameters = ParaInherentStorage.IncludedParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Base.BaseTuple>(parameters, token);
        }
        
        /// <summary>
        /// >> OnChainVotesParams
        ///  Scraped on chain data for extracting resolved disputes as well as backing votes.
        /// </summary>
        public static string OnChainVotesParams()
        {
            return RequestGenerator.GetStorage("ParaInherent", "OnChainVotes", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> OnChainVotes
        ///  Scraped on chain data for extracting resolved disputes as well as backing votes.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ScrapedOnChainVotes> OnChainVotes(CancellationToken token)
        {
            string parameters = ParaInherentStorage.OnChainVotesParams();
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ScrapedOnChainVotes>(parameters, token);
        }
    }
    
    public sealed class ParaInherentCalls
    {
        
        /// <summary>
        /// >> enter
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Enter(HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.InherentData data)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(data.Encode());
            return new Method(54, "ParaInherent", 0, "enter", byteArray.ToArray());
        }
    }
    
    public enum ParaInherentErrors
    {
        
        /// <summary>
        /// >> TooManyInclusionInherents
        /// Inclusion inherent called more than once per block.
        /// </summary>
        TooManyInclusionInherents,
        
        /// <summary>
        /// >> InvalidParentHeader
        /// The hash of the submitted parent header doesn't correspond to the saved block hash of
        /// the parent.
        /// </summary>
        InvalidParentHeader,
        
        /// <summary>
        /// >> CandidateConcludedInvalid
        /// Disputed candidate that was concluded invalid.
        /// </summary>
        CandidateConcludedInvalid,
        
        /// <summary>
        /// >> InherentOverweight
        /// The data given to the inherent will result in an overweight block.
        /// </summary>
        InherentOverweight,
        
        /// <summary>
        /// >> DisputeStatementsUnsortedOrDuplicates
        /// The ordering of dispute statements was invalid.
        /// </summary>
        DisputeStatementsUnsortedOrDuplicates,
        
        /// <summary>
        /// >> DisputeInvalid
        /// A dispute statement was invalid.
        /// </summary>
        DisputeInvalid,
    }
}
