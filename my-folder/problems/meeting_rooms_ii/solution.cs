public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        Array.Sort(intervals, (a, b)=>a[0]-b[0]);
        var pq = new PriorityQueue<int, int>();
        var max = 0;
        foreach(var interval in intervals){
            if(pq.Count!=0){
                var item = pq.Peek();
                if(item <= interval[0]){
                    pq.Dequeue();
                }
            }
            pq.Enqueue(interval[1], interval[1]);
            max = Math.Max(pq.Count, max);
        }
        return max;
    }
}