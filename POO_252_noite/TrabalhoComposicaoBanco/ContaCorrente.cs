using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicaoBanco
{
    public class ContaCorrente
    {
        private static int contador = 1000;
        private double saldo;

        public int Numero { get; }
        public double Saldo
        {
            get { return saldo; }
            private set { saldo = value >= 0 ? value : 0; }
        }

        public ContaCorrente(double saldoInicial)
        {
            Numero = contador++;
            Saldo = saldoInicial;
            Console.WriteLine($"Conta Corrente {Numero} criada com saldo de {Saldo:C}");
        }

        public void Depositar(double valor)
        {
            if (valor > 0) Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
                Saldo -= valor;
            else
                Console.WriteLine("Saldo insuficiente!");
        }
    }
}