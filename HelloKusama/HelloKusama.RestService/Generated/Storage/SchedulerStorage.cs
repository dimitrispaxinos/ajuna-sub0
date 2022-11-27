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
    /// ISchedulerStorage interface definition.
    /// </summary>
    public interface ISchedulerStorage : IStorage
    {
        
        /// <summary>
        /// >> IncompleteSince
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetIncompleteSince();
        
        /// <summary>
        /// >> Agenda
        ///  Items to be executed, indexed by the block number that they should be executed on.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT26 GetAgenda(string key);
        
        /// <summary>
        /// >> Lookup
        ///  Lookup from a name to the block number and index of the task.
        /// 
        ///  For v3 -> v4 the previously unbounded identities are Blake2-256 hashed to form the v4
        ///  identities.
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> GetLookup(string key);
    }
    
    /// <summary>
    /// SchedulerStorage class definition.
    /// </summary>
    public sealed class SchedulerStorage : ISchedulerStorage
    {
        
        /// <summary>
        /// _incompleteSinceTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _incompleteSinceTypedStorage;
        
        /// <summary>
        /// _agendaTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT26> _agendaTypedStorage;
        
        /// <summary>
        /// _lookupTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>> _lookupTypedStorage;
        
        /// <summary>
        /// SchedulerStorage constructor.
        /// </summary>
        public SchedulerStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.IncompleteSinceTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("Scheduler.IncompleteSince", storageDataProvider, storageChangeDelegates);
            this.AgendaTypedStorage = new TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT26>("Scheduler.Agenda", storageDataProvider, storageChangeDelegates);
            this.LookupTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>>("Scheduler.Lookup", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _incompleteSinceTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> IncompleteSinceTypedStorage
        {
            get
            {
                return _incompleteSinceTypedStorage;
            }
            set
            {
                _incompleteSinceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _agendaTypedStorage property
        /// </summary>
        public TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT26> AgendaTypedStorage
        {
            get
            {
                return _agendaTypedStorage;
            }
            set
            {
                _agendaTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _lookupTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>> LookupTypedStorage
        {
            get
            {
                return _lookupTypedStorage;
            }
            set
            {
                _lookupTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await IncompleteSinceTypedStorage.InitializeAsync("Scheduler", "IncompleteSince");
            await AgendaTypedStorage.InitializeAsync("Scheduler", "Agenda");
            await LookupTypedStorage.InitializeAsync("Scheduler", "Lookup");
        }
        
        /// <summary>
        /// Implements any storage change for Scheduler.IncompleteSince
        /// </summary>
        [StorageChange("Scheduler", "IncompleteSince")]
        public void OnUpdateIncompleteSince(string data)
        {
            IncompleteSinceTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> IncompleteSince
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetIncompleteSince()
        {
            return IncompleteSinceTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Scheduler.Agenda
        /// </summary>
        [StorageChange("Scheduler", "Agenda")]
        public void OnUpdateAgenda(string key, string data)
        {
            AgendaTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Agenda
        ///  Items to be executed, indexed by the block number that they should be executed on.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT26 GetAgenda(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AgendaTypedStorage.Dictionary.TryGetValue(key, out HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT26 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Scheduler.Lookup
        /// </summary>
        [StorageChange("Scheduler", "Lookup")]
        public void OnUpdateLookup(string key, string data)
        {
            LookupTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Lookup
        ///  Lookup from a name to the block number and index of the task.
        /// 
        ///  For v3 -> v4 the previously unbounded identities are Blake2-256 hashed to form the v4
        ///  identities.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> GetLookup(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (LookupTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> result))
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
