namespace GamesCatalog.Configuration
{
    public interface IMongoDBConfiguration
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}