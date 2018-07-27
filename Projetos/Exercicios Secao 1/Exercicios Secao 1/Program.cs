using System;


namespace Exercicios_Secao_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int exercicio = 0;
            Console.WriteLine("Digite o numero do exercicio ou '0' para sair:");
            exercicio = int.Parse(Console.ReadLine());

            while (exercicio > 0)
            {
                switch (exercicio)
                {
                    case 1:
                        //Exercicio 1
                        int frasco, vazao, tempo, sobra;

                        Console.WriteLine("Digite o tamanho do frasco:");
                        frasco = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o volume da vazão:");
                        vazao = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o tempo de vazão:");
                        tempo = int.Parse(Console.ReadLine());

                        sobra = frasco - vazao * tempo;
                        if (sobra >= 0)
                        {
                            Console.WriteLine("Sobrou no Frasco o total de: " + sobra + " ml de veneno.");
                        }
                        else
                        {
                            Console.WriteLine("Não é possivel.");
                        }
                        break;

                    case 2:
                        //Exercicio 2
                        double nota1, nota2, nota3, soma, resultado;
                        Console.WriteLine("Digite as notas do aluno:");
                        string[] vet = Console.ReadLine().Split(' ');
                        nota1 = double.Parse(vet[0]);
                        nota2 = double.Parse(vet[1]);
                        nota3 = double.Parse(vet[2]);
                        soma = nota1 + nota2 + nota3;
                        resultado = soma / 3;
                        Console.WriteLine("A média final do aluno é: " + resultado.ToString("F2"));

                        if(resultado < 60.00)
                        {
                            Console.WriteLine("DEPENDENCIA");
                        }
                        break;

                    case 3:
                        //Exercicio 3
                        int x1, x2, y1, y2;
                        Console.WriteLine("Digite o tamanho da foto:");
                        string[] vet1 = Console.ReadLine().Split(' ');
                        x1 = int.Parse(vet1[0]);
                        x2 = int.Parse(vet1[1]);
                        Console.WriteLine("Digite o tamanho do porta retrato:");
                        string[] vet2 = Console.ReadLine().Split(' ');
                        y1 = int.Parse(vet2[0]);
                        y2 = int.Parse(vet2[1]);
                        
                        if ((x1 <= y1 && x2 <= y2) || (x2 <= y1 && x1 <= y2))
                        {
                            Console.WriteLine("SIM");
                        }
                        else
                        {
                            Console.WriteLine("NÃO");
                        }

                        break;

                    case 4:
                        //Exercicio 4
                        double vlrGlicose;
                        Console.WriteLine("Digite o valor de Glicose:");
                        vlrGlicose = int.Parse(Console.ReadLine());

                        if(vlrGlicose <= 90.0)
                        {
                            Console.WriteLine("NORMAL");
                        }
                        else if(vlrGlicose <= 140.0)
                        {
                            Console.WriteLine("ELEVADO");
                        }
                        else
                        {
                            Console.WriteLine("DIABETES");
                        }
                        break;

                    case 5:
                        //Exercicio 5
                        double valor1, valor2, valor3;
                        Console.WriteLine("Digite os valores do lançamento:");
                        string[] vetor = Console.ReadLine().Split(' ');

                        valor1 = int.Parse(vetor[0]);
                        valor2 = int.Parse(vetor[1]);
                        valor3 = int.Parse(vetor[2]);
                        
                        if(valor1 >= valor2 && valor1 >= valor3)
                        {
                            Console.WriteLine("O valor maior é: " + valor1);
                        }
                        else if(valor2 >= valor3)
                        {
                            Console.WriteLine("O valor maior é: " + valor2);
                        }
                        else
                        {
                            Console.WriteLine("O valor maior é: " + valor3);
                        }
                        break;

                    case 6:
                        //Exercicio 6
                        int num1, num2, soma6;
                        soma6 = 0;
                        Console.WriteLine("Digite os 2 números:");
                        string[] vet6 = Console.ReadLine().Split(' ');
                        num1 = int.Parse(vet6[0]);
                        num2 = int.Parse(vet6[1]);

                        for(int cont = num1;cont <= num2; cont++)
                        {
                            if(cont % 2 != 0)
                            {
                                soma6 = cont + soma6;
                            }
                        }

                        Console.WriteLine("A soma dos números impares dentro do range é: " + soma6);

                        break;
                    case 7:
                        //Exercicio 7
                        int intNum, resultado7;

                        Console.WriteLine("Digite o numero:");
                        intNum = int.Parse(Console.ReadLine());

                        while(intNum != 0)
                        {
                            resultado7 = intNum * intNum;
                            Console.WriteLine("O quadrado do número é: " + resultado7);
                            Console.WriteLine("Digite um novo número ou '0' para sair: ");
                            intNum = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 8:
                        //Exercicio 8
                        int numN, numA, numB;
                        Console.WriteLine("Digite o Número 'N': ");
                        numN = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o Número 'A': ");
                        numA = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o Número 'B': ");
                        numB = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        for (int cont = numA;cont<= numB; cont++)
                        {
                            if(cont % numN == 0)
                            {
                                Console.WriteLine(cont);
                            }
                        }
                        break;
                    case 9:
                        //Exercicio 9
                        double total, tempo9, saldo;
                        int quant;

                        Console.WriteLine("Digite o Total de Tempo da Bateria: ");
                        total = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a Quantidade de vezes que irá jogar:");
                        quant = int.Parse(Console.ReadLine());
                        saldo = total;
                        for(int cont = 1; cont <= quant; cont++)
                        {
                            Console.WriteLine("Digite o tempo do " + cont + "º jogo:");
                            tempo9 = double.Parse(Console.ReadLine());
                            saldo = saldo - tempo9;
                            if(saldo > 0)
                            {
                                Console.WriteLine("Tempo restante da bateria: " + saldo);
                            }
                            else
                            {
                                Console.WriteLine("recarregar");
                            }
                            Console.WriteLine();

                        }
                        break;
                    case 10:
                        //Exercicio 10
                        double nota10_1, nota10_2, nota10_3,soma10;
                        int intNum10;

                        Console.WriteLine("Digite a quantidade de alunos:");
                        intNum10 = int.Parse(Console.ReadLine());
                        
                        for(int cont = 1;cont<=intNum10;cont++)
                        {
                            Console.WriteLine("Digite as notas do " + cont + "º Aluno:");
                            string[] vetor10 = Console.ReadLine().Split(' ');
                            nota10_1 = double.Parse(vetor10[0]);
                            nota10_2 = double.Parse(vetor10[1]);
                            nota10_3 = double.Parse(vetor10[2]);

                            soma10 = nota10_1 + nota10_2 + nota10_3;

                            Console.WriteLine("A Nota Final do " + cont + "º Aluno é: " + soma10);
                        }

                        break;
                    case 11:
                        //Exercicio 11
                        int volEntr, volAtual;

                        Console.WriteLine("Digite o Volume inicial: ");
                        volEntr = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a alteração do Volume: ");
                        volAtual = int.Parse(Console.ReadLine());
                        while (volAtual != 0)
                        {
                            volEntr = volEntr + volAtual;
                            if(volEntr > 100)
                            {
                                volEntr = 100;
                            }

                            if(volEntr < 0)
                            {
                                volEntr = 0;
                            }
                            Console.WriteLine("Volume Atualizado: " + volEntr);
                            Console.WriteLine("Digite a alteração do Volume:");
                            volAtual = int.Parse(Console.ReadLine());
                        }
                        break;

                    default:
                        Console.WriteLine("Exercicio não encontrado.");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Digite o numero do exercicio ou '0' para sair:");
                exercicio = int.Parse(Console.ReadLine());

            }
        }
    }
}
