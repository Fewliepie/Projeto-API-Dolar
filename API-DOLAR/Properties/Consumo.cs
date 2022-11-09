




Console.WriteLine("Moeda: ");
var moeda = Console.ReadLine();
var endereco = $@"https://economia.awesomeapi.com.br/json/last/{moeda}";
var client = new HttpClient();


