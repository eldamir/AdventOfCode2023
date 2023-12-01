using System.Text.RegularExpressions;

namespace Tests.Day01;

public class Day01Tests
{
    [Fact]
    public void FindSum_Digits()
    {
        var input = @"1abc2
pqr3stu8vwx
a1b2c3d4e5f
treb7uchet";
        var result = new AdventOfCode2023.Day01.Day01().FindSum_Digits(input);
        Assert.Equal(142, result);
    }
    
    [Fact]
    public void CheckRegexMatch()
    {
        var input = @"two1nine";
        var match = Regex.Matches(input, AdventOfCode2023.Day01.Day01.WordAndDigitRegex).ToList();
        Assert.Equal("two", match[0].ToString());
        Assert.Equal("1", match[1].ToString());
        Assert.Equal("nine", match[2].ToString());
    }
    
    [Fact]
    public void CheckRegexFindsOne()
    {
        var input = @"tonene";
        var match = Regex.Matches(input, AdventOfCode2023.Day01.Day01.WordAndDigitRegex).ToList();
        Assert.Equal("one", match[0].ToString());
    }
    
    [Fact]
    public void CheckRegexFindsTwo()
    {
        var input = @"ttwone";
        var match = Regex.Matches(input, AdventOfCode2023.Day01.Day01.WordAndDigitRegex).ToList();
        Assert.Equal("two", match[0].ToString());
    }
    
    [Fact]
    public void CheckRegexFindsThree()
    {
        var input = @"tothree";
        var match = Regex.Matches(input, AdventOfCode2023.Day01.Day01.WordAndDigitRegex).ToList();
        Assert.Equal("three", match[0].ToString());
    }
    
    [Fact]
    public void CheckRegexFindsFour()
    {
        var input = @"tofour";
        var match = Regex.Matches(input, AdventOfCode2023.Day01.Day01.WordAndDigitRegex).ToList();
        Assert.Equal("four", match[0].ToString());
    }
    
    [Fact]
    public void CheckRegexFindsFive()
    {
        var input = @"tofive";
        var match = Regex.Matches(input, AdventOfCode2023.Day01.Day01.WordAndDigitRegex).ToList();
        Assert.Equal("five", match[0].ToString());
    }
    
    [Fact]
    public void CheckRegexFindsSix()
    {
        var input = @"tosix";
        var match = Regex.Matches(input, AdventOfCode2023.Day01.Day01.WordAndDigitRegex).ToList();
        Assert.Equal("six", match[0].ToString());
    }
    
    [Fact]
    public void CheckRegexFindsSeven()
    {
        var input = @"toseven";
        var match = Regex.Matches(input, AdventOfCode2023.Day01.Day01.WordAndDigitRegex).ToList();
        Assert.Equal("seven", match[0].ToString());
    }
    
    [Fact]
    public void CheckRegexFindsEight()
    {
        var input = @"toeight";
        var match = Regex.Matches(input, AdventOfCode2023.Day01.Day01.WordAndDigitRegex).ToList();
        Assert.Equal("eight", match[0].ToString());
    }
    
    [Fact]
    public void CheckRegexFindsNone()
    {
        var input = @"tonine";
        var match = Regex.Matches(input, AdventOfCode2023.Day01.Day01.WordAndDigitRegex).ToList();
        Assert.Equal("nine", match[0].ToString());
    }
    
    [Fact]
    public void CheckRegexFindsAllMatches()
    {
        var input = @"eightwo";
        var result = new AdventOfCode2023.Day01.Day01().FindSum_Words(input);
        Assert.Equal(82, result);
    }
    
    
    [Fact]
    public void FindSum_Words()
    {
        var input = @"two1nine
eightwothree
abcone2threexyz
xtwone3four
4nineeightseven2
zoneight234
7pqrstsixteen";
        var result = new AdventOfCode2023.Day01.Day01().FindSum_Words(input);
        Assert.Equal(281, result);
    }
}