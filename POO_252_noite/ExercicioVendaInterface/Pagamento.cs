using System;
using ExercicioVendaInterface;

namespace ExercicioVendaInterface
{
    public abstract class Pagamento
    {
        public DateTime Data { get; private set; }
        public double Total { get; protected set; }

        public Pagamento(double total)
        {
            Data = DateTime.Now;
            Total = total;
        }
    }
}