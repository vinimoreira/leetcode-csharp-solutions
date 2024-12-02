using LeetCodeProblems.Arrays;

namespace LeetCodeProblems.Tests.Arrays
{
    public class TwoSumTests
    {

        [Fact]
        public void Calculate_ReturnCorrectIndex()
        {
            var solution = new TwoSum();
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var expected = new int[] { 0, 1 };

            var result = solution.Calculate(nums, target);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate_ReturnsEmptyArray_WhenNoSolution()
        {
            // Arrange
            var solution = new TwoSum();
            var nums = new int[] { 1, 2, 3 };
            var target = 10;

            // Act
            var result = solution.Calculate(nums, target);

            // Assert
            Assert.Empty(result);
        }
    }
}
