using System;


namespace LeetCodeProblems.Arrays
{
    // Problem: Two Sum
    // Link: https://leetcode.com/problems/two-sum/
    //
    // Example: Input: nums = [2,7,11,15], target = 9
    // Output: [0, 1]
    // Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    public class TwoSumV2
    {
        public int[] Calculate(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return [i,j];
                    }
                }
            }
            return [];
        }
    }
}