//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using HelloKusama.NetApiExt.Generated.Model.pallet_bags_list.list;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IVoterListControllerMockupClient
   {
      Task<bool> SetListNodes(Node value, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetCounterForListNodes(U32 value);
      Task<bool> SetListBags(Bag value, U64 key);
   }
}
