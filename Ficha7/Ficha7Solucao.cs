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

                lista = lista + "O produto " + nome + " custa " + preco * quantidade + " €" + "\n";
                totalcompras += preco * quantidade;

            }
            Console.WriteLine(lista);
            Console.WriteLine("O total das compras é " + totalcompras);

        }
        #endregion

        #region Exercicio 9

        public static void Exercicio9()
        {
            Console.WriteLine("Digites números");
            var num = int.Parse(Console.ReadLine());

            /* int contar = 0;
            do // fazer
            {
                Console.WriteLine(contar);
                contar++;
            }
            while (counter )

            }
        } */

            #endregion
        }
    }
}
