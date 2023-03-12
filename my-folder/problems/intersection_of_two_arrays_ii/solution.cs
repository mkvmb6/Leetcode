public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var map = new Dictionary<int, int>();
        foreach(var num in nums1){
            if(!map.ContainsKey(num)){
                map[num]=0;
            }
            map[num]++;
        }
        var result = new List<int>(nums2.Length);
        foreach(var num in nums2){
            if(map.ContainsKey(num)){
                map[num]--;
                if(map[num]==0){
                    map.Remove(num);
                }
                result.Add(num);
            }
        }
        return result.ToArray();
    }
}