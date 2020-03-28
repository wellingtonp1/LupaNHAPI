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
    public class LightIssue
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public bool HasLightPole { get; set; }
       
       // public List<double> loc { get; set; }
        public double Long { get; set; }
        public double Lat { get; set; }
        public bool IsItWorking { get; set; }
        public string Description { get; set; }

    }
}