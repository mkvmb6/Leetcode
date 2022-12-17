public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        var operators = new string[]{"+", "-", "*", "/"};
        foreach(var token in tokens){
            if(IsOperator(token, operators)){
                var num1 = stack.Pop();
                var num2 = stack.Pop();
                stack.Push(Evaluate(num2, num1, token));
            }
            else{
                stack.Push(int.Parse(token));
            }
        }
        return stack.Pop();
    }

    int Evaluate(int num1, int num2, string opr){
        switch(opr){
            case "+":
            return num1+num2;
            case "-":
            return num1-num2;
            case "*":
            return num1*num2;
            case "/":
            return num1/num2;
        }
        return 0;
    }

    bool IsOperator(string str, string[] operators){
        return operators.Any(o=>o == str); 
    }
}