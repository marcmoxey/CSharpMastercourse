﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Week43ChallengeLibrary.DataAccess
{
    public class SQLDataAccess
    {
        public List<T> LoadData<T,U>(string sqlStatement, U parameter, string connectionString)
        {
            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement, parameter).ToList();
                return rows;
            }
        }

        public void SaveData<T>(string sqlStatement, T parameter, string connectionString)
        {
            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(sqlStatement, parameter);
            }
        }
    }
}
