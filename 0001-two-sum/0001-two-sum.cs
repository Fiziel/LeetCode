public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indexes = new int[2];
        if(nums.Length >= 2 && nums.Length <= Math.Pow(10, 9))
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if(target == nums[i] + nums[j])
                    {
                        indexes[0] = i;
                        indexes[1] = j;
                    }
                }
            }
        }
        return indexes;
    }
}