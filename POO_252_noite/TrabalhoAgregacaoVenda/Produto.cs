using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Produto
    {
        private static int codigoAtual;
        private int codigo;
        private string nome;
        private double preco;

        static Produto()
        {
            codigoAtual = 500;
        }

        public Produto(string nome, double preco)
        {
            Codigo = codigoAtual++;
            Nome = nome;
            Preco = preco;
        }

        public int Codigo
        {
            get { return codigo; }
            private set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    nome = value;
                else
                    nome = "Sem nome";
            }
        }

        public double Preco
        {
            get { return preco; }
            set
            {
                if (value > 0)
                    preco = value;
                else
                    preco = 0;
            }
        }

        public void ExibirProduto()
        {
            Console.WriteLine($"Código: {Codigo}, Nome: {Nome}, Preço: {Preco:C2}");
        }
    }
}