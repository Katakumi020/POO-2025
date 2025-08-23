using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        //declaração dos atributos
        public int codigo;
        public string nome;
        public double preco;
        public int estoque;
        public double subtotal;


        //declaração dos métodos/funções

        public void MostrarAtributos(){
            Console.WriteLine("codigo: " + codigo + "\tNome: " + nome + "\tEstoque: " + estoque + "\tPreço: " + preco + "\tSubtotal: " + subtotal);
        }
        public void CalcularAumento(double porcentagem){
            preco = preco + (preco * porcentagem);
        }
        public void RetirarEstoque(int qtde){
            estoque -= qtde;
        }
        public void CalcularSubtotal(){
            subtotal = preco * estoque;
        }
}
}