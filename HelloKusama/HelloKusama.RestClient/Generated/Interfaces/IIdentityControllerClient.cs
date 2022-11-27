//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using HelloKusama.NetApiExt.Generated.Model.pallet_identity.types;
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   
   public interface IIdentityControllerClient
   {
      Task<Registration> GetIdentityOf(AccountId32 key);
      Task<bool> SubscribeIdentityOf(AccountId32 key);
      Task<BaseTuple<AccountId32, EnumData>> GetSuperOf(AccountId32 key);
      Task<bool> SubscribeSuperOf(AccountId32 key);
      Task<BaseTuple<U128, BoundedVecT22>> GetSubsOf(AccountId32 key);
      Task<bool> SubscribeSubsOf(AccountId32 key);
      Task<BoundedVecT23> GetRegistrars();
      Task<bool> SubscribeRegistrars();
   }
}