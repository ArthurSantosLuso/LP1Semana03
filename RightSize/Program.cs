using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {

            // ciclo para percorrer cada palavra dentro da string
            foreach(string palavra in args)
            {

                if(palavra.Length >= 8)
                {
                    // se a palavra ter 8 ou mais caracteres, o programa termina
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
                else if(palavra.Length > 3)
                {
                    // Se a palavra tiver mais que 3 caracteres, printa a palavra na consola
                    Console.WriteLine(palavra);
                }
            }
                Console.WriteLine("\u0008");
        }
    }
}
