using System.Text.Json.Serialization;

namespace ScreenSound04.Modelos;

internal class Musica
{
    private string[] listaAcordes = { "C","C#","D","D#","E","F","F#","G","G#","A","A#","B"};

    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    
    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int? Key { get; set; }
    public string Acorde => listaAcordes[(int)Key!];
    public void ExibirParametros()
    {
        Console.WriteLine(
            $"Musica: {Nome}\n" +
            $"Artista: {Artista}\n" +
            $"Duracao: {Duracao / 1000}\n" +
            $"Genero: {Genero}\n" +
            $"Acorde: {Acorde}");
    }   
    

}
