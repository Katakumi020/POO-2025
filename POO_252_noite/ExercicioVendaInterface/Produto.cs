using System;
using ExercicioVendaInterface;

namespace ExercicioVendaInterface
{
    public class Produto
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public Produto(long codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Nome: {Nome}, Preço: {Preco}, Estoque: {Estoque}";
        }
    }
}