using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Venda
    {
        public Comprador Comprador { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<Produto> Produtos { get; set; }

        public Venda(Comprador comprador, Vendedor vendedor)
        {
            Comprador = comprador;
            Vendedor = vendedor;
            Produtos = new List<Produto>();
        }

        public void RealizarVenda(Produto produto)
        {
            if (Comprador.Verba >= produto.Preco)
            {
                Produtos.Add(produto);
                Comprador.SubtrairVerba(produto.Preco);
                Vendedor.GerarComissao(produto);
                Console.WriteLine($"Venda realizada: {produto.Nome} por R$ {produto.Preco:F2}");
            }
            else
            {
                Console.WriteLine($"Compra não realizada. {Comprador.Nome} não tem verba suficiente.");
            }
        }

        public void MostrarResumo()
        {
            Console.WriteLine($"\nResumo da venda para {Comprador.Nome}:");
            foreach (Produto p in Produtos)
            {
                Console.WriteLine($"- {p.Codigo}: {p.Nome} | R$ {p.Preco:F2}");
            }
            Console.WriteLine($"Verba restante do comprador: R$ {Comprador.Verba:F2}");
            Console.WriteLine($"Comissão do vendedor {Vendedor.Nome}: R$ {Vendedor.Comissao:F2}");
        }
    }
}