using LinqAndLambdaHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdaHomework
{
    public static class SampleData
    {
        public static List<PersonModel> GetPersonData()
        {
                List<PersonModel> output = new List<PersonModel>
                {
                    new PersonModel { Id = 1, FirstName = "Marc", LastName = "Moxey"},
                    new PersonModel { Id = 2, FirstName = "Megan", LastName = "Moxey"},
                    new PersonModel { Id = 3, FirstName = "Kenneth", LastName = "Moxey"}
                };
            return output;
        }
     

      
    }
}
