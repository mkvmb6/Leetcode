public class Solution {
    public bool IsHappy(int n) {
        int slow = n;
        int fast = GetNext(n);
        while(fast!=1 && slow!=fast){
            slow=GetNext(slow);
            fast = GetNext(GetNext(fast));
        }
        return fast==1;
    }

    int GetNext(int num){
        int sum = 0;
        while(num>0){
            sum+=(num%10) * (num%10);
            num/=10;
        }
        return sum;
    }
}