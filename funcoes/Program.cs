using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe tu nombre: ");
            string nome = Console.ReadLine();
            Hellow(nome);
            int escolha = 0;
            Console.Write($"Digite um numero qualquer {nome}: ");
            int num = Convert.ToInt32(Console.ReadLine());
            do
            {

                Console.WriteLine(" 1 - Quadrado do número: ");
                Console.WriteLine(" 2 - Cubo do número: ");
                Console.WriteLine(" 3 - Raiz quadrada do número: ");
                Console.WriteLine(" 4 - Tabuada do número: ");
                Console.WriteLine(" 5 - EXIT: ");
                Console.Write("Digite sua escolha: ");
                escolha = Convert.ToInt32(Console.ReadLine());


                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"O quadrado do numero {num}, é {Quadrado(num)}");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"O Cubo do numero {num}, é {Cubo(num)}");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"A raiz quadrade do numero {num}, é {Raizquadada(num):F2}");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Tabuada(num);
                        Console.ReadKey();
                        break;
                }
               

            }while(escolha != 5);
            Console.ReadKey();
        }

        static void Hellow(string name)
        {

            Console.WriteLine($"Seja bem vindo {name}");
        }
        static double Quadrado(double numero)
        {
            double resultado = numero * numero;
            return resultado;
        }
        static double Cubo(double numero) { 
            double resultado =  Quadrado(numero)*numero;
            return resultado;
        }
        static double Raizquadada(double num)
        {
            double resultado = Math.Sqrt(num);
            return resultado;
        }
        static void Tabuada(int numero) 
        {
            Console.WriteLine($"A Tabuado do numero {numero}");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} X {i} = {numero*i}");
            }
        }

    }
}
