//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace HelloKusama.NetApiExt.Generated.Model.pallet_nomination_pools
{
    
    
    /// <summary>
    /// >> 736 - Composite[pallet_nomination_pools.PoolRoles]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class PoolRoles : BaseType
    {
        
        /// <summary>
        /// >> depositor
        /// </summary>
        private HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _depositor;
        
        /// <summary>
        /// >> root
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseOpt<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _root;
        
        /// <summary>
        /// >> nominator
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseOpt<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _nominator;
        
        /// <summary>
        /// >> state_toggler
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseOpt<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _stateToggler;
        
        public HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Depositor
        {
            get
            {
                return this._depositor;
            }
            set
            {
                this._depositor = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> Root
        {
            get
            {
                return this._root;
            }
            set
            {
                this._root = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> Nominator
        {
            get
            {
                return this._nominator;
            }
            set
            {
                this._nominator = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> StateToggler
        {
            get
            {
                return this._stateToggler;
            }
            set
            {
                this._stateToggler = value;
            }
        }
        
        public override string TypeName()
        {
            return "PoolRoles";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Depositor.Encode());
            result.AddRange(Root.Encode());
            result.AddRange(Nominator.Encode());
            result.AddRange(StateToggler.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Depositor = new HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Depositor.Decode(byteArray, ref p);
            Root = new Ajuna.NetApi.Model.Types.Base.BaseOpt<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
            Root.Decode(byteArray, ref p);
            Nominator = new Ajuna.NetApi.Model.Types.Base.BaseOpt<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
            Nominator.Decode(byteArray, ref p);
            StateToggler = new Ajuna.NetApi.Model.Types.Base.BaseOpt<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
            StateToggler.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
