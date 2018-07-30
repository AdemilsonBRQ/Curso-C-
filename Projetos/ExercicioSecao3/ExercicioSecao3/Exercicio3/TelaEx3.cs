using System;
using System.Globalization;

namespace ExercicioSecao3.Exercicio3
{
    class TelaEx3
    {
        public static int MenuExercicio3()
        {
            Console.WriteLine();
            Console.WriteLine("Digite uma das opções:");
            Console.WriteLine("1 – Listar marcas");
            Console.WriteLine("2 – Listar carros de uma marca ordenadamente");
            Console.WriteLine("3 – Cadastrar marca");
            Console.WriteLine("4 – Cadastrar carro");
            Console.WriteLine("5 – Cadastrar acessório");
            Console.WriteLine("6 – Mostrar detalhes de um carro");
            Console.WriteLine("7 – Sair");
            
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

        public static void exibirMarcas()
        {
            Console.WriteLine("LISTAGEM DE MARCAS:");
            for(int cont = 0; cont < Program.marcas.Count; cont++)
            {
                Console.WriteLine(Program.marcas[cont]);
            }
        }

        public static void exibirCarrosMarca()
        {
            Console.Write("Digite o código da marca: ");
            int cod3 = int.Parse(Console.ReadLine());
            int pos = Program.marcas.FindIndex(x => x.codigo == cod3);
            if(pos == -1)
            {
                throw new ModelException("Código da marca não encontrado: " + cod3);
            }
            else
            {
                Console.WriteLine("Carros da marca " + Program.marcas[pos].nome + ": ");
                for(int cont = 0; cont < Program.marcas[pos].itens.Count; cont++)
                {
                    Console.WriteLine(Program.marcas[pos].itens[cont]);
                }
                
            }
        }

        public static void incluirMarca()
        {
            Console.WriteLine("Digite os dados da marca:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("País de origem: ");
            string pais = Console.ReadLine();

            Marca m = new Marca(codigo, nome, pais);
            Program.marcas.Add(m);

        }

        public static void incluirCarro()
        {
            Console.WriteLine("Digite os dados do carro:");
            Console.Write("Marca (código): ");
            int codM = int.Parse(Console.ReadLine());
            int pos = Program.marcas.FindIndex(x => x.codigo == codM);
            if (pos == -1)
            {
                throw new ModelException("Código da Marca não encontrado: " + codM);
            }
            else
            {
                Console.Write("Código do carro: ");
                int codigo = int.Parse(Console.ReadLine());
                Console.Write("Modelo: ");
                string model = Console.ReadLine();
                Console.Write("Ano: ");
                int ano = int.Parse(Console.ReadLine());
                Console.Write("Preço Básico: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Carro car = new Carro(codigo, model, ano, preco, Program.marcas[pos]);
                Program.carros.Add(car);
                Program.marcas[pos].addCarro(car);
            }
        }

        public static void incluirAcessorio()
        {
            Console.WriteLine("Digite os dados do Acessório:");
            Console.Write("Carro (código): ");
            int codCar = int.Parse(Console.ReadLine());
            int pos = Program.carros.FindIndex(x => x.codigo == codCar);
            if(pos == -1)
            {
                throw new ModelException("Código do carro não encontrado: " + codCar);
            }
            else
            {
                Console.Write("Descrição: ");
                string desc = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Acessorios ace = new Acessorios(desc, preco);
                Carro car = Program.carros[pos];
                car.itens.Add(ace);
            }
        }
        public static void exibirDetalheCarro()
        {
            Console.Write("Digite o código do carro:");
            int codCar = int.Parse(Console.ReadLine());
            int pos = Program.carros.FindIndex(x => x.codigo == codCar);
            if (pos == -1)
            {
                throw new ModelException("Código do carro não encontrado: " + codCar);
            }
            else
            {
                Console.WriteLine(Program.carros[pos]);
                Console.WriteLine("Acessórios:");
                for(int cont=0;cont<Program.carros[pos].itens.Count;cont++)
                {
                    Console.WriteLine(Program.carros[pos].itens[cont]);
                }
            }
        }

    }
}
