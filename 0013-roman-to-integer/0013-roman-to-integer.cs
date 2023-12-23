public class Solution {
    public int RomanToInt(string s) 
    {
        char [] romanChar = s.ToCharArray();
        var result = 0;

        var numerals = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50}, 
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        for(var i = 0; i < romanChar.Length; i++)
        {
            if(i != romanChar.Length-1 && numerals[romanChar[i]] < numerals[romanChar[i+1]])
                result -= numerals[romanChar[i]];
            else result += numerals[romanChar[i]]; 
        }

        return result;
    }
}