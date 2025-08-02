public string SortSentence(string s)
{
    string[] splitString = s.Split(" ");
    string[] sortedStringArr = new string[splitString.Length];
    foreach (string word in splitString)
    {
        sortedStringArr[int.Parse(word[word.Length - 1].ToString()) - 1] = word.Substring(0, word.Length - 1);
    }
    return string.Join(" ", sortedStringArr);
}
