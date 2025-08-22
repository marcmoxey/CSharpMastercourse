using ApiSQLDBUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;
using System.Text.Json;
using System.Net.Http;

namespace ApiSQLDBUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task OnGet()
        {

            await CreatePerson();
           // await GetAllPeople();
        }

        private async Task CreatePerson()
        {
            PersonModel person = new PersonModel
            {
                Id = 7,
                FirstName = "Marc",
                LastName = "Moxey"
            };

            var _client = _httpClientFactory.CreateClient(); // create browser
            var response = await _client.PostAsync("https://localhost:7261/api/People",
               new StringContent(JsonSerializer.Serialize(person), Encoding.UTF8, "application/json"));
        }

        private async Task GetAllPeople()
        {
            var _client = _httpClientFactory.CreateClient(); // create browser
            var response = await _client.GetAsync("https://localhost:7261/api/People");

            List<PersonModel> people;

            if(response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };
            } else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}