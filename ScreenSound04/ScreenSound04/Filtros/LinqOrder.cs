using ScreenSound04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound04.Filtros
{
    internal class LinqOrder
    {
        public static void OrdenarArtista(List<Musica> musicas)
        {
            if (musicas == null)
            {
                return;
            }
            var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musica => musica.Artista).Distinct().ToList();

            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine(artista);
            }

        }
    }
}
