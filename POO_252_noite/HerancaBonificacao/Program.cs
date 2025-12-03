using System;
using HerancaBonificacao;

namespace HerancaBonificacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario(1, "Carlos", 3000);
            Secretario s1 = new Secretario(2, "Ana", 2800);
            Gerente g1 = new Gerente(3, "Roberto", 6000);
            Diretor d1 = new Diretor(4, "Fernanda", 10000);

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            gerenciador.TotalizadorBonificacao(f1);
            gerenciador.TotalizadorBonificacao(s1);
            gerenciador.TotalizadorBonificacao(g1);
            gerenciador.TotalizadorBonificacao(d1);

            Console.WriteLine("=== Bonificações Individuais ===");
            Console.WriteLine($"{f1.GetNome()}: R$ {f1.CalcularBonificacao():F2}");
            Console.WriteLine($"{s1.GetNome()}: R$ {s1.CalcularBonificacao():F2}");
            Console.WriteLine($"{g1.GetNome()}: R$ {g1.CalcularBonificacao():F2}");
            Console.WriteLine($"{d1.GetNome()}: R$ {d1.CalcularBonificacao():F2}");

            Console.WriteLine("\n=== Total de Bonificações ===");
            Console.WriteLine($"R$ {gerenciador.GetTotalBonificacao():F2}");
        }
    }
}