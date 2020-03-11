using System;

namespace Ficha6
{
    public class Ficha6solucao
    {
        #region Exercicio1

        public static void Exercicio1()
        {
            Console.WriteLine("Qual é o nome?");
            var nome = Console.ReadLine();
            OlaNome(nome);
        }
        private static void OlaNome(string nome)
        {
            Console.WriteLine("Olá, seja benvindo " + nome);
        }

        #endregion

        #region Exercicio 2

        public static void Exercicio2()
        {
            Console.WriteLine("Num 1?");
            var num1 = Console.ReadLine();
            Console.WriteLine("Num 2?");
            var num2 = Console.ReadLine();
            var num1Conv = convertStringParaNumero(num1);
            var num2Conv = convertStringParaNumero(num2);
            ApresentarSoma(num1Conv, num2Conv);
        }

        public static int convertStringParaNumero(string num)
        {
            var parseOk = int.TryParse(num, out int parsedNum);
            if (parseOk)
            {
                return parsedNum;
            }
            return -1;
        }
        public static void ApresentarSoma(int numA, int numB)
        {
            Console.WriteLine(numA + " + " + numB + " = " + (numA + numA));
        }

        #endregion

        #region Exercicio 3
        //Ler a soma dos 10 primeiros números
        public static int LerEConverter()
        {
            Console.WriteLine("Ler Número?");
            var num = Console.ReadLine();
            var numParsed = convertStringParaNumero(num);
            return numParsed;
            ; }
        public static void Exercicio3()
        {
            var acumulador = LerEConverter();
            acumulador += LerEConverter();
            acumulador += LerEConverter();
            acumulador += LerEConverter();
            acumulador += LerEConverter();
            acumulador += LerEConverter();
            acumulador += LerEConverter();
            acumulador += LerEConverter();
            acumulador += LerEConverter();
            acumulador += LerEConverter();
            acumulador += LerEConverter();
            Console.WriteLine(acumulador);
        }

        #endregion

        #region Exercicio4

        public static void Exercicio4()
        {
            Console.WriteLine("Primeiro Número?");
            var a = Console.ReadLine();
            Console.WriteLine("Segundo Número?");
            var b = Console.ReadLine();
            var c = a;
            a = b;
            b = c;
            Console.WriteLine("Numero 1 = " + a + " e numero 2 = " + a);
        }

        #endregion

        #region Exercicio5
        public void Exercicio5a()
        {

        }
        #endregion

        #region Exercicio 6
        public static void Exercicio6()
        {
            Console.WriteLine("Solicite a tabuada");
            var t = int.Parse(Console.ReadLine());
            Tabuada(t);
        }
        public static void Tabuada(int t)
        {
            var a = t * 1;
            Console.WriteLine(t + " * 1 = " + a);
            var b = t * 2;
            Console.WriteLine((t + " * 2 = " + b));
            var c = t * 3;
            Console.WriteLine((t + " * 3 = " + c));
            var d = t * 4;
            Console.WriteLine((t + " * 4 = " + d));
            var e = t * 5;
            Console.WriteLine((t + " * 5 = " + e));
            var f = t * 6;
            Console.WriteLine((t + " * 6 = " + f));
            var g = t * 7;
            Console.WriteLine((t + " * 7 = " + g));
            var h = t * 8;
            Console.WriteLine((t + " * 8 = " + h));
            var i = t * 9;
            Console.WriteLine((t + " * 9 = " + i));
            var j = t * 10;
            Console.WriteLine((t + " * 10 = " + j));
        }

        


        #endregion

        #region Exercicio 7
        public static void Exercicio7()
        {
            Console.WriteLine("Digite o 1º número");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            double num2 = double.Parse(Console.ReadLine());
            Calmedia(num1, num2);
        }
        public static void Calmedia(double num1,double num2)
        {
            double r = (num1 + num2) / 2;
            Console.WriteLine("O resultado é " + r);
        }

        #endregion

        #region Exercicio 8
        public static void Exercicio8()
        {
            double num1 = LerEConverter();
            double num2 = LerEConverter();
            double num3 = LerEConverter();
            double num4 = LerEConverter();
            double num5 = LerEConverter();


            Media(num1, num2, num3, num4, num5);
        }
        public static void Media(double n1, double n2, double n3, double n4, double n5)
        {
            double m = (n1 + n2 + n3 + n4 + n5) / 5;
            Console.WriteLine("A média da soma dos 5 números é:" + m);
        }
        #endregion

        #region Exercicio 9
        public static void Exercicio9()
        { 
        double num1 = LerEConverter();
        double num2 = LerEConverter();
        double num3 = LerEConverter();
        double num4 = LerEConverter();
        double num5 = LerEConverter();
        double num6 = LerEConverter();
        double num7 = LerEConverter();
        double num8 = LerEConverter();
        double num9 = LerEConverter();
        double num10 = LerEConverter();

        Media(num1, num2, num3, num4, num5, num6, num7, num8, num9, num10);
    }
    public static void Media(double n1, double n2, double n3, double n4, double n5, double n6, double n7, double n8, double n9, double n10)
    {
        double m = (n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10) / 10;
        Console.WriteLine("A média da soma dos 10 números é:" + m);
    }

        #endregion

        #region Exercicio 10

        public static void Exercicio10()
        {
            Console.WriteLine("Digite um carater");
            var c = Console.ReadLine();

            Console.WriteLine(c + " " + c + " " + c);
            Console.WriteLine(c + " " + c + " " + c);
            Console.WriteLine(c + " " + c + " " + c);
        }
        #endregion

        #region Exercicio 11
        public static void Exercicio11()
        {
            Console.WriteLine("Qual o nome do produto?");
            var produto = Console.ReadLine();
            Console.WriteLine("Qual o preço do produto?");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade do produto?");
            double quantidade  = double.Parse(Console.ReadLine());

            double listacompras = (preco * quantidade);
            Console.WriteLine("O total da lista é " + listacompras + " euros");
            double Comprastotal = listacompras;
            Console.WriteLine("O total do produto é " + listacompras + " euros");


        }

        #endregion

        #region Exercicio 21
        public static void Exercicio21()
        {
            Console.WriteLine("Diz-me algo que eu não sabia");
            var a = Console.ReadLine();
            SabiaQue(a);
        }
        public static void SabiaQue(string a)
        {
            Console.WriteLine("Eu já sabia que " + a);
        }

        #endregion

        #region Exercicio 22

        public static void Exercicio22()
        {
            Console.WriteLine("Introduz dois números");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("O primeiro número é " + num1 + " e o segundo número é " + num2);

        }

        #endregion

        #region Exercicio 23

        public static void Exercicio23()
        {

        }
        #endregion
    }
}
