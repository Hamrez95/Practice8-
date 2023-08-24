namespace Practice8
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //Part one-------------------------------------------------------------------------------------------
            #region Part one
            Console.WriteLine("- Part One : Is Anagram Or Not");
            Part1Anagram part1 = new();
            Console.WriteLine(part1.IsAnagram("anagram", "nagaram"));
            Console.WriteLine(part1.IsAnagram("rat", "car"));
            Console.WriteLine(part1.IsAnagram("hamid", "dimah"));
            Console.WriteLine("*********************************************************************");
            #endregion


            //Part Two-------------------------------------------------------------------------------------------
            #region Part Two
            Console.WriteLine("- Part Two : Add Digits");
            Part2Digits part2 = new();
            Console.WriteLine($"For num = 38 , the answer is --> {part2.AddDigits(38)}");
            Console.WriteLine($"For num = 0 , the answer is --> {part2.AddDigits(0)}");
            Console.WriteLine($"For num = 248 , the answer is --> {part2.AddDigits(248)}");
            Console.WriteLine($"For num = 45678 , the answer is --> {part2.AddDigits(45678)}");
            Console.WriteLine("*********************************************************************");
            #endregion


            //Part Three-------------------------------------------------------------------------------------------
            #region Part Three
            Console.WriteLine("- Part Three : An UglyNumber Check");
            Part3Uglynum part3 = new();
            Console.WriteLine($"Is Number :'6' Ugly?  --> {part3.IsUgly(6)}");
            Console.WriteLine($"Is Number :'1' Ugly?  --> {part3.IsUgly(1)}");
            Console.WriteLine($"Is Number :'14' Ugly?  --> {part3.IsUgly(14)}");
            Console.WriteLine($"Is Number :'10' Ugly?  --> {part3.IsUgly(10)}");
            Console.WriteLine("*******************************************************************************");
            #endregion


            //Part Four-------------------------------------------------------------------------------------------
            #region Part Four
            Console.WriteLine("- Part Four : Move Zeroes To End");
            Part4MoveZiroes part4 = new();
            int[] nums1 = { 0, 1, 0, 3, 12 };
            part4.MoveZeroes(nums1);
            Console.WriteLine($"Move All Zeroes In '[ 0, 1, 0, 3, 12]' To End  --> [{string.Join(", ", nums1)}]");

            int[] nums2 = { 10, 0, 550, 22, 77, 0, 10, 0, 0, 25, 666, 8 };
            part4.MoveZeroes(nums2);
            Console.WriteLine($"Move All Zeroes In '[10, 0, 550, 22, 77, 0, 10, 0, 0, 25, 666, 8]' To End  --> [{string.Join(", ", nums2)}]");

            Console.WriteLine("*******************************************************************************");
            #endregion


            //Part Five-------------------------------------------------------------------------------------------
            #region Part Five
            Console.WriteLine("- Part Five : Word Pattern");
            Part5WordPattern part5 = new();
            Console.WriteLine($"Is 'abba' pattern mach with 'dog cat cat dog' words?  --> {part5.WordPattern("abba", "dog cat cat dog")}");
            Console.WriteLine($"Is 'hrparp' pattern mach with 'hamid reza pakpour amir reza pakpour' words?  --> {part5.WordPattern("hrparp", "hamid reza pakpour amir reza pakpour")}");
            Console.WriteLine($"Is 'hrparp' pattern mach with 'hamid reza pakpour amir hossien pakpour' words?  --> {part5.WordPattern("hrparp", "hamid reza pakpour amir hossien pakpour")}");
            #endregion

        }

    }
}