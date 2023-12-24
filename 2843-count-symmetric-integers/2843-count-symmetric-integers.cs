public class Solution {
    public int CountSymmetricIntegers(int low, int high) {
        var lowList = new List<int>();
        var symmetricCounter = 0;
        
        for(; low <= high; low++)
        {
            var SumOfFirstDigits = 0;
            var SumOfLastDigits = 0;
            lowList.Clear();
            
            var x = low;
            for(; x > 0; x/=10)
                lowList.Insert(0, x % 10);
            
            if (lowList.Count % 2 != 0)
                continue;
            
            for(var i = 0; i < lowList.Count; i++)
            {
                if(i < lowList.Count / 2)
                    SumOfFirstDigits += lowList[i];
                else SumOfLastDigits += lowList[i];
            }
            
            if(SumOfFirstDigits == SumOfLastDigits) 
                symmetricCounter++;
        }
        
        return symmetricCounter;
    }
}