//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.ServiceLayer.Attributes;
using Ajuna.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace HelloKusama.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IImOnlineStorage interface definition.
    /// </summary>
    public interface IImOnlineStorage : IStorage
    {
        
        /// <summary>
        /// >> HeartbeatAfter
        ///  The block number after which it's ok to send heartbeats in the current
        ///  session.
        /// 
        ///  At the beginning of each session we set this to a value that should fall
        ///  roughly in the middle of the session duration. The idea is to first wait for
        ///  the validators to produce a block in the current session, so that the
        ///  heartbeat later on will not be necessary.
        /// 
        ///  This value will only be used as a fallback if we fail to get a proper session
        ///  progress estimate from `NextSessionRotation`, as those estimates should be
        ///  more accurate then the value we calculate for `HeartbeatAfter`.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetHeartbeatAfter();
        
        /// <summary>
        /// >> Keys
        ///  The current set of keys that may issue a heartbeat.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT5 GetKeys();
        
        /// <summary>
        /// >> ReceivedHeartbeats
        ///  For each session index, we keep a mapping of `SessionIndex` and `AuthIndex` to
        ///  `WrapperOpaque<BoundedOpaqueNetworkState>`.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.frame_support.traits.misc.WrapperOpaque GetReceivedHeartbeats(string key);
        
        /// <summary>
        /// >> AuthoredBlocks
        ///  For each session index, we keep a mapping of `ValidatorId<T>` to the
        ///  number of blocks authored by the given authority.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetAuthoredBlocks(string key);
    }
    
    /// <summary>
    /// ImOnlineStorage class definition.
    /// </summary>
    public sealed class ImOnlineStorage : IImOnlineStorage
    {
        
        /// <summary>
        /// _heartbeatAfterTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _heartbeatAfterTypedStorage;
        
        /// <summary>
        /// _keysTypedStorage typed storage field
        /// </summary>
        private TypedStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT5> _keysTypedStorage;
        
        /// <summary>
        /// _receivedHeartbeatsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.frame_support.traits.misc.WrapperOpaque> _receivedHeartbeatsTypedStorage;
        
        /// <summary>
        /// _authoredBlocksTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _authoredBlocksTypedStorage;
        
        /// <summary>
        /// ImOnlineStorage constructor.
        /// </summary>
        public ImOnlineStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.HeartbeatAfterTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("ImOnline.HeartbeatAfter", storageDataProvider, storageChangeDelegates);
            this.KeysTypedStorage = new TypedStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT5>("ImOnline.Keys", storageDataProvider, storageChangeDelegates);
            this.ReceivedHeartbeatsTypedStorage = new TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.frame_support.traits.misc.WrapperOpaque>("ImOnline.ReceivedHeartbeats", storageDataProvider, storageChangeDelegates);
            this.AuthoredBlocksTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("ImOnline.AuthoredBlocks", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _heartbeatAfterTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> HeartbeatAfterTypedStorage
        {
            get
            {
                return _heartbeatAfterTypedStorage;
            }
            set
            {
                _heartbeatAfterTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _keysTypedStorage property
        /// </summary>
        public TypedStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT5> KeysTypedStorage
        {
            get
            {
                return _keysTypedStorage;
            }
            set
            {
                _keysTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _receivedHeartbeatsTypedStorage property
        /// </summary>
        public TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.frame_support.traits.misc.WrapperOpaque> ReceivedHeartbeatsTypedStorage
        {
            get
            {
                return _receivedHeartbeatsTypedStorage;
            }
            set
            {
                _receivedHeartbeatsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _authoredBlocksTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> AuthoredBlocksTypedStorage
        {
            get
            {
                return _authoredBlocksTypedStorage;
            }
            set
            {
                _authoredBlocksTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await HeartbeatAfterTypedStorage.InitializeAsync("ImOnline", "HeartbeatAfter");
            await KeysTypedStorage.InitializeAsync("ImOnline", "Keys");
            await ReceivedHeartbeatsTypedStorage.InitializeAsync("ImOnline", "ReceivedHeartbeats");
            await AuthoredBlocksTypedStorage.InitializeAsync("ImOnline", "AuthoredBlocks");
        }
        
        /// <summary>
        /// Implements any storage change for ImOnline.HeartbeatAfter
        /// </summary>
        [StorageChange("ImOnline", "HeartbeatAfter")]
        public void OnUpdateHeartbeatAfter(string data)
        {
            HeartbeatAfterTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> HeartbeatAfter
        ///  The block number after which it's ok to send heartbeats in the current
        ///  session.
        /// 
        ///  At the beginning of each session we set this to a value that should fall
        ///  roughly in the middle of the session duration. The idea is to first wait for
        ///  the validators to produce a block in the current session, so that the
        ///  heartbeat later on will not be necessary.
        /// 
        ///  This value will only be used as a fallback if we fail to get a proper session
        ///  progress estimate from `NextSessionRotation`, as those estimates should be
        ///  more accurate then the value we calculate for `HeartbeatAfter`.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetHeartbeatAfter()
        {
            return HeartbeatAfterTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for ImOnline.Keys
        /// </summary>
        [StorageChange("ImOnline", "Keys")]
        public void OnUpdateKeys(string data)
        {
            KeysTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Keys
        ///  The current set of keys that may issue a heartbeat.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT5 GetKeys()
        {
            return KeysTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for ImOnline.ReceivedHeartbeats
        /// </summary>
        [StorageChange("ImOnline", "ReceivedHeartbeats")]
        public void OnUpdateReceivedHeartbeats(string key, string data)
        {
            ReceivedHeartbeatsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ReceivedHeartbeats
        ///  For each session index, we keep a mapping of `SessionIndex` and `AuthIndex` to
        ///  `WrapperOpaque<BoundedOpaqueNetworkState>`.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.frame_support.traits.misc.WrapperOpaque GetReceivedHeartbeats(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ReceivedHeartbeatsTypedStorage.Dictionary.TryGetValue(key, out HelloKusama.NetApiExt.Generated.Model.frame_support.traits.misc.WrapperOpaque result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for ImOnline.AuthoredBlocks
        /// </summary>
        [StorageChange("ImOnline", "AuthoredBlocks")]
        public void OnUpdateAuthoredBlocks(string key, string data)
        {
            AuthoredBlocksTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> AuthoredBlocks
        ///  For each session index, we keep a mapping of `ValidatorId<T>` to the
        ///  number of blocks authored by the given authority.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetAuthoredBlocks(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AuthoredBlocksTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
