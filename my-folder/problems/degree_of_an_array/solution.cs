using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int FindShortestSubArray(int[] nums) {
        var indexMap = new Dictionary<int, IndexItem>();
            for (int i = 0; i < nums.Length; i++)
            {
                var item = nums[i];
                if (indexMap.ContainsKey(item))
                {
                    indexMap[item].EndIndex = i;
                }
                else
                {
                    indexMap[item] = new IndexItem { StartIndex = i, EndIndex = i };
                }
                indexMap[item].Count++;
            }
            var degree = indexMap.Values.Max(i => i.Count);
            var min = indexMap.Values.Where(i=>i.Count==degree).Min(i => i.EndIndex-i.StartIndex);
            return min + 1;
    }
}


    class IndexItem
    {
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public int Count { get; set; }
    }