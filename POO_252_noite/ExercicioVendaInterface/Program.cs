using System;
using ExercicioVendaInterface;

namespace ExercicioVendaInterface
{
    class Program
    {
        static List<Produto> produtos = new List<Produto>();

        static void Main()
        {
            int opc = 0;

            while (opc != 4)
            {
                Console.WriteLine("\n=== MENU PRINCIPAL ===");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Realizar Venda");
                Console.WriteLine("4 - Sair");
                Console.Write("Opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1: CadastrarProduto(); break;
                    case 2: ListarProdutos(); break;
                    case 3: RealizarVenda(); break;
                }
            }
        }

        static void CadastrarProduto()
        {
            Console.Write("\nCódigo: ");
            long codigo = long.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Estoque: ");
            int estoque = int.Parse(Console.ReadLine());

            produtos.Add(new Produto(codigo, nome, preco, estoque));

            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        static void ListarProdutos()
        {
            Console.WriteLine("\n=== LISTA DE PRODUTOS ===");
            foreach (var p in produtos)
                Console.WriteLine(p);
        }

        static void RealizarVenda()
        {
            Venda venda = new Venda();
            int opc = 0;

            while (opc != 3)
            {
                Console.WriteLine("\n=== MENU DE VENDA ===");
                Console.WriteLine("1 - Adicionar Item");
                Console.WriteLine("2 - Finalizar Venda");
                Console.WriteLine("3 - Cancelar");
                Console.Write("Opção: ");
                opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {
                    AdicionarItemVenda(venda);
                }
                else if (opc == 2)
                {
                    FinalizarVenda(venda);
                    return;
                }
            }
        }

        static void AdicionarItemVenda(Venda venda)
        {
            ListarProdutos();

            Console.Write("\nDigite o código do produto: ");
            long cod = long.Parse(Console.ReadLine());

            Produto prod = produtos.Find(p => p.Codigo == cod);

            if (prod == null)
            {
                Console.WriteLine("Produto não encontrado!");
                return;
            }

            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine());

            try
            {
                venda.AdicionarItem(prod, qtd);
                Console.WriteLine("Item adicionado!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        static void FinalizarVenda(Venda venda)
        {
            Console.WriteLine($"\nTotal da venda: {venda.Total:F2}");

            Console.WriteLine("\nFormas de pagamento:");
            Console.WriteLine("1 - Espécie");
            Console.WriteLine("2 - Cheque");
            Console.WriteLine("3 - Cartão");

            Console.Write("Opção: ");
            int op = int.Parse(Console.ReadLine());

            Pagamento pag = null;

            switch (op)
            {
                case 1:
                    Console.Write("Valor entregue: ");
                    double quantia = double.Parse(Console.ReadLine());
                    pag = new Especie(venda.Total, quantia);
                    Console.WriteLine($"Troco: {(pag as Especie).Troco:F2}");
                    break;

                case 2:
                    Console.Write("Número do cheque: ");
                    long num = long.Parse(Console.ReadLine());
                    Console.Write("Data depósito (DD-MM-AAAA): ");
                    DateTime dt = DateTime.Parse(Console.ReadLine());
                    pag = new Cheque(venda.Total, num, dt);
                    Console.WriteLine("Cheque registrado!");
                    break;

                case 3:
                    Console.Write("Dados da transação: ");
                    string dados = Console.ReadLine();
                    pag = new Cartao(venda.Total, dados, 1);
                    Console.WriteLine("Transação aprovada!");
                    break;
            }

            Console.WriteLine("\nVenda finalizada com sucesso!");
        }
    }
}