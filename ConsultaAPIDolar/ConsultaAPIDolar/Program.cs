using System.Text.Json;

Console.WriteLine("Moeda: ");
var moeda = Console.ReadLine();
var endereco = $@"https://economia.awesomeapi.com.br/json/last/{moeda}";
var client = new HttpClient();

try
{
	HttpResponseMessage? response = await client.GetAsync(endereco);
	response.EnsureSuccessStatusCode();
	string responseBody = await response.Content.ReadAsStringAsync();
    Console.WriteLine(responseBody);
}

catch (Exception)
{

	throw;
}
