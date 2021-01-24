namespace RomanNumbers
{
    public class RomanNumberConverter
    {
        public static int Convert(string numberInRoman)
        {
            if (numberInRoman == "I")
                return 1;
            else if (numberInRoman == "V")
                return 5;
            else
                return 0;
        }
    }
}
