public class Solution {
    public int[] PlusOne(int[] digits) {
        
        for(var i = digits.Length - 1; i >= 0; i--)
        {
            if(digits[i] != 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        
        var digits1 = new int[digits.Length + 1];
        digits1[0] = 1;
        return digits1;
    }
}