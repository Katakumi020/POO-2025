using System;
using HerancaBonificacao;

namespace HerancaBonificacao
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;

        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            totalBonificacao += funcionario.CalcularBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return totalBonificacao;
        }
    }
}