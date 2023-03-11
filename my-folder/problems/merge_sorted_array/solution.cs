public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int left = m -1;
        int right = n - 1;
        int i = m + n - 1;
        while(i >= 0){
            if(right < 0){
                break;
            }
            if(left >= 0 && nums1[left] >= nums2[right]){
                nums1[i]=nums1[left--];
            }
            else{
                nums1[i]=nums2[right--];
            }
            i--;
        }
    }
}