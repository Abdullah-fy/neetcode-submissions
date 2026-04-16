public class Solution {

    public string Encode(IList<string> strs) {
        if(strs.Count == 0) return "";
        StringBuilder sb = new StringBuilder();
        foreach(var s in strs){
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        } 
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> Result = new List<string>();
        int i = 0;
        while(i<s.Length){
            int delimiterIndex = s.IndexOf('#', i);
            string stringlength = s.Substring(i, delimiterIndex-i);
            int lenght = int.Parse(stringlength);
            int stringStartIndex = delimiterIndex + 1;
            string originalString = s.Substring(stringStartIndex, lenght);
            Result.Add(originalString);
            i = stringStartIndex + lenght;
        }
        return Result;
   }
}
