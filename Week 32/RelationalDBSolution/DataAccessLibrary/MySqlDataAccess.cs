using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class MySqlDataAccess
    {
        public List<T> LoadData<T, U>(string sqlStatment, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatment, parameters).ToList();
                return rows;
            }
        }

        public void SaveData<T>(string sqlStatment, T parameter, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Execute(sqlStatment, parameter);
            }
        }
    }
}
