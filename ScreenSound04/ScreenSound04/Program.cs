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

        //LinqFilter.FiltrarArtistaPorGenero(musicas, "pop");

        LinqFilter.FiltrarMusicasPorArtista(musicas, "Eminem");



    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    
}