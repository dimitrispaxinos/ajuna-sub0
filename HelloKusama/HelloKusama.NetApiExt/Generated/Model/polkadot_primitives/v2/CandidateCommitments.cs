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
    /// >> 351 - Composite[polkadot_primitives.v2.CandidateCommitments]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class CandidateCommitments : BaseType
    {
        
        /// <summary>
        /// >> upward_messages
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> _upwardMessages;
        
        /// <summary>
        /// >> horizontal_messages
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.OutboundHrmpMessage> _horizontalMessages;
        
        /// <summary>
        /// >> new_validation_code
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseOpt<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.ValidationCode> _newValidationCode;
        
        /// <summary>
        /// >> head_data
        /// </summary>
        private HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData _headData;
        
        /// <summary>
        /// >> processed_downward_messages
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _processedDownwardMessages;
        
        /// <summary>
        /// >> hrmp_watermark
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _hrmpWatermark;
        
        public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> UpwardMessages
        {
            get
            {
                return this._upwardMessages;
            }
            set
            {
                this._upwardMessages = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.OutboundHrmpMessage> HorizontalMessages
        {
            get
            {
                return this._horizontalMessages;
            }
            set
            {
                this._horizontalMessages = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.ValidationCode> NewValidationCode
        {
            get
            {
                return this._newValidationCode;
            }
            set
            {
                this._newValidationCode = value;
            }
        }
        
        public HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData HeadData
        {
            get
            {
                return this._headData;
            }
            set
            {
                this._headData = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 ProcessedDownwardMessages
        {
            get
            {
                return this._processedDownwardMessages;
            }
            set
            {
                this._processedDownwardMessages = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 HrmpWatermark
        {
            get
            {
                return this._hrmpWatermark;
            }
            set
            {
                this._hrmpWatermark = value;
            }
        }
        
        public override string TypeName()
        {
            return "CandidateCommitments";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(UpwardMessages.Encode());
            result.AddRange(HorizontalMessages.Encode());
            result.AddRange(NewValidationCode.Encode());
            result.AddRange(HeadData.Encode());
            result.AddRange(ProcessedDownwardMessages.Encode());
            result.AddRange(HrmpWatermark.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            UpwardMessages = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>();
            UpwardMessages.Decode(byteArray, ref p);
            HorizontalMessages = new Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.OutboundHrmpMessage>();
            HorizontalMessages.Decode(byteArray, ref p);
            NewValidationCode = new Ajuna.NetApi.Model.Types.Base.BaseOpt<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.ValidationCode>();
            NewValidationCode.Decode(byteArray, ref p);
            HeadData = new HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData();
            HeadData.Decode(byteArray, ref p);
            ProcessedDownwardMessages = new Ajuna.NetApi.Model.Types.Primitive.U32();
            ProcessedDownwardMessages.Decode(byteArray, ref p);
            HrmpWatermark = new Ajuna.NetApi.Model.Types.Primitive.U32();
            HrmpWatermark.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
