using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicaoBanco
{
    public class Banco
    {
        public string Nome { get; set; }
        private List<ContaCorrente> contasCorrente;
        private List<Poupanca> contasPoupanca;
        public Banco(string nome)
        {
            Nome = nome;
            contasCorrente = new List<ContaCorrente>();
            contasPoupanca = new List<Poupanca>();
            Console.WriteLine($"Banco {Nome} criado!");
        }
        public void AdicionarContaCorrente(ContaCorrente conta)
        {
            contasCorrente.Add(conta);
        }
        public void AdicionarPoupanca(Poupanca poupanca)
        {
            contasPoupanca.Add(poupanca);
        }
        public void ListarContas()
        {
            Console.WriteLine($"\n=== Contas no Banco {Nome} ===");
            foreach (var c in contasCorrente)
            {
                Console.WriteLine($"[Conta Corrente] Número: {c.Numero} | Saldo: {c.Saldo:C}");
            }
            foreach (var p in contasPoupanca)
            {
                Console.WriteLine($"[Poupança] Número: {p.Numero} | Saldo: {p.Saldo:C}");
            }
        }
    }
}