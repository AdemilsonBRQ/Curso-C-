using System;
using System.Collections.Generic;
using ExercicioSecao3.Exercicio1;

namespace ExercicioSecao3
{
    class Program
    {
        public static List<Produto> produto = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>();

        static void Main(string[] args)
        {
            int numExercicio;
            Console.WriteLine("Digite o numero do exercicio, ou '0' para sair:");
            numExercicio = int.Parse(Console.ReadLine());

            while (numExercicio != 0)
            {
                switch (numExercicio)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Digite o numero do exercicio, ou '0' para sair:");
                numExercicio = int.Parse(Console.ReadLine());
            }
        }
        static void Exercicio1()
        {
            try
            {
                int opcao;
                Tela t;
                t = new Tela();
                produto.Add(new Produto(1001, "Cadeira simples", 500.00));
                produto.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
                produto.Add(new Produto(1003, "Sofá de três lugares", 2000.00));
                produto.Add(new Produto(1004, "Mesa retangular", 1500.00));
                produto.Add(new Produto(1005, "Mesa retangular", 2000.00));
                produto.Sort();

                opcao = t.MenuExercicio1();

                while (opcao != 5)
                {
                    switch (opcao)
                    {
                        case 1:
                            Tela.ExibirProdutos();
                            break;
                        case 2:
                            Tela.incluirProduto();
                            break;
                        case 3:
                            Tela.incluirPedido();
                            break;
                        case 4:
                            Tela.exibirPedido();
                            break;
                        default:
                            break;
                    }

                    opcao = t.MenuExercicio1();
                }
                if (opcao == 5)
                {
                    Console.WriteLine("Final  do Programa!");
                    Console.ReadLine();
                }

            }
            catch (ModelException e)
            {
                Console.WriteLine("Erro de negócio: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }

        }
        static void Exercicio2()
        {

        }

    }
}
