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
    /// IXcmPalletStorage interface definition.
    /// </summary>
    public interface IXcmPalletStorage : IStorage
    {
        
        /// <summary>
        /// >> QueryCounter
        ///  The latest available query index.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U64 GetQueryCounter();
        
        /// <summary>
        /// >> Queries
        ///  The ongoing queries.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus GetQueries(string key);
        
        /// <summary>
        /// >> AssetTraps
        ///  The existing asset traps.
        /// 
        ///  Key is the blake2 256 hash of (origin, versioned `MultiAssets`) pair. Value is the number of
        ///  times this pair has been trapped (usually just 1 if it exists at all).
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetAssetTraps(string key);
        
        /// <summary>
        /// >> SafeXcmVersion
        ///  Default version to encode XCM when latest version of destination is unknown. If `None`,
        ///  then the destinations whose XCM version is unknown are considered unreachable.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetSafeXcmVersion();
        
        /// <summary>
        /// >> SupportedVersion
        ///  The Latest versions that we know various locations support.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetSupportedVersion(string key);
        
        /// <summary>
        /// >> VersionNotifiers
        ///  All locations that we have requested version notifications from.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U64 GetVersionNotifiers(string key);
        
        /// <summary>
        /// >> VersionNotifyTargets
        ///  The target locations that are subscribed to our version changes, as well as the most recent
        ///  of our versions we informed them of.
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U32> GetVersionNotifyTargets(string key);
        
        /// <summary>
        /// >> VersionDiscoveryQueue
        ///  Destinations whose latest XCM version we would like to know. Duplicates not allowed, and
        ///  the `u32` counter is the number of times that a send to the destination has been attempted,
        ///  which is used as a prioritization.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT35 GetVersionDiscoveryQueue();
        
        /// <summary>
        /// >> CurrentMigration
        ///  The current migration's stage, if any.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage GetCurrentMigration();
    }
    
    /// <summary>
    /// XcmPalletStorage class definition.
    /// </summary>
    public sealed class XcmPalletStorage : IXcmPalletStorage
    {
        
        /// <summary>
        /// _queryCounterTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U64> _queryCounterTypedStorage;
        
        /// <summary>
        /// _queriesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus> _queriesTypedStorage;
        
        /// <summary>
        /// _assetTrapsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _assetTrapsTypedStorage;
        
        /// <summary>
        /// _safeXcmVersionTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _safeXcmVersionTypedStorage;
        
        /// <summary>
        /// _supportedVersionTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _supportedVersionTypedStorage;
        
        /// <summary>
        /// _versionNotifiersTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U64> _versionNotifiersTypedStorage;
        
        /// <summary>
        /// _versionNotifyTargetsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U32>> _versionNotifyTargetsTypedStorage;
        
        /// <summary>
        /// _versionDiscoveryQueueTypedStorage typed storage field
        /// </summary>
        private TypedStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT35> _versionDiscoveryQueueTypedStorage;
        
        /// <summary>
        /// _currentMigrationTypedStorage typed storage field
        /// </summary>
        private TypedStorage<HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage> _currentMigrationTypedStorage;
        
        /// <summary>
        /// XcmPalletStorage constructor.
        /// </summary>
        public XcmPalletStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.QueryCounterTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U64>("XcmPallet.QueryCounter", storageDataProvider, storageChangeDelegates);
            this.QueriesTypedStorage = new TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus>("XcmPallet.Queries", storageDataProvider, storageChangeDelegates);
            this.AssetTrapsTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("XcmPallet.AssetTraps", storageDataProvider, storageChangeDelegates);
            this.SafeXcmVersionTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("XcmPallet.SafeXcmVersion", storageDataProvider, storageChangeDelegates);
            this.SupportedVersionTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("XcmPallet.SupportedVersion", storageDataProvider, storageChangeDelegates);
            this.VersionNotifiersTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U64>("XcmPallet.VersionNotifiers", storageDataProvider, storageChangeDelegates);
            this.VersionNotifyTargetsTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U32>>("XcmPallet.VersionNotifyTargets", storageDataProvider, storageChangeDelegates);
            this.VersionDiscoveryQueueTypedStorage = new TypedStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT35>("XcmPallet.VersionDiscoveryQueue", storageDataProvider, storageChangeDelegates);
            this.CurrentMigrationTypedStorage = new TypedStorage<HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage>("XcmPallet.CurrentMigration", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _queryCounterTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U64> QueryCounterTypedStorage
        {
            get
            {
                return _queryCounterTypedStorage;
            }
            set
            {
                _queryCounterTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _queriesTypedStorage property
        /// </summary>
        public TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus> QueriesTypedStorage
        {
            get
            {
                return _queriesTypedStorage;
            }
            set
            {
                _queriesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _assetTrapsTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> AssetTrapsTypedStorage
        {
            get
            {
                return _assetTrapsTypedStorage;
            }
            set
            {
                _assetTrapsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _safeXcmVersionTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> SafeXcmVersionTypedStorage
        {
            get
            {
                return _safeXcmVersionTypedStorage;
            }
            set
            {
                _safeXcmVersionTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _supportedVersionTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> SupportedVersionTypedStorage
        {
            get
            {
                return _supportedVersionTypedStorage;
            }
            set
            {
                _supportedVersionTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _versionNotifiersTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U64> VersionNotifiersTypedStorage
        {
            get
            {
                return _versionNotifiersTypedStorage;
            }
            set
            {
                _versionNotifiersTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _versionNotifyTargetsTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U32>> VersionNotifyTargetsTypedStorage
        {
            get
            {
                return _versionNotifyTargetsTypedStorage;
            }
            set
            {
                _versionNotifyTargetsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _versionDiscoveryQueueTypedStorage property
        /// </summary>
        public TypedStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT35> VersionDiscoveryQueueTypedStorage
        {
            get
            {
                return _versionDiscoveryQueueTypedStorage;
            }
            set
            {
                _versionDiscoveryQueueTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _currentMigrationTypedStorage property
        /// </summary>
        public TypedStorage<HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage> CurrentMigrationTypedStorage
        {
            get
            {
                return _currentMigrationTypedStorage;
            }
            set
            {
                _currentMigrationTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await QueryCounterTypedStorage.InitializeAsync("XcmPallet", "QueryCounter");
            await QueriesTypedStorage.InitializeAsync("XcmPallet", "Queries");
            await AssetTrapsTypedStorage.InitializeAsync("XcmPallet", "AssetTraps");
            await SafeXcmVersionTypedStorage.InitializeAsync("XcmPallet", "SafeXcmVersion");
            await SupportedVersionTypedStorage.InitializeAsync("XcmPallet", "SupportedVersion");
            await VersionNotifiersTypedStorage.InitializeAsync("XcmPallet", "VersionNotifiers");
            await VersionNotifyTargetsTypedStorage.InitializeAsync("XcmPallet", "VersionNotifyTargets");
            await VersionDiscoveryQueueTypedStorage.InitializeAsync("XcmPallet", "VersionDiscoveryQueue");
            await CurrentMigrationTypedStorage.InitializeAsync("XcmPallet", "CurrentMigration");
        }
        
        /// <summary>
        /// Implements any storage change for XcmPallet.QueryCounter
        /// </summary>
        [StorageChange("XcmPallet", "QueryCounter")]
        public void OnUpdateQueryCounter(string data)
        {
            QueryCounterTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> QueryCounter
        ///  The latest available query index.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U64 GetQueryCounter()
        {
            return QueryCounterTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for XcmPallet.Queries
        /// </summary>
        [StorageChange("XcmPallet", "Queries")]
        public void OnUpdateQueries(string key, string data)
        {
            QueriesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Queries
        ///  The ongoing queries.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus GetQueries(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (QueriesTypedStorage.Dictionary.TryGetValue(key, out HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for XcmPallet.AssetTraps
        /// </summary>
        [StorageChange("XcmPallet", "AssetTraps")]
        public void OnUpdateAssetTraps(string key, string data)
        {
            AssetTrapsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> AssetTraps
        ///  The existing asset traps.
        /// 
        ///  Key is the blake2 256 hash of (origin, versioned `MultiAssets`) pair. Value is the number of
        ///  times this pair has been trapped (usually just 1 if it exists at all).
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetAssetTraps(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AssetTrapsTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for XcmPallet.SafeXcmVersion
        /// </summary>
        [StorageChange("XcmPallet", "SafeXcmVersion")]
        public void OnUpdateSafeXcmVersion(string data)
        {
            SafeXcmVersionTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> SafeXcmVersion
        ///  Default version to encode XCM when latest version of destination is unknown. If `None`,
        ///  then the destinations whose XCM version is unknown are considered unreachable.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetSafeXcmVersion()
        {
            return SafeXcmVersionTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for XcmPallet.SupportedVersion
        /// </summary>
        [StorageChange("XcmPallet", "SupportedVersion")]
        public void OnUpdateSupportedVersion(string key, string data)
        {
            SupportedVersionTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> SupportedVersion
        ///  The Latest versions that we know various locations support.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetSupportedVersion(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (SupportedVersionTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for XcmPallet.VersionNotifiers
        /// </summary>
        [StorageChange("XcmPallet", "VersionNotifiers")]
        public void OnUpdateVersionNotifiers(string key, string data)
        {
            VersionNotifiersTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> VersionNotifiers
        ///  All locations that we have requested version notifications from.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U64 GetVersionNotifiers(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VersionNotifiersTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U64 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for XcmPallet.VersionNotifyTargets
        /// </summary>
        [StorageChange("XcmPallet", "VersionNotifyTargets")]
        public void OnUpdateVersionNotifyTargets(string key, string data)
        {
            VersionNotifyTargetsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> VersionNotifyTargets
        ///  The target locations that are subscribed to our version changes, as well as the most recent
        ///  of our versions we informed them of.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U32> GetVersionNotifyTargets(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VersionNotifyTargetsTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U32> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for XcmPallet.VersionDiscoveryQueue
        /// </summary>
        [StorageChange("XcmPallet", "VersionDiscoveryQueue")]
        public void OnUpdateVersionDiscoveryQueue(string data)
        {
            VersionDiscoveryQueueTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> VersionDiscoveryQueue
        ///  Destinations whose latest XCM version we would like to know. Duplicates not allowed, and
        ///  the `u32` counter is the number of times that a send to the destination has been attempted,
        ///  which is used as a prioritization.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT35 GetVersionDiscoveryQueue()
        {
            return VersionDiscoveryQueueTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for XcmPallet.CurrentMigration
        /// </summary>
        [StorageChange("XcmPallet", "CurrentMigration")]
        public void OnUpdateCurrentMigration(string data)
        {
            CurrentMigrationTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CurrentMigration
        ///  The current migration's stage, if any.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage GetCurrentMigration()
        {
            return CurrentMigrationTypedStorage.Get();
        }
    }
}
