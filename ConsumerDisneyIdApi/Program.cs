using System.Text.Json;

const string apiUrl = "https://api.disneyapi.dev/character/423";

using HttpClient client = new HttpClient();

try
{
    Console.WriteLine("Iniciando requisição para obter dados do personagem:");
    Console.WriteLine();
    Console.WriteLine(apiUrl);
    Console.WriteLine();

    string resposta = await client.GetStringAsync(apiUrl);

    using JsonDocument json = JsonDocument.Parse(resposta);

    JsonElement data = json.RootElement.GetProperty("data");

    string nome = data
        .GetProperty("name")
        .GetString() ?? "Nome não encontrado.";

    string imagem = data
        .GetProperty("imageUrl")
        .GetString() ?? "Imagem não encontrada.";

    Console.WriteLine("Nome:");
    Console.WriteLine(nome);
    Console.WriteLine();
    Console.WriteLine("Imagem:");
    Console.WriteLine(imagem);
}
catch (HttpRequestException)
{
    Console.WriteLine("Não foi possível acessar a Disney API.");
}
catch (JsonException)
{
    Console.WriteLine("Não foi possível interpretar os dados retornados pela API.");
}
