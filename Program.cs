namespace Practice8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Part One : Is Anagram Or Not **************************************");
            Part1Anagram part1 = new();
            Console.WriteLine(part1.IsAnagram("anagram", "nagaram"));
            Console.WriteLine(part1.IsAnagram("rat", "car"));        
            Console.WriteLine("*********************************************************************");

            //Part Two-------------------------------------------------------------------------------------------
        }
    }
    
}