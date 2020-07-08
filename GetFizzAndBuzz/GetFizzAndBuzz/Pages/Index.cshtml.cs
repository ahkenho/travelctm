using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GetFizzAndBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private static readonly HttpClient _httpClient;

        static IndexModel()
        {
            _httpClient = new HttpClient();
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public int InputNum { get; set; }

        public List<string> FizzBuzz { get; set; }


        public async Task OnGetAsync()
        {

            string serviceURL = $"http://localhost:8080/api/FizzBuzz/{InputNum}";
            var response = await _httpClient.GetAsync(serviceURL);
            FizzBuzz = JsonConvert.DeserializeObject<List<string>>(response.Content.ReadAsStringAsync().Result);
            
        }
    }
}
