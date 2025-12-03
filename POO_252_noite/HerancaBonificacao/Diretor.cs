using System;
using HerancaBonificacao;

namespace HerancaBonificacao
{
    public class Diretor : Funcionario
    {
        public Diretor(int codigo, string nome, double salario)
            : base(codigo, nome, salario)
        {
        }

        public override double CalcularBonificacao()
        {
            return (Salario * 0.10) + 1000.00; // 10% + R$1000 fixo
        }
    }
}