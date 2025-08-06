using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Class3
    {
        public static void printpattern(int n)
        {
            int startingNumber = 1;
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < (n - i); j++)
                {
                    if(j == i)
                    {
                        sb.Append(" ");
                    }
                    else
                    {
                        sb.Append(startingNumber.ToString());
                    }
                }
                Console.WriteLine(sb);
                sb = new StringBuilder();
                startingNumber++;
            }
        }
    }
}
