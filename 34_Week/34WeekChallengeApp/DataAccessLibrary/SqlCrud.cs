using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SqlCrud
    {
        private readonly IConfiguration _config;

        public SqlCrud(IConfiguration config)
        {
            _config = config;
        }



        //Create 
        public void CreatePerson(PersonModel person)
        {
            string connectionString = _config.GetConnectionString("Default");
            string sql = "spData_CreatePerson";

            using (SqlConnection conn = new(connectionString))
            {
                SqlCommand cmd = new(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@FirstName", person.FirstName);
                SqlParameter param2= new SqlParameter("@LastName", person.LastName);

                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
  

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception ex)
                {

                    throw new Exception($"Error {ex.Message}");
                }
            }
        }


        // Read
        public List<PersonModel> GetAllPeople()
        {
            string connectionString = _config.GetConnectionString("Default");
            string sql = "spData_GetAllPeople";
            List<PersonModel> people = new List<PersonModel>();
            using (SqlConnection conn = new(connectionString))
            {
                SqlCommand cmd = new(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        PersonModel person = new PersonModel
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString()
                        };

                        people.Add(person);
                    }
                    conn.Close();
                } 
                catch (Exception ex)
                {
                    throw new Exception($"Error {ex.Message}");
                }

                return people;
            }
        }

        public PersonModel GetPersonById(int id)
        {
            PersonModel person = new PersonModel();
            string connectionString = _config.GetConnectionString("Default");
            string sql = "spData_GetPersonById"; 
            using(SqlConnection conn = new(connectionString))
            {
                SqlCommand cmd = new(sql,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@Id", id);
                cmd.Parameters.Add(param);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        person = new PersonModel
                        {
                            Id=Convert.ToInt32(reader["Id"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString()
                        };
                    }
                    conn.Close();
                   
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error {ex.Message}");
                }
               
                return person;
            }
        }


        // Update
        public void UpdatePerson(PersonModel person)
        {
            string connectionString = _config.GetConnectionString("Default");
            string sql = "spData_UpdatePerson";

            using(SqlConnection conn = new(connectionString))
            {
                SqlCommand cmd = new(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Id", person.Id);
                SqlParameter param2 = new SqlParameter("@FirstName", person.FirstName);
                SqlParameter param3 = new SqlParameter("@LastName", person.LastName);

                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception ex)
                {

                    throw new Exception($"Error {ex.Message}");
                }
            }
        }


        // Delete
        public void DeletePerson(int Id)
        {
            string connectionString = _config.GetConnectionString("Default");
            string sql = "spData_RemovePerson";

            using (SqlConnection conn = new(connectionString))
            {
                SqlCommand cmd = new(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Id", Id);
                cmd.Parameters.Add(param1);
    

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception ex)
                {

                    throw new Exception($"Error {ex.Message}");
                }
            }
        }
    }
}
