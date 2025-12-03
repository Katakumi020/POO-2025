using System;
using ExercicioVendaInterface;

namespace ExercicioVendaInterface
{
    public class Especie : Pagamento
    {
        public double Quantia { get; private set; }
        public double Troco => Quantia - Total;

        public Especie(double total, double quantia) : base(total)
        {
            Quantia = quantia;
        }
    }
}