using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week43Challenge.Models;

namespace Week43ChallengeLibrary.DataAccess
{
    public class TextFileDataAccess
    {

        public List<PersonModel> ReadAllRecords(string textFile)
        {
            if(File.Exists(textFile) == false)
            {
                return new List<PersonModel>();
            }


            var lines = File.ReadAllLines(textFile);
            List<PersonModel> output = new List<PersonModel>();

            foreach (var line in lines) 
            {
                PersonModel p = new PersonModel();
                var vals = line.Split(','); 

                if(vals.Length > 3)
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
