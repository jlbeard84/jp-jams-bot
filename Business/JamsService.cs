using JpJamsBot.Base;
using JpJamsBot.Models;
using Microsoft.Azure.Cosmos;

namespace JpJamsBot.Business
{
    public class JamsService : ServiceBase, IJamsService
    {
        public JamsService(
            CosmosClient cosmosClient,
            AzureSettings settings)
            : base(cosmosClient, settings)
        { }
    }
}