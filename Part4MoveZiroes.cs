namespace Practice8
{
    public class Part4MoveZiroes
    {
        public void MoveZeroes(int[] nums)
        {
            int NonZeroIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[NonZeroIndex] = nums[i];
                    NonZeroIndex++;
                }
                 
            }
            for (int i = NonZeroIndex; i < nums.Length; i++)
            {
                nums[i] = 0; //fill remain indexes with zeroes.
            }
        }
    }
}