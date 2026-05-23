public class Solution {
    public int LongestConsecutive(int[] nums) {
        // second solve , O1
        var numSet = new HashSet<int>(nums);
        var result = 0;

        foreach(var num in numSet){
            if(!numSet.Contains(num-1)){
                var currentVal = num;
                var x = 1;

                while(numSet.Contains(currentVal + 1)){
                    currentVal++;
                    x++;
                }
                result = Math.Max(result, x);
            }
        }
        return result;

        // solve One O2
        // var result = 0;
        // var unique = nums.Distinct().ToArray();
        // for(int i = 0; i < unique.Length; i++){
        // var x = 1;
        //     var currentVal = unique[i];
            
        //     for(int a = 0; a < unique.Length; a++){
        //         if(unique[a] - currentVal == 1){
        //             x++;
        //             currentVal = unique[a];
        //             a = -1;
        //         }
        //         if(result < x){
        //             result = x;
        //         }
        //     }
        // }
        // return result;
    }
}
