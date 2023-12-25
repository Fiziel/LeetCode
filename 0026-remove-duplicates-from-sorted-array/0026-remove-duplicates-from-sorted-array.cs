public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var duplicatesCounter = 0;
        var temp = nums[0];
        
        for(var i = 1; i < nums.Length; i++)
        {
            if(temp != nums[i])
                nums[i - duplicatesCounter] = nums[i];
            else duplicatesCounter++;
             temp = nums[i];
        }
        
        return nums.Length - duplicatesCounter;
    }
}