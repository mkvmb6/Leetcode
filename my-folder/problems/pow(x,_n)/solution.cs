public class Solution {
    public double MyPow(double x, int n) {
        return Calculate(x, n);
    }

    double Calculate(double x, long n){
        if(n == 0){
            return 1;
        }
        if(n < 0){
            return Calculate((1/x), -n);
        }
        if(n % 2 != 0){
            return x * Calculate(x*x, (n-1)/2);
        }
        return Calculate(x*x, n/2);
    }
}