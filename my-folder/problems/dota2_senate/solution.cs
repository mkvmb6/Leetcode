public class Solution {
    public string PredictPartyVictory(string senate) {
        var qR = new Queue<int>();
        var qD = new Queue<int>();
        var len = senate.Length;
        for(int i = 0; i < len; i++) {
            if(senate[i] == 'R') {
                qR.Enqueue(i);
            }
            else {
                qD.Enqueue(i);
            }
        }
        while(qR.Count > 0 && qD.Count > 0) {
            var rIndex = qR.Dequeue();
            var dIndex = qD.Dequeue();
            if(rIndex < dIndex) {
                qR.Enqueue(rIndex + len);
            }
            else {
                qD.Enqueue(dIndex + len);
            }
        }
        return qR.Count > 0 ? "Radiant" : "Dire";
    }
}