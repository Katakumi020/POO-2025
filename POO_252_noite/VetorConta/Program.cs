using System;
using VetorConta;

internal class Program{
    private static void Main(string[] args)
    {
        // declaração do vetor
        Conta[] vetContas = new Conta[3];
        //o laço de repetição realizará o cadsatro das contas
        for (int i = 0; i < vetContas.Length; i++){
            //instanciação de CADA índice
            vetContas[i] = new Conta();
            Console.WriteLine("Digite um numero: ");
            vetContas[i].numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o titular: ");
            vetContas[i].titular = (Console.ReadLine());
            Console.WriteLine("Digite o saldo: ");
            vetContas[i].saldo = Convert.ToDouble(Console.ReadLine());
        }
        // apresentação das contas com for
        for(int i = 0; i < vetContas.Length; i++)
            vetContas[i].MostrarAtributos();

        // apresentação das contas com foreach
        // o foreach APNEAS pode ser usado para vetor que contenha conteúdo
        foreach (Conta c in vetContas)
        {
            c.MostrarAtributos();
        }


    }
}