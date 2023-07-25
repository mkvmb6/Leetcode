public class Solution {
    public int NthUglyNumber(int n) {
        var uglies = new int[n + 1];
        uglies[1] = 1;
        var count = 1;
        int i2 = 1, i3 = 1, i5 = 1;
        while(count < n){
            var r2 = uglies[i2] * 2;
            var r3 = uglies[i3] * 3;
            var r5 = uglies[i5] * 5;
            var min = Math.Min(r2, Math.Min(r3, r5));
            uglies[++count] = min;
            if(min == r2){
                i2++;
            }
            if(min == r3){
                i3++;
            }
            if(min == r5){
                i5++;
            }
        }
        return uglies[n];
    }
}

//1,2,3,4,5,6,8,10,
//    i