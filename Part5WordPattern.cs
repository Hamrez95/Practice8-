namespace Practice8
{
    public class Part5WordPattern
    {
        public bool WordPattern(string pattern, string s)
        {
            string[] words = s.Split(' '); //split each word in s
            if(pattern.Length!=words.Length) return false; //initial check 

            Dictionary<char, string> charToWord = new Dictionary<char, string>();
            HashSet<string> usedWords = new HashSet<string>(); //For register the value of each key for evoiding duplicate

            for (int i = 0; i < pattern.Length; i++)
            {
                char c = pattern[i]; //input pattern
                string word = words[i]; //inpus s

                if(charToWord.ContainsKey(c))
                {
                    if (charToWord[c] != word)
                        return false;                                     
                }
                else
                {
                    if(usedWords.Contains(word))
                        return false;

                    charToWord[c] = word;   
                    usedWords.Add(word);//add word to hashset collection
                }

            }
            return true;
        }
    }

}
