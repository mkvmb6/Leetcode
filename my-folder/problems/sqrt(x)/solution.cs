public class Solution {
    public int MySqrt(int x) {
        if(x<2){
            return x;
        }
        var left = 2;
        var right = x/2;
        var mid = 1;
        while(left<=right){
            mid = left + (right - left)/2;
            long square = (long)mid*mid;
            if(square==x){
                return mid;
            }
            else if(square < x){
                left=mid+1;
            }
            else{
                right=mid-1;
            }
        }
        return right;
    }
}