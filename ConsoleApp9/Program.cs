using System;
using ConsoleTables;
namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Generador = new Random();
            int[] Numeros = new int[10];
            double[] RaizCuadrada = new double[10];
            int[] impar = new int[10];
            int[] Contador = new int[10];

            for (int i = 0; i < Numeros.Length; i++)
            {

                Numeros[i] = Generador.Next(1, 99);
            }
            for (int i = 0; i < Numeros.Length; i++)
            {
                double Raiz = HallarRaiz(Numeros[i]);
                Console.WriteLine($"La Raiz cuadrada de {Numeros[i]} es:{Raiz}");
                int Impar = Hallarnumerosimpares(Numeros[i]);
                Console.WriteLine($"Los numeros pares son:{Numeros[i]}",i-1);
                //int ContadorNumerosPar = HallarNumerosPares(Numeros[i]);
                //Console.WriteLine($"Los numeros impares son:{Impar}");
                //Console.WriteLine($"los numeros son:{Numeros[i]}");
            }
            Console.ReadLine();
        }

        private static double HallarRaiz(int numeros) => Math.Sqrt(numeros);

        private static int Hallarnumerosimpares(int numeros)
        {
            for (int i = 0; i < numeros; i++)
            {
                if (numeros % 2 == 0)
                {
                    Console.WriteLine($"{numeros} es par");
                   
                }
                else
                {
                    Console.WriteLine($"{numeros} es impar");
                }
                return numeros; 
            }
            return numeros;
        }

    }
    }
