using Newtonsoft.Json;

namespace SistemaCambio;

public class Moeda
{
    [JsonProperty("code")]
    public string Codigo {get; set;} = "";

    [JsonProperty("name")] 
    public string Nome {get; set;} = "";

    [JsonProperty("bid")]
    public string ValorCompra {get; set;} = "";
    
    [JsonProperty("create_date")]
    public string DataConsulta { get; set; } = "";

    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Nome} ({Codigo})");
        Console.WriteLine($" Preço Atual: R$ {ValorCompra}");
        Console.WriteLine($"Data: {DataConsulta}");
    }

}