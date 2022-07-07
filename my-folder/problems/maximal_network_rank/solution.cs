public class Solution {
    public int MaximalNetworkRank(int n, int[][] roads) {
        var networkMap = new Dictionary<int, HashSet<int>>();
        foreach(var road in roads){
            if(networkMap.ContainsKey(road[0])){
                networkMap[road[0]].Add(road[1]);
            }
            else{
                networkMap[road[0]]=new HashSet<int>{road[1]};
            }
            if(networkMap.ContainsKey(road[1])){
                networkMap[road[1]].Add(road[0]);
            }
            else{
                networkMap[road[1]]=new HashSet<int>{road[0]};
            }
        }
        
        int maxRank = 0;
        foreach(var kvp1 in networkMap){
            foreach(var kvp2 in networkMap){
                if(kvp1.Key==kvp2.Key){
                    continue;
                }
                int extra= kvp1.Value.Contains(kvp2.Key)?1:0;
                maxRank=Math.Max(maxRank, kvp1.Value.Count+kvp2.Value.Count-extra);
            }
        }
        return maxRank;
    }
}