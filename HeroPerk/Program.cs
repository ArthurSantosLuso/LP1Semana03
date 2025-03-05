using HeroPerks;
using System;
using System.Diagnostics.CodeAnalysis;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Perks myPerks = new Perks();
            bool skip = false;

            string input = Console.ReadLine();

            foreach (char carater in input)
            {
                // fazer toggle dos perks
                switch (carater)
                {
                    case 'w':
                        myPerks ^= Perks.WarpShift;
                        break;
                    case 'a':
                        myPerks ^= Perks.AutoHeal;
                        break;
                    case 's':
                        myPerks ^= Perks.Stealth;
                        break;
                    case 'd':
                        myPerks ^= Perks.DoubleJump;
                        break;
                    // no caso de não existir o perk
                    default:
                        skip = true;
                        Console.WriteLine("!Unknown perk!");
                        break;
                }
            }

            // se o não existir nemhuma perk desconhecida
            if (skip == false)
            {
                // Verificar se o enumerador esta vazio
                // Se sim, não imprimir o enumerador
                if (!IsEmpty(myPerks))
                    Console.WriteLine(myPerks);

                // Verificar se os perks formam
                // O "Silent jumper"
                if ((myPerks & Perks.Stealth) == Perks.Stealth &&
                (myPerks & Perks.DoubleJump) == Perks.DoubleJump)
                {
                    Console.WriteLine("!Silent jumper!");
                }

                // Verificar se não existe
                // nenhuma perk
                if (IsEmpty(myPerks))
                {
                    Console.WriteLine("!No perks at all!");
                }

                // Verificar se os perks formam
                // o "Not gonna make it"
                if ((myPerks & Perks.AutoHeal) != Perks.AutoHeal)
                {
                    Console.WriteLine("!Not gonna make it!");
                }
            }
        }

        // função para verificar se o enumerado está "vazio", não é de nenhuma perk
        private static bool IsEmpty(Perks perks)
        {
            bool empty = false;
            if (perks == 0)
                empty = true;

            return empty;
        }
    }
}
