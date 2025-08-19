using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class TextFileDataAccess
    {
        public List<ContactModel> ReadAllRecords(string textFile)
        {
            if (File.Exists(textFile) == false)
            {
                return new List<ContactModel>();
            }

            var lines = File.ReadAllLines(textFile);
            List<ContactModel> output = new List<ContactModel>();

            foreach (var line in lines)
            {
                ContactModel c = new ContactModel();
                var vals = line.Split(','); // spit string into a string array
               
                if(vals.Length < 4) // check if line is valid
                {
                    throw new Exception($"Invalid row data: {line}");
                }
                c.FirstName = vals[0];
                c.LastName = vals[1];
                c.EmailAddresses = vals[2].Split(';').ToList();
                c.PhoneNumbers = vals[3].Split(';').ToList();

                output.Add(c);
            }

            return output;
        }

        public void WriteAllRecords(List<ContactModel> contacts, string textFile)
        {
            // Tim,Corey,555-1212
            List<string> lines = new();

            foreach(var c in contacts)
            {
                lines.Add($"{c.FirstName},{c.LastName},{String.Join(';', c.EmailAddresses)},{String.Join(';', c.PhoneNumbers)}");
            }
            File.WriteAllLines(textFile, lines);
        }


    }
}
