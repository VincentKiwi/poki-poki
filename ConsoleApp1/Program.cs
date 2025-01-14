using System.Text.Json;
using System.Net.Http.Json;

HttpClient client = new(); 

client.BaseAddress = new("https://digi-api.com/api/v1/digimon/");

HttpResponseMessage response = client.GetAsync("1460").Result;

digimon digimon = response.Content.ReadFromJsonAsync<digimon>().Result;

Console.WriteLine(digimon.name);

Console.ReadLine();


