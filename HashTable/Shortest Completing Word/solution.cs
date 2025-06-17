//Take a count of the letters in licensePlate using dictionary
//Take a count of letters in each string in words array using hash table
//Comapre whether the count of that particular word is mating the count of each letter in dictionary
//If matches add that word to a list or break from that foreach loop
//Sort the List<string> based on the each word length
//Return the first one

public class Solution {
    public string ShortestCompletingWord(string licensePlate, string[] words) {
        Dictionary<char, int> lisenceDict = new Dictionary<char, int>();
            int[] wordArr = new int[1000];
            List<string> wordStr = new List<string>();

            foreach(char letter in licensePlate)
            {
                if (char.IsLetter(letter))
                {
                    if (lisenceDict.ContainsKey(char.ToLower(letter)))
                    {
                        lisenceDict[char.ToLower(letter)]++;
                    }
                    else
                    {
                        lisenceDict[char.ToLower(letter)] = 1;
                    }
                }
            }

            foreach(string word in words)
            {
                wordArr = new int[1000];
                bool matching = true;
                foreach(char letter in word)
                {
                    wordArr[letter]++;
                }
                foreach(KeyValuePair<char,int> kvp in lisenceDict)
                {
                    if(kvp.Value > wordArr[kvp.Key])
                    {
                        matching = false;
                        break;
                    }
                }
                if (matching)
                {
                    wordStr.Add(word);
                }
            }

            List<string> sortedStrArr = wordStr.OrderBy(word => word.Length).ToList();

            return sortedStrArr[0];
    }
}
