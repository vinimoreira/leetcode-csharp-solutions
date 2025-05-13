using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		
        //Input: nums = [2,7,11,15], target = 9
        //Output: [0,1]
        //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1]

        var nums = new int []{2,7, 11,15};
        var target = 9;

        Solution.TwoSum(nums,target)

        
        
	}

    public static class Solution {
        public int[] TwoSum(int[] nums, int target) {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] + num[j] == target)
                    {
                        return i,j; 
                    }
                }
            }
            return null;
        } 
    }
}