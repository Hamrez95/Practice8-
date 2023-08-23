namespace Practice8
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Part One : Is Anagram Or Not **************************************");
            Part1Anagram part1 = new();
            Console.WriteLine(part1.IsAnagram("anagram", "nagaram"));
            Console.WriteLine(part1.IsAnagram("rat", "car"));
            Console.WriteLine(part1.IsAnagram("hamid", "dimah"));
            Console.WriteLine("*********************************************************************");

            //Part Two-------------------------------------------------------------------------------------------

            Console.WriteLine("- Part Two : Add Digits ********************************************");
            Part2Digits part2 = new();
            Console.WriteLine($"For num = 38 , the answer is --> {part2.AddDigits(38)}");  
            Console.WriteLine($"For num = 0 , the answer is --> {part2.AddDigits(0)}");  
            Console.WriteLine($"For num = 248 , the answer is --> {part2.AddDigits(248)}");  
            Console.WriteLine($"For num = 45678 , the answer is --> {part2.AddDigits(45678)}");
            Console.WriteLine("*********************************************************************");

            //Part Three-------------------------------------------------------------------------------------------


        }
    }

}