using System;
using System.Globalization;
using System.Collections.Generic;

namespace Projetos_Secao_3
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
                        ExercicioFix1();
                        break;
                    case 2:
                        ExercicioFix2();
                        break;
                    case 3:
                        ExercicioFix3();
                        break;
                    case 4:
                        ExercicioFix4();
                        break;
                    case 5:
                        ExercicioFix5();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Digite o numero do exercicio, ou '0' para sair:");
                numExercicio = int.Parse(Console.ReadLine());

            }



        }
        static void ExercicioFix1()
        {
            double numConta, vlrDeposito, vlrSaque;
            string nomeCliente, havDeposito;
            Console.Write("Digite o número da conta: ");
            numConta = double.Parse(Console.ReadLine());
            Console.Write("Digite o nome do Titular da conta: ");
            nomeCliente = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            havDeposito = Console.ReadLine();

            DadosConta Conta;

            if (havDeposito == "s")
            {
                Console.Write("Digite o valor do depósito inicial: ");
                vlrDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta = new DadosConta(numConta, nomeCliente, vlrDeposito);
            }
            else
            {
                Conta = new DadosConta(numConta, nomeCliente);
            }
            Console.WriteLine();
            Console.WriteLine("Conta Criada:");
            Console.WriteLine(Conta);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            vlrDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Deposito(vlrDeposito);

            Console.WriteLine();
            Console.WriteLine("Conta Atualizada:");
            Console.WriteLine(Conta);

            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            vlrSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Saque(vlrSaque);

            Console.WriteLine();
            Console.WriteLine("Conta Atualizada:");
            Console.WriteLine(Conta);

            Console.ReadLine();
        }

        static void ExercicioFix2()
        {
            string nome, email;
            int quant, quarto;

            Quarto[] q;
            q = new Quarto[10];

            for (int cont = 0; cont < 10; cont++)
            {
                q[cont] = new Quarto("", "", cont);
            }

            Console.Write("Quantos aluguéis serão registrados?");
            quant = int.Parse(Console.ReadLine());

            for(int cont = 0; cont < quant; cont++)
            {
                Console.WriteLine("Dados do " + (cont + 1) + "º aluguel:");
                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Email:");
                email = Console.ReadLine();
                Console.Write("Quarto: ");
                quarto = int.Parse(Console.ReadLine());
                q[quarto] = new Quarto(nome, email, quarto);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");

            for(int cont = 0; cont < 10; cont++)
            {
                if(q[cont].nomeHospede != "")
                {
                    Console.Write(q[cont].numQuarto + ": ");
                    Console.Write("Nome: " + q[cont].nomeHospede);
                    Console.WriteLine(", Email: " + q[cont].emailHospede);
                    
                }
            }
            Console.ReadLine();
        }

        static void ExercicioFix3()
        {

            int[,] mat;
            int M, N, numPesq;

            Console.WriteLine("Digite o número de Colunas:");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de Linhas:");
            M = int.Parse(Console.ReadLine());

            mat = new int[M,N];

            Console.WriteLine("Digite as informações das linhas:");
            for(int i = 0; i < M; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }
            Console.WriteLine("Digite o número a ser pesquisado:");
            numPesq = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(mat[i,j] == numPesq)
                    {
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda:" + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }
                        if (j < N - 1)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if (i < M - 1)
                        {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                        i = M;
                        j = N;
                    }
                }
            }

            Console.ReadLine();
        }

        static void ExercicioFix4()
        {
            int quant;
            double cpf, salario,aumento;
            string nome;
            Console.Write("Quantos funcionários serão cadastrados? ");
            quant = int.Parse(Console.ReadLine());

            List < Salario > salFunc = new List<Salario>();

            for(int cont = 0; cont < quant; cont++)
            {
                Console.WriteLine("Dados do " + (cont + 1) + "º funcionário:");
                Console.Write("CPF: ");
                cpf = double.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Salario: ");
                salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                salFunc.Add(new Salario(cpf,nome,salario));
            }

            Console.WriteLine();
            Console.Write("Digite o CPF do funcionário que terá aumento: ");
            cpf = double.Parse(Console.ReadLine());

            int pos = salFunc.FindIndex(x => x.numCPF == cpf);

            if (pos >= 0)
            {
                Console.Write("Digite a porcentagem de aumento:");
                aumento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                salFunc[pos].atualizaSalario(aumento);
            }
            else
            {
                Console.WriteLine("CPF INEXISTENTE");
            }

            Console.WriteLine();
            for(int cont = 0; cont < salFunc.Count; cont++)
            {
                Console.WriteLine(salFunc[cont]);
            }

            Console.ReadLine();
            
        }

        static void ExercicioFix5()
        {
            int numAlunoA, numAlunoB, numAlunoC, codAluno;
            Console.Write("Quantos alunos possuem o curso A: ");
            numAlunoA = int.Parse(Console.ReadLine());
            HashSet<int> cursoA = new HashSet<int>();

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int cont = 0; cont < numAlunoA; cont++)
            {
                codAluno = int.Parse(Console.ReadLine());
                cursoA.Add(codAluno);
            }

            Console.Write("Quantos alunos possuem o curso B: ");
            numAlunoB = int.Parse(Console.ReadLine());
            HashSet<int> cursoB = new HashSet<int>();

            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int cont = 0; cont < numAlunoB; cont++)
            {
                codAluno = int.Parse(Console.ReadLine());
                cursoB.Add(codAluno);
            }

            Console.Write("Quantos alunos possuem o curso C: ");
            numAlunoC = int.Parse(Console.ReadLine());
            HashSet<int> cursoC = new HashSet<int>();

            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int cont = 0; cont < numAlunoC; cont++)
            {
                codAluno = int.Parse(Console.ReadLine());
                cursoC.Add(codAluno);
            }

            HashSet<int> curso = new HashSet<int>();
            curso.UnionWith(cursoA);
            curso.UnionWith(cursoB);
            curso.UnionWith(cursoC);

            Console.WriteLine("Total de alunos: " + curso.Count);
            Console.ReadLine();

        }

    }

}
