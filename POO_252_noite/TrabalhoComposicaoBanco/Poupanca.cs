using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicaoBanco
{
    public class Poupanca
    {
        private static int contador = 2000;
        private double saldo;

        public int Numero { get; }
        public double Saldo
        {
            get { return saldo; }
            private set { saldo = value >= 0 ? value : 0; }
        }

        public Poupanca(double saldoInicial)
        {
            Numero = contador++;
            Saldo = saldoInicial;
            Console.WriteLine($"Poupança {Numero} criada com saldo de {Saldo:C}");
        }
        public void Depositar(double valor)
        {
            if (valor > 0) Saldo += valor;
        }
        public void RenderJuros(double taxa)
        {
            if (taxa > 0) Saldo += Saldo * taxa / 100;
        }
    }
}