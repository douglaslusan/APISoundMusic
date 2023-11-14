using ScreenSound04.Filtros;
using ScreenSound04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        // LinqFilter.FiltrarTodosGeneros(musicas);

        // LinqOrder.OrdenarArtista(musicas);

        // LinqFilter.FiltrarArtistaPorGenero(musicas, "pop");

        // LinqFilter.FiltrarMusicasPorArtista(musicas, "Eminem");

        var minhasMusicasPreferidas = new MusicasPreferidas("douglas");

        minhasMusicasPreferidas.AddMusicaFavorita(musicas[20]);
        minhasMusicasPreferidas.AddMusicaFavorita(musicas[30]);
        minhasMusicasPreferidas.AddMusicaFavorita(musicas[31]);
        minhasMusicasPreferidas.AddMusicaFavorita(musicas[45]);
        minhasMusicasPreferidas.AddMusicaFavorita(musicas[46]);

        minhasMusicasPreferidas.ExibirMusicasFavoritas();

        minhasMusicasPreferidas.GerarArquivoJson();

        var musicaspreferidasRazi = new MusicasPreferidas("razi");

        musicaspreferidasRazi.AddMusicaFavorita(musicas[121]);
        musicaspreferidasRazi.AddMusicaFavorita(musicas[149]);
        musicaspreferidasRazi.AddMusicaFavorita(musicas[254]);
        musicaspreferidasRazi.AddMusicaFavorita(musicas[306]);
        musicaspreferidasRazi.AddMusicaFavorita(musicas[552]);

        musicaspreferidasRazi.ExibirMusicasFavoritas();

        musicaspreferidasRazi.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    
}