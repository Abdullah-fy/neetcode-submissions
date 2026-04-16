public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
       List<List<string>> result = new List<List<string>>();
        List<string> sortedKeys = new List<string>();

        foreach (var str in strs) {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);

            bool found = false;
            for (int i = 0; i < sortedKeys.Count; i++) {
                if (sortedKeys[i] == sorted) {
                    result[i].Add(str);
                    found = true;
                    break;
                }
            }

            if (!found) {
                sortedKeys.Add(sorted);
                result.Add(new List<string> { str });
            }
        }

        return result;
    }
}
