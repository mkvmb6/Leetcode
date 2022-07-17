public class Solution {
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn) {
        return FindPaths(m,n,maxMove,startRow,startColumn,new Dictionary<(int, int, int),int>());
    }
    
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn, Dictionary<(int, int, int),int> cache) {
        
        if(startRow<0 || startColumn<0 || startRow >=m || startColumn >=n){
            return 1;
        }
        if(maxMove<=0){
            return 0;
        }
        if(cache.ContainsKey((maxMove,startRow,startColumn))){
            return cache[(maxMove,startRow,startColumn)];
        }
        long paths = 0;
        paths+=FindPaths(m,n,maxMove-1, startRow+1, startColumn, cache)%1000000007;
        paths+=FindPaths(m,n,maxMove-1, startRow-1, startColumn, cache)%1000000007;
        paths+=FindPaths(m,n,maxMove-1, startRow, startColumn+1, cache)%1000000007;
        paths+=FindPaths(m,n,maxMove-1, startRow, startColumn-1, cache)%1000000007;
        var res =(int)(paths%1000000007);
        cache[(maxMove,startRow,startColumn)]=res;
        return res;
    }
    
}