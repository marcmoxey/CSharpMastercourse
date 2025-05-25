using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericValidatorSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<UserModel> users = new List<UserModel>
            {
                  new UserModel { Name = "John", Email = "john@email.com" },
                  new UserModel { Name = "BadEmail", Email = "no-at-symbol.com" }


            };


            var userValidator = new Validator<UserModel>();

            userValidator.InvalidEntryFound += (sender, e) =>
            {
                Console.WriteLine($"Invalid user: {e.Name} - {e.Email}");
            };
            userValidator.AddRule(u => u.Email.Contains("@"));
            userValidator.Validate(users);








            List<ProductModel> products = new List<ProductModel>
            {

            }; 
            
            Console.ReadLine();
            
        }
    }

    public class Validator<T>
    {
        public event EventHandler<T> InvalidEntryFound; 

        private List<Func<T, bool>> _rules = new List<Func<T, bool>>();
        public void AddRule(Func<T, bool> rule)
        {
            _rules.Add(rule);   
        }

        public void Validate(List<T> items)
        {
            foreach (var item in items)
            {
                foreach(var rule in _rules)
                {
                    if(!rule(item))
                    {
                        InvalidEntryFound?.Invoke(this, item);
                        break;
                    }
                }
            }
        }
    }

    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class ProductModel
    {
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
