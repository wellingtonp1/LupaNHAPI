using LupaNHAPI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LupaNHAPI.Services
{
    public class TrashServices
    {
        private readonly IMongoCollection<TrashIssue> _tissue;

        public TrashServices(ILupaNHDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _tissue = database.GetCollection<TrashIssue>(settings.TrashCollectionName);

        }

        public List<TrashIssue> Get() =>
         
            _tissue.Find(issue => true).ToList();


        public TrashIssue Get(string id) =>
            _tissue.Find<TrashIssue>(issue => issue.Id == id).FirstOrDefault();

        public TrashIssue Create(TrashIssue issue)
        {
            _tissue.InsertOne(issue);
            return issue;
        }

        public void Update(string id, TrashIssue issueIn) =>
            _tissue.ReplaceOne(issue => issue.Id == id, issueIn);

        public void Remove(TrashIssue issueIn) =>
            _tissue.DeleteOne(issue => issue.Id == issueIn.Id);

        public void Remove(string id) =>
            _tissue.DeleteOne(issue => issue.Id == id);
    }
}

