using System.Net.Http.Headers;

namespace ScreenSound.Modelos;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    double Media { get; } 
}
