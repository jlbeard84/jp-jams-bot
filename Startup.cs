using System;
using JpJamsBot.Business;
using JpJamsBot.Interfaces;
using JpJamsBot.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(JpJamsBot.Startup))]

namespace JpJamsBot
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var settings = PopulateSettings();

            builder.Services
                .AddSingleton(s => new CosmosClient(
                    settings.CosmosEndpointUrl,
                    settings.CosmosAuthorizationKey
                ))
                .AddSingleton<IAzureSettings>(s => settings)
                .AddScoped<IJamsService, JamsService>();
        }

        private AzureSettings PopulateSettings()
        {
            var settings = new AzureSettings
            {
                CosmosEndpointUrl = Environment
                    .GetEnvironmentVariable(nameof(AzureSettings.CosmosEndpointUrl)),
                CosmosAuthorizationKey = Environment
                    .GetEnvironmentVariable(nameof(AzureSettings.CosmosAuthorizationKey)),
                CosmosContainerId = Environment
                    .GetEnvironmentVariable(nameof(AzureSettings.CosmosContainerId)),
                CosmosDatabaseId = Environment
                    .GetEnvironmentVariable(nameof(AzureSettings.CosmosDatabaseId)),
            };

            return settings;
        }
    }
}