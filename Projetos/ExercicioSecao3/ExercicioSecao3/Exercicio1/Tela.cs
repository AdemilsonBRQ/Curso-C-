using System;
using System.Globalization;

namespace ExercicioSecao3.Exercicio1
{
    class Tela
    {
        public int MenuExercicio1()
        {
            Console.WriteLine();
            Console.WriteLine("Digite uma das opções:");
            Console.WriteLine("1 – Listar produtos ordenadamente");
            Console.WriteLine("2 – Cadastrar produto");
            Console.WriteLine("3 – Cadastrar pedido");
            Console.WriteLine("4 – Mostrar dados de um pedido");
            Console.WriteLine("5 – Sair");

            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
                return 0;
            }
        }
        public static void ExibirProdutos()
        {
            Console.WriteLine();
            Console.WriteLine("LISTAGEM DE PRODUTOS: ");
            for(int i = 0; i < Program.produto.Count; i++)
            {
                Console.WriteLine(Program.produto[i]);
            }
        }
        public static void incluirProduto()
        {
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Código:");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descrição:");
            string descricao = Console.ReadLine();
            Console.Write("Preço:");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Produto P = new Produto(codigo, descricao, preco);
            Program.produto.Add(P);
            Program.produto.Sort();
        }

        public static void incluirPedido()
        {
            Console.WriteLine("Digite os dados do Pedido:");
            Console.Write("Pedido: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Pedido p = new Pedido(codigo, dia, mes, ano);

            Console.Write("Quantos itens tem o pedido? ");
            int quant = int.Parse(Console.ReadLine());

            for(int cont = 0; cont < quant; cont++)
            {
                Console.WriteLine("Digite os dados do " + (cont + 1) + "º item:");
                Console.Write("Produto (código): ");
                codigo = int.Parse(Console.ReadLine());
                int pos = Program.produto.FindIndex(x => x.codigo == codigo);
                if (pos == -1)
                {
                    throw new ModelException("Código do produto não encontrado: " + codigo);
                }
                else
                {
                    Console.Write("Quantidade: ");
                    int quantItem = int.Parse(Console.ReadLine());
                    Console.Write("Porcentagem de desconto:");
                    double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    ItemPedido item = new ItemPedido(quantItem, porc, p,Program.produto[pos]);
                    p.itens.Add(item);
                }
            }
            Program.pedidos.Add(p);
        }
        public static void exibirPedido()
        {
            Console.Write("Digite o código do pedido:");
            int codPedido = int.Parse(Console.ReadLine());
            int pos = Program.pedidos.FindIndex(x => x.codigo == codPedido);
            if(pos == -1)
            {
                throw new ModelException("Código do produto não encontrado: " + codPedido);
            }
            Console.WriteLine(Program.pedidos[pos]);
            Console.WriteLine();
        }
    }
}
