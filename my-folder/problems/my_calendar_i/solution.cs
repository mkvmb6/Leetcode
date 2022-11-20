public class MyCalendar {
    SortedList<int, int> bookings;

    public MyCalendar() {
        bookings=new SortedList<int, int>();
    }
    
    public bool Book(int start, int end) {
        int left = 0, right = bookings.Count - 1;
        while(left <= right){
            var mid = left + (right - left)/2;
            var bookingStart = bookings.Keys[mid];
            var bookingEnd = bookings.Values[mid];
            if(end > bookingStart && start < bookingEnd){
                return false;
            }
            else if(start < bookingStart){
                right = mid - 1;
            }
            else{
                left = mid + 1;
            }
            
        }
        bookings.Add(start, end);
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */