public class Solution {
    public int LengthOfLastWord(string s) {
        var wordCounter = 0;
        s = s.TrimEnd(new Char[] { ' ' });
        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] == ' ')
            {
                wordCounter = 0;
                continue;
            }
            wordCounter++;
        }
        
        return wordCounter;
    }
}