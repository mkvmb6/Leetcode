public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        int cost  = 0;
        for(int i=0;i< colors.Length - 1;i++){
            if(colors[i]!=colors[i+1]){
                continue;
            }
            if(neededTime[i] > neededTime[i+1]){
                var temp = neededTime[i];
                neededTime[i]=neededTime[i+1];
                neededTime[i+1]=temp;
            }
            cost+=neededTime[i];
        }
        return cost;
    }
}