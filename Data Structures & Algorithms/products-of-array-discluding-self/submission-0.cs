public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        result[0] = 1;
        for (int i = 1; i < n; i++) {
            result[i] = result[i - 1] * nums[i - 1];
        }
        int suffix = 1;
        for (int i = n - 1; i >= 0; i--) {
            result[i] *= suffix;
            suffix *= nums[i];
        }
        return result;
    // first solve o(n2)
        // List<int> arr = new List<int>();
        // for(int x = 0; x < nums.Length; x++){
        //     var y = 1;
        //     for(int z = 0; z < nums.Length; z++){
        //         if(z == x){
        //             continue;
        //         }
        //         y *= nums[z];
        //     }
        //     arr.Add(y);
        // }
        // return arr.ToArray();
    }
}
