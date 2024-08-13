class Solution {
    public boolean isPalindrome(String s) {
        String result = s.toLowerCase().replaceAll("[^a-zA-Z0-9]", "");
        String rs = "";
        for (int i = result.length() - 1; i >=0; i--) {
            rs = rs + result.charAt(i);
        }
        if(rs.equals(result)){
            return true;
        }
        return false;
    }
}