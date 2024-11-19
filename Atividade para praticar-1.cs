using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_fixacao_FUNCTIONS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //atividade-1//
            /*
            Console.WriteLine($"Digite o número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O numero foi {numero}, e ficou {RetornarNumNegativo(numero)}");
            Console.ReadKey();
            */

            //atividade-2//
            /*
            calcPotencia();
            */
            //atividade-3//
            Console.Write($"Digite o numero: ");
            int numero = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine($"O fatorial do numero {numero} é {fatorial(numero)}");
            Console.ReadKey();
        }

        //funçoes atividade-1//
        static int RetornarNumNegativo(int num)
        {
            if (num <= 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        //funçoes atividade-2//
        static void calcPotencia()
        {
            Console.Write("Digite o BASE: ");
            int basi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o EXPOENTE: ");
            int expoente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A potencia da operação de BASE: {basi} e de EXPOENTE: {expoente} é {Math.Pow(basi, expoente)}");
        }

        static int fatorial(int num)
        {
            if (num > 0) 
            {
                int fac = 1;
                for (int i = 1; i <= num; i++)
                {
                    fac *= i;
                }
                return fac;
            }
            else
            {
                return 0;
            }
        }


    }
}
