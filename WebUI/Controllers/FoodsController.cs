using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.FoodDtos;

namespace WebUI.Controllers
{
    public class FoodsController : Controller
    {
        public async Task<IActionResult> Index()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://tasty.p.rapidapi.com/recipes/list?from=0&size=20&tags=under_30_minutes"),
                Headers =
                {
                    { "x-rapidapi-key", "1cd0b07e55msh766ca1b28cc97eep1ddf20jsn394261c6dd7d" },
                    { "x-rapidapi-host", "tasty.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var root = JsonConvert.DeserializeObject<FoodTastyApi>(body);
                var values = root.Results;
                return View(values.ToList());
            }
        }
    }
}
