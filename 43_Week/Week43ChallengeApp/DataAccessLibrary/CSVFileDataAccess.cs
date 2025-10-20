using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLibrary
{
    public  class CSVFileDataAccess
    {
        
        public List<PersonModel> ReadAllRecords( string csvFile)
        {
            var errorLogPath = @"C:\\Users\\moxey\\source\\repos\\C#Mastercourse\\43_Week\\ErrorText.txt";
            var invalidLines = new List<string>();

            if (File.Exists(csvFile) == false)
            {
                return new List<PersonModel>();
            }

            var lines = File.ReadAllLines(csvFile);
            List<PersonModel> output = new List<PersonModel>();

            foreach(var line in lines)
            {
                PersonModel p = new PersonModel();
                var vals = line.Split(',');

                // check if there 3 col
                if(vals.Length != 3)
                {
                    invalidLines.Add($"Invalid row data: {line}");
                    continue;
                } 
                
                // check if there data in all 3 cols
                if(string.IsNullOrEmpty(vals[0]) || 
                    string.IsNullOrEmpty(vals[1]) || 
                    string.IsNullOrEmpty(vals[2]))
                {
                    invalidLines.Add($"Invalid row data: {line}");
                    continue;
                }

                
                p.FirstName = vals[0];
                p.LastName = vals[1];   
                p.State = vals[2];

                output.Add(p);

            }
            // Write all invalid rows to a text file (append if already exists)
            if (invalidLines.Any())
            {
                File.WriteAllLines(errorLogPath, invalidLines);
            }
            return output;  
        }

     
    }
}
