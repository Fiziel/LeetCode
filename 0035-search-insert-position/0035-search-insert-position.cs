public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var low = 0;
        var high = nums.Length - 1;
        var medium = 0;
        while(low <= high)
        {
            medium = (low + high) / 2;
            if(target == nums[medium])
                return medium;
            else if(target > nums[medium])
                low = medium + 1;
            else if(target < nums[medium])
                high = medium - 1;
        }
        
        return low;
    }
}