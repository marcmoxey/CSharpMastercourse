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
    }
}
