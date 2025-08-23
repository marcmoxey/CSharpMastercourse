using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CosmosDBDataAccess
    {
        private readonly string _endpointUrl;
        private readonly string _primaryKey;
        private readonly string _databaseName;
        private readonly string _containerName;

        private CosmosClient _cosmosClient;
        private Database _database;
        private Container _container;

        public CosmosDBDataAccess(string endpointUrl, string primaryKey, string databaseName, string containerName)
        {
            _endpointUrl = endpointUrl;
            _primaryKey = primaryKey;
            _databaseName = databaseName;
            _containerName = containerName;

            _cosmosClient = new CosmosClient(_endpointUrl, _primaryKey); // unlock server
            _database = _cosmosClient.GetDatabase(databaseName); // talk to the database
            _container = _database.GetContainer(containerName); // connect to specify container(table)
        }

      
        public async Task<List<T>> LoadRecordsASync<T>()
        {
            string sql = "Select * from c"; // c - alias, already talking to container
            QueryDefinition queryDefinition = new QueryDefinition(sql); 
            FeedIterator<T> feedIterator = _container.GetItemQueryIterator<T>(queryDefinition); // have records that match the query 

            List<T> output = new List<T>();

            while(feedIterator.HasMoreResults) // find more results that match 
            {
                FeedResponse<T> currentResultSet = await feedIterator.ReadNextAsync(); // grab result set

                foreach (var item in currentResultSet)
                {
                    output.Add(item); // loop through result add to output
                }
            }

            return output;
        }

        public async Task<T> LoadRecordById<T>(string id)
        {
            string sql = "Select * from c where c.id = @Id "; // c - alias, already talking to container
            QueryDefinition queryDefinition = new QueryDefinition(sql).WithParameter("@Id", id);
            FeedIterator<T> feedIterator = _container.GetItemQueryIterator<T>(queryDefinition); // have records that match the query 

            

            while (feedIterator.HasMoreResults) // find more results that match 
            {
                FeedResponse<T> currentResultSet = await feedIterator.ReadNextAsync(); // grab result set

                foreach(var item in currentResultSet)
                {
                    return item; // return first value 
                }
            }

            throw new Exception("Item not found");
        }

        // async need a task
        // Task is similar to void 
        public async Task UpsertRecordAsync<T>(T record)
        {
            await _container.UpsertItemAsync(record);  // wait for this code to be done before doing anything else 
            
        }

    }
}
