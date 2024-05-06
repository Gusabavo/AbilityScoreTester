namespace AbilityScoreTester


{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue ");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;


                ///<sumary>
                ///Write the prompt and read
                ///</sumary>
                ///<param name="lastUsedValue">The default value.</param>
                ///<param name="prompt">Prompt to print to the console.</param>
                ///<returns>The read int value, or the default value if it cannot be converted.</returns
                static int ReadInt (int lastUsedValue, string prompt)
                {
                    Console.Write(prompt + " [" + lastUsedValue + "]:");
                    string line = Console.ReadLine();
                    if ( int.TryParse(line, out int value))
                    {
                        Console.WriteLine("   using value " + value);
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("   using default value " + lastUsedValue);
                        return lastUsedValue;
                    }
                    
                }

                static double ReadDouble(double lastUsedValue, string prompt)
                {
                    Console.Write(prompt + " [" + lastUsedValue + "]:");
                    string line = Console.ReadLine();
                    if (double.TryParse(line, out double value))
                    {
                        Console.WriteLine("   using value " + value);
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("   using default value " + lastUsedValue);
                        return lastUsedValue;
                    }

                }
            }
        }
    }
}
