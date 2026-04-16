public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums.Length < 2 || nums.Length > 1000 || target < -10000000 || target > 10000000)
        {
            return new int[0];
        }
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[i] + nums[j] == target){
                    return new int[] { i, j };
                }
            }
        }
        return new int[0];
    }
}
