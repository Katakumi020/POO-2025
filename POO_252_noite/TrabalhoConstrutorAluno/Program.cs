using System;
using TrabalhoConstrutorAluno;
internal class Program
{
    private static void Main()
    {
        Aluno aluno1 = new Aluno();
        Aluno aluno2 = new Aluno("Alecsandro Silva");
        Aluno aluno3 = new Aluno("JOAQUIM SOUZA");

        Console.WriteLine("Lista dos Alunos:");
        aluno1.MostrarAtributos();
        aluno2.MostrarAtributos();
        aluno3.MostrarAtributos();

        Console.ReadKey();
    }
}