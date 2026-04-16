public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach(var num in nums){
            if(freq.ContainsKey(num)){
                freq[num]++;
            }else{
                freq[num] = 1;
            }
        }

        int[] result = freq.OrderByDescending(pair => pair.Value)
                           .Select(pair => pair.Key)
                           .Take(k)
                           .ToArray();
        return result;
    }
}
