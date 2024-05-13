class Solution {
    public boolean isHappy(int n) {
           int rem = 0, sum = 0;
           while (n != 1 && n != 4)
        {
            n = check(n);
        }
        return n == 1;  
    }

    int check(int num){
        int rem = 0, sum = 0;
        while (num > 0)
        {
            rem = num % 10;
            sum = sum + (rem * rem);
            num = num / 10;
        }
        return sum;
    }
}