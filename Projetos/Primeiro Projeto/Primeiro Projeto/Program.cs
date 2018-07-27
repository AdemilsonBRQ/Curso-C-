using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = 10.345324;
            //int y = 36;
            //string z = "Jose";
            //char w = 'M';

            //Console.Write("Olá mundo!!");
            //Console.WriteLine("Bom dia!!");
            //Console.WriteLine("Até mais.!!");

            //Console.WriteLine();
            //Console.WriteLine(x);
            //Console.WriteLine(x.ToString("F2"));
            //Console.WriteLine(x.ToString("F4"));
            //Console.WriteLine(x.ToString("F2"), CultureInfo.InvariantCulture);

            //Console.WriteLine();
            //Console.WriteLine("RESULTADO = " + x);
            //Console.WriteLine("O valor do troco é " + x + " reais.");
            //Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais.");
            //Console.WriteLine(x.ToString("F4"));
            //Console.WriteLine(x.ToString("F2"), CultureInfo.InvariantCulture);

            //Console.WriteLine();
            //Console.WriteLine("O paciente " + z + " tem " + y + " anos e se usexo é " + w);

            //string x;
            //int y;
            //double z;
            //char w;

            ////x = Console.ReadLine();
            ////y = int.Parse(Console.ReadLine());
            ////z = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            ////w = char.Parse(Console.ReadLine());

            //string[] vet = Console.ReadLine().Split(' ');

            //x = vet[0];
            //y = int.Parse(vet[1]);
            //z = double.Parse(vet[2]);

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            ////Console.WriteLine(w);

            //Calculo Equação 2º Grau
            //double a, b, c, delta, x1, x2;

            //string[] vet = Console.ReadLine().Split(' ');
            //a = double.Parse(vet[0]);
            //b = double.Parse(vet[1]);
            //c = double.Parse(vet[2]);

            //delta = b * b - 4 * a * c;
            //if (a == 0.0 || delta < 0.0)
            //{
            //    Console.WriteLine("IMPOSSIVEL CALCULAR");
            //}
            //else
            //{
            //    x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            //    x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            //    Console.WriteLine("X1 = " + x1.ToString("F4"));
            //    Console.WriteLine("X2 = " + x2.ToString("F4"));
            //}

            //Calculo da média dentro de um array de numeros

            //int idade, soma, cont;
            //double media;

            //idade = int.Parse(Console.ReadLine());
            //cont = 0;
            //soma = 0;

            //while (idade >= 0)
            //{
            //    cont++;
            //    soma = soma + idade;
            //    idade = int.Parse(Console.ReadLine());
            //}
            //if(cont > 0)
            //{
            //    media = (double) soma / cont;
            //    Console.WriteLine(media.ToString("F2"));
            //}
            //else
            //{
            //    Console.WriteLine("IMPOSSIVEL CALCULAR.");
            //}

            //Calculo de divisão de pares N vezes
            int N;
            double x1, x2, resultado;
            string[] vet;
            N = int.Parse(Console.ReadLine());

            for(int i=0;i<N;i++)
            {
                vet = Console.ReadLine().Split(' ');
                x1 = double.Parse(vet[0]);
                x2 = double.Parse(vet[1]);
                if (x2 == 0.0)
                {
                    Console.WriteLine("Não existe");
                }
                else
                {
                    resultado = x1 / x2;
                    Console.WriteLine(resultado.ToString("F3"));
                }
            }

            Console.ReadLine();
        }
    }
}
