using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Ficha14
{
    public class ficha14solucao
    {
        #region Exercicio 1
        public static void Exercicio1()
        {
            Console.WriteLine("Num?");
            int limite = int.Parse(Console.ReadLine());
            int inicio = 1;
            NumNaturais(inicio, limite);
        }
        public static void NumNaturais(int inicio, int limite)
        {
            if (inicio == limite)
            {
                Console.WriteLine(limite);
            }
            else
            {
                Console.WriteLine(inicio);
                NumNaturais(inicio + 1, limite);
            }

        }

        #endregion

        #region Exercicio 2 
        public static void Exercicio2()
        {
            Console.WriteLine("Numero?");
            int num = int.Parse(Console.ReadLine());
            NumNaturaisDecres(num);
        }
        public static void NumNaturaisDecres(int num)
        {
            if (num == 0)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine(num);
                NumNaturaisDecres(num - 1);
            }
        }


        #endregion

        #region Exercicio 3 
        public static void Exercicio3()
        {
            Console.WriteLine("Numero?");
            int num = int.Parse(Console.ReadLine());
            int soma = 0;
            SomaNnum(num, soma);
        }
        public static void SomaNnum(int num, int soma)
        {
            if (num == 0)
            {
                Console.WriteLine(soma);
            }
            else
            {
                SomaNnum(num - 1, soma = soma + num);
            }
        }
        #endregion

        #region Exercicio 4
        public static void Exercicio4()
        {
            Console.Write("Introduza o primeiro numero");
            var num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduza o segundo numero");
            var num2 = int.Parse(Console.ReadLine());
            ParesEntreNum(num1, num2);
        }
        public static void ParesEntreNum(int num1, int num2)
        {
            if (num1 <= num2)
            {
                if (num1 % 2 == 0)
                {
                    Console.WriteLine(num1);
                }
                ParesEntreNum(num1 + 1, num2);
            }
        }

        #endregion

        #region Exercicio 5
        public static void Exercicio5()
        {
            Console.WriteLine("Introduza um número");
            int num = int.Parse(Console.ReadLine());
            int lista = 0;
            Fibonacci(num, lista);
        }
       public static int Fibonacci(int n, int lista)
        {
            int u;
            if (n <= 1)
            {
                lista += n;
                Console.WriteLine(n);
            }
            var fib = Fibonacci(n - 1, lista) + Fibonacci(n - 2, u = 0);
            lista += fib;
            return fib;
        }

        #endregion

        #region Exercicio 6
        public static void Exercicio6()
        {
            Console.Write("Introduza o numero fatorial que quer calcular ");
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num}! = {factorial(num)}");
        }
        private static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
                return n * factorial(n - 1);
        }


        #endregion

    }
}