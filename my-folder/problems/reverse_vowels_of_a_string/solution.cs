public class Solution {
    public string ReverseVowels(string s) {
        var left = 0;
        var right = s.Length - 1;
        var arr = s.ToCharArray();
        while(left<right){
            if(!isVovel(arr[left])){
                left++;
            }
            else if(!isVovel(arr[right])){
                right--;
            }
            else{
                var t = arr[left];
                arr[left] = arr[right];
                arr[right] = t;
                left++;
                right--;
            }
        }
        return new string(arr);
    }

    bool isVovel(char ch){
        return ch == 'a' ||ch == 'e' ||ch == 'i' ||ch == 'o' ||ch == 'u' ||ch == 'A' ||ch == 'E' ||ch == 'I' ||ch == 'O' ||ch == 'U';
    }
}