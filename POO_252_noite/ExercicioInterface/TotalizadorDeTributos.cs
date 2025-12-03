using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioInterface
{
    public class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Adiciona(Itributavel t)
        {
            Total += t.CalculaTributos();
        }
    }
}