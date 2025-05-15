using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		
        //Problems: https://leetcode.com/problems/palindrome-number/

        var nums = new int []{2,7, 11,15};
        var target = 9;

        Solution.TwoSum(nums,target)

        
        
	}

    public static class Solution {
        public bool IsPalindrome(int x) {
            if(x < 0) 
				return false;
			
            string numberString = x.ToString();
			
            int j = (numberString.Length -1);
            for(int i = 0; i < numberString.Length ; i++)
            {	
                if(numberString[i] != numberString[j])
                    return false;
                
                j--;
            }

            return true ;
        }
    }
}