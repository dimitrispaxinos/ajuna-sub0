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
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet;
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   
   public class XcmPalletControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      [Test()]
      public async System.Threading.Tasks.Task TestQueryCounter()
      {
         // Construct new Mockup client to test with.
         XcmPalletControllerMockupClient mockupClient = new XcmPalletControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmPalletControllerClient rpcClient = new XcmPalletControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U64 mockupValue = this.GetTestValueU64();


         Assert.IsTrue(await rpcClient.SubscribeQueryCounter());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetQueryCounter(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U64 rpcResult = await rpcClient.GetQueryCounter();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus GetTestValue3()
      {
         HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus result;
         result = new HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus();
         result.Create(this.GetTestValueEnum<HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.QueryStatus>(), this.GetTestValue4());
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi.Model.Types.Primitive.U8>>, Ajuna.NetApi.Model.Types.Primitive.U32> GetTestValue4()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi.Model.Types.Primitive.U8>>, Ajuna.NetApi.Model.Types.Primitive.U32> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi.Model.Types.Primitive.U8>>, Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Create(this.GetTestValue5(), this.GetTestValue7(), this.GetTestValueU32());
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation GetTestValue5()
      {
         HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation result;
         result = new HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation();
         result.Create(this.GetTestValueEnum<HelloKusama.NetApiExt.Generated.Model.xcm.VersionedMultiLocation>(), this.GetTestValue6());
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation GetTestValue6()
      {
         HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation result;
         result = new HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation();
         result.Create(this.GetTestValueEnum<HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.MultiLocation>(), this.GetTestValueBaseVoid());
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi.Model.Types.Primitive.U8>> GetTestValue7()
      {
         Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi.Model.Types.Primitive.U8>> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi.Model.Types.Primitive.U8>>();
         result.Create(this.GetTestValue8());
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi.Model.Types.Primitive.U8> GetTestValue8()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi.Model.Types.Primitive.U8> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Create(this.GetTestValueU8(), this.GetTestValueU8());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestQueries()
      {
         // Construct new Mockup client to test with.
         XcmPalletControllerMockupClient mockupClient = new XcmPalletControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmPalletControllerClient rpcClient = new XcmPalletControllerClient(_httpClient, subscriptionClient);
         HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus mockupValue = this.GetTestValue3();
         Ajuna.NetApi.Model.Types.Primitive.U64 mockupKey = this.GetTestValueU64();

         Assert.IsTrue(await rpcClient.SubscribeQueries(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetQueries(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumQueryStatus rpcResult = await rpcClient.GetQueries(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue10()
      {
         HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 result;
         result = new HelloKusama.NetApiExt.Generated.Model.primitive_types.H256();
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
      public async System.Threading.Tasks.Task TestAssetTraps()
      {
         // Construct new Mockup client to test with.
         XcmPalletControllerMockupClient mockupClient = new XcmPalletControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmPalletControllerClient rpcClient = new XcmPalletControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();
         HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 mockupKey = this.GetTestValue10();

         Assert.IsTrue(await rpcClient.SubscribeAssetTraps(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAssetTraps(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetAssetTraps(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestSafeXcmVersion()
      {
         // Construct new Mockup client to test with.
         XcmPalletControllerMockupClient mockupClient = new XcmPalletControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmPalletControllerClient rpcClient = new XcmPalletControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeSafeXcmVersion());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSafeXcmVersion(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetSafeXcmVersion();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> GetTestValue13()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation>();
         result.Create(this.GetTestValueU32(), this.GetTestValue14());
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation GetTestValue14()
      {
         HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation result;
         result = new HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation();
         result.Create(this.GetTestValueEnum<HelloKusama.NetApiExt.Generated.Model.xcm.VersionedMultiLocation>(), this.GetTestValue15());
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation GetTestValue15()
      {
         HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation result;
         result = new HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation();
         result.Create(this.GetTestValueEnum<HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.MultiLocation>(), this.GetTestValueBaseVoid());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestSupportedVersion()
      {
         // Construct new Mockup client to test with.
         XcmPalletControllerMockupClient mockupClient = new XcmPalletControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmPalletControllerClient rpcClient = new XcmPalletControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> mockupKey = this.GetTestValue13();

         Assert.IsTrue(await rpcClient.SubscribeSupportedVersion(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSupportedVersion(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetSupportedVersion(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> GetTestValue17()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation>();
         result.Create(this.GetTestValueU32(), this.GetTestValue18());
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation GetTestValue18()
      {
         HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation result;
         result = new HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation();
         result.Create(this.GetTestValueEnum<HelloKusama.NetApiExt.Generated.Model.xcm.VersionedMultiLocation>(), this.GetTestValue19());
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation GetTestValue19()
      {
         HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation result;
         result = new HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation();
         result.Create(this.GetTestValueEnum<HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.MultiLocation>(), this.GetTestValueBaseVoid());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestVersionNotifiers()
      {
         // Construct new Mockup client to test with.
         XcmPalletControllerMockupClient mockupClient = new XcmPalletControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmPalletControllerClient rpcClient = new XcmPalletControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U64 mockupValue = this.GetTestValueU64();
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> mockupKey = this.GetTestValue17();

         Assert.IsTrue(await rpcClient.SubscribeVersionNotifiers(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetVersionNotifiers(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U64 rpcResult = await rpcClient.GetVersionNotifiers(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U32> GetTestValue21()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U32> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Create(this.GetTestValueU64(), this.GetTestValueU64(), this.GetTestValueU32());
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> GetTestValue22()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation>();
         result.Create(this.GetTestValueU32(), this.GetTestValue23());
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation GetTestValue23()
      {
         HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation result;
         result = new HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation();
         result.Create(this.GetTestValueEnum<HelloKusama.NetApiExt.Generated.Model.xcm.VersionedMultiLocation>(), this.GetTestValue24());
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation GetTestValue24()
      {
         HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation result;
         result = new HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation();
         result.Create(this.GetTestValueEnum<HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.MultiLocation>(), this.GetTestValueBaseVoid());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestVersionNotifyTargets()
      {
         // Construct new Mockup client to test with.
         XcmPalletControllerMockupClient mockupClient = new XcmPalletControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmPalletControllerClient rpcClient = new XcmPalletControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U32> mockupValue = this.GetTestValue21();
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> mockupKey = this.GetTestValue22();

         Assert.IsTrue(await rpcClient.SubscribeVersionNotifyTargets(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetVersionNotifyTargets(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U64, Ajuna.NetApi.Model.Types.Primitive.U32> rpcResult = await rpcClient.GetVersionNotifyTargets(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT35 GetTestValue26()
      {
         HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT35 result;
         result = new HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT35();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Ajuna.NetApi.Model.Types.Primitive.U32>>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Ajuna.NetApi.Model.Types.Primitive.U32>[] {
                  this.GetTestValue27()});
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Ajuna.NetApi.Model.Types.Primitive.U32> GetTestValue27()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Ajuna.NetApi.Model.Types.Primitive.U32> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation, Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Create(this.GetTestValue28(), this.GetTestValueU32());
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation GetTestValue28()
      {
         HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation result;
         result = new HelloKusama.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation();
         result.Create(this.GetTestValueEnum<HelloKusama.NetApiExt.Generated.Model.xcm.VersionedMultiLocation>(), this.GetTestValue29());
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation GetTestValue29()
      {
         HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation result;
         result = new HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.EnumMultiLocation();
         result.Create(this.GetTestValueEnum<HelloKusama.NetApiExt.Generated.Model.xcm.v0.multi_location.MultiLocation>(), this.GetTestValueBaseVoid());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestVersionDiscoveryQueue()
      {
         // Construct new Mockup client to test with.
         XcmPalletControllerMockupClient mockupClient = new XcmPalletControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmPalletControllerClient rpcClient = new XcmPalletControllerClient(_httpClient, subscriptionClient);
         HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT35 mockupValue = this.GetTestValue26();


         Assert.IsTrue(await rpcClient.SubscribeVersionDiscoveryQueue());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetVersionDiscoveryQueue(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT35 rpcResult = await rpcClient.GetVersionDiscoveryQueue();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage GetTestValue31()
      {
         HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage result;
         result = new HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage();
         result.Create(this.GetTestValueEnum<HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.VersionMigrationStage>(), this.GetTestValueBaseVoid());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestCurrentMigration()
      {
         // Construct new Mockup client to test with.
         XcmPalletControllerMockupClient mockupClient = new XcmPalletControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmPalletControllerClient rpcClient = new XcmPalletControllerClient(_httpClient, subscriptionClient);
         HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage mockupValue = this.GetTestValue31();


         Assert.IsTrue(await rpcClient.SubscribeCurrentMigration());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetCurrentMigration(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         HelloKusama.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumVersionMigrationStage rpcResult = await rpcClient.GetCurrentMigration();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
