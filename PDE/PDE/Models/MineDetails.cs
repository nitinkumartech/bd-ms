using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PDE.Models
{
    public class MineDetails
    {
        public ObjectId Id { get; set; }
        [BsonElement("Company")]
        public string Company { get; set; }
        [BsonElement("Site")]
        public string Site { get; set; }
        [BsonElement("Mineral")]
        public string Mineral { get; set; }
        [BsonElement("CO2")]
        public string CO2 { get; set; }

        [BsonElement("Temperature")]
        public string Temperature { get; set; }
    }
}
