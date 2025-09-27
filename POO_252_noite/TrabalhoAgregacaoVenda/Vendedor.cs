using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Vendedor
    {
        public string Nome { get; set; }
        public double Comissao { get; private set; }
        public Vendedor(string nome)
        {
            Nome = nome;
            Comissao = 0;
        }
        public void GerarComissao(Produto produto)
        {
            Comissao += produto.Preco * 0.02;
        }
    }
}