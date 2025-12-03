using System;
using TrabalhoComposicaoBanco;

internal class Program
{
    private static void Main()
    {
        Banco banco = new Banco("FatecBank");
        ContaCorrente c1 = new ContaCorrente(1500);
        ContaCorrente c2 = new ContaCorrente(500);

        Poupanca p1 = new Poupanca(2000);
        Poupanca p2 = new Poupanca(1000);

        banco.AdicionarContaCorrente(c1);
        banco.AdicionarContaCorrente(c2);
        banco.AdicionarPoupanca(p1);
        banco.AdicionarPoupanca(p2);

        c1.Depositar(300);
        c2.Sacar(100);
        p1.RenderJuros(5);

        banco.ListarContas();
    }
}