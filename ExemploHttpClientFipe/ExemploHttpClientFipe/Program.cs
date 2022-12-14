//Você pode alterar na url "carros" para "motos" ou "caminhoes" de acordo com a sua necessidade.
using ExemploHttpClientFipe;
using System.Text.Json;
using static System.Net.WebRequestMethods;

Console.WriteLine("Digite o tipo de veículo! (carros -motos-caminhoes)");
var TipoVeiculo=Console.ReadLine();
var endereco= $@"https://parallelum.com.br/fipe/api/v1/{TipoVeiculo}/marcas";
var client = new HttpClient();
try
{
	HttpResponseMessage? response=await client.GetAsync(endereco);
	response.EnsureSuccessStatusCode();
	string responseBody=await response.Content.ReadAsStringAsync();
	//Console.WriteLine(responseBody);
	List<veiculo> Veiculos=JsonSerializer.Deserialize<List<veiculo>>(responseBody);

	foreach (var veiculo in Veiculos)
	{
		Console.WriteLine(veiculo.nome);
		Console.WriteLine(veiculo.codigo);
	}
}
catch (Exception)
{

	throw;
}