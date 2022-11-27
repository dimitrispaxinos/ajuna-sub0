//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class ConfigurationControllerMockupClient : MockupBaseClient, IConfigurationControllerMockupClient
   {
      private HttpClient _httpClient;
      public ConfigurationControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetActiveConfig(HostConfiguration value)
      {
         return await SendMockupRequestAsync(_httpClient, "Configuration/ActiveConfig", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ConfigurationStorage.ActiveConfigParams());
      }
      public async Task<bool> SetPendingConfigs(BaseVec<BaseTuple<U32, HostConfiguration>> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Configuration/PendingConfigs", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ConfigurationStorage.PendingConfigsParams());
      }
      public async Task<bool> SetBypassConsistencyCheck(Bool value)
      {
         return await SendMockupRequestAsync(_httpClient, "Configuration/BypassConsistencyCheck", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ConfigurationStorage.BypassConsistencyCheckParams());
      }
   }
}