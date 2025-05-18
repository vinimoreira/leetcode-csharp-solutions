namespace LeetCodeProblems.Arrays
{
    // Problem: Two Sum
    // Link: https://leetcode.com/problems/two-sum/
    //
    // Example: Input: nums = [2,7,11,15], target = 9
    // Output: [0, 1]
    // Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    public class TwoSum
    {
        public int[] Calculate(int[] nums, int target)
        {
            var dict  = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int result = target - nums[i];
                if (dict.ContainsKey(result))
                {
                    return new int[] { dict[result], i };
                }
                dict[nums[i]] = i;
            }

            return Array.Empty<int>();
        }
    }
}
