using Dapper;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary;
public  class SqlDataAccess
{
    private readonly IConfiguration _config;

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<List<PersonModel>> LoadPeople()
    {
        string connectionString = _config.GetConnectionString("Default");
        string sql = "select * from dbo.People";

        using IDbConnection connection = new SqlConnection(connectionString);
        IEnumerable<PersonModel> output = await connection.QueryAsync<PersonModel>(sql, commandType: CommandType.Text);

        return output.ToList();
    }



}
