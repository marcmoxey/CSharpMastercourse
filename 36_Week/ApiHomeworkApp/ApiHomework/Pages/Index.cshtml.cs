using ApiHomework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace ApiHomework.Pages
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
            await GetPerson();
        }

        private async Task GetPerson()
        {
            var _client = _httpClientFactory.CreateClient(); // create the browser
            var response = await _client.GetAsync("https://www.swapi.tech/api/people/1");

            List<PersonModel> people;


            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true, // ignore the case
                };

                string responseText = await response.Content.ReadAsStringAsync(); // json 
                people = JsonSerializer.Deserialize<List<PersonModel>>(responseText, options);
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
