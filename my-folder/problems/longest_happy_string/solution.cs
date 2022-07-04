public class Solution {
    public string LongestDiverseString(int a, int b, int c) {
        var result = string.Empty;
        var maxHeap = new PriorityQueue<char, int>(Comparer<int>.Create((p1,p2)=>p2-p1));
        if(a>0)
            maxHeap.Enqueue('a', a);
        if(b>0)
            maxHeap.Enqueue('b', b);
        if(c>0)
            maxHeap.Enqueue('c', c);
        
        while(maxHeap.TryDequeue(out char item, out int priority)){
            var len = result.Length;
            if(len>1 && result[len-1]==result[len-2] && result[len-1]==item){
                if(maxHeap.TryDequeue(out char item2, out int priority2)){
                    result+=item2;
                    priority2--;
                    if(priority2 > 0){
                        maxHeap.Enqueue(item2, priority2);
                    }
                }
                else{
                    return result;
                }
            }
            else{
                result+=item;
                priority--;
            }
            if(priority > 0){
                maxHeap.Enqueue(item, priority);
            }
        }
        return result;
    }
}