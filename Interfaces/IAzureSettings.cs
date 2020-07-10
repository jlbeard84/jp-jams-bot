namespace JpJamsBot.Interfaces
{
    public interface IAzureSettings
    {
        public string CosmosEndpointUrl { get; set; }

        public string CosmosAuthorizationKey { get; set; }

        public string CosmosDatabaseId { get; set; }

        public string CosmosContainerId { get; set; }
    }
}