using System;
using JpJamsBot.Models;

namespace JpJamsBot.Base
{
    public abstract class FunctionBase
    {
        private AzureSettings _settings = null;

        protected AzureSettings Settings
        {
            get
            {
                if (_settings == null)
                {
                    _settings = PopulateSettings();
                }

                return _settings;
            }
        }

        private AzureSettings PopulateSettings()
        {
            var settings = new AzureSettings
            {
                CosmosEndpointUrl = Environment.GetEnvironmentVariable(nameof(AzureSettings.CosmosAuthorizationKey)),
                CosmosAuthorizationKey = Environment.GetEnvironmentVariable(nameof(AzureSettings.CosmosAuthorizationKey)),
                CosmosContainerId = Environment.GetEnvironmentVariable(nameof(AzureSettings.CosmosContainerId)),
                CosmosDatabaseId = Environment.GetEnvironmentVariable(nameof(AzureSettings.CosmosDatabaseId)),
            };

            return settings;
        }
    }
}