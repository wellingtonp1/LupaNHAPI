using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;

namespace LupaNHAPI.Models
{
    public class TrashIssue
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        //Bool behavior
        public string HasWasteCollection { get; set; }
        public double Long { get; set; }
        public double Lat { get; set; }
        
        // 0 - no collection, 1x a week, 2- 3x a week, 3- once a month
        public string HowOften { get; set; }
        
        public string Description { get; set; }

    }
}
