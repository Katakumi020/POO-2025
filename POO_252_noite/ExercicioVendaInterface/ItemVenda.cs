using System;
using ExercicioVendaInterface;

namespace ExercicioVendaInterface
{
    public class ItemVenda
    {
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public double PrecoUnitario { get; private set; }
        public double Subtotal => Quantidade * PrecoUnitario;

        public ItemVenda(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitario = produto.Preco;
        }
    }
}