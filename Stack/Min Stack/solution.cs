public class MinStack {
    Stack<int> stk;
    Stack<int> minStorage;
    int minValue;

    public MinStack() {
        stk = new Stack<int>();
        minStorage = new Stack<int>();
        minValue = int.MaxValue;
    }
    
    public void Push(int val) {
        stk.Push(val);

        if(val <= minValue){
            minValue = val;
            minStorage.Push(minValue);
        } 

    }
    
    public void Pop() {
        if(stk.Peek() == minValue){
            minStorage.Pop();
            if(minStorage.Count > 0){
                minValue = minStorage.Peek();
            }
            else{
                minValue = int.MaxValue;
            }
        }
        stk.Pop();
    }
    
    public int Top() {
        return stk.Peek();
    }
    
    public int GetMin() {
        return minStorage.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
