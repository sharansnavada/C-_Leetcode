public class Solution {
    public int EvalRPN(string[] tokens)
        {
            Stack<int> stk = new Stack<int>();
            string operators = "+-/*";

            foreach(string op in tokens){
                if (!operators.Contains(op)) // if its the digit just add this digit to the stack
                    stk.Push(int.Parse(op));
                else                        // if its operator, then take first two digits from the stack and perform operations with this operator
                {
                    int second = stk.Pop();
                    int first = stk.Pop();

                    stk.Push(PerformOperation(op, first, second));
                }
            }

            return stk.Peek();
        }

        public int PerformOperation(string op, int first, int second)
        {
            switch (op)
            {
                case "+": return first + second;

                case "-": return first - second;

                case "/": return first / second;

                case "*": return first * second;
            }

            return 0;
        }
}
