public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        char[] schar = s.ToCharArray();
        char[] tchar = t.ToCharArray();
        Array.Sort(schar);
        Array.Sort(tchar);
        for(int i = 0; i < schar.Length; i++){
                if(schar[i] != tchar[i]){
                    return false;
            }
        }
        return true;
    }
}
