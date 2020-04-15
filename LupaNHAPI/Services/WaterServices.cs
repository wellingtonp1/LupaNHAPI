using LupaNHAPI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LupaNHAPI.Services
{
    public class WaterServices
    {
        private readonly IMongoCollection<WaterIssue> _wissue;

        public WaterServices(ILupaNHDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _wissue = database.GetCollection<WaterIssue>(settings.WaterCollectionName);

        }

        public List<WaterIssue> Get() =>
          
            _wissue.Find(issue => true).ToList();


        public WaterIssue Get(string id) =>
            _wissue.Find<WaterIssue>(issue => issue.Id == id).FirstOrDefault();

        public WaterIssue Create(WaterIssue issue)
        {
            _wissue.InsertOne(issue);
            return issue;
        }

        public void Update(string id, WaterIssue issueIn) =>
            _wissue.ReplaceOne(issue => issue.Id == id, issueIn);

        public void Remove(WaterIssue issueIn) =>
            _wissue.DeleteOne(issue => issue.Id == issueIn.Id);

        public void Remove(string id) =>
            _wissue.DeleteOne(issue => issue.Id == id);
    }
}

