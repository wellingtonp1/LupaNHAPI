using LupaNHAPI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LupaNHAPI.Services
{
    public class LightServices
    {
        private readonly IMongoCollection<LightIssue> _lissue;

        public LightServices(ILupaNHDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            //  IMongoCollection<GasStation> collection = _mongoDatabase.GetCollection<GasStation>("GasStations");
            //  collection.Indexes.CreateOne(new IndexKeysDefinitionBuilder<GasStation>().Geo2DSphere(x => x.Location));

            _lissue = database.GetCollection<LightIssue>(settings.LightCollectionName);
       
        }

        public List<LightIssue> Get() =>
            // _lissue.Find(issue => true).ToList();
            _lissue.Find(issue => true).ToList();
       

        public LightIssue Get(string id) =>
            _lissue.Find<LightIssue>(issue => issue.Id == id).FirstOrDefault();

        public LightIssue Create(LightIssue issue)
        {
            _lissue.InsertOne(issue);
            return issue;
        }

        public void Update(string id, LightIssue issueIn) =>
            _lissue.ReplaceOne(issue => issue.Id == id, issueIn);

        public void Remove(LightIssue issueIn) =>
            _lissue.DeleteOne(issue => issue.Id == issueIn.Id);

        public void Remove(string id) =>
            _lissue.DeleteOne(issue => issue.Id == id);
    }
}
