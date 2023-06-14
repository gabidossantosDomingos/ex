using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    internal class Program
    {
        static void ex1()
        {
            int tam;
            float num, soma = 0;
            Console.WriteLine("escreva a quantidade de vetores:");
            tam = int.Parse(Console.ReadLine());

            int[] vetor = new int[tam];

            float menorN = float.MaxValue;
            float maiorN = float.MinValue;

            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine("escreva o valor para  conteudo");

                vetor[i] = int.Parse(Console.ReadLine());
                soma = soma + vetor[i];

                if (vetor[i] > maiorN)
                    maiorN = vetor[i];

                if (vetor[i] < menorN)
                    menorN = vetor[i];

            }

            Console.WriteLine("essa é o menor valor:" + menorN);
            Console.WriteLine("essa é o mair valor:" + maiorN);
            float media = (float)soma / (float)tam;

            Console.ReadKey();


        }

        static void ex2()
        {
            int num, soma = 0, media = 0;


            Console.WriteLine("Digite a quantidade do vetor:");
            num = int.Parse(Console.ReadLine());

            int[] N = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Digite um número (>=0)");
                N[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < num; i++)
            {
                soma += N[i];

            }

            for (int i = 0; i < num; i++)
            {
                media = soma / num;

            }

            for (int i = 0; i < num; i++)
            {
                if (N[i] > media)
                {
                    Console.WriteLine("O número do vetor maiore é:" + N[i]);
                }

                if (N[i] == media)
                {
                    Console.WriteLine("O número do vetor igual a média é:" + N[i]);
                }

            }
            Console.ReadKey();



        }

        static void ex3()
        {
            int num, soma = 0, media = 0;


            Console.WriteLine("Digite a quantidade do vetor:");
            num = int.Parse(Console.ReadLine());

            int[] N = new int[num];

            Random random = new Random();


            for (int i = 0; i < num; i++)

            {

                 N[i] = random.Next(0,20);

            }

            for (int i = 0; i < num; i++)
            {
                soma += N[i];

            }

            
            
                media = soma / num;

            

            for (int i = 0; i < num; i++)
            {
                if (N[i] > media)
                {
                    Console.WriteLine("O número do vetor maiore é:" + N[i]);
                }

                if (N[i] == media)
                {
                    Console.WriteLine("O número do vetor igual a média é:" + N[i]);
                }

            }
            Console.ReadKey();



        }

        static void ex4()
        {

            Console.Write("Digite o número de assinaturas: ");
            int n = int.Parse(Console.ReadLine());

            string[] lista = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome da assinatura {0}: ", i + 1);
                lista[i] = Console.ReadLine();

            }
            for (int i = n - 1; i >= 0; i--)
            {

                Console.WriteLine("posição [{0}] = {1}", i, lista[i]);


            }

            Console.ReadKey();
        }

        static void ex5()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();

            while (n <= 0)
            {
                Console.WriteLine("O tamanho do vetor precisa ser maior que zero. Tente novamente.");
                Console.Write("Digite o tamanho do vetor: ");
                n = int.Parse(Console.ReadLine());
            }

            float[] vetor = new float[n];

            for (int i = 0; i < n; i++)
            {

                vetor[i] = rand.Next(10, 50);

            }

            int In = 0, P = 0;

            for (int i = 0; i < n; i++)
            {

                if (vetor[i] % 2 == 0)
                {
                    P = P + 1;
                }
                else
                {
                    In = In + 1;
                }
                Console.WriteLine("a soma dos pares é" + P);
                Console.WriteLine("a soma dos impares é" + In);
                Console.ReadKey();
            }
        }









        static void Main(string[] args)
        {

            int opcao;

            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("Ex1 - 1");
                Console.WriteLine("Ex2 - 2");
                Console.WriteLine("Ex3 - 3");
                Console.WriteLine("Ex4 - 4");
                Console.WriteLine("Ex5 - 5");
                Console.WriteLine("sair - 0");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        ex1();
                        break;
                    case 2:
                        ex2();
                        break;
                    case 3:
                        ex3();
                        break;
                    case 4:
                        ex4();
                        break;
                    case 5:
                        ex5();

                        break;
                    default:
                        Console.WriteLine("o numero não é um exercicio valido");
                        break;
                }





            } while (opcao !=0);

            Console.WriteLine("Digite 0 para sair");
        }
    }
}
