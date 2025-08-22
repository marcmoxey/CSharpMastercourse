using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public  class SqlCrud
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
                SqlCommand cmd = new(sql, connection);

                try
                {
                    connection.Open();
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

        // People Wirte 
        public void CreatePerson(PersonModel person)
        {
            string sql = "insert into dbo.People (FirstName, LastName) values (@FirstName, @LastName);";

            using (SqlConnection conn = new(_connectionString))
            {
                SqlCommand cmd = new(sql, conn);
                SqlParameter param1 = new SqlParameter("@FirstName", person.FirstName);
                SqlParameter param2 = new SqlParameter("@LastName", person.LastName);
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
                    Console.WriteLine(ex.Message);
                }
            }
        }


        public void UpdatePerson(PersonModel person)
        {
            string sql = "update dbo.People set FirstName = @FirstName, LastName = @LastName where Id = @Id";

            using (SqlConnection conn = new(_connectionString))
            {
                SqlCommand cmd = new(sql, conn);
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
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void DeletePerson(int id)
        {
            string sql = "delete from dbo.People where Id = @Id";
            using (SqlConnection conn = new(_connectionString))
            {
                SqlCommand cmd = new(sql, conn);
                SqlParameter param = new SqlParameter("@Id", id);
                cmd.Parameters.Add(param);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
