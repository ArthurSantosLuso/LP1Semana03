using System;
using System.Globalization;


namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {

            CultureInfo customCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            // Converter argumentos para floats
            args = Console.ReadLine().Split();
            float a11 = float.Parse(args[0]);
            float a12 = float.Parse(args[1]);
            float a21 = float.Parse(args[2]);
            float a22 = float.Parse(args[3]);
            float b1 = float.Parse(args[4]);
            float b2 = float.Parse(args[5]);

            // Definir Matriz A, B e C
            float[,] A = { { a11, a12 }, { a21, a22 } };
            float[] b = { b1, b2 };
            float[] Ab = new float[2];

            // Multiplicação da matriz A pelo vetor b
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Ab[i] += A[i, j] * b[j];
                }
            }

            // mostrar o resultado da multiplicação das matrizes A e B
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"| {Ab[i],7:F2} |");
            }
        }
    }
}
