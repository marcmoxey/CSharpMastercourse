using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WrapUpDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{ FirstName = "Marc", LastName = "Moxeydarnit" ,Email = "moxeymarc@gmail.com"},
                new PersonModel{ FirstName = "Sue", LastName = "Storm" ,Email = "sue@stormy.net"},
                new PersonModel{ FirstName = "Tim", LastName = "Corey" ,Email = "tim@iamtimcorey.com"}
            };


            List<CarModel> cars = new List<CarModel> 
            {
                new CarModel { Manufacturer = "Toyota", Model = "HECKSupra"},
                new CarModel { Manufacturer = "Toyota", Model = "GR86" },
                new CarModel { Manufacturer = "Ford", Model = "Corvette"},
            };

            DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();
            peopleData.BadEntryFound += PeopleData_BadEntryFound;

            peopleData.SaveToCSV(people, @"C:\Users\moxey\source\repos\marcmoxey\CSharpMastercourse\Week 15\people.csv");



            DataAccess<CarModel> carData = new DataAccess<CarModel>();
            carData.BadEntryFound += CarData_BadEntryFound; 
            carData.SaveToCSV(cars,@"C:\Users\moxey\source\repos\marcmoxey\CSharpMastercourse\Week 15\cars.csv");





            Console.ReadLine(); 
        }

        private static void CarData_BadEntryFound(object sender, CarModel e)
        {
            Console.WriteLine($"Bad entry found for {e.Manufacturer} {e.Model}");
        }

        private static void PeopleData_BadEntryFound(object sender, PersonModel e)
        {
            Console.WriteLine($"Bad Entry found for { e.FirstName} {e.LastName}");
        }
    }

    public  class DataAccess<T> where T : new() // T(item being passing) need to have empty ctor
    {

        public event EventHandler<T> BadEntryFound; 


        public void SaveToCSV(List<T> items, string filePath)
        {
            List<string> rows = new List<string>();
            T entry = new T(); // new instance 
            var cols = entry.GetType().GetProperties();


            // Header Row
            string row = string.Empty;
            foreach (var col in cols )
            {
                row += $",{ col.Name } ";
            }
            row = row.Substring(1);  // cut of the leading comma
            rows.Add(row);

            // Value Row
            foreach(var item in items)
            {
                row = string.Empty; 
                bool badWordDetected =  false;
                foreach (var col in cols)
                {
                    string val = col.GetValue(item, null).ToString();
                 
                    badWordDetected = BadWordDetector(val); 
                    if(badWordDetected == true)
                    {
                        BadEntryFound?.Invoke(this, item);
                        break;
                    }

                    row += $",{val} "; // getting the value from the item
                }

                if (badWordDetected == true)
                {
                    continue;
                }
                row = row.Substring(1);  // cut of the leading comma
                rows.Add(row);
            }

            File.WriteAllLines(filePath, rows);
        }

        private bool BadWordDetector(string stringToTest)
        {
            bool output = false;

            string lowerCaseToTest = stringToTest.ToLower();
            if(lowerCaseToTest.Contains("darn") || lowerCaseToTest.Contains("heck")) 
            {
                output = true;
            }

            return output;
        }
    }
}
