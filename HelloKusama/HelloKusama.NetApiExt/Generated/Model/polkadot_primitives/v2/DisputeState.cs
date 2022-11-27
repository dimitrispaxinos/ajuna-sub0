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


namespace HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2
{
    
    
    /// <summary>
    /// >> 812 - Composite[polkadot_primitives.v2.DisputeState]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class DisputeState : BaseType
    {
        
        /// <summary>
        /// >> validators_for
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0> _validatorsFor;
        
        /// <summary>
        /// >> validators_against
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0> _validatorsAgainst;
        
        /// <summary>
        /// >> start
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _start;
        
        /// <summary>
        /// >> concluded_at
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> _concludedAt;
        
        public Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0> ValidatorsFor
        {
            get
            {
                return this._validatorsFor;
            }
            set
            {
                this._validatorsFor = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0> ValidatorsAgainst
        {
            get
            {
                return this._validatorsAgainst;
            }
            set
            {
                this._validatorsAgainst = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> ConcludedAt
        {
            get
            {
                return this._concludedAt;
            }
            set
            {
                this._concludedAt = value;
            }
        }
        
        public override string TypeName()
        {
            return "DisputeState";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ValidatorsFor.Encode());
            result.AddRange(ValidatorsAgainst.Encode());
            result.AddRange(Start.Encode());
            result.AddRange(ConcludedAt.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ValidatorsFor = new Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
            ValidatorsFor.Decode(byteArray, ref p);
            ValidatorsAgainst = new Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
            ValidatorsAgainst.Decode(byteArray, ref p);
            Start = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Start.Decode(byteArray, ref p);
            ConcludedAt = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>();
            ConcludedAt.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
