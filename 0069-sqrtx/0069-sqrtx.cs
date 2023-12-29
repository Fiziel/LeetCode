public class Solution {
    public int MySqrt(int x) {
        if(x == 0) return x;
        
        long start = 0;
        long end = x;
        
        while(start <= end)
        {
            long mid = (start + end) / 2;
            
            if(mid * mid == x)
                return (int)mid;
            else if(mid * mid > x)
                end = mid - 1;
            else start++;
        }
        
        return (int)end;
    }
}