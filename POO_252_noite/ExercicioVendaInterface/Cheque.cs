using System;
using ExercicioVendaInterface;

namespace ExercicioVendaInterface
{
    public class Cheque : Pagamento
    {
        public long Numero { get; private set; }
        public DateTime DataDeposito { get; private set; }
        public int Situacao { get; private set; }

        public Cheque(double total, long numero, DateTime dataDeposito) : base(total)
        {
            Numero = numero;
            DataDeposito = dataDeposito;
            Situacao = 0;
        }
    }
}