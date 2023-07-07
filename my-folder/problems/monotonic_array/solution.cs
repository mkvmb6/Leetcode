public class Solution {
    public bool IsMonotonic(int[] array) {
        var increased = false;
        var decreased = false;
        for(int i=0;i<array.Length-1;i++){
            if(array[i]<array[i+1]){
                increased = true;
            }
            if(array[i]>array[i+1]){
                decreased = true;
            }
        }
		return !(increased && decreased);
    }
}