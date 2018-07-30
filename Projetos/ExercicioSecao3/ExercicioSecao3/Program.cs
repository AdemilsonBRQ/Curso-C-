using System;
using System.Collections.Generic;
using ExercicioSecao3.Exercicio1;
using ExercicioSecao3.Exercicio2;
using ExercicioSecao3.Exercicio3;

namespace ExercicioSecao3
{
    class Program
    {
        public static List<Produto> produto = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>();

        public static List<Artista> artistas = new List<Artista>();
        public static List<Filme> filmes = new List<Filme>();

        public static List<Marca> marcas = new List<Marca>();
        public static List<Carro> carros = new List<Carro>();

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
                    case 3:
                        Exercicio3();
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
               
                produto.Add(new Produto(1001, "Cadeira simples", 500.00));
                produto.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
                produto.Add(new Produto(1003, "Sofá de três lugares", 2000.00));
                produto.Add(new Produto(1004, "Mesa retangular", 1500.00));
                produto.Add(new Produto(1005, "Mesa retangular", 2000.00));
                produto.Sort();

                Console.Clear();
                opcao = Tela.MenuExercicio1();

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

                    opcao = Tela.MenuExercicio1();
                    
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
            try
            {
                int opcao;
                
                artistas.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
                artistas.Add(new Artista(102, "Chris Evans", 2500000.00));
                artistas.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
                artistas.Add(new Artista(104, "Morgan Freeman", 4000000.00));
                artistas.Sort();

                Console.Clear();
                opcao = TelaEx2.MenuExercicio2();

                while (opcao != 5)
                {
                    switch (opcao)
                    {
                        case 1:
                            TelaEx2.exibirArtistas();
                            break;
                        case 2:
                            TelaEx2.incluirArtista();
                            break;
                        case 3:
                            TelaEx2.incluirFilme();
                            break;
                        case 4:
                            TelaEx2.exibirFilme();
                            break;
                        default:
                            break;
                    }

                    opcao = TelaEx2.MenuExercicio2();
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
                Console.WriteLine(value: "Erro inesperado: " + e.Message);
            }
        }

        static void Exercicio3()
        {
            try
            {
                int opcao;
                Marca m1 = new Marca(1001, "Volkswagen", "Alemanha");
                Marca m2 = new Marca(1002, "General Motors", "Estados Unidos");

                Carro c1 = new Carro(101, "Fusca", 1980, 5000.00,m1);
                m1.addCarro(c1);
                Carro c2 = new Carro(102, "Golf", 2016, 60000.00,m1);
                m1.addCarro(c2);
                Carro c3 = new Carro(103, "Fox", 2017, 30000.00,m1);
                m1.addCarro(c3);
                Carro c4 = new Carro(104, "Cruze", 2016, 30000.00,m2);
                m2.addCarro(c4);
                Carro c5 = new Carro(105, "Cobalt", 2015, 25000.00,m2);
                m2.addCarro(c5);
                Carro c6 = new Carro(106, "Cobalt", 2017, 35000.00,m2);
                m2.addCarro(c6);

                marcas.Add(m1);
                marcas.Add(m2);

                carros.Add(c1);
                carros.Add(c2);
                carros.Add(c3);
                carros.Add(c4);
                carros.Add(c5);
                carros.Add(c6);
                carros.Sort();
                
                Console.Clear();
                opcao = TelaEx3.MenuExercicio3();

                while (opcao != 7)
                {
                    switch (opcao)
                    {
                        case 1:
                            TelaEx3.exibirMarcas();
                            break;
                        case 2:
                            TelaEx3.exibirCarrosMarca();
                            break;
                        case 3:
                            TelaEx3.incluirMarca();
                            break;
                        case 4:
                            TelaEx3.incluirCarro();
                            break;
                        case 5:
                            TelaEx3.incluirAcessorio();
                            break;
                        case 6:
                            TelaEx3.exibirDetalheCarro();
                            break;
                        default:
                            break;
                    }

                    opcao = TelaEx3.MenuExercicio3();
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
                Console.WriteLine(value: "Erro inesperado: " + e.Message);
            }
        }
    }
}
