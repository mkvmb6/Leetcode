public class Solution {
    public int LongestMountain(int[] arr) {
        var len = arr.Length;
        var maxPeak = 0;
        if(len < 3){
            return 0;
        }
        for(int i=1;i<len-1;i++){
            if(arr[i] > arr[i-1] && arr[i] > arr[i+1]){
                maxPeak = Math.Max(maxPeak, FindPeakLength(arr, i));
            }
        }
        return maxPeak;
    }

    int FindPeakLength(int[] arr, int peak){
        var len = 1;
        var i = peak -1;
        while(i >= 0){
            if(arr[i] >= arr[i+1]){
                break;
            }
            len++;
            i--;
        }
        i = peak + 1;
        while(i < arr.Length){
            if(arr[i] >= arr[i-1]){
                break;
            }
            len++;
            i++;
        }
        return len;
    }
}