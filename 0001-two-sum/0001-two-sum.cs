public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums.Length >= 2 && nums.Length <= Math.Pow(10, 9))
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if(target == nums[i] + nums[j])
                    return new int[] {i, j};
                }
            }
        }
        return new int[] {};
    }
}