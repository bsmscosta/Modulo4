using System;

namespace ficha9
{
    public class ficha9solucao
    {
        #region Exercicio 1
        public static void Exercicio1()
        {
            Console.WriteLine("Primeiro número?");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número?");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Terceiro número?");
            double n3 = double.Parse(Console.ReadLine());

            double produto = n1 * n2 * n3;
            Console.WriteLine("O resultado do produto é igual a " + produto);

            /* Buscar as funções no GitHub do Fábio https://github.com/fabiojesus/Modulo4.git 
             * clicar  Ctrl + . e add "Common References", caso não reconhecer as funções.
             * 
             * Public static void CalcularProdutoDeTresNum()
             * {
             *
             * double total = 1.0
             * for (int counter = 1; counter  < 3; counter ++){
             *     var currentNumer = InputResquest.ResquestDouble("Introduza um número") // Pedir um input
             *     total *= currentNumber;
             *    }
             *
             * Console.WriteLine("O resultado do produto é igual a " + total);
             * 
             *
             *  }
             */

        }
        #endregion

        #region Exercicio 2
        public static void Exercicio2()
        {
            Console.WriteLine("Primeiro número?");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número?");
            double n2 = double.Parse(Console.ReadLine());
            ApresentarOperacao(n1, n2);
        }
        public static void ApresentarOperacao(double n1, double n2)
        {
            double soma = n1 + n2;
            Console.WriteLine("N1 + N2 = " + soma);
            double subtracao = n1 - n2;
            Console.WriteLine("N1 - N2 = " + subtracao);
            double multiplicacao = n1 * n2;
            Console.WriteLine("N1 * N2 = " + multiplicacao);
            double divisao = n1 / n2;
            Console.WriteLine("N1 / N2 = " + divisao);
            double resto = n1 % n2;
            Console.WriteLine("N1 % N2 = " + resto);
        }


        #endregion

        #region Exercicio 3
        public static void Exercicio3()
        {
            Console.WriteLine("Número a?");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Número b?");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Número c?");
            double n3 = double.Parse(Console.ReadLine());
            Operacao(n1, n2, n3);
        }
        public static void Operacao(double n1, double n2, double n3)
        {
            double resultado1 = (n1 + n2) * n3;
            double resultado2 = (n1 * n2) + (n2 * n3);
            Console.WriteLine("O resultado dos calculos: " + "\n" +
                              "1. (a + b) * c = " + resultado1 + "\n" + "2. (a * b) + (b * c) = " + resultado2);
        }
        #endregion

        #region Exercicio 4
        public static void Exercicio4()
        {
            Console.WriteLine("Digite um número");
            var num = int.Parse(Console.ReadLine());

            /* int counter1 = 2; //Significa que os números só são validos a partir de 2

             while(counter1 < num) //significa que enquanto o contador 1 for menor que o nr primo...
             {
                 bool primo = true; //começar com a instrução verdade
                 int counter2 = 2; //e inicia o contador 2 = 2

                 while(counter2 < counter1) //se counter 2 menor ao contador 1 é falso...
                 {
                     if(counter1 % counter2 == 0)
                     {
                         primo = false; //não é necessário identificar novamente a variavel ex: bool primo.
                     }

                 }
                 counter2++; /* sera incrementado e passa novamente para o While, 
                             * se for maior que o contadar 2, apresenta os valor primos **Terminar aqui 1*comentário
                 if (primo)
                 {
                     Console.WriteLine(counter1);
                 }
                 counter1++;
             } */

            for (var i = 2; i <= num; i++)
            {
                var primo = true;
                for (var j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                if (primo) Console.WriteLine(i + "");
            }
        }

        #endregion

        #region Exercicio 5

        public static void Exercicio5()
        {
            Console.WriteLine("Hello?");
            string song = Console.ReadLine();
            string answer = "is it me you're looking for?";

            if (song == answer)
            {
                Console.WriteLine("I can see it in your eyes");
            }
            else
            {
                Console.WriteLine("bye");
            }
        }


        #endregion

        #region Exerceicio 6

        public static void Exercicio6()
        {
            Console.WriteLine("Quantos itens");
            var contagem = double.Parse(Console.ReadLine());
            while (contagem > 0)
            {
                if (contagem % 2 == 0)
                {
                    Console.WriteLine("Um pra ti");
                }
                else
                {
                    Console.WriteLine("Outro pra mim");
                }
                contagem--;
            }
        }

        #endregion

        #region Exercicio 7
        public static void Exercicio7()
        {
            Console.WriteLine("Solicite um ano");
            var ano = int.Parse(Console.ReadLine());

            if (ano % 400 == 0 || (ano % 100 != 0 && ano % 4 == 0)) // Bissexto - Um ano é bissexto se ele for divisível por 400 ou se ele
                                                                    //         for divisível por 4 e não por 100.
            {
                Console.WriteLine("O ano " + ano + " é bissexto!");
            }
            else
            {
                Console.WriteLine("Não é um ano bissexto");
            }


        }

        #endregion

        #region Exercicio 8

        public static void Exercicio8()
        {
            Console.Write("beers on the wall, 99 bottles of beer" + "\n");

            for (var i = 99; i > 0; i--)
            {
                Console.Write(i + " beers on the wall, " + i + " bottles of beer" + "\n");
                i--;
                Console.WriteLine("Take one done and pass it arrond" + i + "bottles of beer on the wall...");

                if (i == 0)
                {
                    Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer." + "\n" + "Go to the store and buy some more, 99 bottles of beer on the wall.");
                    break;
                }
            }
        }

        #endregion

        #region Exercicio 9

        public static void Exercicio9()
        {

            Console.WriteLine("Introduza três medidas para obter informações sobre triângulo");
            Console.WriteLine("Introduza a primeira medida");
            double m1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduza a segunda medida");
            double m2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduza a terceira medida");
            double m3 = double.Parse(Console.ReadLine());

            if (m1 == m2 && m2 == m3 && m3 == m1)
            {
                Console.WriteLine("É um triângulo equilatero");
            }
            else if (m1 == m2 || m2 == m3 || m3 == m1)
            {
                Console.WriteLine("É um triângulo Isosceles");
            }
            else if (m1 != m2 && m2 != m3 && m3 != m1)
            {
                Console.WriteLine("É um triângulo Escaleno");
            }
            else
            {
                Console.WriteLine("Valores inválidos para verificar o triângulo");
            }
        }

        #endregion  

        #region Exercicio 10
        public static void Exercicio10()
        {
            Console.WriteLine("Qual o valor inicial?");
            var inicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor final?");
            var final = double.Parse(Console.ReadLine());
            var balanco = final - inicial;
            if (balanco < 0)
            {
                Console.WriteLine("Prejuízo");
            }
            else if (balanco == 0)
            {
                Console.WriteLine("Neutro");
            }
            else
            {
                Console.WriteLine("Lucro");
            }
        }

        #endregion

        #region Exercicio 11
        public static void Exercicio11()
        {
            Console.WriteLine("Qual o mês?");
            var mes = int.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro, 31");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro 28, 29");
                    break;
                case 3:
                    Console.WriteLine("Março, 31");
                    break;
                case 4:
                    Console.WriteLine("Abril, 30");
                    break;
                case 5:
                    Console.WriteLine("Maio, 31");
                    break;
                case 6:
                    Console.WriteLine("Junho, 30");
                    break;
                case 7:
                    Console.WriteLine("Julho, 31");
                    break;
                case 8:
                    Console.WriteLine("Agosto, 31");
                    break;
                case 9:
                    Console.WriteLine("Setembro 30");
                    break;
                case 10:
                    Console.WriteLine("Outubro, 31");
                    break;
                case 11:
                    Console.WriteLine("Novembro, 30");
                    break;
                case 12:
                    Console.WriteLine("Dezembro, 31");
                    break;
                default:
                    Console.WriteLine("Valor introduzido inválido");
                    break;

            }

        }

        #endregion

        #region Exercicio 12
        public static void Exercicio12()
        {
            Console.WriteLine("Qual a dimensão da árvore de TaNal?");
            int n = int.Parse(Console.ReadLine());
            int t = n; //Equivale ao valor fixo
            int i = (n-1) + n;

            while (n > 0)
            {
                n--;
                int a = 0;

                while (a != (t - n))
                {
                    Console.Write(" ");
                    a++;
                }
                int b = 0;

                while (b != i)
                {
                    Console.Write("*");
                    b++;
                }
                i -= 2;
                Console.Write("\n");
            }


        }
    

        #endregion

        #region Exercicio 13
        public static void Exercicio13()
        {
            Console.WriteLine("Para apresentar a sua fatura de água, tem de indicar quantas unidades consumiu e a sua região:" + "\n"
                               + "A - 2 euros por unidade" + "\n" + "B - 1.20 euros por unidade" + "\n" + "C - 1 euros por unidade" + "\n" + "D -  0.75 euros por unidade");
            Console.WriteLine("Quantos unidades de água consumiu?");
            double unidade = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua região?");
            var region = Console.ReadLine();

            switch (region)
            {
                case "a":
                    {
                        Console.WriteLine("A sua fatura de água é: " + unidade * 2 + " euros");
                    }
                    break;
                case "b":
                    {
                        Console.WriteLine("A sua fatura de água é: " + unidade * 1.20 + " euros");
                    }
                    break;
                case "c":
                    {
                        Console.WriteLine("A sua fatura de água é: " + unidade * 1 + " euros");
                    }
                    break;
                case "d":
                    {
                        Console.WriteLine("A sua fatura de água é: " + unidade * 0.75 + " euros");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Região inválida");
                    }
                    break;

            }



        }



        #endregion

        #region Exercicio 14

        public static void Exercicio14()
        {
            //Sequencia Fibonaccié uma lista infinita de números, em que cada um de seus valores é o resultado da soma dos dois anteriores
            Console.WriteLine("Digite a dimensão da sequência Fibonacci nao recursivo");
            int n = int.Parse(Console.ReadLine());
            int num1 = 1;
            int num2 = 0;
            int f;
            int counter = 2;

            Console.WriteLine(num2);
            Console.WriteLine(num1);

            while (counter < n)
            {
                f = num1 + num2;
                Console.WriteLine(f);
                num2 = num1;
                num1 = f;
                counter++;
            }

        }

        #endregion

        #region Exercicio 15
        
        public static void Exercicio15()
        {
            Console.WriteLine("Qual o número"); 
            int n = int.Parse(Console.ReadLine());

            int op1 = 5 * n * n + 4;
            int test1 = (int)Math.Sqrt(op1);
            int op2 = 5 * n * n - 4;
            int test2 = (int)Math.Sqrt(op2);


            if (((test1 * test1) == op1) || ((test2 * test2) == op2))
            {
                Console.WriteLine("Não é Fibonice!");
            }
            else
            {
                Console.WriteLine("É Fibonice!");
            }
        }

        #endregion

        #region Exercicio 16
        public static void Exercicio16()
        {
            int min = 1;
            int max = 100;
            bool numCerto = false; // porque assumimos primeiro que é o número errado.

            while (!numCerto)
            {
                Console.WriteLine();
                var media = (int)Math.Floor((double)(min + max) / 2); //faz uma média do nr min e max
                var intervaloConfianca = max - min;
                var keyOK = false;

                if (intervaloConfianca < 2)
                {

                    for (int i = min; i < (max + 1); i++)
                    {
                        Console.WriteLine("É " + i + "?");
                        var key = Console.ReadKey().Key;

                        if (key == ConsoleKey.Y || key == ConsoleKey.S)
                        {
                            numCerto = true;
                            break;
                        }
                        Console.WriteLine("");

                    }
                }
                if (!numCerto)
                {
                    while (!keyOK)
                    {
                        Console.WriteLine("O número é inferior a " + media + " ?" + " S ou N?");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.Y:

                            case ConsoleKey.S:
                                keyOK = true;
                                max = media - 1;
                                break;
                            case ConsoleKey.N:
                                keyOK = true;
                                min = media;
                                break;
                            default:
                                break;
                        }
                    }
                }

            }

        }


        #endregion
    }
}