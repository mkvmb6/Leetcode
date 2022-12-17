public class Solution {
    public int GarbageCollection(string[] garbage, int[] travel) {
        var len = garbage.Length;
        int lastMIndex = -1, lastPIndex = -1, lastGIndex = -1;
        for(int i=len-1;i>=0;i--){
            if(lastMIndex == -1 || lastPIndex == -1 || lastGIndex == -1){
                if(lastMIndex==-1 && garbage[i].Contains("M")){
                    lastMIndex = i;
                }
                if(lastPIndex==-1 && garbage[i].Contains("P")){
                    lastPIndex = i;
                }
                if(lastGIndex==-1 && garbage[i].Contains("G")){
                    lastGIndex = i;
                }
            }
            else{
                break;
            }
        }
        int sumM = garbage[0].Count(x=>x=='M'), sumP =  garbage[0].Count(x=>x=='P'), sumG =  garbage[0].Count(x=>x=='G');
        for(int i=1;i<len;i++){
            if(i<=lastMIndex){
                sumM += travel[i-1];
                sumM += garbage[i].Count(x=>x=='M');
            }
            if(i<=lastPIndex){
                sumP += travel[i-1];
                sumP += garbage[i].Count(x=>x=='P');
            }
            if(i<=lastGIndex){
                sumG += travel[i-1];
                sumG += garbage[i].Count(x=>x=='G');
            }
        }
        return sumM + sumP + sumG;
    }
}