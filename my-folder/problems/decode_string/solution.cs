public class Solution {
    public string DecodeString(string s) {
        var len = s.Length;
        int i = 0;
        var stack = new Stack<char>();
        while(i < len){
            if(s[i]==']'){
                var stack2 = new Stack<char>();
                while(stack.Peek()!='['){
                    stack2.Push(stack.Pop());
                }
                stack.Pop();
                var numStr = "";
                while(stack.Count > 0 && char.IsDigit(stack.Peek())){
                    numStr=stack.Pop()+numStr;
                }
                var num = int.Parse(numStr);
                var str = stack2.ToArray();
                for(int j=0;j<num;j++){
                    for(int k=0;k<str.Length;k++){
                        stack.Push(str[k]);
                    }
                }
            }
            else{
                stack.Push(s[i]);
            }
            i++;
        }
        var arr = new char[stack.Count];
        for(int l=stack.Count-1;l>=0;l--){
            arr[l]=stack.Pop();
        }
        return new string(arr);
    }
}