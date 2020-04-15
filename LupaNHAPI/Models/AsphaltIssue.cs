using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;

namespace LupaNHAPI.Models
{
    public class AsphaltIssue
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        // public initial location { get; set; }
        public double Long { get; set; }
        public double Lat { get; set; }

        // public End location { get; set; }
        public double EndLong { get; set; }
        public double EndLat { get; set; }
       
        //Bool behavior
        public string Description { get; set; }

    }
}