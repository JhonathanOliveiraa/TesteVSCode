using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        int tempoViagem = int.Parse(console.WriteLine());
        int velocidadeMedia = int.Parse(console.WriteLine());
        double distancia = velocidadeMedia * tempoViagem;
        double quantidadeLitros = distancia / 12;

        Console.WriteLine($"{quantidadeLitros}");
        //quem ler é um ze ruela
    }
}
