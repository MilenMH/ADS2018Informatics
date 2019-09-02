using System;
using System.Text.RegularExpressions;

namespace AlgorithmsAndDataStructures.Algorithms.BinaryConversion
{
    public class BinaryConverter
    {

        public string ToDecimal(string input)
        {
            if (Regex.IsMatch(input, "^[01]+$"))
            {
                double output = 0;
                var index = 0;
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                foreach (var character in charArray)
                {
                    if (character.Equals('1'))
                    {
                        output += Math.Pow(2, index);
                    }
                    index++;
                }
                return output.ToString();
            }
            throw new ArgumentException();
        }

        public string ToBinary(string input)
        {
            if (Regex.IsMatch(input, "^[\\d]+$"))
            {
                string output = "";
                var number = int.Parse(input);
                do
                {
                    var remainder = number % 2;
                    if (remainder == 1)
                    {
                        output += "1";
                    }
                    else
                    {
                        output += "0";
                    }
                    number = number / 2;
                }while (number > 0);
                var charArray = output.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
            throw new ArgumentException();
        }

    }
}
