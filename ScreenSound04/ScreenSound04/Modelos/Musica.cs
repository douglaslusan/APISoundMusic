
using System.Text.Json.Serialization;

namespace ScreenSound04.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    
    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirParametros()
    {
        Console.WriteLine(
            $"Musica: {Nome}\n" +
            $"Artista: {Artista}\n" +
            $"Duracao: {Duracao / 1000}\n" +
            $"Genero: {Genero}");
    }
}
