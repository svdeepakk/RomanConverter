using System.Text;

namespace RomanConverter
{
    public static class RomanConverterExtension
    {
        public static string ConvertToRoman(int number)
        {
            if (number < 0 || (number > 3999))
                throw new ArgumentOutOfRangeException("Use a positive integer between, 1 - 3999");

            StringBuilder romanNumber = new StringBuilder();
            int remain = number;
            while (remain > 0)
            {
                if (remain >= 1000) { romanNumber.Append("M"); remain -= 1000; }
                else if (remain >= 900) { romanNumber.Append("CM"); remain -= 900; }
                else if (remain >= 500) { romanNumber.Append("D"); remain -= 500; }
                else if (remain >= 400) { romanNumber.Append("CD"); remain -= 400; }
                else if (remain >= 100) { romanNumber.Append("C"); remain -= 100; }
                else if (remain >= 90) { romanNumber.Append("XC"); remain -= 90; }
                else if (remain >= 50) { romanNumber.Append("L"); remain -= 50; }
                else if (remain >= 40) { romanNumber.Append("XL"); remain -= 40; }
                else if (remain >= 10) { romanNumber.Append("X"); remain -= 10; }
                else if (remain >= 9) { romanNumber.Append("IX"); remain -= 9; }
                else if (remain >= 5) { romanNumber.Append("V"); remain -= 5; }
                else if (remain >= 4) { romanNumber.Append("IV"); remain -= 4; }
                else if (remain >= 1) { romanNumber.Append("I"); remain -= 1; }
                else throw new Exception("Unexpected error."); 
            }
            return romanNumber.ToString();
        }
    }
}