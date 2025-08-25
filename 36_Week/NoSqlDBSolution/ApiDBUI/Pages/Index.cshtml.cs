using ApiDBUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiDBUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory; // browse - put iu the url and got to the url 

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task OnGet()
        {
          
            await CreateContact();
            await GetAllContacts();
        }

        private async Task CreateContact()
        {
            ContactModel contact = new ContactModel
            {
                FirstName = "Marc",
                LastName = "Moxey"
            };
            contact.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "someemail@gmail.com" });
            contact.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "mam52801@gmail.com" });
            contact.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1212" });
            contact.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1234" });

            var _client = _httpClientFactory.CreateClient(); // create the browser
            var response = await _client.PostAsync("https://localhost:44339/api/Contacts",
                                                   new StringContent(JsonSerializer.Serialize(contact), Encoding.UTF8, "application/json"));


        }
        private async Task GetAllContacts()
        {
            var _client = _httpClientFactory.CreateClient(); // create the browser
            var response = await _client.GetAsync("https://localhost:44339/api/Contacts");
            // pull from appsettings.json

            List<ContactModel> contacts;

            if(response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true, // ignore the case
                };

                string responseText = await response.Content.ReadAsStringAsync(); // json 
                contacts = JsonSerializer.Deserialize<List<ContactModel>>(responseText,options);
            } else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
