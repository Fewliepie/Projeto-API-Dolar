using System.Text.Json;

Console.WriteLine("Moedas, CotacaoDolarDia, CotacaoDolarPeriodo, CotacaoMoedaDia, CotacaoMoedaPeriodo");
var recurso = Console.ReadLine();







Console.WriteLine("Data da cotação - informar no padrão 'MM-DD-AAAA'");
var parametro = Console.ReadLine();
//var endereco = $@"https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/{recurso}?$format=json&";
var endereco = $@"https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/{recurso}(dataCotacao=@dataCotacao)?@dataCotacao='{parametro}'&$format=json";

var client  = new HttpClient();
try
{
	HttpResponseMessage? response = await client.GetAsync(endereco);
	response.EnsureSuccessStatusCode();
	string responseBody = await response.Content.ReadAsStringAsync();
    Console.WriteLine(responseBody);
   // List<moeda> Moedas = JsonSerializer.Deserialize<List<moeda>>(responseBody);


   // foreach (var moeda in Moedas)
	//{
	//	Console.WriteLine(moeda.simbolo);
	//	Console.WriteLine(moeda.nomeFormatado);
	//	Console.WriteLine(moeda.tipoMoeda);
	//}
}

catch (Exception)
{

	throw;
}

