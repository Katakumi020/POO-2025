using System;
using EncapsulamentoConta;

internal class Program
{
    private static void Main(string[] args)
    {
        Conta c1 = new Conta();
        c1.Numero = 1;
        c1.Titular = "Alec";
        c1.Saldo = 100;
        c1.MostrarAtributos();

        Conta c2 = new Conta();
        Console.WriteLine("Digite o número: ");
        c2.Numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o titular: ");
        c2.Titular = Console.ReadLine();  // Corrigido aqui

        Console.WriteLine("Digite o saldo: ");
        c2.Saldo = Convert.ToDouble(Console.ReadLine());  // Corrigido aqui

        c2.MostrarAtributos();  // Mostrar os atributos do c2, não c1
    }
}