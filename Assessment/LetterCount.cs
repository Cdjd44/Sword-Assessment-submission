namespace Assessment
{
    public class LetterCount
    {
        private string inputText;

        public LetterCount(string sample)
        {
            inputText = sample;
        }

        public List<KeyValuePair<string, int>> getCharacters(bool caseSensitive)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            if (caseSensitive)
            {
                foreach (char c in inputText)
                {
                    counts.TryGetValue(c.ToString(), out int currentCount);
                    counts[c.ToString()] = currentCount + 1;
                }
            }
            else
            {
                foreach (char c in inputText)
                {
                    string character = c.ToString();
                    character = character.ToLower();
                    counts.TryGetValue(character, out int currentCount);
                    counts[character] = currentCount + 1;
                }
            }

            var sortedKeyValuePairs = counts.OrderByDescending(x => x.Value).ToList();
            return sortedKeyValuePairs;
        }

        public int getTotalCharacters()
        {
            return inputText.Length;
        }
    }
}