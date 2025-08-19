using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CSVFileDataAccess
    {
        public List<PersonModel> ReadAllRecords(string csvFile)
        {
            if(File.Exists(csvFile) == false)
            {
                return new List<PersonModel>();
            }

            var lines = File.ReadAllLines(csvFile);
            List<PersonModel> output = new List<PersonModel>();

            foreach(var line in lines)
            {
                PersonModel person = new PersonModel();
                var vals = line.Split(',');

                if(vals.Length > 2)
                {
                    throw new Exception($"Invalid row data: {line}");
                }
        
               
                person.FirstName = vals[0];
                person.LastName = vals[1];

               
        
                

                output.Add(person);
            }
            return output;
        }

        public void WrtieAllRecords(List<PersonModel> people, string csvFile)
        {
            List<string> lines = new();

            foreach(var perosn in people)
            {
                lines.Add($"{perosn.FirstName},{perosn.LastName}");
            }
            File.WriteAllLines(csvFile, lines);
        }
    }
}
