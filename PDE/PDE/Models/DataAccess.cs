using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace PDE.Models
{
    public class DataAccess
    {
        public class MineContext : IMineContext
        {
            private readonly IMongoDatabase _db;
            public MineContext(IOptions<Settings> options)
            {
                var client = new MongoClient(options.Value.ConnectionString);
                _db = client.GetDatabase(options.Value.Database);
            }
            public IMongoCollection<MineDetails> Mining => _db.GetCollection<MineDetails>("Mining");
        }

        public interface IMineContext
        {
            IMongoCollection<MineDetails> Mining { get; }
        }
    }
}
