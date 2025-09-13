internal class Program
{
    private static void Main()
    {
        Produto[] produtos = new Produto[6];

        produtos[0] = new Produto(1, "Leite", 10.00, 20);
        produtos[1] = new Produto(2, "Biscoito", 5.50, 21);
        produtos[2] = new Produto(3, "Pão", 4.80, 30);
        produtos[3] = new Produto(4, "Agua", 3.20, 25);
        produtos[4] = new Produto(5, "Lápis", 1.00, 15);
        produtos[5] = new Produto(6, "Caderno", 12.50, 12);

        for (int i = 0; i < produtos.Length; i++)
        {
            if (i % 2 == 0)
            {
                produtos[i].CalcularAumento(10);
            }
        }
    
        for (int i = 0; i < produtos.Length; i++)
        {
            if (i % 2 != 0)
            {
                produtos[i].RetirarEstoque(3);
            }
        }
        
        Console.WriteLine("\nProdutos Atualizados:");
        for (int i = 0; i < produtos.Length; i++)
        {
            produtos[i].MostrarAtributos();
        }

        double total = 0;
        for (int i = 0; i < produtos.Length; i++)
        {
            total += produtos[i].Subtotal;
        }

        Console.WriteLine("\nSubtotal Geral: R$", total);
    }
}