using System;
using ClasseProduto;

internal class Program{
    private static void Main(string[] args)
    {
        Produto p1;

        p1 = new Produto();
        p1.codigo = 1;
        p1.nome = "Lapis";
        p1.preco = 50;
        p1.estoque = 100;
        p1.MostrarAtributos();
        p1.CalcularAumento(0.5);
        p1.MostrarAtributos();
        p1.RetirarEstoque(10);
        p1.MostrarAtributos();
        p1.CalcularSubtotal();
        p1.MostrarAtributos();
    }
}