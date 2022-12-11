public class Solution {
    public string GetPermutation(int n, int k) {
        var str = string.Empty;
        for(int i=1;i<=n;i++){
            str+=i;
        }
        return FindPermutation(str, n, k, FindFact(n));
    }

    string FindPermutation(string str, int n, int k, int totalPerm){
        if(k==1){
            return str;
        }
        var remainingPerm = totalPerm/n;
        remainingPerm = remainingPerm==0?k:remainingPerm;
        var carry =  k % remainingPerm;        
        var index = (k / remainingPerm)+(carry>0?1:0)-1;
        var remStr = RemoveAtIndex(str, index);
        return str[index]+FindPermutation(remStr, remStr.Length,carry==0?remainingPerm:carry, remainingPerm);
    }

    string RemoveAtIndex(string s, int index){
        return s.Substring(0, index)+s.Substring(index+1);
    }

    private int FindFact(int n){
        if(n==0){
            return 1;
        }
        return n*FindFact(n-1);
    }
}