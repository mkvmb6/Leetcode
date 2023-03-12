public class Solution {
    public int TitleToNumber(string columnTitle) {
        int sum = 0;
        foreach(var ch in columnTitle){
            sum = sum * 26 + (ch-'A'+1);
        }
        return sum;
    }
}