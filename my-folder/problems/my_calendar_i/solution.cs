public class MyCalendar {
    List<List<int>> bookings;

    public MyCalendar() {
        bookings=new List<List<int>>();
    }
    
    public bool Book(int start, int end) {
        foreach(var booking in bookings){
            if(end>booking[0] && start < booking[1]){
                return false;
            }
        }
        bookings.Add(new List<int>{start, end});
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */