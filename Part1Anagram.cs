namespace Practice8
{
    public class Part1Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            char[] sortedS = s.ToCharArray();
            char[] sortedT = t.ToCharArray();

            Array.Sort(sortedS);
            Array.Sort(sortedT);

            for (int i = 0; i < sortedS.Length; i++)
            {
                if (sortedS[i] != sortedT[i])
                    return false;
            }

            return true;
        }
    }
    

}