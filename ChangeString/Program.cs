using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Pedir a string ao utilizador
            Console.Write("String: ");
            string palavra = Console.ReadLine();

            // Pedir o carater da string a ser trocado
            Console.Write("Caráter: ");
            char caraterTrocar = char.Parse(Console.ReadLine());

            // Trocar os caraters da string original
            string palavraTrocada = palavra.Replace(caraterTrocar, 'x');

            // Imprimir a sting com os caracters trocados
            Console.WriteLine(palavraTrocada);
        }
    }
}
