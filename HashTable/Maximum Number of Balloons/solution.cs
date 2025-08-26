public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int[] arr = new int[5];
            bool noMoreLeft = false;
            string requiredText = "abllnoo";
            int instances = 0;
            bool hasSomeLetters = false;
            Dictionary<char, int> dict = new Dictionary<char, int> { { 'a', 0 }, { 'b', 1 }, { 'l', 2 }, { 'o', 3 }, { 'n', 4 } };
            Dictionary<int, char> dict1 = new Dictionary<int, char> { { 0,'a'}, { 1,'b'}, { 2,'l'}, { 3,'o'}, { 4,'n'} };

            foreach (char letter in text)
            {
                if (requiredText.Contains(letter))
                {
                    arr[dict[letter]] += 1;
                    hasSomeLetters = true;
                }
            }


            while (true && hasSomeLetters)
            {
                StringBuilder checker = new StringBuilder();
                
                for(int i = 0; i < arr.Length; i++)
                {
                    if(i == 2 || i == 3)
                    {
                        if(arr[i] >= 2)
                        {
                            arr[i] -= 2;
                            checker.Append(dict1[i].ToString());
                            checker.Append(dict1[i].ToString());
                        }
                        else
                        {
                            noMoreLeft = true;
                            break;
                        }
                    }
                    else
                    {
                        if(arr[i] >= 1)
                        {
                            arr[i] -= 1;
                            checker.Append(dict1[i].ToString());
                        }
                        else
                        {
                            noMoreLeft = true;
                            break;
                        }
                    }
                }
                char[] charArr = checker.ToString().ToCharArray();
                Array.Sort(charArr);
                string check = new string(charArr);

                if (noMoreLeft)
                {
                    return instances;
                }
                else if (requiredText == check)
                {
                    instances++;
                }

            }

            return instances;
    }
}
