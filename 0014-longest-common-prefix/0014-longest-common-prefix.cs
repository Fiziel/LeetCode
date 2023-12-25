public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }
        
        var prefix = new StringBuilder();
        var temporaryPrefixes = new string[strs.Length];
        
        for(var wordCounter = 0; wordCounter < strs[0].Length; wordCounter++)
        {
            char tempChar = strs[0][wordCounter];
            
            for(var i = 1; i < strs.Length; i++)
            {
                if(wordCounter >= strs[i].Length || strs[i][wordCounter] != tempChar)
                    return prefix.ToString();
            }
            prefix.Append(tempChar);
        }
        
        return prefix.ToString();
    }
}