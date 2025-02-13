namespace ScreenSound.Modelos;

internal class Banda
{
    private List<Album> albuns = new();
    private List<Avaliacao> notas = new();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public double Media
    {
        get
        {
            if (notas.Count == 0)
                return 0;
            else
                return notas.Average(a => a.Nota);
        }
    }
    public List<Album> Albuns => albuns;

    // Adiciona um álbum à discografia da banda
    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    // Adiciona uma avaliação à lista de notas da banda
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    // Exibe a discografia da banda
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}
