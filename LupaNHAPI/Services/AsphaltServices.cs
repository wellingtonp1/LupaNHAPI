using LupaNHAPI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LupaNHAPI.Services
{
    public class AsphaltServices
    {
        private readonly IMongoCollection<AsphaltIssue> _lissue;

        public AsphaltServices(ILupaNHDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _lissue = database.GetCollection<AsphaltIssue>(settings.AsphaltCollectionName);

        }

        public List<AsphaltIssue> Get() =>
          
            _lissue.Find(issue => true).ToList();


        public AsphaltIssue Get(string id) =>
            _lissue.Find<AsphaltIssue>(issue => issue.Id == id).FirstOrDefault();

        public AsphaltIssue Create(AsphaltIssue issue)
        {
            _lissue.InsertOne(issue);
            return issue;
        }

        public void Update(string id, AsphaltIssue issueIn) =>
            _lissue.ReplaceOne(issue => issue.Id == id, issueIn);

        public void Remove(AsphaltIssue issueIn) =>
            _lissue.DeleteOne(issue => issue.Id == issueIn.Id);

        public void Remove(string id) =>
            _lissue.DeleteOne(issue => issue.Id == id);
    }
}
