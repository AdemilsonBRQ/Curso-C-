using System;
using System.Globalization;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula 1
            //Triangulo X, Y;
            //X = new Triangulo();
            //Y = new Triangulo();

            //double areaX, areaY;
            //X.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //X.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //X.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //areaX = X.area();
            //areaY = Y.area();
            //Console.WriteLine("AREA DO TRIANGULO X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("AREA DO TRIANGULO Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            //if (areaX > areaY)
            //{
            //    Console.WriteLine("TRIANGULO DE MAIOR AREA: X");
            //}
            //else if (areaY > areaX)
            //{
            //    Console.WriteLine("TRIANGULO DE MAIOR AREA: Y");
            //}
            //else
            //{
            //    Console.WriteLine("AREAS IGUAIS");
            //}
            //Console.ReadLine();

            //Aula 2
            int qtde;
            Produto P;
            
            Console.WriteLine("Digite os dados do Produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            if (quantidade == 0)
            {
                P = new Produto(nome, preco);
            }
            else
            {
                P = new Produto(nome, preco, quantidade);
            }


            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + P);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
            qtde = int.Parse(Console.ReadLine());
            P.realizarEntrada(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que saíram do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            P.realizarSaida(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P);

            Console.ReadLine();

        }
    }
}