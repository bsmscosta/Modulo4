using System;

namespace Ficha7

{
    public class Ficha7Solucao
    {
        #region Exercicio 1
        public static void Exercicio1()
        {
            Console.WriteLine("Valor da nota?");
            double nota = double.Parse(Console.ReadLine());

            if (nota > 9.44)
            {
                Console.WriteLine("Passou");
            }
            else
            {
                Console.WriteLine("Chumbou");
            }

        }



        #endregion

        #region Exercicio 2
        public static void Exercicio2()
        {
            Console.WriteLine("Altura?");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Peso?");
            double peso = double.Parse(Console.ReadLine());

            double bmi = peso / (altura * altura);

            if (bmi < 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if ((bmi > 18.5) && (bmi < 24.9))
            {
                Console.WriteLine("Peso Normal");
            }
            else if ((bmi > 25) && (bmi < 29.9))
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }

        }
        #endregion

        #region Exercicio 3

        public static void Exercicio3()
        {
            Console.WriteLine("Número?");
            double num = double.Parse(Console.ReadLine());

            if ((num % 3 == 0) && (num % 7 == 0))
            {
                Console.WriteLine("É multiplo de 3 e 7");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("É multiplo de 3");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine("É multiplo de 7");
            }
            else
            {
                Console.WriteLine("Não é multiplo de 3 nem de 7");
            }
        }


        #endregion

        #region Exercicio 4
        public static void Exercicio4()
        {
            Console.WriteLine("Solicitar um número");
            int num = int.Parse(Console.ReadLine());

            if ((num >= 30) && (num <= 50)) // Inclusive
            {
                Console.WriteLine("O valor encontra-se entre 30 e 50");
            }
            else
            {
                Console.WriteLine("O valor nao se encontra entre 30 e 50");
            }

        }


        #endregion

        #region Exercicio 5
        public static void Exercicio5()
        {
            Console.WriteLine("Solicitar um número");
            int num = int.Parse(Console.ReadLine());

            if ((num > 10) && (num < 20)) // exclusive
            {
                Console.WriteLine("O valor encontra-se entre 10 e 20");
            }
            else
            {
                Console.WriteLine("O valor nao se encontra entre 10 e 20");
            }

        }
        #endregion

        #region Exercicio 6

        public static void Exercicio6()
        {
            Console.WriteLine("Vai em que andar?");
            int andar = int.Parse(Console.ReadLine());

            if ((andar < -2) || (andar > 6) || (andar == 3) || (andar == 5))
            {
                Console.WriteLine("Não disponível");
            }
            else
            {
                Console.WriteLine("A seguir para o piso " + andar);
            }
        }

        #endregion

        #region Exercicio 7
        public static void Exercicio7()
        {
            int i = 0; //contar os numeros de 0 à 9 = 10 números
            double soma = 0;

            while (i < 10) //ou i <= 10 se i = 1
            {
                Console.WriteLine("Número?");
                double num = double.Parse(Console.ReadLine());

                soma = soma + num;
                i++;
                Console.WriteLine("A soma é igual a " + soma);
            }
        }


        #endregion

        #region Exercicio 8

        public static void Exercicio8()
        {
            string lista = "";
            double totalcompras = 0; //igual a zero por ser um valor

            for (int contador = 0; contador < 5; contador++)
            {
                Console.WriteLine("Solicitar produto");
                var nome = Console.ReadLine();
                Console.WriteLine("Solicite o preço");
                double preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Solicite o quantidade");
                double quantidade = double.Parse(Console.ReadLine());

                lista = lista + "O produto " + nome + " custa " + (preco * quantidade) + " €" + "\n";
                totalcompras += preco * quantidade;

            }
            Console.WriteLine(lista);
            Console.WriteLine("O total das compras é " + totalcompras);

        }
        #endregion

        #region Exercicio 9

        public static void Exercicio9()
        {
            int i = 0;
            double soma = 0;
            double num;

            do
            {
                Console.WriteLine("Digites números");
                num = double.Parse(Console.ReadLine());


                if (num != 0)
                {
                    soma = soma + num;
                    i++;
                }
            } while (num != 0);

            Console.WriteLine("A média da soma é igual" + soma / i);
        }

        #endregion

        #region Exercicio 10

        public static void Exercicio10()
        {
            Console.WriteLine(" 1º N?");
            var n1 = double.Parse(Console.ReadLine());
            Console.WriteLine(" 2º N?");
            var n2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Qual é a operação");
            var op = Console.ReadLine();
            double resultado = 0;

            if (op == "+")
            {
                resultado = n1 + n2;
                Console.WriteLine("N1 + N2 = " + resultado);
            }
            else if (op == "-")
            {
                resultado = n1 - n2;
                Console.WriteLine("N1 - N2 = " + resultado);
            }
            else if (op == "*")
            {
                resultado = n1 * n2;
                Console.WriteLine("N1 * N2 = " + resultado);
            }
            else if (op == "/")
            {
                resultado = n1 / n2;
                Console.WriteLine("N1 / N2 = " + resultado);
            }
            else if (op == "%")
            {
                resultado = n1 % n2;
                Console.WriteLine("N1 % N2 = " + resultado);
            }
            else
            {
                Console.WriteLine("operador invalido");
            }

        }

        #endregion

        #region Exercicio11

        public static void Exercicio11()
        {
            Console.WriteLine("Escreva um carater");
            var c = Console.ReadLine();

            for (int counter = 1; counter <= 3; counter++)
            {
                for (int counter2 = 1; counter2 <= 3; counter2++)
                {
                    Console.Write(c + " ");
                }
                Console.Write("\n");
            }

        }
        #endregion

        #region Exercicio 12

        public static void Exercicio12()
        {
            Console.WriteLine("Escreva um carater");
            var c = Console.ReadLine();
            Console.WriteLine("Escreva um número");
            int n = int.Parse(Console.ReadLine());

            for (int counter = 1; counter <= n; counter++)
            {
                for (int counter2 = 1; counter2 <= n; counter2++)
                {
                    Console.Write(c + " ");
                }
                Console.Write("\n");
            }

        }

        #endregion

        #region Exercicio 13

        public static void Exercicio13()
        {
            Console.WriteLine("Escreva o primeiro carater");
            var m = Console.ReadLine();
            Console.WriteLine("Escreva o segundo carater");
            var n = Console.ReadLine();

            Console.WriteLine("Digite o primeiro número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int num2 = int.Parse(Console.ReadLine());

            for (int counter = 1; counter <= num1; counter++)
            {
                for (int counter2 = 1; counter2 <= num2; counter2++)
                {
                    if (counter2 % 2 == 0)
                    {
                        Console.Write(m + " ");
                    }
                    else
                    {
                        Console.Write(n + " ");
                    }
                }
                Console.Write("\n");
            }
        }
        #endregion

        #region Exercicio 21
        public static void Exercicio21()
        {
            Console.WriteLine("Introduz a temperatura");
            double temp = double.Parse(Console.ReadLine());
            string escala = "";

            while (escala != "C" && escala != "K" && escala != "F")
            {
                Console.WriteLine("Em que escala? (C,K ou F)");
                escala = Console.ReadLine();
            }
            switch (escala)
            {
                case "C":
                    Console.WriteLine("ºC é equivalente a " + (temp + 273.15) + " ºK e " + ((temp * 9 / 5) + 32) + "F");
                    break;
                case "K":
                    Console.WriteLine("ºK é equivalente a " + (temp - 273.15) + " ºC e " + ((temp * 9 / 5) - 459, 67) + "F");
                    break;
                case "F":
                    Console.WriteLine("ºF é equivalente a " + ((temp - 32) * 5 / 9) + " ºC e " + (temp + 459, 67) + "K");
                    break;
                default:
                    Console.WriteLine("Escala de temperatura desconhecida");
                    break;
            }
        }

        #endregion

        #region Exercicio 22
        public static void Exercicio22() // Apresenta uma lista de nº impares
        {
            Console.WriteLine("Qual é o número limite?");
            int num = int.Parse(Console.ReadLine());

            for (int count = 0; count <= num; count++)
            {
                if (count % 2 == 1)
                {
                    Console.WriteLine(count);
                }
            }
        }

        

        #endregion

        #region Exercicio 23
        public static void Exercicio23()
        {
            string caracteres = "";
            string caracter = "";

            do
            {
                Console.WriteLine("Introduz um número, ou enter para terminar");
                caracter = Console.ReadLine();
                caracteres = caracter + caracteres; // Apresenta o resultado ao contrário porque A = B + A --> BA
            } while (caracter != "");
            Console.WriteLine(caracteres);
        }

        #endregion

        #region Exercicio 31
        public static void Exercicio31()
        {
            Console.WriteLine("Introduz um número?");
            double n = double.Parse(Console.ReadLine());
            if ( n % 2 == 0)
            {
                Console.WriteLine(n * 3);
            }
            else
            {
                Console.WriteLine(n * 2);
            }
        }

        #endregion

        #region Exercicio 32
        public static void Exercicio32()
        {
            Console.WriteLine("Qual é a dimensão do triângulo?");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
      

            while (n > 0)
            {
                n--;
                int a = 0;

                while (a != n)
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
                i += 2;
                Console.Write("\n");
            }

        }

        #endregion
    }
}

