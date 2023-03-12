public class Solution {
    public uint reverseBits(uint n) {
        uint res = 0;
        for(int i=31;i>=0;i--){
            res <<= 1;
            res |= n & 1;
            n >>= 1;
        }
        return res;
    }
}