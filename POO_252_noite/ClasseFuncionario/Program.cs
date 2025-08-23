using System;
using ClasseFuncionario;

internal class Program{
    private static void Main(string[] args)
    {
        Funcionario f1;

        f1 = new Funcionario();
        f1.codigo = 1;
        f1.nome = "Maria";
        f1.salario = 2500;
        f1.MostrarAtributos();
        f1.CalcularSalario(0.05);
        f1.MostrarAtributos();

        Funcionario f2 = new Funcionario();
        f1.codigo = 2;
        f1.nome = "Jonas";
        f1.salario = 600;
        f1.MostrarAtributos();
        f1.CalcularSalario(0.05);
        f1.MostrarAtributos();
    }
}