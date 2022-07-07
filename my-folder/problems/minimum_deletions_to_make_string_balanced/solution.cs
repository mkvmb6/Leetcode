public class Solution {
    public int MinimumDeletions(string s) {
        var len = s.Length;
        var arrA = new int[len];
        arrA[len-1]=s[len-1]=='a'?1:0;
        for(int i=len-2;i>=0;i--){
            arrA[i]=arrA[i+1]+(s[i]=='a'?1:0);
        }
        var minDel = int.MaxValue;
        int bCount=0;
        for(int i=0;i<len;i++){
            if(s[i]=='b'){
                minDel = Math.Min(minDel,bCount+arrA[i]);
                bCount++;
            }
        }
        minDel=Math.Min(minDel, bCount);
        return minDel;
    }
}