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

        // People Read 
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

        // People Wirte 
        public void CreatePerson(PersonModel person)
        {
            string sql = "insert into dbo.People (FirstName, LastName) values (@FirstName, @LastName);";
           
            using(SqlConnection conn = new(_connectionString))
            {
                SqlCommand cmd = new (sql, conn);
                SqlParameter param1 = new SqlParameter("@FirstName", person.FirstName);
                SqlParameter param2 = new SqlParameter("@LastName",person.LastName);
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

            using(SqlConnection conn = new(_connectionString))
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
                SqlCommand cmd = new (sql, conn);
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

        // Addresses Read
        public List<AddressModel> GetAllAddresses()
        {
            string sql = "select StreetAddress, City, State, ZipCode from dbo.Addresses";
            List<AddressModel> addresses = new List<AddressModel>();
            using(SqlConnection conn = new(_connectionString))
            {
                SqlCommand cmd = new(sql, conn); 

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        AddressModel address = new AddressModel
                        {
                            StreetAddress = reader["StreetAddress"].ToString(),
                            City = reader["City"].ToString(),
                            State = reader["State"].ToString(), 
                            ZipCode = reader["ZipCode"].ToString()
                        };
                        addresses.Add(address);
                    }
                    reader.Close();
                } 
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return addresses;
            }
        }

        public AddressModel GetAnAddressById(int id)
        {
            AddressModel address = new AddressModel();
            string sql = "select StreetAddress, City, State, ZipCode from dbo.Addresses where Id = @Id";
            using(SqlConnection conn = new(_connectionString))
            {
                SqlCommand cmd = new(sql, conn);
                SqlParameter param = new SqlParameter("@Id", id);
                cmd.Parameters.Add(param);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        address = new AddressModel
                        {
                            StreetAddress = reader["StreetAddress"].ToString(),
                            City = reader["City"].ToString(),
                            State = reader["State"].ToString(),
                            ZipCode = reader["ZipCode"].ToString()

                        };
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                return address;
            }

        }

        // Addresses Write 
        public void CreateAddress(AddressModel address)
        {
            string sql = "insert into dbo.Addresses (StreetAddress, City, State, ZipCode) values (@StreetAddress, @City, @State, @ZipCode);";
            using(SqlConnection conn = new(_connectionString))
            {
                SqlCommand cmd = new(sql, conn); 
                SqlParameter param1 = new SqlParameter("@StreetAddress", address.StreetAddress);
                SqlParameter param2 = new SqlParameter("@City", address.City);
                SqlParameter param3 = new SqlParameter("@State", address.State);
                SqlParameter param4 = new SqlParameter("@ZipCode", address.ZipCode);

                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.Parameters.Add(param4);

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

        public void UpdateAddress(AddressModel address)
        {
            string sql = "update dbo.Addresses set StreetAddress = @StreetAddress, City = @City, State = @State, ZipCode = @ZipCode where Id = @Id";
            using(SqlConnection conn = new(_connectionString))
            {
                SqlCommand cmd = new(sql, conn);
                SqlParameter param1 = new SqlParameter("@Id", address.Id);
                SqlParameter param2 = new SqlParameter("@StreetAddress", address.StreetAddress);
                SqlParameter param3 = new SqlParameter("@City", address.City);
                SqlParameter param4 = new SqlParameter("@State", address.State);
                SqlParameter param5= new SqlParameter("@ZipCode", address.ZipCode);

                cmd.Parameters.Add(@param1);
                cmd.Parameters.Add(@param2);
                cmd.Parameters.Add(@param3);
                cmd.Parameters.Add(@param4);
                cmd.Parameters.Add(@param5);

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

        public void DeleteAddress(int addressId)
        {
            string sql = "delete from dbo.Addresses where Id = @Id;";
            using(SqlConnection conn = new(_connectionString))
            {
                SqlCommand cmd = new(sql, conn);
                SqlParameter param = new SqlParameter("@Id", addressId);
                cmd.Parameters.Add(param);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close ();
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Erorr: {ex.Message}");
                }
            }
        }

    }
}
