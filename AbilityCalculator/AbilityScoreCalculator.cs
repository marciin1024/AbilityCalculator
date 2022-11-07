using System;
using System.Collections.Generic;
using System.Text;

namespace AbilityCalculator
{
    class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;
        /// <summary>
        /// Liczy punkty umiejętności gracza
        /// </summary>
        public void Calculate()
        {
            RollResult = ReadInt(RollResult, "Początkowy rzut 4d6");           
            DivideBy = ReadDouble(DivideBy, "Dzielenie przez");
            AddAmount = ReadInt(AddAmount, "Dodawana wartość");        
            Minimum = ReadInt(Minimum, "Minimum");
            double divided = RollResult / DivideBy;
            int added = AddAmount + (int)divided;
            if (added < Minimum)
                Score = Minimum;
            else
                Score = added;
            Console.WriteLine("Obliczone punkty umiejętności: " + Score);
            DafaultValues();
        }
        /// <summary>
        /// Ustawia wartości potrzebne do liczenia umiejętności jako domyślne
        /// </summary>
        private void DafaultValues()
        {
            RollResult = 14;
            DivideBy = 1.75;
            AddAmount = 2;
            Minimum = 3;
    }
        /// <summary>
        /// Zapisuje wartość podaną przez użytkownika lub przyjmuje wartość domyślną gdy nie zostanie podana wartość typu int
        /// </summary>
        /// <param name="default_value">Wartość domyślna</param>
        /// <param name="prompt">Tekst do wyświetlenia</param>
        /// <returns>Wartość typu int (podana przez użytkownika lub domyślna)</returns>
        int ReadInt(int default_value, string prompt)
        {
            Console.Write(prompt + " [" + default_value + "]: ");
            string text = Console.ReadLine();
            if (int.TryParse(text, out int point))
            {
                Console.WriteLine("\tUżycie wartości " + point);
                return point;
            }
            else
            {
                Console.WriteLine("\tUżycie wartości domyślnej " + default_value);
                return default_value;
            }
            
        }
        /// <summary>
        /// Zapisuje wartość podaną przez użytkownika lub przyjmuje wartość domyślną gdy nie zostanie podana wartość typu double
        /// </summary>
        /// <param name="default_value">Wartość domyślna</param>
        /// <param name="prompt">Tekst do wyświetlenia</param>
        /// <returns>Wartość typu double (podana przez użytkownika lub domyślna)</returns>
        double ReadDouble(double default_value, string prompt)
        {
            Console.Write(prompt + " [" + default_value + "]: ");
            string text = Console.ReadLine();
            if (double.TryParse(text, out double point))
            {
                Console.WriteLine("\tUżycie wartości " + point);
                return point;
            }
            else
            {
                Console.WriteLine("\tUżycie wartości domyślnej " + default_value);
                return default_value;
            }       
        }
    }
}
