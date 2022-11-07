using System;

namespace AbilityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.Calculate();
                Console.WriteLine("Naciśnij klawisz Q by zakończyć, lub inny klawisz, aby kontynuować.");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == 'q' || keyChar == 'Q') return;
            }
        }
    }
}
