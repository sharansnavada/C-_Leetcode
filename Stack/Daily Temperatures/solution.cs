int[] retArr = new int[temperatures.Length];
        int arrIndex = 0;
        Stack<int> stk = new Stack<int>();

        for(int i = 0; i < temperatures.Length; i++){
            if(stk.Count == 0) stk.Push(i); // for the 0th index.
            else{
                int currentTemperature = temperatures[i]; // to compare with peek of the stack.
                while(currentTemperature > temperatures[stk.Peek()]){ //if currTemp is greater than the stk peek element, Calculate the difference btw the days by using index.
                    retArr[stk.Peek()] = i - stk.Peek();
                    arrIndex++; stk.Pop();
                    if(stk.Count == 0) break; // break, because stc empty exception comes in while loop if stk is empty.
                }
                stk.Push(i); // push every day index.
            }
        }
        return retArr;
