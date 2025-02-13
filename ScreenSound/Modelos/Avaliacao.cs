using System.Globalization;

namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }

    // Método para criar uma avaliação a partir de um texto
    public static Avaliacao Parse(String texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
