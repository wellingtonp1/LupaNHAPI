using LupaNHAPI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LupaNHAPI.Services
{
    public class SewerServices
    {
        private readonly IMongoCollection<SewerIssue> _sissue;

        public SewerServices(ILupaNHDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _sissue = database.GetCollection<SewerIssue>(settings.SewerCollectionName);

        }

        public List<SewerIssue> Get() =>
         
            _sissue.Find(issue => true).ToList();


        public SewerIssue Get(string id) =>
            _sissue.Find<SewerIssue>(issue => issue.Id == id).FirstOrDefault();

        public SewerIssue Create(SewerIssue issue)
        {
            _sissue.InsertOne(issue);
            return issue;
        }

        public void Update(string id, SewerIssue issueIn) =>
            _sissue.ReplaceOne(issue => issue.Id == id, issueIn);

        public void Remove(SewerIssue issueIn) =>
            _sissue.DeleteOne(issue => issue.Id == issueIn.Id);

        public void Remove(string id) =>
            _sissue.DeleteOne(issue => issue.Id == id);
    }
}

