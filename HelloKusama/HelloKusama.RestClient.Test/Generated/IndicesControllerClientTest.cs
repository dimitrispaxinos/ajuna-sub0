//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using HelloKusama.RestClient.Mockup.Generated.Clients;
   using HelloKusama.RestClient.Generated.Clients;
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public class IndicesControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.NetApi.Model.Types.Primitive.Bool> GetTestValue2()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.NetApi.Model.Types.Primitive.Bool> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.NetApi.Model.Types.Primitive.Bool>();
         result.Create(this.GetTestValue3(), this.GetTestValueU128(), this.GetTestValueBool());
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue3()
      {
         HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new HelloKusama.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAccounts()
      {
         // Construct new Mockup client to test with.
         IndicesControllerMockupClient mockupClient = new IndicesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         IndicesControllerClient rpcClient = new IndicesControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.NetApi.Model.Types.Primitive.Bool> mockupValue = this.GetTestValue2();
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeAccounts(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAccounts(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.NetApi.Model.Types.Primitive.Bool> rpcResult = await rpcClient.GetAccounts(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
