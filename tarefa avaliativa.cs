using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha = 0;
            do{
                Console.WriteLine("=========================================================");
                Console.WriteLine(" 1 - Inverter um vetor ");
                Console.WriteLine(" 2 - Calcular a média dos números pares em um vetor");
                Console.WriteLine(" 3 - Calcular as somas das diagonais de uma matriz 3x3");
                Console.WriteLine(" 4 - Somar os elementos de cada linha de uma matriz 4x4");
                Console.WriteLine(" 5 - Contar a frequência de um número em um vetor");
                Console.WriteLine(" 6 - SAIR");
                Console.WriteLine("=========================================================");
                Console.Write("Selecione uma opção: ");
                escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        inverteVetor();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();

                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        somaDiagonal();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        somaLinhas();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        FrequenciaElementos();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Escolha uma opção válida! ---- Prescione qualquer tecla!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (escolha !=6);
            Console.ReadKey();
        }
        static void inverteVetor()
        {
            int tamanho = 5;
            int tamanho2 = 9;
            int valortemp = 0;
            int[] vetor = new int[tamanho];
            for (int i = 0 ; i< tamanho; i++)
            {
                Console.WriteLine($"Prencha a casa N°{i+1} do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < tamanho; i++)
            {
                valortemp = vetor[i];
                vetor[i] = vetor[tamanho2];
                vetor[tamanho2] = valortemp;
                tamanho2--;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
        static void somaDiagonal()
        {
            int linhas = 3;
            int colunas = 3;
            int[,] matriz = new int[linhas, colunas];
            Console.WriteLine("Prencher Matriz 3x3, 9 elementos!");
            for (int i = 0; i < linhas; i++)
            {
                for (int j= 0; j < colunas; j++)
                {
                    Console.WriteLine($"Linha {i+1}, coluna {j+1}: ");
                    matriz[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int somaPrincipal = 0, somaSecundaria =0;
            Console.WriteLine("Fazenddo o calculo das diagonais!");
            for(int i = 0;i < linhas; i++)
            {
                somaPrincipal += matriz[i,i];

                somaSecundaria+= matriz[i, 2 -i];
            }
            if(somaPrincipal > somaSecundaria)
            {
                Console.WriteLine($"A diagonal príncipal tem um maior valor de {somaPrincipal}");
            }
            else if(somaSecundaria > somaPrincipal) 
            {
                Console.WriteLine($"A diagonal secundária tem um maior valor de {somaSecundaria}");
            }
            else
            {
                Console.WriteLine($"Ambas as digonaais tem a mesma soma príncipal: {somaPrincipal}, Secundaria: {somaSecundaria} !");

            }
        }

        static void somaLinhas()
        {
            int linhas = 4;
            int colunas = 4;
            int[,] matriz = new int[linhas, colunas];

            Console.WriteLine("Prencher Matriz 4x4, 16 elementos!");
            for (int i = 0; i < linhas ; i++)
            {
                for(int j = 0; j < colunas; j++)
                {
                    Console.Write($"Linha {i + 1}, coluna {j + 1}: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int controlarSoma = 4;
            int[] soma = new int[controlarSoma];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    soma[i] += matriz[i,j];
                }
            }

            for (int i = 0;i < controlarSoma; i++)
            {
                Console.WriteLine($"A soma da linha {i+1} da soma é de {soma[i]}");
            }
        }

        static void FrequenciaElementos()
        {
            int tamanhoVetor = 10;
            int[] vetor = new int[tamanhoVetor];
            
            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.Write($"Prencher a casa {i+1} do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Digite um número para verificar sua frequência: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int frequencia = 0;
            for (int i = 0;i< tamanhoVetor ; i++) 
            {
                if (vetor[i] == num)
                {
                    frequencia++;
                }
            }
            Console.WriteLine($"O numero {num}, se repetiu com a frequência de {frequencia}");
            Console.ReadKey();
        }
    }
}
