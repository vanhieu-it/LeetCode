public class Solution {
    public int CompareVersion(string version1, string version2) {
        string[] segments1 = version1.Split('.');
        string[] segments2 = version2.Split('.');
        
        int maxLength = Math.Max(segments1.Length, segments2.Length);
        
        for (int i = 0; i < maxLength; i++) {
            int a = i < segments1.Length ? int.Parse(segments1[i]) : 0;
            int b = i < segments2.Length ? int.Parse(segments2[i]) : 0;
            
            if (a != b) {
                return a < b ? -1 : 1;
            }
        }
        return 0;
    }
}
