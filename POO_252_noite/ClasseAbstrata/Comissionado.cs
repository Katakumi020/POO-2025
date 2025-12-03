using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    public class Comissionado : Funcionario
    {
        public double Comissao { get; set; }

        public Comissionado(int codigo, string nome, double salarioBase, double comissao)
            : base(codigo, nome, salarioBase)
        {
            Comissao = comissao;
        }

        public override double CalcularSalario(int diasUteis)
        {
            return (SalarioBase / 30 * diasUteis) * Comissao + SalarioBase;
        }
    }
}