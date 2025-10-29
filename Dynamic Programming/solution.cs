//JARVIS
public class Solution {
    public int MaxRepeating(string sequence, string word) {
        int count = 0;
            bool isPrevSubstring = true;
            int actualIndex = 0;
            bool isPrevNotSubString = true; ;

            for(int i = 0; i <= (sequence.Length - word.Length); i++)
            {
                if(sequence[i] == word[0])
                {
                    int j = i;
                    for(int k = 0; k < word.Length; k++)
                    {
                        if(sequence[j] != word[k])
                        {
                            isPrevSubstring = false;
                            break;
                        }
                        j++;
                    }
                    if (isPrevSubstring)
                    {
                        count = isPrevNotSubString ? 0 : count;
                        isPrevNotSubString = false;
                        count++;
                        i = j - 1; // -1 because in forloop one increment will happen
                    }
                    else
                    {
                        isPrevNotSubString = true;
                        //count = 0;
                        actualIndex++;
                        i = actualIndex - 1; // -1 because in forloop one increment will happen

                    }
                    isPrevSubstring = true;
                }
                else
                {
                    actualIndex++;
                    i = actualIndex - 1; // -1 because in forloop one increment will happen
                    //count = 0;
                    isPrevNotSubString = true;
                }
            }

            return count;
                }
            }

            return count;
    }
}
