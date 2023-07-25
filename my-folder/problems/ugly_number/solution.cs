public class Solution {
    public bool IsUgly(int n) {
        if(n == 0){
            return false;
        }
        var divisible = true;
        while(divisible){
            if(n % 2 == 0){
                n /= 2;
                continue;
            }
            else if(n % 3 == 0){
                n /= 3;
                continue;
            }
            else if(n % 5 == 0){
                n /= 5;
                continue;
            }
            divisible = false;
        }
        return n == 1;
    }
}