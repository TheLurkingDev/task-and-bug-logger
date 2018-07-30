using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using TaskAndBugLogger.Models;

namespace TaskAndBugLogger.Data
{
    public class MongoDBRepository
    {
        public readonly IMongoDatabase Database;

        public MongoDBRepository(IOptions<Settings> settings)
        {
            try
            {
                var mongoClient = new MongoClient(settings.Value.ConnectionString);
                Database = mongoClient.GetDatabase(settings.Value.Database);
            }
            catch (Exception ex)
            {
                throw new Exception
                    ("There was a problem connecting to the MongoDB Database.", ex);                
            }
        }
    }
}
