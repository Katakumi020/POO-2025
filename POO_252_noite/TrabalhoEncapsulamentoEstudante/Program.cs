using System;
using TrabalhoEncapsulamentoEstudante;

internal class Program
{
    private static void Main()
    {
        Estudante e1 = new Estudante();
        e1.Nome = "Alec Bryan";
        e1.Nota = 8.5;

        Estudante e2 = new Estudante();
        e2.Nome = "Maria";
        e2.Nota = 5.5;

        Console.WriteLine("Detalhes dos Estudantes:");
        e1.InformacoesAlunos();
        e1.Aprovacao();

        Console.WriteLine();

        e2.InformacoesAlunos();
        e2.Aprovacao();
    }
}