public class Solution {
    public IList<long> MaximumEvenSplit(long finalSum) {
        var result = new List<long>();
        if(finalSum%2==1){
            return result;
        }
        long seed = 2;
        long prevSeed = 2;
        long remain = finalSum;
        while(seed <= remain){
            remain-=seed;
            if(remain==seed){
                result.Add(remain+seed);
                return result;
            }
            result.Add(seed);
            seed+=2;
        }
        if(remain>0){
            long last = result.Last();
            result.RemoveAt(result.Count-1);
            result.Add(last+remain);
        }
        
        return result;
    }
    
}