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
    /// IDmpStorage interface definition.
    /// </summary>
    public interface IDmpStorage : IStorage
    {
        
        /// <summary>
        /// >> DownwardMessageQueues
        ///  The downward messages addressed for a certain para.
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage> GetDownwardMessageQueues(string key);
        
        /// <summary>
        /// >> DownwardMessageQueueHeads
        ///  A mapping that stores the downward message queue MQC head for each para.
        /// 
        ///  Each link in this chain has a form:
        ///  `(prev_head, B, H(M))`, where
        ///  - `prev_head`: is the previous head hash or zero if none.
        ///  - `B`: is the relay-chain block number in which a message was appended.
        ///  - `H(M)`: is the hash of the message being appended.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 GetDownwardMessageQueueHeads(string key);
    }
    
    /// <summary>
    /// DmpStorage class definition.
    /// </summary>
    public sealed class DmpStorage : IDmpStorage
    {
        
        /// <summary>
        /// _downwardMessageQueuesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage>> _downwardMessageQueuesTypedStorage;
        
        /// <summary>
        /// _downwardMessageQueueHeadsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.primitive_types.H256> _downwardMessageQueueHeadsTypedStorage;
        
        /// <summary>
        /// DmpStorage constructor.
        /// </summary>
        public DmpStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.DownwardMessageQueuesTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage>>("Dmp.DownwardMessageQueues", storageDataProvider, storageChangeDelegates);
            this.DownwardMessageQueueHeadsTypedStorage = new TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.primitive_types.H256>("Dmp.DownwardMessageQueueHeads", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _downwardMessageQueuesTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage>> DownwardMessageQueuesTypedStorage
        {
            get
            {
                return _downwardMessageQueuesTypedStorage;
            }
            set
            {
                _downwardMessageQueuesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _downwardMessageQueueHeadsTypedStorage property
        /// </summary>
        public TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.primitive_types.H256> DownwardMessageQueueHeadsTypedStorage
        {
            get
            {
                return _downwardMessageQueueHeadsTypedStorage;
            }
            set
            {
                _downwardMessageQueueHeadsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await DownwardMessageQueuesTypedStorage.InitializeAsync("Dmp", "DownwardMessageQueues");
            await DownwardMessageQueueHeadsTypedStorage.InitializeAsync("Dmp", "DownwardMessageQueueHeads");
        }
        
        /// <summary>
        /// Implements any storage change for Dmp.DownwardMessageQueues
        /// </summary>
        [StorageChange("Dmp", "DownwardMessageQueues")]
        public void OnUpdateDownwardMessageQueues(string key, string data)
        {
            DownwardMessageQueuesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> DownwardMessageQueues
        ///  The downward messages addressed for a certain para.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage> GetDownwardMessageQueues(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (DownwardMessageQueuesTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Dmp.DownwardMessageQueueHeads
        /// </summary>
        [StorageChange("Dmp", "DownwardMessageQueueHeads")]
        public void OnUpdateDownwardMessageQueueHeads(string key, string data)
        {
            DownwardMessageQueueHeadsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> DownwardMessageQueueHeads
        ///  A mapping that stores the downward message queue MQC head for each para.
        /// 
        ///  Each link in this chain has a form:
        ///  `(prev_head, B, H(M))`, where
        ///  - `prev_head`: is the previous head hash or zero if none.
        ///  - `B`: is the relay-chain block number in which a message was appended.
        ///  - `H(M)`: is the hash of the message being appended.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 GetDownwardMessageQueueHeads(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (DownwardMessageQueueHeadsTypedStorage.Dictionary.TryGetValue(key, out HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 result))
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