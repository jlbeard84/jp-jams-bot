using System.Threading.Tasks;
using JpJamsBot.Models;
using Microsoft.Azure.Cosmos;

namespace JpJamsBot.Base
{
    public abstract class ServiceBase
    {
        protected readonly CosmosClient CosmosClient;
        protected readonly AzureSettings Settings;

        protected ServiceBase(
            CosmosClient client,
            AzureSettings settings)
        {
            CosmosClient = client;
            Settings = settings;
        }

        protected async Task SetupDb()
        {
            await CosmosClient
                .CreateDatabaseIfNotExistsAsync(Settings.CosmosDatabaseId);
        }
    }
}