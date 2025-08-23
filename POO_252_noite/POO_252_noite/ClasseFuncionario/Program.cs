using System;
using ClasseFuncionario;

internal class Program{
    private static void Main(string[] args)
    {
        Funcionario f1;

        f1 = new Funcionario();
        f1.codigo = 1;
        f1.nome = "Ana";
        f1.salario = 200;
        f1.MostrarAtributos();
        f1.CalcularSalario(0.05);
        f1.MostrarAtributos();
    }
}