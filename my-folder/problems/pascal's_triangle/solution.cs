public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var result = new List<IList<int>>();
        for(int i=0;i<numRows;i++){
            result.Add(new List<int>());
            for(int j=0;j<=i;j++){
                if(j==0 || j==i){
                    result[i].Add(1);
                }
                else{
                    result[i].Add(result[i-1][j-1]+result[i-1][j]);
                }
            }
        }
        
        return result;
    }
}