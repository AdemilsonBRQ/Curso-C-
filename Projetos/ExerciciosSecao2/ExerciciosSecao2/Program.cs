using System;
using System.Globalization;

namespace ExerciciosSecao2
{
    class Program
    {
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
            Retangulo R;
            R = new Retangulo();
            Console.WriteLine("Digite a Largura do Retangulo:");
            R.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a Altura do Retangulo:");
            R.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A área do Retangulo é: " + R.area());
            Console.WriteLine("O perimetro do Retangulo é: " + R.perimetro());
            Console.WriteLine("A diagonal do Retangulo é: " + R.diagonal());

            Console.ReadLine();
            return;
        }
        static void Exercicio2()
        {
            double porc;

            Funcionario F;
            F = new Funcionario();
            Console.Write("Nome: ");
            F.nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            F.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Desconto: ");
            F.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(F);
            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem: ");
            porc = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            F.aumentarSalario(porc);

            Console.WriteLine(F);
            
        }
        static void Exercicio3()
        {
            Aluno A;
            A = new Aluno();
            Console.WriteLine("Digite o Nome do Aluno: ");
            A.nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite a 1ª Nota:");
            A.nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a 2ª Nota:");
            A.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a 3ª Nota:");
            A.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(A);

        }
    }
}
