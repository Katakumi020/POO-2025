using System;
using ClasseProduto;

internal class Program{
    private static void Main(string[] args)
    {/*
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
*/
        
        produto p2;

        p2 = new Produto();
        Console.WriteLine("Informe o nome do produto: ");
        p2.nome = Console.ReadLine();
        Console.WriteLine("Informe o estoque: ");
        p2.estoque = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o preço do produto: ");
        p2.preco = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o preço do produto: ");
        p2.porcentagem = Convert.ToDouble(Console.ReadLine());
        p2.MostrarAtributos();
        p2.CalcularAumento();
        p2.MostrarAtributos();
        p2.RetirarEstoque();
        p2.MostrarAtributos();
        p2.CalcularSubtotal();
        p2.MostrarAtributos();

        
    }
}