public class Solution {
    public bool IsValid(string s) {
        //var pOpen=0,cOpen=0,sOpen=0,pClose=0,cClose=0,sClose=0;
        var stack = new Stack<char>();
        foreach(var c in s){
            if(c=='(' || c=='{' || c=='['){
                stack.Push(c);
            }
            else if(stack.Count > 0){
                if(c==')'){
                    if(stack.Peek()=='('){
                        stack.Pop();
                    }
                    else{
                        return false;
                    }
                }
                else if(c=='}'){
                    if(stack.Peek()=='{'){
                        stack.Pop();
                    }
                    else{
                        return false;
                    }
                }else{
                    if(stack.Peek()=='['){
                        stack.Pop();
                    }
                    else{
                        return false;
                    }
                }
            }
            else{
                return false;
            }
            
        }
        return stack.Count == 0;
    }
}

