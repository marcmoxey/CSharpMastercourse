using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SqliteCrud
    {
        private readonly string _connectionString;

        public SqliteCrud(string connectionString)
        {
            _connectionString = connectionString;
        }

        // People Read 
        public List<PersonModel> GetAllPeople()
        {

            string sql = "select Id, FirstName, LastName from People";
            List<PersonModel> people = new List<PersonModel>();
            using (SQLiteConnection connection = new(_connectionString))
            {
                SQLiteCommand cmd = new(sql, connection);

                try
                {
                    connection.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();

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
            string sql = "select Id, FirstName, LastName from People where Id = @Id";
            using (SQLiteConnection connection = new(_connectionString))
            {
                SQLiteCommand cmd = new(sql, connection);
                SQLiteParameter param = new SQLiteParameter("@Id", id);

                cmd.Parameters.Add(param);

                try
                {
                    connection.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();

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
        public void CreatePerson(FullPersonModel person)
        {
           

            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                SQLiteTransaction trans = conn.BeginTransaction();

                try
                {
                    int PersonId;

                    // 1. Insert employer and get ID
                    string sql = @"INSERT INTO People (FirstName, LastName) 
                           VALUES (@FirstName, @LastName); 
                           SELECT SCOPE_IDENTITY();";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@FirstName",  person.BasicInfo.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", person.BasicInfo.LastName);
                        PersonId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2. Insert each address and link to employer
                    foreach (var address in person.Addresses)
                    {
                        int addressId = address.Id;

                        if (addressId == 0)
                        {
                            sql = @"INSERT INTO Addresses (StreetAddress, City, State, ZipCode) 
                            VALUES (@StreetAddress, @City, @State, @ZipCode); 
                            SELECT SCOPE_IDENTITY();";

                            using (SQLiteCommand cmd = new SQLiteCommand(sql, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@StreetAddress", address.StreetAddress);
                                cmd.Parameters.AddWithValue("@City", address.City);
                                cmd.Parameters.AddWithValue("@State", address.State);
                                cmd.Parameters.AddWithValue("@ZipCode", address.ZipCode);

                                addressId = Convert.ToInt32(cmd.ExecuteScalar());
                            }
                        }

                        // 3. Link address to employer
                        sql = "INSERT INTO EPersonAddress (PersonId, AddressId) VALUES (@PersonId, @AddressId);";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@EmployerId", PersonId);
                            cmd.Parameters.AddWithValue("@AddressId", addressId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    Console.WriteLine($"Error: {ex.Message}");
                    throw;
                }
            }
        }


        public void UpdatePerson(PersonModel person)
        {
            string sql = "update People set FirstName = @FirstName, LastName = @LastName where Id = @Id";

            using (SQLiteConnection conn = new(_connectionString))
            {
                SQLiteCommand cmd = new(sql, conn);
                SQLiteParameter param1 = new SQLiteParameter("@Id", person.Id);
                SQLiteParameter param2 = new SQLiteParameter("@FirstName", person.FirstName);
                SQLiteParameter param3 = new SQLiteParameter("@LastName", person.LastName);
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
            string sql = "delete from People where Id = @Id";
            using (SQLiteConnection conn = new(_connectionString))
            {
                SQLiteCommand cmd = new(sql, conn);
                SQLiteParameter param = new SQLiteParameter("@Id", id);
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
            string sql = "select StreetAddress, City, State, ZipCode from Addresses";
            List<AddressModel> addresses = new List<AddressModel>();
            using (SQLiteConnection conn = new(_connectionString))
            {
                SQLiteCommand cmd = new(sql, conn);

                try
                {
                    conn.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
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
            string sql = "select StreetAddress, City, State, ZipCode from Addresses where Id = @Id";
            using (SQLiteConnection conn = new(_connectionString))
            {
                SQLiteCommand cmd = new(sql, conn);
                SQLiteParameter param = new SQLiteParameter("@Id", id);
                cmd.Parameters.Add(param);

                try
                {
                    conn.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
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
            string sql = "insert into Addresses (StreetAddress, City, State, ZipCode) values (@StreetAddress, @City, @State, @ZipCode);";
            using (SQLiteConnection conn = new(_connectionString))
            {
                SQLiteCommand cmd = new(sql, conn);
                SQLiteParameter param1 = new SQLiteParameter("@StreetAddress", address.StreetAddress);
                SQLiteParameter param2 = new SQLiteParameter("@City", address.City);
                SQLiteParameter param3 = new SQLiteParameter("@State", address.State);
                SQLiteParameter param4 = new SQLiteParameter("@ZipCode", address.ZipCode);

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
            string sql = "update Addresses set StreetAddress = @StreetAddress, City = @City, State = @State, ZipCode = @ZipCode where Id = @Id";
            using (SQLiteConnection conn = new(_connectionString))
            {
                SQLiteCommand cmd = new(sql, conn);
                SQLiteParameter param1 = new SQLiteParameter("@Id", address.Id);
                SQLiteParameter param2 = new SQLiteParameter("@StreetAddress", address.StreetAddress);
                SQLiteParameter param3 = new SQLiteParameter("@City", address.City);
                SQLiteParameter param4 = new SQLiteParameter("@State", address.State);
                SQLiteParameter param5 = new SQLiteParameter("@ZipCode", address.ZipCode);

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
            string sql = "delete from Addresses where Id = @Id;";
            using (SQLiteConnection conn = new(_connectionString))
            {
                SQLiteCommand cmd = new(sql, conn);
                SQLiteParameter param = new SQLiteParameter("@Id", addressId);
                cmd.Parameters.Add(param);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Erorr: {ex.Message}");
                }
            }
        }


        // Employer Read
        public List<EmployerModel> GetAllEmployers()
        {
            string sql = "select Id, Employer from Employers;";
            List<EmployerModel> employers = new List<EmployerModel>();

            using (SQLiteConnection conn = new(_connectionString))
            {
                SQLiteCommand cmd = new(sql, conn);

                try
                {
                    conn.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        EmployerModel employer = new EmployerModel
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Employer = reader["Employer"].ToString()
                        };
                        employers.Add(employer);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return employers;
            }
        }

        public EmployerModel GetEmployerById(int id)
        {
            EmployerModel employer = new EmployerModel();
            string sql = "select Id,  employer from Employers where Id = @Id;";


            using (SQLiteConnection conn = new(_connectionString))
            {
                SQLiteCommand cmd = new(sql, conn);
                SQLiteParameter param = new SQLiteParameter("@Id", id);
                cmd.Parameters.Add(param);

                try
                {
                    conn.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        employer = new EmployerModel
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Employer = reader["Employer"].ToString()
                        };
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return employer;
            }
        }

        // Employer Write

        public void UpdateEmployer(EmployerModel employer)
        {
            string sql = "update Employers set Employer = @Employer where Id = @Id;";
            using (SQLiteConnection conn = new(_connectionString))
            {
                SQLiteCommand cmd = new(sql, conn);
                SQLiteParameter param = new SQLiteParameter("@Id", employer.Id);
                SQLiteParameter param2 = new SQLiteParameter("@Employer", employer.Employer);
                cmd.Parameters.Add(param);
                cmd.Parameters.Add(param2);

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

        public void DeleteEmployer(int id)
        {
            string sql = "delete from Employers where Id = @Id;";
            using (SQLiteConnection conn = new(_connectionString))
            {
                SQLiteCommand cmd = new(sql, conn);
                SQLiteParameter param = new SQLiteParameter("@Id", id);
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

        public void CreateEmployer(FullEmployerModel employer)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                SQLiteTransaction trans = conn.BeginTransaction();

                try
                {
                    int employerId;

                    // 1. Insert employer and get ID
                    string sql = @"INSERT INTO Employers (Employer) 
                           VALUES (@Employer); 
                           SELECT SCOPE_IDENTITY();";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@Employer", employer.BasicInfo.Employer);
                        employerId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2. Insert each address and link to employer
                    foreach (var address in employer.Addresses)
                    {
                        int addressId = address.Id;

                        if (addressId == 0)
                        {
                            sql = @"INSERT INTO Addresses (StreetAddress, City, State, ZipCode) 
                            VALUES (@StreetAddress, @City, @State, @ZipCode); 
                            SELECT SCOPE_IDENTITY();";

                            using (SQLiteCommand cmd = new SQLiteCommand(sql, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@StreetAddress", address.StreetAddress);
                                cmd.Parameters.AddWithValue("@City", address.City);
                                cmd.Parameters.AddWithValue("@State", address.State);
                                cmd.Parameters.AddWithValue("@ZipCode", address.ZipCode);

                                addressId = Convert.ToInt32(cmd.ExecuteScalar());
                            }
                        }

                        // 3. Link address to employer
                        sql = "INSERT INTO EmployerAddress (EmployerId, AddressId) VALUES (@EmployerId, @AddressId);";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@EmployerId", employerId);
                            cmd.Parameters.AddWithValue("@AddressId", addressId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    Console.WriteLine($"Error: {ex.Message}");
                    throw;
                }
            }
        }

    }
}
