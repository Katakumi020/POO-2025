using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVetorProduto
{
    public class Produto
    {

    public int Codigo { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Estoque { get; set; }
    public double Subtotal { get; private set; }

    public Produto(int codigo, string nome, double preco, int estoque)
    {
        Codigo = codigo;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
        CalcularSubtotal();
    }

        public void MostrarAtributos()
        {
            Console.WriteLine("codigo: " + codigo + "\tNome: " + nome + "\tEstoque: " + estoque + "\tPreço: " + preco + "\tSubtotal: " + subtotal);
        }
        public void CalcularAumento(double porcentagem)
        {
            preco = preco + (preco * (porcentagem / 100));
            CalcularSubtotal();
        }
        public void RetirarEstoque(int qtde)
        {
            estoque -= qtde;
            CalcularSubtotal();
        }
        public void CalcularSubtotal(){
            subtotal = preco * estoque;
        }
    }
}