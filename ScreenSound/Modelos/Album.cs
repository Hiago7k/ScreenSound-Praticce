namespace ScreenSound.Modelos;

internal class Album : IAvaliavel // Implementando Iterface
{
    private List<Musica> musicas = new List<Musica>();
    //private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public Album(string nome)
    {
        Nome = nome;
        ContadorDeObjetos++; // incrementar objetos automaticos para contador
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;

    public double Media // Adicionando as regras necessarias
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
       
        
    public static int ContadorDeObjetos = 0;

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota); // Adicionando regra da interface
    }


    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }

   
}