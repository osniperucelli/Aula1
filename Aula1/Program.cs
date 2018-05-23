using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Ex1();
            int numero = Ex2();
            Ex3(numero);
            Ex4(numero);
            Ex5(numero);
            Ex6(numero, nome);
            Ex7(nome);

            FimDoPrograma();
        }


        static string Ex1()
        {
            Console.WriteLine("****** Ex1 ******");

            Console.WriteLine("Hello World! Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Seu nome e: " + nome);

            return nome;
        }


        static int Ex2()
        {
            Console.WriteLine("****** Ex2 ******");

            Console.WriteLine("Digite um numero: ");
            int numero = LerInteiro();

            return numero;
        }


        static void Ex3(int numero)
        {
            Console.WriteLine("****** Ex3 ******");

            int i;
            for (i = numero + 1; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("O numero que voce digitou antes do for: " + numero);
        }


        static void Ex4(int numero)
        {
            Console.WriteLine("****** Ex4 ******");

            int antecessor, sucessor;
            antecessor = numero - 1;
            sucessor = numero + 1;

            Console.WriteLine("Antecessor = " + antecessor);
            Console.WriteLine("Sucessor = " + sucessor);
        }


        static void Ex5(int numero)
        {
            Console.WriteLine("****** Ex5 ******");

            //Faça um programa que leia um número e imprima a soma do sucessor de seu triplo com o antecessor de seu dobro.
            int sucessorTriplo, antecessorDobro;

            sucessorTriplo = (numero * 3) + 1;
            antecessorDobro = (numero * 2) - 1;

            int soma = sucessorTriplo + antecessorDobro;  //declaro e atribuo

            Console.WriteLine("A soma do sucessor de seu triplo com o antecessor de seu dobro: " + soma);
        }


        static void Ex6(int numero, string nome)
        {
            Console.WriteLine("****** Ex6 ******");

            //Faça um programa que realize a conversão de milhas para quilômetros.Lembre - se que uma milha representa 1.6KM

            double milhas = numero * 1.6;

            Console.WriteLine(numero + " KM = " + milhas + " Milhas");
            string mensagem = string.Format("{0}: {1} KM = {2} Milhas", nome, numero, milhas);
            Console.WriteLine(mensagem);
        }


        static void Ex7(string nome)
        {
            Console.WriteLine("****** Ex7 ******");

            //Faça um programa que solicite as notas de 3 provas que um dado aluno efetuou. O programa deve calcular a media final do aluno e 
            //informar se ele esta aprovado (maior que 6), reprovado (menor que 5) ou de recuperacao (entre 4 e 5). 
            //O programa deve informar a maior e a menor nota.

            double nota1, nota2, nota3;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = LerDouble();


            Console.WriteLine("Digite a segunda nota: ");
            nota2 = LerDouble();

            Console.WriteLine("Digite a terceira nota: ");
            nota3 = LerDouble();

            double media = (nota1 + nota2 + nota3) / 3;


            if (media >= 6)
            {
                //6.0 ate 10.0
                Console.WriteLine("Aluno: " + nome + " Media :  " + media + " Aprovado!");
            }
            else if (media >= 5 && media < 6)
            {
                //5.0 ate 5.9
                Console.WriteLine("Aluno: " + nome + " Media :  " + media + " Em recuperação!");
            }
            else
            {
                //4.9 ate 0
                Console.WriteLine("Aluno: " + nome + " Media :  " + media + " Reprovado!");
            }
        }

        static void FimDoPrograma()
        {
            Console.WriteLine("Fim do programa... pressione enter para finalizar");
            Console.ReadLine();
        }

        static int LerInteiro()
        {
            string line = Console.ReadLine();
            int iLine = Convert.ToInt32(line);

            return iLine;
        }

        static double LerDouble()
        {
            string line = Console.ReadLine();
            double dLine = Convert.ToDouble(line);

            return dLine;

        }
    }
}
