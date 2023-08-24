namespace Practice8
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Part One : Is Anagram Or Not");
            Part1Anagram part1 = new();
            Console.WriteLine(part1.IsAnagram("anagram", "nagaram"));
            Console.WriteLine(part1.IsAnagram("rat", "car"));
            Console.WriteLine(part1.IsAnagram("hamid", "dimah"));
            Console.WriteLine("*********************************************************************");

            //Part Two-------------------------------------------------------------------------------------------

            Console.WriteLine("- Part Two : Add Digits");
            Part2Digits part2 = new();
            Console.WriteLine($"For num = 38 , the answer is --> {part2.AddDigits(38)}");
            Console.WriteLine($"For num = 0 , the answer is --> {part2.AddDigits(0)}");
            Console.WriteLine($"For num = 248 , the answer is --> {part2.AddDigits(248)}");
            Console.WriteLine($"For num = 45678 , the answer is --> {part2.AddDigits(45678)}");
            Console.WriteLine("*********************************************************************");

            //Part Three-------------------------------------------------------------------------------------------

            Console.WriteLine("- Part Three : An UglyNumber Check");
            Part3Uglynum part3 = new();
            Console.WriteLine($"Is Number :'6' Ugly?  --> {part3.IsUgly(6)}");
            Console.WriteLine($"Is Number :'1' Ugly?  --> {part3.IsUgly(1)}");
            Console.WriteLine($"Is Number :'14' Ugly?  --> {part3.IsUgly(14)}");
            Console.WriteLine($"Is Number :'10' Ugly?  --> {part3.IsUgly(10)}");

            Console.WriteLine("*******************************************************************************");

            //Part Four-------------------------------------------------------------------------------------------
        }

    }
}