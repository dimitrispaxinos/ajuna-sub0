//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.scheduler
{
    
    
    public enum AssignmentKind
    {
        
        Parachain = 0,
        
        Parathread = 1,
    }
    
    /// <summary>
    /// >> 778 - Variant[polkadot_runtime_parachains.scheduler.AssignmentKind]
    /// </summary>
    public sealed class EnumAssignmentKind : BaseEnumExt<AssignmentKind, BaseVoid, BaseTuple<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.collator_app.Public, Ajuna.NetApi.Model.Types.Primitive.U32>>
    {
    }
}