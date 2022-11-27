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
    
    
    public sealed class SessionStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public SessionStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Session", "Validators"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Session", "CurrentIndex"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Session", "QueuedChanged"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.Bool)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Session", "QueuedKeys"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.kusama_runtime.SessionKeys>>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Session", "DisabledValidators"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U32>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Session", "NextKeys"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(HelloKusama.NetApiExt.Generated.Model.kusama_runtime.SessionKeys)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Session", "KeyOwner"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.KeyTypeId, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>), typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32)));
        }
        
        /// <summary>
        /// >> ValidatorsParams
        ///  The current set of validators.
        /// </summary>
        public static string ValidatorsParams()
        {
            return RequestGenerator.GetStorage("Session", "Validators", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Validators
        ///  The current set of validators.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>> Validators(CancellationToken token)
        {
            string parameters = SessionStorage.ValidatorsParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>(parameters, token);
        }
        
        /// <summary>
        /// >> CurrentIndexParams
        ///  Current index of the session.
        /// </summary>
        public static string CurrentIndexParams()
        {
            return RequestGenerator.GetStorage("Session", "CurrentIndex", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CurrentIndex
        ///  Current index of the session.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> CurrentIndex(CancellationToken token)
        {
            string parameters = SessionStorage.CurrentIndexParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> QueuedChangedParams
        ///  True if the underlying economic identities or weighting behind the validators
        ///  has changed in the queued validator set.
        /// </summary>
        public static string QueuedChangedParams()
        {
            return RequestGenerator.GetStorage("Session", "QueuedChanged", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> QueuedChanged
        ///  True if the underlying economic identities or weighting behind the validators
        ///  has changed in the queued validator set.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.Bool> QueuedChanged(CancellationToken token)
        {
            string parameters = SessionStorage.QueuedChangedParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.Bool>(parameters, token);
        }
        
        /// <summary>
        /// >> QueuedKeysParams
        ///  The queued keys for the next session. When the next session begins, these keys
        ///  will be used to determine the validator's session keys.
        /// </summary>
        public static string QueuedKeysParams()
        {
            return RequestGenerator.GetStorage("Session", "QueuedKeys", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> QueuedKeys
        ///  The queued keys for the next session. When the next session begins, these keys
        ///  will be used to determine the validator's session keys.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.kusama_runtime.SessionKeys>>> QueuedKeys(CancellationToken token)
        {
            string parameters = SessionStorage.QueuedKeysParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.kusama_runtime.SessionKeys>>>(parameters, token);
        }
        
        /// <summary>
        /// >> DisabledValidatorsParams
        ///  Indices of disabled validators.
        /// 
        ///  The vec is always kept sorted so that we can find whether a given validator is
        ///  disabled using binary search. It gets cleared when `on_session_ending` returns
        ///  a new set of identities.
        /// </summary>
        public static string DisabledValidatorsParams()
        {
            return RequestGenerator.GetStorage("Session", "DisabledValidators", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> DisabledValidators
        ///  Indices of disabled validators.
        /// 
        ///  The vec is always kept sorted so that we can find whether a given validator is
        ///  disabled using binary search. It gets cleared when `on_session_ending` returns
        ///  a new set of identities.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U32>> DisabledValidators(CancellationToken token)
        {
            string parameters = SessionStorage.DisabledValidatorsParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U32>>(parameters, token);
        }
        
        /// <summary>
        /// >> NextKeysParams
        ///  The next session keys for a validator.
        /// </summary>
        public static string NextKeysParams(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Session", "NextKeys", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> NextKeys
        ///  The next session keys for a validator.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.kusama_runtime.SessionKeys> NextKeys(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = SessionStorage.NextKeysParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.kusama_runtime.SessionKeys>(parameters, token);
        }
        
        /// <summary>
        /// >> KeyOwnerParams
        ///  The owner of a key. The key is the `KeyTypeId` + the encoded key.
        /// </summary>
        public static string KeyOwnerParams(Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.KeyTypeId, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> key)
        {
            return RequestGenerator.GetStorage("Session", "KeyOwner", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> KeyOwner
        ///  The owner of a key. The key is the `KeyTypeId` + the encoded key.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> KeyOwner(Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.KeyTypeId, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> key, CancellationToken token)
        {
            string parameters = SessionStorage.KeyOwnerParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(parameters, token);
        }
    }
    
    public sealed class SessionCalls
    {
        
        /// <summary>
        /// >> set_keys
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetKeys(HelloKusama.NetApiExt.Generated.Model.kusama_runtime.SessionKeys keys, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> proof)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(keys.Encode());
            byteArray.AddRange(proof.Encode());
            return new Method(8, "Session", 0, "set_keys", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> purge_keys
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method PurgeKeys()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(8, "Session", 1, "purge_keys", byteArray.ToArray());
        }
    }
    
    public enum SessionErrors
    {
        
        /// <summary>
        /// >> InvalidProof
        /// Invalid ownership proof.
        /// </summary>
        InvalidProof,
        
        /// <summary>
        /// >> NoAssociatedValidatorId
        /// No associated validator ID for account.
        /// </summary>
        NoAssociatedValidatorId,
        
        /// <summary>
        /// >> DuplicatedKey
        /// Registered duplicate key.
        /// </summary>
        DuplicatedKey,
        
        /// <summary>
        /// >> NoKeys
        /// No keys are associated with this account.
        /// </summary>
        NoKeys,
        
        /// <summary>
        /// >> NoAccount
        /// Key setting account is not live, so it's impossible to associate keys.
        /// </summary>
        NoAccount,
    }
}
