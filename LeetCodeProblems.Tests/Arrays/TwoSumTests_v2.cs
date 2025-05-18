using LeetCodeProblems.Arrays;

namespace LeetCodeProblems.Tests.Arrays
{
    public class TwoSumTestsV2
    {

        [Fact]
        public void Calculate_ReturnCorrectIndex_Example1()
        {
            var solution = new TwoSumV2();
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var expected = new int[] { 0, 1 };

            var result = solution.Calculate(nums, target);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void Calculate_ReturnCorrectIndex_Example2()
        {
            var solution = new TwoSumV2();
            var nums = new int[] { 3, 2, 4 };
            var target = 6;
            var expected = new int[] { 1, 2 };

            var result = solution.Calculate(nums, target);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate_ReturnCorrectIndex_Example3()
        {
            var solution = new TwoSumV2();
            var nums = new int[] { 3, 3 };
            var target = 6;
            var expected = new int[] { 0, 1 };

            var result = solution.Calculate(nums, target);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate_ReturnsEmptyArray_WhenNoSolution()
        {
            // Arrange
            var solution = new TwoSumV2();
            var nums = new int[] { 1, 2, 3 };
            var target = 10;

            // Act
            var result = solution.Calculate(nums, target);

            // Assert
            Assert.Empty(result);
        }
    }
}
