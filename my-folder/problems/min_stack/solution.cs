public class MinStack {
    Stack<int> minStack;
    Stack<int> stack;

    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minStack.Count == 0 || val <= minStack.Peek()){
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        var item = stack.Pop();
        if(item == minStack.Peek()){
            minStack.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
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