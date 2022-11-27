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
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.crypto;
   
   public class ParaSessionInfoControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app.Public> GetTestValue2()
      {
         Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app.Public> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app.Public>();
         result.Create(new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app.Public[] {
                  this.GetTestValue3()});
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app.Public GetTestValue3()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app.Public result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app.Public();
         result.Value = new HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public();
         result.Value = this.GetTestValue4();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public GetTestValue4()
      {
         HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public result;
         result = new HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public();
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
      public async System.Threading.Tasks.Task TestAssignmentKeysUnsafe()
      {
         // Construct new Mockup client to test with.
         ParaSessionInfoControllerMockupClient mockupClient = new ParaSessionInfoControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParaSessionInfoControllerClient rpcClient = new ParaSessionInfoControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app.Public> mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeAssignmentKeysUnsafe());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAssignmentKeysUnsafe(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app.Public> rpcResult = await rpcClient.GetAssignmentKeysUnsafe();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestEarliestStoredSession()
      {
         // Construct new Mockup client to test with.
         ParaSessionInfoControllerMockupClient mockupClient = new ParaSessionInfoControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParaSessionInfoControllerClient rpcClient = new ParaSessionInfoControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeEarliestStoredSession());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetEarliestStoredSession(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetEarliestStoredSession();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.SessionInfo GetTestValue7()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.SessionInfo result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.SessionInfo();
         result.ActiveValidatorIndices = new Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex>();
         result.ActiveValidatorIndices.Create(new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex[] {
                  this.GetTestValue8()});
         result.RandomSeed = new HelloKusama.NetApiExt.Generated.Types.Base.Arr32U8();
         result.RandomSeed.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
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
         result.DisputePeriod = this.GetTestValueU32();
         result.Validators = new Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.validator_app.Public>();
         result.Validators.Create(new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.validator_app.Public[] {
                  this.GetTestValue9()});
         result.DiscoveryKeys = new Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.sp_authority_discovery.app.Public>();
         result.DiscoveryKeys.Create(new HelloKusama.NetApiExt.Generated.Model.sp_authority_discovery.app.Public[] {
                  this.GetTestValue11()});
         result.AssignmentKeys = new Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app.Public>();
         result.AssignmentKeys.Create(new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app.Public[] {
                  this.GetTestValue13()});
         result.ValidatorGroups = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex>>();
         result.ValidatorGroups.Create(new Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex>[] {
                  this.GetTestValue15()});
         result.NCores = this.GetTestValueU32();
         result.ZerothDelayTrancheWidth = this.GetTestValueU32();
         result.RelayVrfModuloSamples = this.GetTestValueU32();
         result.NDelayTranches = this.GetTestValueU32();
         result.NoShowSlots = this.GetTestValueU32();
         result.NeededApprovals = this.GetTestValueU32();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex GetTestValue8()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.validator_app.Public GetTestValue9()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.validator_app.Public result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.validator_app.Public();
         result.Value = new HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public();
         result.Value = this.GetTestValue10();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public GetTestValue10()
      {
         HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public result;
         result = new HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public();
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
      public HelloKusama.NetApiExt.Generated.Model.sp_authority_discovery.app.Public GetTestValue11()
      {
         HelloKusama.NetApiExt.Generated.Model.sp_authority_discovery.app.Public result;
         result = new HelloKusama.NetApiExt.Generated.Model.sp_authority_discovery.app.Public();
         result.Value = new HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public();
         result.Value = this.GetTestValue12();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public GetTestValue12()
      {
         HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public result;
         result = new HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public();
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
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app.Public GetTestValue13()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app.Public result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app.Public();
         result.Value = new HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public();
         result.Value = this.GetTestValue14();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public GetTestValue14()
      {
         HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public result;
         result = new HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public();
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
      public Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex> GetTestValue15()
      {
         Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex>();
         result.Create(new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex[] {
                  this.GetTestValue16()});
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex GetTestValue16()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex();
         result.Value = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestSessions()
      {
         // Construct new Mockup client to test with.
         ParaSessionInfoControllerMockupClient mockupClient = new ParaSessionInfoControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParaSessionInfoControllerClient rpcClient = new ParaSessionInfoControllerClient(_httpClient, subscriptionClient);
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.SessionInfo mockupValue = this.GetTestValue7();
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeSessions(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSessions(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.SessionInfo rpcResult = await rpcClient.GetSessions(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> GetTestValue18()
      {
         Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
         result.Create(new HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32[] {
                  this.GetTestValue19()});
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue19()
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
      public async System.Threading.Tasks.Task TestAccountKeys()
      {
         // Construct new Mockup client to test with.
         ParaSessionInfoControllerMockupClient mockupClient = new ParaSessionInfoControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParaSessionInfoControllerClient rpcClient = new ParaSessionInfoControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> mockupValue = this.GetTestValue18();
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeAccountKeys(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAccountKeys(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> rpcResult = await rpcClient.GetAccountKeys(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
