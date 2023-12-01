using System.Text.RegularExpressions;

namespace AdventOfCode2023.Day01;

public class Output
{
    public static void Main()
    {
        var result1 = new Day01().FindSum_Digits(Input.Data);
        Console.WriteLine($"Part1: Sum of number is: {result1}");
        
        var result2 = new Day01().FindSum_Words(Input.Data);
        Console.WriteLine($"Part2: Sum of number is: {result2}");
    }
}