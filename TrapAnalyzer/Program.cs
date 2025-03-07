using System;

namespace TrapAnalyzer
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            TrapType trap = Enum.Parse<TrapType>(args[0]);
            PlayerGear gear = ParseGear(args);
            bool survives = CanSurviveTrap(trap, gear);
            DisplayResult(trap, survives);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the player gear.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The player gear.</returns>
        private static PlayerGear ParseGear(string[] args)
        {
            // Create the variable to store playes gear.
            PlayerGear gearParsed = new PlayerGear();

            // Loop to add the gear
            for (int i = 0; i < args.Length; i++)
            {
                // If it is the first arg, skip it.
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    // Add the gear to the player.
                    gearParsed = Enum.Parse<PlayerGear>(args[i]);
                }
            }
             
            // Return the gear.
            return gearParsed;
        }

        /// <summary>
        /// Can the player survive the trap given the gear it has?
        /// </summary>
        /// <param name="trap">The trap the player falls into.</param>
        /// <param name="gear">The gear the player has.</param>
        /// <returns>Wether the player survived the trap or not.</returns>
        private static bool CanSurviveTrap(TrapType trap, PlayerGear gear)
        {
            // Store if the player can survive or not.
            bool canSuvive = false;

            // Switch to verify each case.
            switch (trap)
            {
                case TrapType.FallingRocks:

                    canSuvive = (gear & PlayerGear.Helmet) == PlayerGear.Helmet ? true : false;
                    break;

                case TrapType.SpinningBlades:

                    canSuvive = (gear & PlayerGear.Shield) == PlayerGear.Shield ? true : false;
                    break;

                case TrapType.PoisonGas:

                    canSuvive = (gear & PlayerGear.Helmet) == PlayerGear.Helmet ||
                        (gear & PlayerGear.Shield) == PlayerGear.Shield ? true : false;
                    break;

                case TrapType.LavaPit:

                    canSuvive = (gear & PlayerGear.Boots) == PlayerGear.Boots ? true : false;
                    break;
            }

            // Return if can survive.
            return canSuvive;

        }

        /// <summary>
        /// Display information on wether the player survived the trap or not.
        /// </summary>
        /// <param name="trap">The trap the player has fallen into.</param>
        private static void DisplayResult(TrapType trap, bool survives)
        {
            if (survives)
            {
                // Player survived
                Console.WriteLine($"Player survives {trap.ToString()}");
            }
            else
            {
                // Player did not survive.
                Console.WriteLine($"Player dies due to {trap.ToString()}");
            }

        }
    }
}
