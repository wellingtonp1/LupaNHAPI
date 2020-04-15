using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;

namespace LupaNHAPI.Models
{
    public class SewerIssue
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string HasSanitation { get; set; }

        public double Long { get; set; }
        public double Lat { get; set; }
        public string HasCesspool { get; set; }
        public string Description { get; set; }

    }
}
