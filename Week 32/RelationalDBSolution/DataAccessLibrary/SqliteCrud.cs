using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SqliteCrud
    {
        private readonly string _connectionString;
        private SqliteDataAccess db = new SqliteDataAccess();

        public SqliteCrud(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Read 
        public List<BasicContactModel> GetAllContacts()
        {
            string sql = "select Id, FirstName, LastName from Contacts";
            return db.LoadData<BasicContactModel, dynamic>(sql, new { }, _connectionString);
        }

        public FullContactModel GetFullContactById(int id)
        {
            string sql = "select Id, FirstName, LastName from Contacts where Id = @Id";
            FullContactModel output = new FullContactModel();
            output.BasicInfo = db.LoadData<BasicContactModel, dynamic>(sql, new { Id = id }, _connectionString).FirstOrDefault(); // return first record

            if (output.BasicInfo == null)
            {
                // do something to tell the user that the record was not found
                throw new Exception("User not found");
                //return null;
            }

            sql = @"select e.*
                    from EmailAddresses e
                    inner join ContactEmail ce on ce.EmailAddressId = e.Id
                    where ce.ContactId = @Id";

            // load all the email addresses 
            output.EmailAddresses = db.LoadData<EmailAddressModel, dynamic>(sql, new { Id = id }, _connectionString);

            // load all the phone numbers
            sql = @"select p.*
                    from PhoneNumbers p
                    inner join ContactPhoneNumber cpn on cpn.PhoneNumberId = p.Id
                    where cpn.ContactId = @Id";


            output.PhoneNumbers = db.LoadData<PhoneNumberModel, dynamic>(sql, new { Id = id }, _connectionString);

            return output;
        }


        // Write 
        public void CreateContact(FullContactModel contact)
        {
            // save basic contact 
            string sql = "insert into Contacts (FirstName, LastName) values (@FirstName, @LastName);";
            db.SaveData(sql, new { FirstName = contact.BasicInfo.FirstName, LastName =   contact.BasicInfo.LastName }, _connectionString);

            // Get the Id number of the contact - look up by first and last name
            sql = "select Id from Contacts where FirstName = @FirstName and LastName = @LastName;";
            var contactId = db.LoadData<IdLookupModel, dynamic>(sql, new {FirstName =  contact.BasicInfo.FirstName, LastName = contact.BasicInfo.LastName }, _connectionString).First().Id;


            foreach (var phoneNumber in contact.PhoneNumbers)
            {
                // Identify if the phone number exists
                if (phoneNumber.Id == 0)
                {

                    // Insert the new phone number if not and get the id
                    sql = "insert into PhoneNumbers (PhoneNumber) values (@PhoneNumber);";
                    db.SaveData(sql, new { phoneNumber.PhoneNumber }, _connectionString);

                    sql = "select Id from PhoneNumbers where PhoneNumber = @PhoneNumber";
                    phoneNumber.Id = db.LoadData<IdLookupModel, dynamic>(sql, new { phoneNumber.PhoneNumber }, _connectionString).First().Id;
                }

                // Insert into link table for that number
                sql = "insert into ContactPhoneNumber (ContactId, PhoneNumberId) values (@ContactId, @PhoneNumberId);";

                // Then do the link table insert
                db.SaveData(sql, new { ContactId = contactId, PhoneNumberId = phoneNumber.Id }, _connectionString);
            }



            // Do the same for email 

            foreach (var emailAddress in contact.EmailAddresses)
            {
                if (emailAddress.id == 0)
                {
                    sql = "Insert into EmailAddresses (EmailAddress) values (@EmailAddress);";
                    db.SaveData(sql, new { emailAddress.EmailAddress }, _connectionString);

                    sql = "select id from  EmailAddresses where EmailAddress = @EmailAddress";
                    emailAddress.id = db.LoadData<IdLookupModel, dynamic>(sql, new { emailAddress.EmailAddress }, _connectionString).First().Id;
                }

                sql = "insert into ContactEmail (ContactId, EmailAddressId) values (@ContactId, @EmailAddressId);";

                db.SaveData(sql, new { contactId = contactId, EmailAddressId = emailAddress.id }, _connectionString);
            }

        }


        public void UpdateContactName(BasicContactModel contact)
        {
            string sql = "update Contacts set FirstName = @FirstName, LastName = @LastName where Id = @Id";
            db.SaveData(sql, contact, _connectionString);
        }

        public void RemovePhoneNumberFromContact(int contactId, int phoneNumberId)
        {
            // Find all the usages of the phone number id 
            string sql = "select Id, ContactId, PhoneNumberId from ContactPhoneNumber where PhoneNumberId = @PhoneNumberId";
            var links = db.LoadData<ContactPhoneNumberModel, dynamic>(sql, new { PhoneNumberId = phoneNumberId }, _connectionString);
            // if > 1, then delete link for contact 
            sql = "delete from ContactPhoneNumber where PhoneNumberId = @PhoneNumberId and ContactId = @ContactId";
            db.SaveData(sql, new { PhoneNumberId = phoneNumberId, ContactId = contactId }, _connectionString);

            // if 1, then delete link and phone 
            if (links.Count == 1)
            {
                sql = "delete from PhoneNumbers where Id = @PhoneNumberId;";
                db.SaveData(sql, new { PhoneNumberId = phoneNumberId }, _connectionString);
            }

        }
    }
}
