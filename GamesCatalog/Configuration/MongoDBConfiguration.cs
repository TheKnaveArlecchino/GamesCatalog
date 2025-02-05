﻿namespace GamesCatalog.Configuration
{
    public class MongoDBConfiguration : IMongoDBConfiguration
    {

        public string ConnectionString { get; set; } = string.Empty;

        public string DatabaseName { get; set; } = string.Empty;
    }