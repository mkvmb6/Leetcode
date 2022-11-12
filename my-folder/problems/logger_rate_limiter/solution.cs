public class Logger {
    Dictionary<string, int> streamMap;

    public Logger() {
        streamMap = new Dictionary<string, int>();
    }
    
    public bool ShouldPrintMessage(int timestamp, string message) {
        if(streamMap.ContainsKey(message) && timestamp < streamMap[message]){
            return false;
        }
        streamMap[message]=timestamp + 10;
        return true;
    }
}

/**
 * Your Logger object will be instantiated and called as such:
 * Logger obj = new Logger();
 * bool param_1 = obj.ShouldPrintMessage(timestamp,message);
 */