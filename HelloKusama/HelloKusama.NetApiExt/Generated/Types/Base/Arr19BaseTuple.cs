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
    /// >> 302 - Array
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Array)]
    public sealed class Arr19BaseTuple : BaseType
    {
        
        private Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>, Ajuna.NetApi.Model.Types.Base.BaseCom<HelloKusama.NetApiExt.Generated.Model.sp_arithmetic.per_things.PerU16>>[] _value;
        
        public override int TypeSize
        {
            get
            {
                return 19;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>, Ajuna.NetApi.Model.Types.Base.BaseCom<HelloKusama.NetApiExt.Generated.Model.sp_arithmetic.per_things.PerU16>>[] Value
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
            return string.Format("[{0}; {1}]", new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>, Ajuna.NetApi.Model.Types.Base.BaseCom<HelloKusama.NetApiExt.Generated.Model.sp_arithmetic.per_things.PerU16>>().TypeName(), this.TypeSize);
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            foreach (var v in Value){result.AddRange(v.Encode());};
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            var array = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>, Ajuna.NetApi.Model.Types.Base.BaseCom<HelloKusama.NetApiExt.Generated.Model.sp_arithmetic.per_things.PerU16>>[TypeSize];
            for (var i = 0; i < array.Length; i++) {var t = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>, Ajuna.NetApi.Model.Types.Base.BaseCom<HelloKusama.NetApiExt.Generated.Model.sp_arithmetic.per_things.PerU16>>();t.Decode(byteArray, ref p);array[i] = t;};
            var bytesLength = p - start;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
            Value = array;
        }
        
        public void Create(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>, Ajuna.NetApi.Model.Types.Base.BaseCom<HelloKusama.NetApiExt.Generated.Model.sp_arithmetic.per_things.PerU16>>[] array)
        {
            Value = array;
            Bytes = Encode();
        }
    }
}
