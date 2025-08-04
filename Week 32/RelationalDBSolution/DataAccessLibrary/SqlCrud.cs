using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace DataAccessLibrary
{
    public class SqlCrud
    {
        private readonly string _connectionString;
        private SQLDataAccess db = new SQLDataAccess();

        public SqlCrud(string connectionString)
        {
           _connectionString = connectionString;
        }

        // Read 
        public List<BasicContactModel> GetAllContacts()
        {
            string sql = "select Id, FirstName, LastName from dbo.Contacts";
            return db.LoadData<BasicContactModel, dynamic>(sql, new { }, _connectionString);
        }

        public FullContactModel GetFullContactById(int id)
        {
            string sql = "select Id, FirstName, LastName from dbo.Contacts where Id = @Id";
            FullContactModel output = new FullContactModel();
            output.BasicInfo = db.LoadData<BasicContactModel, dynamic>(sql, new { Id = id }, _connectionString).FirstOrDefault(); // return first record

            if(output.BasicInfo == null)
            {
                // do something to tell the user that the record was not found
                throw new Exception("User not found");
                //return null;
            }

            sql = @"select e.*
                    from dbo.EmailAddresses e
                    inner join dbo.ContactEmail ce on ce.EmailAddressId = e.Id
                    where ce.ContactId = @Id";

            // load all the email addresses 
            output.EmailAddresses = db.LoadData<EmailAddressModel, dynamic>(sql, new { Id = id }, _connectionString);

            // load all the phone numbers
            sql = @"select p.*
                    from dbo.PhoneNumbers p
                    inner join dbo.ContactPhoneNumber cpn on cpn.PhoneNumberId = p.Id
                    where cpn.ContactId = @Id";


            output.PhoneNumbers = db.LoadData<PhoneNumberModel, dynamic>(sql, new{ Id = id }, _connectionString);

            return output;
        }


        // Write 
        public void CreateContact(FullContactModel contact)
        {
            // save basic contact 
            string sql = "insert into dbo.Contacts (FirstName, LastName) values (@FirstName, @LastName);";
            db.SaveData(sql, new { FirstName =  contact.BasicInfo.FirstName, LastName = contact.BasicInfo.LastName }, _connectionString);

            // Get the Id number of the contact - look up by first and last name
            sql = "select Id from dbo.Contacts where FirstName = @FirstName and LastName = @LastName;";
            var contactId = db.LoadData<IdLookupModel, dynamic>(sql, new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName }, _connectionString).First().Id;

            
                 foreach(var phoneNumber in contact.PhoneNumbers)
                 {
                        // Identify if the phone number exists
                        if (phoneNumber.Id == 0)
                        {

                            // Insert the new phone number if not and get the id
                            sql = "insert into dbo.PhoneNumbers (PhoneNumber) values (@PhoneNumber);";
                            db.SaveData(sql, new { phoneNumber.PhoneNumber}, _connectionString);

                           sql = "select Id from dbo.PhoneNumbers where PhoneNumber = @PhoneNumber";
                           phoneNumber.Id = db.LoadData<IdLookupModel, dynamic>(sql, new { phoneNumber.PhoneNumber }, _connectionString).First().Id;
                        }

                    // Insert into link table for that number
                    sql = "insert into dbo.ContactPhoneNumber (ContactId, PhoneNumberId) values (@ContactId, @PhoneNumberId);";

                    // Then do the link table insert
                    db.SaveData(sql, new { ContactId = contactId, PhoneNumberId = phoneNumber.Id}, _connectionString);
                 }



            // Do the same for email 

            foreach(var emailAddress in contact.EmailAddresses)
            {
                if(emailAddress.id == 0)
                {
                    sql = "Insert into dbo.EmailAddresses (EmailAddress) values (@EmailAddress);";
                    db.SaveData(sql, new {emailAddress.EmailAddress}, _connectionString);

                    sql = "select id from  dbo.EmailAddresses where EmailAddress = @EmailAddress";
                    emailAddress.id = db.LoadData<IdLookupModel, dynamic>(sql, new { emailAddress.EmailAddress }, _connectionString).First().Id;
                }

                sql = "insert into dbo.ContactEmail (ContactId, EmailAddressId) values (@ContactId, @EmailAddressId);";

                db.SaveData(sql, new { contactId = contactId, EmailAddressId = emailAddress.id }, _connectionString);
            }

        }
    }
}
