using System;
using System.Globalization;

namespace ExercicioSecao3.Exercicio2
{
    class TelaEx2
    {
        public static int MenuExercicio2()
        {
            Console.WriteLine();
            Console.WriteLine("Digite uma das opções:");
            Console.WriteLine("1 – Listar artistas ordenadamente");
            Console.WriteLine("2 – Cadastrar artista");
            Console.WriteLine("3 – Cadastrar filme");
            Console.WriteLine("4 – Mostrar dados de um filme");
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

        public static void exibirArtistas()
        {
            Console.WriteLine();
            Console.WriteLine("LISTAGEM DE ARTISTAS:");
            for(int cont = 0; cont < Program.artistas.Count; cont++)
            {
                Console.WriteLine(Program.artistas[cont]);
            }
        }

        public static void incluirArtista()
        {
            Console.WriteLine();
            Console.WriteLine("Digite os dados do artista:");
            Console.Write("Código:");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Valor do cachê:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Artista art = new Artista(codigo, nome, valor);
            Program.artistas.Add(art);
            Program.artistas.Sort();
        }

        public static void incluirFilme()
        {
            Console.WriteLine();
            Console.WriteLine("Digite os dados do filme:");
            Console.Write("Código:");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Título:");
            string nomeFilme = Console.ReadLine();
            Console.Write("Ano:");
            int ano = int.Parse(Console.ReadLine());

            Filme f = new Filme(codigo, nomeFilme, ano);

            Console.Write("Quantas participações tem o filme?");
            int quant = int.Parse(Console.ReadLine());

            for(int cont = 0; cont < quant; cont++)
            {
                Console.WriteLine("Digite os dados da " + (cont + 1) + "ª participação:");
                Console.Write("Artista (código): ");
                int cod = int.Parse(Console.ReadLine());
                int pos = Program.artistas.FindIndex(x => x.codigo == cod);
                if (pos == -1)
                {
                    throw new ModelException("Código do Artista não encontrado: " + cod);
                }
                else
                {
                    Console.Write("Desconto: ");
                    double desc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Participacao part = new Participacao(desc, Program.artistas[pos], f);
                    f.itens.Add(part);

                }
                

            }
            Program.filmes.Add(f);
        }

        public static void exibirFilme()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o código do filme:");
            int codFilme = int.Parse(Console.ReadLine());
            int pos = Program.filmes.FindIndex(x => x.codigo == codFilme);
            if (pos == -1)
            {
                throw new ModelException("Código do Filme não encontrado: " + codFilme);
            }
            Console.WriteLine(Program.filmes[pos]);
            Console.WriteLine();

        }
    }
}
