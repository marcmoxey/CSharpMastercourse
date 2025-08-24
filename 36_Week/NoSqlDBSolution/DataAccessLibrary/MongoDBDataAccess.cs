using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class MongoDBDataAccess
    {
        private IMongoDatabase db;
        public MongoDBDataAccess(string dbname, string connectionString)
        {
            var client = new MongoClient(connectionString); 
            db = client.GetDatabase(dbname); // connect to one db on mongoDB server
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table); // get table
            collection.InsertOne(record); // insert one record into table
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table); // establish connect to table
            return collection.Find(new BsonDocument()).ToList(); 
        }

        public T LoadRecordById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }

        
        public void UpsertRecord<T>(string table, Guid id, T record)
        {
            var collection = db.GetCollection<T>(table);
            var result = collection.ReplaceOne(
                 new BsonDocument("_id", id), 
                 record,
                 new ReplaceOptions {  IsUpsert = true }); // if match not there insert into collection
        }

        public void DeleteRecord<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}
