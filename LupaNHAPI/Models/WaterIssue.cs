using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;

namespace LupaNHAPI.Models
{
    public class WaterIssue
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        //Bool behavior
        public string HasPipedWater { get; set; }
        // 0- no lack of water, 1- Once a week, 2- three times a week, etc...
        public string HasOftenWaterLack { get; set; }
        public double Long { get; set; }
        public double Lat { get; set; }
        //Bool behavior
        public string HasBorehole { get; set; }
        //0 - Artesiano, 1- Amazonas
        public string KindofBorehole { get; set; }
        public string Description { get; set; }
    }
}
