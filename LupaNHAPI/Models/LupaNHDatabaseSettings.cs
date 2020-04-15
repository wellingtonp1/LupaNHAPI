using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LupaNHAPI.Models
{
    public class LupaNHDatabaseSettings : ILupaNHDatabaseSettings
    {
        public string LightCollectionName { get; set; }
        public string SewerCollectionName { get; set; }
        public string TrashCollectionName { get; set; }
        public string WaterCollectionName { get; set; }
        public string AsphaltCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ILupaNHDatabaseSettings
    {
        string LightCollectionName { get; set; }
        string SewerCollectionName { get; set; }
        string TrashCollectionName { get; set; }
        string WaterCollectionName { get; set; }
        string AsphaltCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
