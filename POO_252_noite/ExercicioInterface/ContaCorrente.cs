using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    public class ContaCorrente : Itributavel
    {
        public double Saldo { get; set; }

        public ContaCorrente(double saldo)
        {
            Saldo = saldo;
        }

        public double CalculaTributos()
        {
            return Saldo * 0.05;
        }
    }
}