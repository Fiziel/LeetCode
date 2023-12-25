public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var valCounter = 0;
        
        for(var i = 0; i < nums.Length; i++)
        {
            if(val == nums[i])
                valCounter++;
            else nums[i - valCounter] = nums[i];
        }
        
        return nums.Length - valCounter;
    }
}