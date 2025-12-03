using System;
using ExercicioInterface;

internal class Program {
    static void Main(string[] args)
    {
        ContaCorrente cc = new ContaCorrente(1000);
        SeguroVida sv = new SeguroVida();

        TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
        totalizador.Adiciona(cc);
        totalizador.Adiciona(sv);

        Console.WriteLine("Tributos Conta Corrente: " + cc.CalculaTributos());
        Console.WriteLine("Tributos Seguro de Vida: " + sv.CalculaTributos());
        Console.WriteLine("Total de Tributos: " + totalizador.Total);

        Console.ReadKey();
    }
}