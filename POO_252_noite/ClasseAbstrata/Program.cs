using System;
using ClasseAbstrata;

internal class Program {
    static void Main()
    {
        Departamento dep = new Departamento("Tecnologia");

        Funcionario f1 = new Assalariado(1, "Maria", 3000);
        Funcionario f2 = new Comissionado(2, "João", 2500, 0.20);

        dep.Admitir(f1);
        dep.Admitir(f2);

        f1.AdicionarDependente(new Dependente(1, "Carlos", 12));
        f1.AdicionarDependente(new Dependente(2, "Julia", 10));

        Console.WriteLine("DEPENDENTES DE MARIA:");
        f1.ListarDependentes();
        Console.WriteLine("Total: " + f1.CalcularTotalDependentes());

        Console.WriteLine("\nFUNCIONÁRIOS:");
        dep.ListarFuncionarios(20);

        Console.WriteLine("\nCUSTO DA FOLHA (20 dias úteis):");
        Console.WriteLine(dep.CalcularCustoFolha(20));

        Console.ReadKey();
    }
}


