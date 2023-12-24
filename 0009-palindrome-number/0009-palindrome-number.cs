public class Solution {
    public bool IsPalindrome(int x) {
        var list = new List<int>();
        
        if(x < 0)
            return false;
        
        for(; x > 0; x /= 10)
            list.Add(x % 10);
        
        for(var i = 0; i < list.Count; i++)
        {
            if(list[i] != list[list.Count - 1 - i])
                return false;
        }
        return true;
    }
}