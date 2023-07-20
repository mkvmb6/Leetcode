public class Solution {
    public int Tribonacci(int n) {
        if(n == 0){
            return 0;
        }
        else if(n == 1 || n ==2){
            return 1;
        }
        var n1 = 0;
        var n2 = 1;
        var n3 = 1;
        int i = 3;
        var sum = 0;
        while(i <= n){
            sum = n1 + n2 + n3;
            n1 = n2;
            n2 = n3;
            n3 = sum;
            i++;
        }
        return sum;
    }
}