using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NewsOnThisDate.Services;
using NewsOnThisDate.DTO;

namespace NewsOnThisDate.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class WikiDataController : ControllerBase
    {

        private readonly HttpClient _httpClient;

        public WikiDataController()
        {
            _httpClient = new HttpClient();
        }

        [HttpGet]
        public async Task<IActionResult> Get(int? Month, int? Day)
        {
            WikiDataService wikiDataService = new WikiDataService();

            (string selectedMonth, string selectedDay) = wikiDataService.GetData(Month, Day);

            string requestUri = $"https://en.wikipedia.org/api/rest_v1/feed/onthisday/all/{selectedMonth.Replace("\"", "")}/{selectedDay.Replace("\"", "")}";

            HttpResponseMessage response = await _httpClient.GetAsync(requestUri);

            if (response.IsSuccessStatusCode)
            {
                var jsonContent = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<WikiDTO>(jsonContent);


                return Ok(responseObject);
            }
            else
            {
                return NotFound();
            }
        }
    }
}