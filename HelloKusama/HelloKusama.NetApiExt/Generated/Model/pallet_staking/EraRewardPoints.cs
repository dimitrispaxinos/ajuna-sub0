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


namespace HelloKusama.NetApiExt.Generated.Model.pallet_staking
{
    
    
    /// <summary>
    /// >> 540 - Composite[pallet_staking.EraRewardPoints]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class EraRewardPoints : BaseType
    {
        
        /// <summary>
        /// >> total
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _total;
        
        /// <summary>
        /// >> individual
        /// </summary>
        private HelloKusama.NetApiExt.Generated.Types.Base.BTreeMapT1 _individual;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Total
        {
            get
            {
                return this._total;
            }
            set
            {
                this._total = value;
            }
        }
        
        public HelloKusama.NetApiExt.Generated.Types.Base.BTreeMapT1 Individual
        {
            get
            {
                return this._individual;
            }
            set
            {
                this._individual = value;
            }
        }
        
        public override string TypeName()
        {
            return "EraRewardPoints";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Total.Encode());
            result.AddRange(Individual.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Total = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Total.Decode(byteArray, ref p);
            Individual = new HelloKusama.NetApiExt.Generated.Types.Base.BTreeMapT1();
            Individual.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
