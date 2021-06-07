using System;

namespace Task_4
{
    internal delegate string ConvertRule(string str);

    internal class Converter
    {
        public string Convert(string str, ConvertRule cr) => cr?.Invoke(str);
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var strings = new[] { "dasdas12312", "   123 312dsa dsa", "dasdas 3123 dsad123a   123" };
            var converter = new Converter();
            foreach (var str in strings)
            {
                Console.WriteLine($"Delete digits: {converter.Convert(str, RemoveDigits)}");
                Console.WriteLine($"Delete spaces: {converter.Convert(str, RemoveSpaces)}");
            }

            var convert = new ConvertRule(RemoveDigits) + RemoveSpaces;
            foreach (ConvertRule convertRule in convert.GetInvocationList())
            {
                foreach (var s in strings)
                {
                    Console.WriteLine(convertRule?.Invoke(s));
                }

                Console.WriteLine();
            }
        }

        public static string RemoveDigits(string str)
        {
            var newStr = string.Empty;
            foreach (var ch in str)
            {
                if (char.IsDigit(ch)) continue;

                newStr += ch;
            }

            return newStr;
        }

        public static string RemoveSpaces(string str)
        {
            var newStr = string.Empty;
            foreach (var ch in str)
            {
                if (char.IsWhiteSpace(ch)) continue;

                newStr += ch;
            }

            return newStr;
        }
    }
}