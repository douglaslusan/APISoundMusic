using ScreenSound04.Modelos;

namespace ScreenSound04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosGeneros(List<Musica> musicas)
    {
        var todosGeneros = musicas.Select(genero => genero.Genero).Distinct().ToList();
        foreach (var genero in todosGeneros)
        {
            Console.WriteLine(genero);
        }
    }

    public static void FiltrarArtistaPorGenero(List<Musica> musicas, string genero)
    {
        // na lista de musicas quero musicas onde contem o genero escolhido, selecionando o artista sem repetir e colocando em uma lista
        var artistaPorGenero = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(artista => artista.Artista).Distinct().ToList();

        foreach (var artista in artistaPorGenero)
        {
            Console.WriteLine(artista);
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        // na lista de musicas quero as musicas onde seja igual o artista escolhido e colocando em uma lista
        var musicaPorArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
        Console.WriteLine($"{artista}\n");
        foreach (var item in musicaPorArtista)
        {
            Console.WriteLine(item.Nome);
        }
    }
}
