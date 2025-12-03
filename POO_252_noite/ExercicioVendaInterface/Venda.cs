using System;
using System.Collections.Generic;
using System.Linq;
using ExercicioVendaInterface;

namespace ExercicioVendaInterface
{
    public class Venda
    {
        public DateTime Data { get; private set; }
        public List<ItemVenda> Itens { get; private set; }

        public double Total
        {
            get
            {
                double soma = Itens.Sum(i => i.Subtotal);
                int totalQtd = Itens.Sum(i => i.Quantidade);

                if (totalQtd >= 50)
                {
                    soma *= 0.80;
                }

                return soma;
            }
        }

        public Venda()
        {
            Data = DateTime.Now;
            Itens = new List<ItemVenda>();
        }

        public void AdicionarItem(Produto p, int quantidade)
        {
            if (p.Estoque < quantidade)
            {
                throw new Exception("Estoque insuficiente.");
            }

            p.Estoque -= quantidade;
            Itens.Add(new ItemVenda(p, quantidade));
        }
    }
}