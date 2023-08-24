namespace Practice8
{
    public class Part2Digits
    {
        public int AddDigits(int num)
        {

            while (num >= 10)
            {
                int digitSum = 0;

                while (num > 0)
                {
                    digitSum += num % 10; // Add the last digit of 'num' to 'digitSum'
                    num /= 10;   //num = num/10 Remove the last digit from 'num'
                }

                num = digitSum;
            }

            return num;

        }
    }


}