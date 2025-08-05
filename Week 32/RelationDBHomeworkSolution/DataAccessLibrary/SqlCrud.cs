using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SqlCrud
    {
        private readonly string _connectionString;

        public SqlCrud(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<PersonModel> GetAllPeople()
        {

            string sql = "select Id, FirstName, LastName from dbo.People";
           List<PersonModel> people = new List<PersonModel>();
            using (SqlConnection connection = new(_connectionString))
            {
                SqlCommand cmd = new(sql,connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    while(reader.Read())
                    {
                        PersonModel person = new PersonModel
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString()
                        };

                        
                        people.Add(person);

                    }
                    reader.Close();
                 
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            
            }

            return people;
        }

        public PersonModel GetPersonById(int id)
        {
            PersonModel person = new PersonModel();
            string sql = "select Id, FirstName, LastName from dbo.People where Id = @Id"; 
            using (SqlConnection connection = new(_connectionString))
            {
                SqlCommand cmd = new(sql, connection);
                SqlParameter param = new SqlParameter("@Id", id);
              
                cmd.Parameters.Add(param);

                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        person = new PersonModel
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString()
                        };


                      

                    }
                    reader.Close();

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            return person;
        }
    }
}
