namespace us.fatehi.palindrome
{
    public class Palindrome
    {
        public bool IsPalindrome(string word)
        {
            // Exit early for trivial cases, such as null,
            // empty string, and a word with a single letter
            if (word == null || word.Length < 2)
            {
                return true;
            }

            char firstChar = word[0];
            char lastChar = word[word.Length - 1];
            string center = word.Substring(1, word.Length - 2);
            return (firstChar == lastChar) && IsPalindrome(center);
        }
    }
}
