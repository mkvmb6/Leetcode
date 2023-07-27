public class Solution {
    public int JobScheduling(int[] startTime, int[] endTime, int[] profit) {
        var len = startTime.Length;
        var jobs = new (int start, int end, int profit)[len];
        for(int i=0;i<len;i++){
            jobs[i] = (startTime[i], endTime[i], profit[i]);
        }
        Array.Sort(jobs, (a, b)=>{
           var diff = a.start - b.start;
            if(diff == 0){
                diff = a.end - b.end;
            }
            return diff;
        });
        var cache = new int[len + 1];
        return GetMaxProfit(jobs, 0, cache);
    }

    int GetMaxProfit((int start, int end, int profit)[] jobs, int i, int[] cache) {
        if(i == jobs.Length - 1) {
            return jobs[i].profit;
        }

        if(cache[i] != 0) {
            return cache[i];
        }

        var firstJob = jobs[i];
        var secondJob = jobs[i+1];
        var profit = firstJob.profit;
        if(firstJob.end <= secondJob.start) {
            return firstJob.profit + GetMaxProfit(jobs, i+1, cache);
        }
        else{
            var idx = -1;
            for(var j=i+2;j<jobs.Length;j++) {
                if(firstJob.end <= jobs[j].start) {
                    idx = j;
                    break;
                }
            }
            profit = Math.Max(profit, GetMaxProfit(jobs, i+1, cache));
            if(idx != -1) {
                profit = Math.Max(profit, firstJob.profit + GetMaxProfit(jobs, idx, cache));
            }
        }
        return cache[i] = profit;

    }
}