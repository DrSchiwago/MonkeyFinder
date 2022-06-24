using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonkeyFinder.Model;
using System.Net.Http.Json;

namespace MonkeyFinder.Services
{
    public class MonkeyService
    {
        List<Monkey> monkeyList = new();
        HttpClient httpClient;

        public MonkeyService()
        {
            httpClient = new HttpClient();
        }
        
        public async Task<List<Monkey>> GetMonkeys()
        {
            if(monkeyList.Count > 0)
                return monkeyList;

            var response = await httpClient.GetAsync("https://www.montemagno.com/monkeys.json");

            if (response.IsSuccessStatusCode)
            {
                monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
            }

            // solution from file
            //using var stream = await FileSystem.OpenAppPackageFileAsync("monkeydata.json");
            //using var reader = new StreamReader(stream);
            //var contents = await reader.ReadToEndAsync();
            //monkeyList = JsonSerializer.Deserialize<List<Monkey>>(contents);

            return monkeyList;
        }
    }
}
