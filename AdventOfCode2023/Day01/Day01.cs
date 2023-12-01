using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AdventOfCode2023.Day01;

public class Day01
{
    public static string DigitRegex = @"\d";
    public static string WordAndDigitRegex =
        @"(?:\d)|(?:one)|(?:two)|(?:three)|(?:four)|(?:five)|(?:six)|(?:seven)|(?:eight)|(?:nine)";
    
    public int FindSum_Digits(string input)
    {
        return Find(input, DigitRegex);
    }
    
    public int FindSum_Words(string input)
    {
        return Find(input, WordAndDigitRegex, (d) => ConvertWordToDigit(d));
    }

    private int Find(string input, string regex, Func<string, string>? conversion = null)
    {
        return input
            .Split("\n")
            .Select(line =>
            {
                string firstNumber = Regex.Matches(line, regex).Select(x => x.ToString()).First();
                string lastNumber = default;

                int cursor = 1;
                while (cursor <= line.Length)
                {
                    var match = Regex.Matches(line.Substring(line.Length - cursor), regex);
                    if (match.Any())
                    {
                        lastNumber = match.First().ToString();
                        break;
                    }
                    cursor++;
                }


                if (conversion != null)
                {
                    firstNumber = conversion(firstNumber);
                    lastNumber = conversion(lastNumber);
                }

                var combined = firstNumber + lastNumber;
                return int.Parse(combined);
            })
            .Sum();
    }

    private string ConvertWordToDigit(string digit)
    {
        switch (digit)
        {
            case "one": return "1";
            case "two": return "2";
            case "three": return "3";
            case "four": return "4";
            case "five": return "5";
            case "six": return "6";
            case "seven": return "7";
            case "eight": return "8";
            case "nine": return "9";
        }

        if (digit.Length == 1 && char.IsDigit(digit[0]))
        {
            return digit;
        }

        throw new ArgumentException($"No conversion for {digit}");
    }
}