using System;
using ExercicioVendaInterface;

namespace ExercicioVendaInterface
{
    public class Cartao : Pagamento
    {
        public string DadosTransacao { get; private set; }
        public int ResultadoTransacao { get; private set; }

        public Cartao(double total, string dadosTransacao, int resultadoTransacao)
            : base(total)
        {
            DadosTransacao = dadosTransacao;
            ResultadoTransacao = resultadoTransacao;
        }
    }
}