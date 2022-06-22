public class Solution {
    public IList<string> ReadBinaryWatch(int turnedOn) {
        if(turnedOn > 8){
            return new List<string>();
        }
        var result = new List<string>();
        for(int i=0; i <= turnedOn; i++){
            var hours = GetHours(i);
            var minutes = GetMinutes(turnedOn - i);
            result.AddRange(GetCombinations(hours, minutes));
        }
        return result;
    }
    
    public IList<string> GetCombinations(IList<string> hours, IList<string> minutes){
        var result = new List<string>();
        if(hours.Count==0 || minutes.Count==0){
            return result;
        }
        foreach(var hour in hours){
            foreach(var minute in minutes){
                result.Add(hour+":"+minute);
            }
        }
        
        return result;
    }
    
    public IList<string> GetHours(int bits){
        switch(bits)
        {
            case 0: return new List<string>{"0"};
            case 1: return new List<string>{"1","2","4","8"};
            case 2: return new List<string>{"3","5","6","9","10"};
            case 3: return new List<string>{"7","11"};
            default:return new List<string>();
        }
    }
    public IList<string> GetMinutes(int bits){
        switch(bits)
        {
            case 0: return new List<string>{"00"};
            case 1: return new List<string>{"01","02","04","08", "16", "32"};
            case 2: return new List<string>{"03","05","06","09","10","12","17","18","20","24","33","34","36","40","48"};
            case 3: return new List<string>{"07","11","13","14","19","21","22","25","26","28","35","37","38","41","42","44","49","50","52","56"};
            case 4: return new List<string>{"15","23","27","29","30","39","43","45","46","51","53","54","57","58"};
            case 5: return new List<string>{"31","47","55","59"};
            default:return new List<string>();
        }
    }
}