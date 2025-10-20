using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public  class CSVFileDataAccess
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
                PersonModel p = new PersonModel();
                var vals = line.Split(',');

                if(vals.Length < 2)
                {
                    throw new Exception($"Invalid row data: {line}");
                } 

                
                p.FirstName = vals[0];
                p.LastName = vals[1];   
                p.State = vals[2];

                output.Add(p);

            }

            return output;  
        }
    }
}
