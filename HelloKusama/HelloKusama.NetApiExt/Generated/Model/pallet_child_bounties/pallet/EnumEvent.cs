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


namespace HelloKusama.NetApiExt.Generated.Model.pallet_child_bounties.pallet
{
    
    
    public enum Event
    {
        
        Added = 0,
        
        Awarded = 1,
        
        Claimed = 2,
        
        Canceled = 3,
    }
    
    /// <summary>
    /// >> 460 - Variant[pallet_child_bounties.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U128, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>>
    {
    }
}