public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        int groups = 0;
        Array.Sort(reservedSeats, (a, b)=>a[0]-b[0]);
        int j=0;
        int prevRow = 0;
        while(j < reservedSeats.Length){
            var row = reservedSeats[j][0];
            groups+=(row-prevRow-1)*2;
            var is23Empty = true;
            var is89Empty= true;
            var is45Empty= true;
            var is67Empty= true;
            while(j < reservedSeats.Length && row==reservedSeats[j][0]){
                var rs=reservedSeats[j];
                if(rs[1]==2 || rs[1]==3){
                    is23Empty=false;
                }
                if(rs[1]==8 || rs[1]==9){
                    is89Empty=false;
                }
                if(rs[1]==4 || rs[1]==5){
                    is45Empty=false;
                }
                if(rs[1]==6 || rs[1]==7){
                    is67Empty = false;
                }
                j++;
            }
            
            if(is23Empty || is89Empty){
                if(is23Empty && is45Empty){
                    groups++;
                }
                if(is67Empty && is89Empty){
                    groups++;
                }
            }
            else if(is45Empty && is67Empty){
                groups++;
            }
            prevRow = row;
        }
        groups+=(n-prevRow)*2;
        return groups;
    }
}