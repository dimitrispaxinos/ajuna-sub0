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


namespace HelloKusama.NetApiExt.Generated.Types.Base
{
    
    
    /// <summary>
    /// >> 497 - Composite[Cow]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Cow : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Types.Base.Arr8U8, Ajuna.NetApi.Model.Types.Primitive.U32>> _value;
        
        public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Types.Base.Arr8U8, Ajuna.NetApi.Model.Types.Primitive.U32>> Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "Cow";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Types.Base.Arr8U8, Ajuna.NetApi.Model.Types.Primitive.U32>>();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
