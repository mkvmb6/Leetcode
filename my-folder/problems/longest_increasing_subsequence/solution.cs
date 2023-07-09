public class Solution {
    public int LengthOfLIS(int[] array) {        
        var len = array.Length;
		var maxSums = new int[len];
        var maxIndex = 0;
        var maxSum = 1;
        maxSums[0] = 1;
        var seqs = Enumerable.Repeat(-1, len).ToList();
        
        for(int i=1;i<array.Length;i++){
            var num = array[i];
            maxSums[i] = 1;
            if(maxSums[i] > maxSum){
                maxIndex = i;
                maxSum = maxSums[i];
            }
            for(int j=0;j<i;j++){
                var prevNum = array[j];
                if(prevNum < num && maxSums[j] + 1 >= maxSums[i]){
                    maxSums[i] = maxSums[j] + 1;
                    seqs[i] = j;
                    if(maxSums[i] > maxSum){
                        maxIndex = i;
                        maxSum = maxSums[i];
                    }
                }
            }
        }
        len = 0;
        while(maxIndex!=-1){
            len++;
            maxIndex = seqs[maxIndex];
        }
        return len;
    }
}