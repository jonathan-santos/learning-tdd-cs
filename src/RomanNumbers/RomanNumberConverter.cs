using System.Collections.Generic;

namespace RomanNumbers
{
    public class RomanNumberConverter
    {
        static Dictionary<char, int> _letterValues = new()
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000,
        };

        public static int Convert(string numberInRoman)
        {
            int accumulator = 0;
            int lastNeighbourRight = 0;

            for (var i = numberInRoman.Length - 1; i >=0; i--)
            {
                int current = _letterValues[numberInRoman[i]];
                int multiplier = 1;

                if (current < lastNeighbourRight)
                    multiplier = -1;

                accumulator += current * multiplier;

                lastNeighbourRight = current;
            }

            return accumulator;
        }
    }
}
