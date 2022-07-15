public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var pq = new PriorityQueue<int, int>();
        int counter = 0;
        while(counter < k){
            pq.Enqueue(nums[counter], nums[counter]);
            counter++;
        }
        while(counter < nums.Length){
            if(pq.Peek() < nums[counter]){
                pq.EnqueueDequeue(nums[counter], nums[counter]);
            }
            counter++;
        }
        return pq.Peek();
    }
}