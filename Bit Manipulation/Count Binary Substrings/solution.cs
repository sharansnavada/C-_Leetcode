using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class bitmanipulation
    {
        public int CountBinarySubstrings(string s)
        {
            int length = s.Length;
            int count = 0;
            bool addToCount = false;
            string str = "";
            int total = 0;
            int j = 0;

            while (j != length)
            {
                str = ""; total = 0;
                int k = j;
                while (k < length)
                {
                    //int iterator = k + 2;
                    int iterator = k + 2 >= length ? k + 1 : k + 2;
                    while (k < iterator)
                    {
                        str += s[k];
                        total += int.Parse(s[k].ToString());
                        k++;
                    }
                    if (total != 0)
                    {
                        if (((float)str.Length / (float)total == 2f)) // as 5/2 was also considered as 2 instead of 2.5, so casting these int values to the float datatype to get the exact value with the decimal. "000111000"  ---> for this test case, instead of 6 I was getting 7 as output
                        {
                            char bit = str[str.Length / 2];
                            int index = (str.Length / 2);

                            while (true)
                            {
                                if (str[index] != bit)
                                {
                                    addToCount = false;
                                    break;
                                }
                                else
                                {
                                    addToCount = true;
                                }
                                index++;
                                if (index == str.Length)
                                {
                                    break;
                                }
                            }
                        }
                    }
                    if (addToCount)
                        count++;
                    addToCount = false;
                    //k++;
                }
                j++;
            }
            return count;
        }
    }

}

