using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    public class Assalariado : Funcionario
    {
        public Assalariado(int codigo, string nome, double salarioBase)
            : base(codigo, nome, salarioBase)
        {
        }

        public override double CalcularSalario(int diasUteis)
        {
            return (SalarioBase / 30) * diasUteis;
        }
    }
}