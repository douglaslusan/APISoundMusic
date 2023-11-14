using System.Text.Json;

namespace ScreenSound04.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaMusicaPreferidas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaMusicaPreferidas = new();
    }

    public void AddMusicaFavorita(Musica musica)
    {
        ListaMusicaPreferidas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Musicas preferidas de {Nome}");
        foreach (var musica in ListaMusicaPreferidas)
        {
            Console.WriteLine($"Musica {musica.Nome} =>  {musica.Artista}");
        }
        Console.WriteLine();
    }

    internal void GerarArquivoJson()
    {
        // essa estrutura new {} na propriedade siginifica criar objeto anonimo
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaMusicaPreferidas,
        });
        string nomeDoArquivo = $"musicas-Favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
    }
}
